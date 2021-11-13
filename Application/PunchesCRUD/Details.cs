using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.PunchesCRUD
{
    public class Details
    {
        public class Query : IRequest<Punch>
        {
            public Guid Id {get; set;}
        }

        public class Handler : IRequestHandler<Query, Punch>
        {
            public DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Punch> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Punches.FindAsync(request.Id);
            }
        }
    }
}