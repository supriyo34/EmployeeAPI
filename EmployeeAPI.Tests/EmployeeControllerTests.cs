using EmployeeAPI.Controllers;
using EmployeeAPI.Data;
using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace EmployeeAPI.Tests;

public class EmployeeControllerTests
{
    private EmployeeDbContext GetDbContext()
    {
        var options = new DbContextOptionsBuilder<EmployeeDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        var context = new EmployeeDbContext(options);

        context.Employees.Add(new Employee
        {
            Id = 1,
            Name = "John",
            Department = "IT",
            Salary = 5000
        });

        context.Employees.Add(new Employee
        {
            Id = 2,
            Name = "Alice",
            Department = "HR",
            Salary = 4500
        });

        context.SaveChanges();

        return context;
    }

    [Fact]
    public async Task GetEmployees_ReturnsAllEmployees()
    {
        // Arrange
        var context = GetDbContext();

        var controller = new EmployeesController(context);

        // Act
        var result = await controller.GetEmployees();

        // Assert
        var employees = Assert.IsType<List<Employee>>(result.Value);

        Assert.Equal(5, employees.Count);
    }
    [Fact]
    public async Task GetEmployee_ReturnsEmployee_WhenEmployeeExists()
    {
        // Arrange
        var context = GetDbContext();

        var controller = new EmployeesController(context);

        // Act
        var result = await controller.GetEmployee(1);

        // Assert
        var employee = Assert.IsType<Employee>(result.Value);

        Assert.Equal("John", employee.Name);
    }
    [Fact]
    public async Task GetEmployee_ReturnsNotFound_WhenEmployeeDoesNotExist()
    {
        // Arrange
        var context = GetDbContext();

        var controller = new EmployeesController(context);

        // Act
        var result = await controller.GetEmployee(100);

        // Assert
        Assert.IsType<NotFoundObjectResult>(result.Result);
    }
    [Fact]
    public async Task CreateEmployee_AddsEmployee()
    {
        // Arrange
        var context = GetDbContext();

        var controller = new EmployeesController(context);

        var employee = new Employee
        {
            Name = "Bob",
            Department = "Finance",
            Salary = 7000
        };

        // Act
        var result = await controller.CreateEmployee(employee);

        // Assert
        var created = Assert.IsType<CreatedAtActionResult>(result.Result);

        Assert.Equal(3, context.Employees.Count());
    }
    [Fact]
    public async Task DeleteEmployee_RemovesEmployee()
    {
        // Arrange
        var context = GetDbContext();

        var controller = new EmployeesController(context);

        // Act
        var result = await controller.DeleteEmployee(1);

        // Assert
        Assert.IsType<NoContentResult>(result);

        Assert.Single(context.Employees);
    }
}