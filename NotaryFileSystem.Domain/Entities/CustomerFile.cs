using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaryFileSystem.Domain.Entities
{
    public class CustomerFile
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string FileName { get; set; } = default!;
        public string FilePath { get; set; } = default!;
        public long FileSize { get; set; }
        public string FileType { get; set; } = default!;
    }
}
