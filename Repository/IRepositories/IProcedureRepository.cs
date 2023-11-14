﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepositories
{
    public interface IProcedureRepository : IBaseRepository<Procedure>
    {
        //Task<Procedure> GetByBirdCageId(int birdCageId);
        Procedure GetByBirdCageId(int birdCageId);
        Task<Procedure> GetById(int id);
    }
}
