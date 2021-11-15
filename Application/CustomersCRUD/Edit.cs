using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
using AutoMapper;

namespace Application.CustomersCRUD
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Customer Customer {get; set;}
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var customer = await _context.Customers.FindAsync(request.Customer.Id);

                _mapper.Map(request.Customer, customer);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}