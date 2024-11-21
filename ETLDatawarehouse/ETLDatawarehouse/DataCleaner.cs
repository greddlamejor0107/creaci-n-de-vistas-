using ETLDaraWarehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETLDarawarehouse
{
    public class DataCleaner
    {
        private readonly DatawarehouseContext _context;

        public DataCleaner(DatawarehouseContext context)
        {
            _context = context;
        }

        public void CleanDimensions()
        {
            _context.DimCustomers.RemoveRange(_context.DimCustomers);
            _context.DimSuppliers.RemoveRange(_context.DimSuppliers);
            _context.DimEmployees.RemoveRange(_context.DimEmployees);
            _context.DimShippers.RemoveRange(_context.DimShippers);
            _context.DimCategories.RemoveRange(_context.DimCategories);
            _context.DimProducts.RemoveRange(_context.DimProducts);
            _context.SaveChanges();
            Console.WriteLine("Dimensiones limpiadas correctamente.");
        }
    }
}
