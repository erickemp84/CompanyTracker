using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
using AutoMapper;

namespace Application.CustomersCRUD
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid Id {get;set;}
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var customer = await _context.Customers.FindAsync(request.Id);

                _context.Remove(customer);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}