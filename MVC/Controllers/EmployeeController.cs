using Microsoft.AspNetCore.Mvc;
using MVC.Entities;

namespace MVC.Controllers;

public class EmployeeController : Controller
{
    
    private readonly DataContext _context;

    public EmployeeController(DataContext context)
    {
        _context = context;
    }
    
    // GET
    public IActionResult Index()
    {
        List<Employee> list = _context.Employees.ToList();
        return View(list);
    }
    
    // DELETE
    public IActionResult Delete()
    {
        Console.Write("Delete");
        // Employee employee = _context.Employees.Find(id);
        // if (employee == null)
        // {
        //     return NotFound();
        // }
        //
        // _context.Employees.Remove(employee);
        // _context.SaveChanges();
        return View("Index");
    }
}