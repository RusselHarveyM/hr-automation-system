﻿using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.Repositories
{
    public class ApplicationRepository : BaseRepository, IApplicationRepository
    {
        private readonly BasecodeContext _context;

        public ApplicationRepository(IUnitOfWork unitOfWork, BasecodeContext context) : base(unitOfWork)
        {
            _context = context;
        }

        public Application GetById(Guid id)
        {
            return _context.Application.Find(id);
        }
    }
}
