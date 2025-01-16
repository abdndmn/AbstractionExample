# Abstraction Example - Employee Roles

This project demonstrates the concept of **abstraction** in C# by defining a base class `Employee` with shared attributes and methods, and implementing role-specific behavior through derived classes.

---

## Features

### Classes

#### **1. Employee (Abstract Base Class)**
- **Properties**:
  - `Name`: The first name of the employee.
  - `Surname`: The last name of the employee.
  - `Department`: The department the employee belongs to.
- **Methods**:
  - `EmployeeInfo`: A non-abstract method that prints the employee's basic information.
  - `Title`: An abstract method to be implemented by derived classes, representing the employee's role.

#### **2. Developer (Derived Class)**
- Implements the `Title` method to indicate the employee is a developer.

#### **3. ProjectManager (Derived Class)**
- Implements the `Title` method to indicate the employee is a project manager.

#### **4. SalesRep (Derived Class)**
- Implements the `Title` method to indicate the employee is a sales representative.

---

## Usage Example

### Code:
```csharp
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
```

### Output:
```
Ad: Curtis
Soyad: Jackson
Departman: Development
Yazılımcı olarak çalışıyorum.

Ad: Marshall
Soyad: Matters
Departman: Project Management
Proje yöneticisi olarak çalışıyorum.

Ad: Andre
Soyad: Young
Departman: Sales Department
Satış temsilcisi olarak çalışıyorum.
```

---

## Concepts Demonstrated

### 1. **Abstraction**
- The `Employee` base class provides a common interface for all employee types, hiding the implementation details of each role.

### 2. **Inheritance**
- The `Developer`, `ProjectManager`, and `SalesRep` classes inherit from the `Employee` class, reusing its shared properties and methods.

### 3. **Polymorphism**
- The `Title` method is overridden in each derived class to provide role-specific behavior.

---

## How to Extend
- Add more employee roles by creating new classes that derive from `Employee`.
- Introduce additional methods or properties specific to roles, such as `Salary` or `YearsOfExperience`.

---

## Summary
This project demonstrates the power of abstraction and inheritance in object-oriented programming. By defining a common base class and extending it for specific use cases, the code achieves flexibility, scalability, and reusability.

