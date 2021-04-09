using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C_Sharp_Practice
{
    //public class Keyboard
    //{
    //    public Key[] Keys { get; set; }

    //    public Key this[int index]
    //    {
    //        get {
    //            return Keys[index];
    //        }
    //        set {
    //            this.Keys[index] = value;
            
    //        }
    //    }

    //    public Key this[string index]
    //    {
    //        get
    //        {
    //            return Keys[index];
    //        }
    //        set
    //        {
    //            this.Keys[index] = value;

    //        }
    //    }


    //}
    //public class Key
    //{
    //    public string KeyName { get; set; }
    //    public int KeyNumber { get; set; }

    //}
    public class Animal
    {
        public void Move()
        {

        }
        
        public void Eat()
        {

        }

    }
    public class Eagle :Animal
    {
        public void Fly()
        {

        }
    }
    //public class Country
    //{
    //    public string Code { get; set; }
    //    public string Name { get; set; }
    //    public string Capital { get; set; }
    //}

    //public class Depertment
    //{
    //    public Depertment(int maxCapacity)
    //    {
    //        _maxCapacity = maxCapacity;
    //        //_studentInfos = new List<StudentInfo>();
    //    }
    //    public Depertment(string cd, string dp, int maxCapacity):this(maxCapacity)
    //    {
    //        this.Code = cd;
    //        this.DeptName = dp;
    //    }

    //    public string Code { get; set; }
    //    public string DeptName { get; set; }

    //    private int _maxCapacity;
    //    private List<StudentInfo> _studentInfos;

    //    public bool AddStudent(StudentInfo studentInfo)
    //    {
    //        if(_studentInfos == null)
    //        {
    //            _studentInfos = new List<StudentInfo>();
    //        }

    //        if(HasCapacity())
    //        {
    //            _studentInfos.Add(studentInfo);
    //            return true;
    //        }
    //        return false;
    //    }

    //    private bool HasCapacity()
    //    {
    //        return _studentInfos.Count <= _maxCapacity;
    //    }

        
        



    //}
    //public class StudentInfo
    //{
    //    public string RegNo { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public Depertment Depertment { get; set; }


    //    public StudentInfo()
    //    {

    //    }
    //    public StudentInfo(string RgNo, string Nm, string Em)
    //    {
    //        this.RegNo = RgNo;
    //        this.Name = Nm;
    //        this.Email = Em;
    //    }
    //}

    class Program
    {
        //static Depertment depertment;
        //static StudentInfo studentInfo;
        static void Main(string[] args)
        {
            var customer = new 
            {
                Id = 1,
                Name = "Robin",
                Age = "27"
            };

            var customer2 = new[]
            {
                new {Id = 2, Name = "rajib", Age = "30"},
                new {Id = 3, Name = "rajon", Age = "40"},
                new {Id = 4, Name = "raja", Age = "50"},
                new {Id = 5, Name = "roja",Age= "70"}
            };
            
            Show(customer2);


            ObjectInitialization objectInitialization = new ObjectInitialization()
            {
                Id = 1,
                Name = "Saiful",
                Age = "25"
            };

            List<ObjectInitialization> objectInitializations = new List<ObjectInitialization>()
            {
                objectInitialization,
                new ObjectInitialization(){Id = 1, Name = "Jahirul", Age = "22"},
                new ObjectInitialization(){Id = 2, Name = "Aminul", Age = "25"}
            };

            //for(int i = 0; i< objectInitializations.Count; i++)
            //{
            //    Console.WriteLine("Id: {0} && Name: {1} && Age: {2}",objectInitializations[i]);
            //}
            //foreach(ObjectInitialization obj in objectInitializations)
            //{
            //    Console.WriteLine("Id: {0} && Name: {1} && Age: {2}", obj.Id, obj.Name, obj.Age);
            //}
            Console.ReadKey();
            //List<Animal> zoo = new List<Animal>();
            //Animal anAnimal = new Eagle();

            //Eagle anEagle = (Eagle)anAnimal;

            //zoo.Add(new Eagle());
            //zoo.Add(anAnimal);

            
            

            ////** Student Info
            //Console.WriteLine("Enter Registration No: ");
            //string RgNo = Console.ReadLine();

            //Console.WriteLine("Enter Student Name");
            //string StudentNm = Console.ReadLine();

            //Console.WriteLine("Enter Email");
            //string Email = Console.ReadLine();


            //studentInfo = new StudentInfo(RgNo, StudentNm, Email);


            //Console.WriteLine("Enter Code");
            //string Code =  Console.ReadLine();
            
            //Console.WriteLine("Enter Code");
            //string DeptName = Console.ReadLine();

            //List<StudentInfo> infos = new List<StudentInfo>();
            //infos.Add(studentInfo);

            //depertment = new Depertment(Code, DeptName, 4);

            //Console.WriteLine("Dept Id {0} Name {1} StudentCount {2}", depertment.Code, depertment.DeptName);
            //Console.ReadLine();


           
            
           



            ////Thread thread1 = new Thread(Function1);
            ////Thread thread2 = new Thread(Function2);
            ////thread1.Start();
            ////thread2.Start();

            //Function1();
            //Function2();
        }

        //static void Function1()
        //{
            //    for(int i = 0; i <10; i++)
            //    {
            //        Console.WriteLine("Functions1 loop is Executing" + "\t" + i.ToString());
            //    }
            //    //Thread.Sleep(4000);
            //}
            //static void Function2()
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Functions2 loop is Executing" +"\t" + i.ToString());
            //    }
            //    //Thread.Sleep(4000);
            //}

        static void Show(dynamic customer2)
        {
            foreach (var cust in customer2)
            {
                Console.WriteLine("Id: {0} && name: {1} && age: {2}", cust.Id, cust.Name, cust.Age);
            }
        }
      

        }
}
