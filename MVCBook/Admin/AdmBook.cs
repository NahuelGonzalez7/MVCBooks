using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBook.Data;
using MVCBook.Models;

namespace MVCBook.Admin
{
    public static class AdmBook
    {
        private static DbBookContext context = new DbBookContext();

        public static List<Book> List()
        {
            return context.books.ToList();
        }

        public static void Insert (Book book)
        {
            context.books.Add(book);
            context.SaveChanges();
        }

        public static void Delete(Book book)
        { 
            context.books.Remove(book);
            context.SaveChanges();
        }

        public static void Modify(Book book)
        {
            context.books.Attach(book);
            context.SaveChanges();
        }
    }
}