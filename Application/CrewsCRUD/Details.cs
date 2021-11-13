using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.CrewsCRUD
{
    public class Details
    {
        public class Query : IRequest<Crews>
        {
            public Guid Id {get; set;}
        }

        public class Handler : IRequestHandler<Query, Crews>
        {
            public DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Crews> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Crews.FindAsync(request.Id);
            }
        }
        
    }
}