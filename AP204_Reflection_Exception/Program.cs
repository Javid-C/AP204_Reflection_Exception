using AP204_Reflection_Exception.Exceptions;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AP204_Reflection_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Reflection
            //Assembly assembly = Assembly.GetExecutingAssembly();

            //var classes = assembly.GetTypes();

            //foreach (var clas in classes)
            //{
            //Console.WriteLine(clas.FullName);
            //Fields
            //foreach (var item in clas.GetFields())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Properties
            //Console.WriteLine("Class: " + clas.Name);
            //foreach (var item in clas.GetProperties())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Methods
            //Console.WriteLine("Class: " + clas.Name);
            //foreach (var item in clas.GetMethods())
            //{
            //    Console.WriteLine(item.IsStatic);
            //}
            //}

            //var student = assembly.GetType("AP204_Reflection_Exception.Student");

            //foreach (var field in student.GetFields())
            //{
            //    Console.WriteLine(field);
            //}


            //Public field
            //var fullnameField = student.GetField("StudentFullname");

            //Student stu1 = new Student();
            //var fullname = fullnameField.GetValue(stu1);

            //Console.WriteLine("Old name: " + fullname);

            //fullnameField.SetValue(stu1, "Bahadur");

            //Console.WriteLine("New name: " + fullnameField.GetValue(stu1));


            //Private field
            //var pointField = student.GetField("Point",BindingFlags.NonPublic | BindingFlags.Instance);

            //Student stu2 = new Student();
            //var point = pointField.GetValue(stu2);

            //pointField.SetValue(stu2, "Ferq elemez");

            //Console.WriteLine(pointField.GetValue(stu2));
            #endregion


            

            try
            {
                //Format exception
                //int number = int.Parse("5a");
                //Console.WriteLine(number);


                //Divided by zero
                //int five = 5;
                //int zero = 0;
                //int number = five / zero;

                ////Index out of range exception
                //int[] arr = new int[5];
                //arr[0] = 5;
                //arr[5] = 5;
                //foreach (var item in arr)
                //{
                //    Console.WriteLine(item);
                //}

                ////Null reference exception
                //Teacher teacher = new Teacher();
                //teacher.Students[0] = new Student();
                Student student = new Student();
                student.Age = 17;
                student.checkAge();
            }
            catch (FormatException e)
            {
                //Console.WriteLine("Message: " + e.Message);
                throw new FormatException("Duzgun deyil");
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("Zehmet olmasa bolen hissesinde 0 qeyd etmeyin");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                //throw new IndexOutOfRangeException("About Index");
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(StudentCheckAgeException e)
            {
                Console.WriteLine("Bu catch studentcheckageexceptionuna aiddir");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("After throw");
            }
            Console.WriteLine("After try catch");
        }
    }

    class Teacher
    {
        public string TeacherFullaname;
        public Student[] Students;
        public int Age { get; set; }
        public Teacher()
        {
            //Students = new Student[5];
        }
    }

    class Student
    {
        public string StudentFullname = "Malik";
        public string GroupNo { get; set; }

        private string Point = "Private deyerdir";

        public byte Age;



        public static void getInfo()
        {
            Console.WriteLine("Info");
        }

        static Student()
        {

        }
        public void checkAge()
        {
            if (Age < 18)
            {
                throw new StudentCheckAgeException();
            }
            else
            {
                Console.WriteLine("Uni seni gozleyir");
            }
        }

    }
}
