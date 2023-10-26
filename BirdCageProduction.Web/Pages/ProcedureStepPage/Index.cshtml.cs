﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess;

namespace BirdCageProduction.Web.Pages.ProcedureStepPage
{
    public class IndexModel : PageModel
    {
        private readonly DataAccess.BirdCageProductionContext _context;

        public IndexModel(DataAccess.BirdCageProductionContext context)
        {
            _context = context;
        }

        public IList<ProcedureStep> ProcedureStep { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ProcedureSteps != null)
            {
                ProcedureStep = await _context.ProcedureSteps
                .Include(p => p.Procedure).ToListAsync();
            }
        }
    }
}
