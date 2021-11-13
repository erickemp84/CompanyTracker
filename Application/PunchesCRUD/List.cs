using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.PunchesCRUD
{
    public class List
    {
        public class Query : IRequest<List<Punch>> {}

        public class Handler : IRequestHandler<Query, List<Punch>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Punch>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Punches.ToListAsync();
            }
        }
    }
}