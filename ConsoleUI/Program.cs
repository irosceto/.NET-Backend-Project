using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.VisualBasic;
using System;

namespace ConsoleUI
{

    class Program
    {

        static void Main(string[] args)
        {
           
            //Category test();
            //Data Transformation Object

        }

        private static void CategoryTest()
        {
            CategoryManeger categoryManeger = new CategoryManeger(new EfCategoryDal());
            foreach (var category in categoryManeger.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }


    }
}