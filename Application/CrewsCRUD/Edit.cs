using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
using AutoMapper;

namespace Application.CrewsCRUD
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Crews Crews {get; set;}
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var crews = await _context.Crews.FindAsync(request.Crews.Id);

                _mapper.Map(request.Crews, crews);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}