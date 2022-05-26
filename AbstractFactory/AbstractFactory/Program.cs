using System;
namespace AbstractFactory
{
    abstract class DepartmentFactory
    {
        public abstract Department getDepartment(String type);
        public static DepartmentFactory getDepartmentFactory(String type)
        {
            if (type=="CSE")
                return new CSE();
            else if (type=="IT")
                return new IT();
            else return null;
        }
    }

    public class Vehicle
    {
    }

    internal class CSE : DepartmentFactory
    {

        public override Department getDepartment(string type)
        {
            if (type=="CSEA")
                return new CSEA();
            else if (type=="CSEB")
                return new CSEB();
            else
                return null;
        }
    }
    interface Department
    {
        public void TypeDepartment();
    }
    class CSEA : Department
    {

        public void TypeDepartment()
        {
            Console.WriteLine("I belongs to CSE-A");
        }
    }
    class CSEB : Department
    {

        public void TypeDepartment()
        {
            Console.WriteLine("I belongs to CSE-B");
        }
    }
    class IT : DepartmentFactory
    {

        public override Department getDepartment(string type)
        {
            if (type=="ITA")
                return new ITA();
            else if (type=="ITB")
                return new ITB();
            else return null;
        }
    }
    class ITA : Department
    {
        public void TypeDepartment()
        {
            Console.WriteLine("I belongs to IT-A");
        }
    }
    class ITB : Department
    {
        public void TypeDepartment()
        {
            Console.WriteLine("I belongs to IT-B");
        }
    }
    public class HelloWorld
    {
        static void Main(String[] args)
        {
            DepartmentFactory departmentFactory = DepartmentFactory.getDepartmentFactory("IT");
            Department department = departmentFactory.getDepartment("ITA");
            department.TypeDepartment();
        }
    }
}