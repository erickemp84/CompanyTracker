using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.BillablesCRUD
{
    public class List
    {
        public class Query : IRequest<List<Billables>> {}

        public class Handler : IRequestHandler<Query, List<Billables>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Billables>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Billables.ToListAsync();
            }
        }
    }
}