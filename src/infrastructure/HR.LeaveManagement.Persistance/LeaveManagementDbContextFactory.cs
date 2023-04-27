using HR.LeaveManagement.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HR.LeaveManagement.Persistance;
public class LeaveManagementDbContextFactory : IDesignTimeDbContextFactory<LeaveManagementDbContext>
{
public LeaveManagementDbContext CreateDbContext(string[] args)
{
    IConfigurationRoot configuration = new ConfigurationBuilder()
    .SetBasePath("/home/biruk/Desktop/Classes/A2SV/Internship/net/lesson/src/api/HR.LeaveManagement.Api/")
    .AddJsonFile("appsettings.json")
    .Build();

    var builder = new DbContextOptionsBuilder<LeaveManagementDbContext>();
    var connectionString = configuration.GetConnectionString(name: "ConnectionString");
    
    builder.UseNpgsql(connectionString);

    return new LeaveManagementDbContext(builder.Options);
}
}