using ETLDarawarehouse;
using ETLDaraWarehouse;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        // Cadenas de conexión definidas directamente en el código
        var northwindConnectionString =
            "Server=(localdb)\\GreddServer;Database=Norwind;Trusted_Connection=True;MultipleActiveResultSets=True;";
        var dataWarehouseConnectionString =
            "Server=(localdb)\\GreddServer;Database=DWHNorthWindOrders;Trusted_Connection=True;MultipleActiveResultSets=True;";

        // Configuración del contenedor de dependencias
        var services = new ServiceCollection();
        services.AddDbContext<NorthwindContext>(options =>
            options.UseSqlServer(northwindConnectionString));
        services.AddDbContext<DatawarehouseContext>(options =>
            options.UseSqlServer(dataWarehouseConnectionString));

        var serviceProvider = services.BuildServiceProvider();

        // Proceso de limpieza de las dimensiones
        var cleaner = new DataCleaner(serviceProvider.GetService<DatawarehouseContext>());
        cleaner.CleanDimensions();


        var etlProcessor = new ETLProcessor(
            serviceProvider.GetService<NorthwindContext>(),
            serviceProvider.GetService<DatawarehouseContext>());

        etlProcessor.LoadDimCustomers();
        etlProcessor.LoadEmployees();
        etlProcessor.LoadCategories();
        etlProcessor.LoadShippers();
        etlProcessor.LoadSuppliers();
        etlProcessor.LoadProducts();
    }
}