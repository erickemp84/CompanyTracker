using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
using AutoMapper;

namespace Application.PunchesCRUD
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Punch Punch {get; set;}
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
                var punch = await _context.Punches.FindAsync(request.Punch.Id);

                _mapper.Map(request.Punch, punch);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}