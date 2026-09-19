using System.ComponentModel.DataAnnotations;

namespace FirstGroup_1.Models
{
    public class Employee
    {
      //Data Annotations are used to define validation rules and constraints for the properties of the Employee class.
     //These annotations help ensure that the data entered for an employee meets certain criteria before it is saved to the database or processed further.

        [Key]// This attribute specifies that the Id property is the primary key for the Employee entity.
        public int Id { get; set; }
        [Required]// This attribute indicates that the Name property is required and cannot be null or empty.
        [StringLength(200)]// This attribute specifies that the maximum length of the Name property is 200 characters.
        public string Name { get; set; } = string.Empty;// string.Empty is used to initialize the Name property with an empty string to avoid null reference issues And = ""
        [Required]
        [EmailAddress]// This attribute indicates that the Email property must be a valid email address format.
        public string Email { get; set; } = "";
        // ? Means that the Address property is nullable,
        // allowing it to have a null value if no address is provided.
        public string? Address { get; set; }

        [StringLength(11)]
        public string? Phone { get; set; }
        public string? City { get; set; }
        [Required]
        [Range(3000,10000, ErrorMessage = "Salary must be between 3000 and 10000.")]
        public decimal Salary { get; set; }

        public int? DepartmentId { get; set; }
        //navigation property 
        public Department? Department { get; set; }

    }
}
