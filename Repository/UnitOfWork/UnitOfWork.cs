﻿using DataAccess;
using Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BirdCageProductionContext _context;

        public UnitOfWork(BirdCageProductionContext context, ICustomerRepository customerRepository)
        {
            _context = context;
            CustomerRepository = customerRepository;
        }

        public ICustomerRepository CustomerRepository { get; }

        public IAccountRepository AccountRepository { get; }

        public IBirdCageCategoryRepository BirdCageCategoryRepository {  get; }

        public IOrderDetailRepository OrderDetailRepository { get; }

        public IOrderRepository OrderRepository {  get; }

        public IPartItemRepository PartItemRepository {  get; }

        public IPartRepository PartRepository {  get; }

        public IProcedureRepository ProcedureRepository {  get; }

        public IProcedureStepRepository ProcedureStepRepository {  get; }

        public IProductionPlanRepository ProductionPlanRepository {  get; }

        public IProductionPlanStepRepository ProductionPlanStepRepository {  get; }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
