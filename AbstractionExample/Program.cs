using AbstractionExample;

Employee Developer = new Developer
{
    Name = "Curtis",
    Surname = "Jackson",
    Department = "Development"

};
Developer.EmployeeInfo();
Developer.Title();

Employee ProjectManager = new ProjectManager
{
    Name = "Marshall",
    Surname = "Matters",
    Department = "Project Management"
};
ProjectManager.EmployeeInfo();
ProjectManager.Title();

Employee SalesRep = new SalesRep
{
    Name = "Andre",
    Surname = "Young",
    Department = "Sales Department"

};
SalesRep.EmployeeInfo();
SalesRep.Title();

