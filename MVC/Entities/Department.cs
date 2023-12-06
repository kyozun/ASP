using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Entities;

[Table(" Department_Tbl")]
public class Department
{
    [Key] public int Id { get; set; }

    public string Department_Name { get; set; }
    
    public string Department_Code { get; set; }
    
    public string Location { get; set; }
    
    public string Number_Of_Person { get; set; }
}