using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Entities;

[Table(" Employee_Tbl")]
public class Employee
{
    [Key] public int Id { get; set; }

    public string Employee_Name { get; set; }
    
    public string Employee_Code { get; set; }
    
    public string Department { get; set; }
    
    public string Rank { get; set; }
    
}