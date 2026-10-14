namespace FirstGroup_1.Dtos
{
    public class EmployeeListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salay { get; set; }
        public string DepartedName { get; set; }

    }

    public class CreateEmployeeDto 
    {
        public string  Name       { get; set; }
        public string  Email      { get; set; }
        public string  Phone      { get; set; }
        public decimal Salary     { get; set; }
        public int     DepartedID { get; set; }
    }
    public class UpdateEmployeeDto :CreateEmployeeDto
    {
        public int ID { get; set; }
    }
}
