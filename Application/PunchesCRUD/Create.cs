using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.PunchesCRUD
{
    public class Create
    {
        public class Command : IRequest
        {
            public Punch Punch {get; set;}
        }

        public class Handler : IRequestHandler<Command>
        {
            public DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Punches.Add(request.Punch);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}