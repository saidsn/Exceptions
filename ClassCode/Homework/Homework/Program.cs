using Homework.Exceptions;
using Homework.Models;
using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //MyList<int> nums = new MyList<int>();
            //nums.Add(1);
            //nums.Add(12);
            //nums.Add(11);
            //nums.Add(13);
            //nums.Add(1);
            //nums.Add(12);
            //nums.Add(11);
            //nums.Add(13);
            //nums.Add(1);
            //nums.Add(12);
            //nums.Add(11);
            //nums.Add(13);


            ////nums.Clear();

            //nums.Add(11);
            //nums.Add(13);

            //nums.GetAll();

            //List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            //nums.AddRange(list);
            //nums.GetAll();


            //MyList<Book> books = new MyList<Book>();

            //Book book1 = new Book
            //{
            //    Name= "Xosrov"
            //};

            //Book book2 = new Book
            //{
            //    Name = "Xosrov"
            //};

            //Book book3 = new Book
            //{
            //    Name = "Xosrov"
            //};

            //books.Add(book1);
            //books.Add(book3);
            //books.Add(book3);

            //books.GetAll();

            //MyList<string> names = new MyList<string>();

            //names.Add("Orxan");
            //names.Add("Seid");
            //names.Add("Emil");
            //names.Add("Esqin");

            //var result = names.Find(m => m == "Seid");

            //Console.WriteLine(result);
            #endregion

            #region Homework
            //try
            //{
            //    int a = 5;
            //    int b = 0;

            //    int c = a / b;

            //    Console.WriteLine(c);

            //    //int[] arr = new int[3];
            //    //arr[7] = 8;
            //}
            //catch (NullReferenceException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Duzelin");
            //}
            #endregion


            #region NotDivide 2
            //Divide(18, 2);
            #endregion


            #region  FindName
            //List<string> list = new List<string>() { "Orxan", "Emil", "Cavidan", "Fidan" };
            //string searchText = "Emily";

            //FindName(list, searchText);
            #endregion


        }
        #region FindName
        //public static void FindName(List<string> names, string name)
        //{
        //    try
        //    {
        //        if (!names.Contains(name))
        //        {
        //            throw new FindNameException("Not found name");
        //        }
        //        Console.WriteLine("Tapildi");
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }
        //}
        #endregion


        #region NotDivide 2
        //public static void Divide(int num1, int num2)
        //{

        //    try
        //    {
        //        if (num2 == 2)
        //        {
        //            throw new DivideException("num 2 cant equal 2");
        //        }
        //        Console.WriteLine(num1/num2);
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }

        //}
        #endregion



    }
    #region Homework
    //public class Book
    //{
    //    public string Name { get; set; }
    //}
    #endregion

}
