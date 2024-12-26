using ClassLibrary1;
using System.Security.Cryptography.X509Certificates;
namespace Assignment6
{
    internal class Program
    {
        //public static void DoSomeCode()
        //{//try catch 
        // //last defence line
        //    try
        //    {
        //        int x, y, z;
        //        Console.Write("please enter value of x:");
        //        x = int.Parse(Console.ReadLine());
        //        Console.Write("please enter value of y:");
        //        y = int.Parse(Console.ReadLine());

        //        z = x / y;

        //        int[] Numbers = { 1, 2, 3 };
        //        Numbers[100] = 33;
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }
           

        //}
        public static void DoSomeProtictiveCode()
        {
            try
            {
                int x, y, z;
              
                do
                {
                    Console.WriteLine("Please enter value of x:");
                    
                }while (!int.TryParse(Console.ReadLine(), out x));

                do
                {
                    Console.WriteLine("Please enter value of y:");

                } while (!int.TryParse(Console.ReadLine(), out y) || y==0);
                z = x / y;
                int[] arr = { 1, 2, 3 };

                if (arr?.Length > 100)
                {
                    arr[100] = 90;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
             
        }
        enum Gender
        {
            Male=1,Female=2,male=1,female=2
        }
        enum WeekDays:int
        {
            Satarday,
            Sunday,
            Mounday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }
        enum Grades
        {
            A, B, C, D, E, F
        }
        enum Roles
        {
            Admin=10,
            Viewer=20,
            Editor=30
        }
        enum Branches:byte//0:255
        {
            NaserCity,Maadi=251,Alex,Doki,Elnahas,SmartVillage

        }
        [Flags]
        enum Permissions:byte
        {
            Delete=1,Eecute=2,Read=4,Write=8
        }

        class Employee
        {
            public string Name;
            public int Age;
            public decimal Salary;
            public Gender Gender;//MAle - Female
            public Roles Roles;
            public Permissions Permissions;
        }
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static void Main(string[] args)
        {
            #region Demo

            #region Excertion handling
            //Exception HAndling => Run time eror
            //DoSomeCode();
            //Console.WriteLine("ayman");
            //FormatException
            //DivideByZeroException
            //Exception => Father class of all exception
            //System Exception
            //1)Format Exception
            //2)Index Out Of Range Exception
            //3)Null Reference
            //4)Arthimitic Exception
            //5)Invalid Operation exception
            //Application Exception
            //try
            //{
            //    DoSomeProtictiveCode();//Try code
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);//Error
            //}
            //finally
            //{
            //    //[Realsed,Deallocate,Delete,Close]
            //    //External Resource
            //}
            #endregion
            #region Access Modiofieers
            //TypeA typeA = new TypeA();


            #endregion
            #region Enums
            #region Ex01
            //string Day = "Hamada";
            //Days days = Days.Sunday;
            //Grades grade = Grades.A;
            //if (grade == Grades.A)
            //{
            //    Console.WriteLine(":)");
            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //}

            #endregion
            #region Ex02
            //Grades grades = (Grades)2;//Explicit casting 
            //Console.WriteLine(grades);//c

            //Grades grades = (Grades)10;//Explicit casting
            //Console.WriteLine(grades);//10
            //Admin Viewr Editor

            #endregion
            #region Ex03
            //Grades grade = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine());
            //Enum.TryParse(typeof(Grades), Console.ReadLine(), out object Result);
            //Grades grade = (Grades)Result;
            //Console.WriteLine(Result);


            #endregion
            #region Ex04
            string Gender = "male";
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), out object result);
            //Console.WriteLine(result);
            //Enum.TryParse<Gender>(Gender, true, out Gender result);



            #endregion

            #endregion
            #region Permissions With Enum
            // #region Permisions
            // Employee Employee = new Employee();
            // Employee.Name = "Ali";
            // Employee.Salary = 2000;
            // Employee.Age= 30;
            // Employee.Permissions = (Permissions)3;
            // Console.WriteLine(Employee.Permissions);//Delete Execute
            ////XOR ^
            // Employee.Permissions = Employee.Permissions ^ Permissions.Read;//add permision
            // Console.WriteLine(Employee.Permissions);//Delete Execute Read
            // Employee.Permissions = Employee.Permissions ^ Permissions.Read;//Delete for permission.
            // Console.WriteLine(Employee.Permissions);//Delete Execute
            // //& AND
            // if ((Employee.Permissions & Permissions.Read) == Permissions.Read)
            // {
            //     Console.WriteLine("permision already exsist");
            // }
            // else
            // {
            //     Employee.Permissions = Employee.Permissions ^ Permissions.Read;
            //     Console.WriteLine(Employee.Permissions);
            // }
            // // Or |
            // //use to check for permission
            // Employee.Permissions= Employee.Permissions | Permissions.Write;
            // Console.WriteLine(Employee.Permissions); 
            #endregion
            #region Struct
            //Point p01;
            ////p01.x = 10;
            ////p01.y = 20;
            ////Console.WriteLine(p01.x);//invalid you must assign avalue before
            ////Console.WriteLine(p01.y);//invalid you must assign avalue before
            ////use construcor to assign the values
            //p01 = new Point(2,7);
            ////Console.WriteLine(p01.x);
            ////Console.WriteLine(p01.y);
            //Console.WriteLine(p01.ToString());//Assignment6.Point,bestway
            //Console.WriteLine(p01);//boking and un boking
            //Point p02= new();
            #endregion

            #endregion
            #region Assignment
            #region Q1
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion
            #region Q2

            Console.WriteLine("Enter the season (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();
            if (Enum.TryParse(input, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season entered. Please enter a valid season (Spring, Summer, Autumn, Winter).");
            }



            #endregion
            #region Q3
            // #region Permisions
            // Employee Employee = new Employee();
            // Employee.Name = "Ali";
            // Employee.Salary = 2000;
            // Employee.Age= 30;
            // Employee.Permissions = (Permissions)3;
            // Console.WriteLine(Employee.Permissions);//Delete Execute
            ////XOR ^
            // Employee.Permissions = Employee.Permissions ^ Permissions.Read;//add permision
            // Console.WriteLine(Employee.Permissions);//Delete Execute Read
            // Employee.Permissions = Employee.Permissions ^ Permissions.Read;//Delete for permission.
            // Console.WriteLine(Employee.Permissions);//Delete Execute
            // //& AND
            // if ((Employee.Permissions & Permissions.Read) == Permissions.Read)
            // {
            //     Console.WriteLine("permision already exsist");
            // }
            // else
            // {
            //     Employee.Permissions = Employee.Permissions ^ Permissions.Read;
            //     Console.WriteLine(Employee.Permissions);
            // }
            // // Or |
            // //use to check for permission
            // Employee.Permissions= Employee.Permissions | Permissions.Write;
             //Console.WriteLine(Employee.Permissions);
            #endregion
            #region MyRegion

            #endregion
            #endregion

        }

    }
}
