using System;

namespace Classes___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // an object is an instance of a class, 
            // student ife = new student ("ife", "dayo", 25); //these are objects of the class student
            // student ekene = new student ("ekene", "anolue", 35);
            // ife.printFullName();
            // ekene.printFullName();
              //students sarah = new students();
             // sarah.addNumbers();
            //students.addNumbers();
            // student sam = new student ("sam allardyce", "oba akran", 09084577, 23);
            // sam.studentIdentity();
            // student john = new student ("John terry","adeniyi johnson", 8966777, 34 );
            // john.studentIdentity();
            triangle one = new triangle(23,11,45);
            one.perimeter();
            one.area();
            
        }    
    }

//  public class student // a class is a blue for creating objects, it is used to store complex data types
//         {
//             string _firstName;
//             string _lastName;
//             int _age;
//             public student(string firstName, string lastName, int age) // constructor, if we do not create a constructor, the class uses the default dotnet constructor that is parameterless
//             {
//                 _firstName = firstName;
//                 _lastName = lastName;
//                 _age = age;
//             }

        // public void printFullName()
        //  //public static void printFullName() static property can not be called with the instance of that class
        //  // it can only be called with an  of that class
        // {
        //    Console.WriteLine("The full name of the student  is " + _firstName + " " + _lastName + " he is " +_age + "years old"); 
        // }
        // }
 
//  public class students // Methods
//  {
//      public void addNumbers()
//      {
//          int firstNumber =29;
//          int secondNumber = 45;
//          int result = firstNumber + secondNumber;
//          Console.WriteLine(result);
//      }
//  }
    // public class student
    // {
    //     string _name;
    //     string _address;
    //     int _rollNumber;
    //     int _phoneNumber;

    //     public student(string name,  string address, int phoneNumber, int rollNumber )
    //     {
    //         _name = name;
    //         _address = address;
    //         _rollNumber = rollNumber;
    //         _phoneNumber = phoneNumber;
           
    //     }
    //     public void studentIdentity()
    //     {
    //         Console.WriteLine(_name+ " "  +"has the number "
    //         + _rollNumber + " and Phonenumber " +_phoneNumber + "he lives at " + _address);
    //     }

    // }
    //Write a program to print the area and perimeter of a triangle by creating a class named 'Triangle' taking in three integers as parameters in its constructor
    public class triangle
    {
        int _base;
        int _height;
        int _length;
        
        public triangle(int baase, int height, int length)
        {
            _base = baase;
            _height = height;
            _length = length;
         }
         public void perimeter()
         {
             Console.WriteLine("The perimeter of the triangle is: " + (_base+_height+_length));
         }
          public void area()
         {
             Console.WriteLine("The area of the triangle is: " + (0.5*(_base*_height)));
         }
    }
}
        
