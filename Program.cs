using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
    //Encapsulation 
    class BankDetailsEncapsulation
    {
        //Encapsulaton properties for Bank Balance
        public string accountName { get; set; }
        public double accBalance { get; set; }

       

    }
    class CircleDeatils
    {
        public int radius { get; set; }
        public double areaofCircle { get; set; }
        public double areaofRect { get; set; }
        public int length { get; set; }
        public int bredth { get; set; }
    
        public double Circlearea(int rad)
        {
            this.radius = rad;
            return areaofCircle;
        }
        public double RectangleArra(int length,int breadth)
        {
            this.length = length;
            this.bredth = breadth;
            return areaofRect;
        }
        
        
    }

    //inheritance 
    class EmployeeDe
    {//by giving mebers also can call
        public string nameEmp = "shiva";
        /// <summary>
        /// by usng method also can call
        /// </summary>
        public void MainEMployee() {
            Console.WriteLine("the Employee is calling");
                }
    } 
    class company : EmployeeDe
    {
        //by giving mebers also can call
        public string cmpyName = "web synergies";
        
          /// <summary>
        /// by usng method also can call
        /// </summary>
        public void EMpMain2()
        {
            Console.WriteLine("the employee maine 2 is called");
        }

    }



    //employee object creation
    class Employee
    {
        public int ID, Age;
        public string Name, Gender;

        public void SetData(int id/*ID*/, string Name, int Age, string Gender)
        {
            this.ID = id;
            this.Name = Name;//Name = name;
            this.Age = Age;
            this.Gender = Gender;
        }
        public void GetData()
        {
            Console.WriteLine("ID is :{0}\tName is:{1}\tAge is:{2}\tGender is :{3}", ID, Name, Age, Gender);
        }

        public Employee()
        {
            Console.WriteLine("constructed created:");
        }
        //static Employee()
        //{
        //    Console.WriteLine("static created");
        //}
    }
    //inheritance concept with two interfaces and class inherit clanss name Cirlce
    interface IDrawable
    {
        void Draw();
    }
    interface IResizable
    {
        void Resize(int width,int height);
    }
    class Circle : IDrawable, IResizable
    {
        public void Draw()
        {
            Console.WriteLine("Crawing a circle");
        }
        public void Resize(int width, int height)
        {
            Console.WriteLine($"the {width} and height is{height}");
        }
    }

    //method overloading concept
    class calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    //method overrriding concept
   class baseClass
    {
        public virtual void Drawing()
        {
            Console.WriteLine("base class is Drawing");
        }
    }
    class subClass:baseClass
    {
        public override void Drawing()
        {
            Console.WriteLine("subcalss which is overridden ");
        }
    }

    /// <summary>
    /// polymorphism
    /// </summary>




    class Program
    {
        string nameof;
        static void Main(string[] args)
        {


            //Encapsulation Object createtion assign values
            BankDetailsEncapsulation bank = new BankDetailsEncapsulation();
            bank.accountName = "shiva";
            bank.accBalance=40000;
            Console.WriteLine("the bank Details of ann accountant is:"+bank.accountName+" "+bank.accBalance);
            CircleDeatils cd = new CircleDeatils();
            cd.radius = 100;
            cd.length = 2;
            cd.bredth = 4;
            cd.areaofCircle = 2.314 * cd.radius * cd.radius;
            cd.areaofRect = cd.length * cd.bredth;
            
            Console.WriteLine("circle "+cd.areaofCircle+ " Reactangle"+ cd.areaofRect);


            //inheritance object creating and calling and pring values
            company c = new company();
            Console.WriteLine("the Employee Name: "+c.nameEmp);
            Console.WriteLine($"the Employee Name is {c.nameEmp} and working in campany {c.cmpyName}" );
            c.MainEMployee();
            c.EMpMain2();


            //mulplie inheritance calling object
            InhtitanceMultiple im = new InhtitanceMultiple();
            im.Add(2, 4);
            im.Sub(45, 34);
            Console.WriteLine($"the values of addtion values are {im.r} and subtractvalues are {im.r2}");



            //polymorphism concelpt implements values passing
            PolymorphismClass pc = new PolymorphismClass();
            Console.WriteLine("thevalues of additon 1"+ pc.Addition(23, 234));
            Console.WriteLine("thevalues of additon 2" + pc.Addition(23, 234,34));

            //mthod overloading concept 
            calculator cl = new calculator();
            int r1=cl.Add(10, 10);
            double r2 = cl.Add(20, 10);
            Console.WriteLine("The vaules after return add int "+r1);
            Console.WriteLine("The vaules after return add double" + r2);

            //by removing the virtudal and override in method overriding classes
            MethodoverRidingBase mob = new MethodDerived();
            mob.Greetings();

            //inheritance concept 
            Circle circle = new Circle();
            circle.Draw();
            circle.Resize(10, 10);

            //overriding concept 
            baseClass bc = new subClass();
            bc.Drawing();

            //abstract class
            DerivedAbstract da = new DerivedAbstract();
            da.Animal();
            da.Hello();

            //Employee object creation
            Employee emp = new Employee();
            Employee emp1 = new Employee();
            Program p = new Program();
            p.nameof = "shiva";
            Console.WriteLine("my name is " + p.nameof);
            /*emp.ID = 2012;
            emp.Name = "shiva";
            emp.Age = 25;
            emp.Gender = "Male";
            Console.WriteLine("ID is :{0}\tName is:{1}\tAge is:{2}\tGender is :{3}",emp.ID,emp.Name,emp.Age,emp.Gender);*/
            emp.SetData(2010, "shiva", 25, "M");
            emp.GetData();


            //class constructor

            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("welocme");
            ClassConstructor cc=    new ClassConstructor();
            cc.empID = 3435;
            cc.empNamePerson = "shiva naga goud";
            cc.EmployeeDetailsList();

            ///<summary>
            ///Patient Details with SetMethod
            /// </summary>

            cc.SetPatientDetails("shivangoud403", 2345);
            cc.GetPatientDetils();

            ///<summary>
            ///Inheritance basic method caling
            /// </summary>

            InheritanceDerived idm = new InheritanceDerived();
            idm.InheritanceMethod();
            idm.InheritanceMethod2();

            Console.ReadLine();
           


            

            

        }
    }
}


