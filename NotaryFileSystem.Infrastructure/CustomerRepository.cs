using Microsoft.EntityFrameworkCore;
using NotaryFileSystem.Application.Interfaces;
using NotaryFileSystem.Domain.Entities;
using NotaryFileSystem.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaryFileSystem.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext context) => _context = context;

        public async Task AddAsync(Customer customer) => await _context.Customers.AddAsync(customer);

        public async Task<Customer?> GetByIdAsync(Guid id)
            => await _context.Customers.Include(c => c.Files).FirstOrDefaultAsync(c => c.Id == id);

        public async Task<List<Customer>> GetAllAsync()
            => await _context.Customers.Include(c => c.Files).ToListAsync();

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}
