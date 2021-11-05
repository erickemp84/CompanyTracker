using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
using AutoMapper;

namespace Application.AppUsers
{
    public class Edit
    {
        public class Command : IRequest
        {
            public AppUser AppUser {get; set;}
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var appUser = await _context.AppUsers.FindAsync(request.AppUser.Id);

                _mapper.Map(request.AppUser, appUser);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}