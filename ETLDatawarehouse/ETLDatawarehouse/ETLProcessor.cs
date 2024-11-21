using ETLDaraWarehouse.Entities.DWH;

namespace ETLDaraWarehouse
{
    public class ETLProcessor
    {
        private readonly NorthwindContext _northwindContext;
        private readonly DatawarehouseContext _dataWarehouseContext;

        public ETLProcessor(NorthwindContext northwindContext, DatawarehouseContext dataWarehouseContext)
        {
            _northwindContext = northwindContext;
            _dataWarehouseContext = dataWarehouseContext;
        }

        public void LoadDimCustomers()
        {
            try
            {
                var customers = _northwindContext.Customers.Select(c => new DimCustomer
                {

                    IDCustomer = c.CustomerID,


                    NameCustomer = c.CompanyName,
                    NameContact = c.ContactName,
                    TitleContact = c.ContactTitle,
                    Address = c.Address,
                    City = c.City,
                    Region = c.Region,
                    PostalCode = c.PostalCode,
                    Country = c.Country,
                    Phone = c.Phone,
                    Fax = c.Fax
                }).ToList();


                _dataWarehouseContext.DimCustomers.AddRange(customers);
                try
                {
                    _dataWarehouseContext.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                Console.WriteLine("DimCustomer cargada correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }




        }

        public void LoadCategories()
        {
            try
            {
                var categories = _northwindContext.Categories.Select(c => new DimCategory
                {
                    IDCategory = c.CategoryID,
                    NameCategory = c.CategoryName,
                    Description = c.Description,
                }).ToList();

                _dataWarehouseContext.DimCategories.AddRange(categories);
                try
                {
                    _dataWarehouseContext.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void LoadSuppliers()
        {
            try
            {
                var suppliers = _northwindContext.Suppliers.Select(c => new DimSupplier
                {
                    IDSupplier = c.SupplierId,
                    Address = c.Address,
                    City = c.City,
                    CodePostal = c.PostalCode,
                    Country = c.Country,
                    Fax = c.Fax,
                    NameContact = c.ContactName,
                    NameSupplier = c.CompanyName,
                    PageHome = c.HomePage,
                    Phone = c.Phone,
                    TitleContact = c.ContactTitle,
                    Region = c.Region
                });
                _dataWarehouseContext.DimSuppliers.AddRange(suppliers);

                try
                {
                    _dataWarehouseContext.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void LoadShippers()
        {
            try
            {
                var shippers = _northwindContext.Shippers.Select(c => new DimShipper
                {
                    IDShipper = c.ShipperId,
                    ShipperName = c.CompanyName,
                    Phone = c.Phone
                });
                _dataWarehouseContext.DimShippers.AddRange(shippers);
                try
                {
                    _dataWarehouseContext.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void LoadProducts()
        {
            try
            {
                var products = _northwindContext.Products.Select(c => new DimProduct
                {
                    IDProduct = c.ProductId,
                    IDSupplier = c.SupplierId,
                    IDCategory = c.CategoryId,
                    NameProduct = c.ProductName,
                    Discontinued = c.Discontinued,
                    UnitPrice = c.UnitPrice,
                    UnitsInStock = c.UnitsInStock,
                    UnitsOnOrder = c.UnitsOnOrder,
                    QuantityPerUnit = c.QuantityPerUnit,
                    ReorderLevel = c.ReorderLevel,

                }).ToList();

                _dataWarehouseContext.DimProducts.AddRange(products);
                try
                {
                    _dataWarehouseContext.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void LoadEmployees()
        {
            try
            {
                var Employee = _northwindContext.Employees.Select(c => new DimEmployee
                {
                    IDEmployee = c.EmployeeId,
                    LastName = c.LastName,
                    FirstName = c.FirstName,
                    Title = c.Title,
                    TitleOfCourtesy = c.TitleOfCourtesy,
                    BirthDate = c.BirthDate,
                    HireDate = c.HireDate,
                    Address = c.Address,
                    City = c.City,
                    Region = c.Region,
                    PostalCode = c.PostalCode,
                    Country = c.Country,
                    HomePhone = c.HomePhone,
                    Extension = c.Extension,
                    ReportsTo = c.ReportsTo,
                }).ToList();
                _dataWarehouseContext.DimEmployees.AddRange(Employee);
                try
                {
                    _dataWarehouseContext.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                Console.WriteLine("DimEmployee cargada correctamente.");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }



    }

}