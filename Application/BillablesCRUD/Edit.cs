using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
using AutoMapper;

namespace Application.BillablesCRUD
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Billables Billables {get; set;}
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
                var billables = await _context.Billables.FindAsync(request.Billables.Id);

                _mapper.Map(request.Billables, billables);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}