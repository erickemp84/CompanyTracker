using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.AppUsers
{
    public class Create
    {
        public class Command : IRequest
        {
            public AppUser AppUser {get; set;}
        }

        public class Handler : IRequestHandler<Command>
        {
            public readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.AppUsers.Add(request.AppUser);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
