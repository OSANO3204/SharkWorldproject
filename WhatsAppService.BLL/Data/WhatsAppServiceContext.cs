﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsAppService.Core.Models;

namespace WhatsAppService.BLL.Data
{
   public  class WhatsAppServiceContext:IdentityDbContext
    {
        public WhatsAppServiceContext(DbContextOptions<WhatsAppServiceContext> options):base(options)
        {

        }
        public virtual DbSet<MpesaTransaction> mpesatransaction { get; set; }
        public  DbSet<UsersData>  users { get; set; }
    }
}
