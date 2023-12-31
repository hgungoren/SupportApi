﻿namespace SK.Support.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly SupportDbContext _context;

        public InitialHostDbBuilder(SupportDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            new ProductSeed(_context).Create(); 
            new TechnicalServiceSeed(_context).Create();
            //new FaultSeed(_context).Create();

            _context.SaveChanges();
        }
    }
}
