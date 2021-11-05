using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.AppUsers
{
    public class List
    {   
        public class Query : IRequest<List<AppUser>> {}

        public class Handler : IRequestHandler<Query, List<AppUser>>
        {

            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<AppUser>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.AppUsers.ToListAsync();
            }
            
        }
    }
}