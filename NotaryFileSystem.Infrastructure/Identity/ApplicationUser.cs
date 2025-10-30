﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaryFileSystem.Infrastructure.Identity
{
    public class ApplicationUser :IdentityUser
    {
        public string? DisplayName { get; set; }
    }
}
