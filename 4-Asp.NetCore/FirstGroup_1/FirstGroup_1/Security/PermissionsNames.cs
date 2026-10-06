namespace FirstGroup_1.Security
{
    public class PermissionsNames
    {
        public const string ClaimType = "Permission";
        // Add your permission names here
        //Employee Permissions
        public const string EmployeeView    = "Employees.View";
        public const string EmployeeCreate  = "Employees.Create";
        public const string EmployeeEdit    = "Employees.Edit";
        public const string EmployeeDelete  = "Employees.Delete";
        public const string EmployeeDetails = "Employees.Details";
        //Department Permissions
        public const string DepartmentView    = "Departments.View";
        public const string DepartmentCreate  = "Departments.Create";
        public const string DepartmentEdit    = "Departments.Edit";
        public const string DepartmentDelete  = "Departments.Delete";
        public const string DepartmentDetails = "Departments.Details";
        //Products Permissions
        public const string ProductView    = "Products.View";
        public const string ProductCreate  = "Products.Create";
        public const string ProductEdit    = "Products.Edit";
        public const string ProductDelete  = "Products.Delete";
        public const string ProductDetails = "Products.Details";
        //Roles Permissions
        public const string RoleMangment       = "Roles.Mangment";
        public const string PermissionMangment = "Permissions.Mangment";

        public static readonly string[] AllPermissions = 
        {
            EmployeeView,
            EmployeeCreate,
            EmployeeEdit,
            EmployeeDelete,
            EmployeeDetails,
            DepartmentView,
            DepartmentCreate,
            DepartmentEdit,
            DepartmentDelete,
            DepartmentDetails,
            ProductView,
            ProductCreate,
            ProductEdit,
            ProductDelete,
            ProductDetails,
            RoleMangment,
            PermissionMangment

        };

    }
}
