using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.CrewsCRUD
{
    public class List
    {
        public class Query : IRequest<List<Crews>> {}

        public class Handler : IRequestHandler<Query, List<Crews>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Crews>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Crews.ToListAsync();
            }
        }
    }
}