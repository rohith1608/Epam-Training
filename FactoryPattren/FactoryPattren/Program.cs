using System;
namespace FactoryPattren
{
    interface Prototype
    {
        public Prototype getClone();
    }
    class Student : Prototype
    {
        private int id;
    private string name, address;
    public Student()
        {
            Console.WriteLine("Student Details");
            Console.WriteLine("id" + " name" + " address");
        }
        public Student(int id,string name,string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void showRecord()
        {
            Console.WriteLine(id + " " + name + " " + address);
        }
        public Prototype getClone()
        {
            return new Student(id, name, address);
        }
    }
    class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Your id");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name");
            String name=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your address");
            String address=Convert.ToString(Console.ReadLine());
            Student student=new Student(id,name,address);
            student.showRecord();
            Student student2=(Student)student.getClone();
            student2.showRecord();

        }
    }
}