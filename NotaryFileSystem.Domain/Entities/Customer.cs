using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaryFileSystem.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = default!;
        public string NationalCode { get; set; } = default!;
        public string CaseNumber { get; set; } = default!;
        public string ReceiptNumber { get; set; } = default!;
        public ICollection<CustomerFile> Files { get; set; } = new List<CustomerFile>();
    }

    
}
