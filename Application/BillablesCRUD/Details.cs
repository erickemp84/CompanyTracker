using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.BillablesCRUD
{
    public class Details
    {
        public class Query : IRequest<Billables>
        {
            public Guid Id {get; set;}
        }

        public class Handler : IRequestHandler<Query, Billables>
        {
            public DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Billables> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Billables.FindAsync(request.Id);
            }
        }
    }
}