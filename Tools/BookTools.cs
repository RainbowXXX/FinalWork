using Dapper;
using FinalWork.Configs;
using FinalWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork.Tools
{
    public class BookTools
    {
        public static List<BookEntity> GetBooks()
        {
            return SqlHandler.Instance.conn.Query<BookEntity>("SELECT * FROM books;").ToList();
        }
        public static bool RemoveBook(int bid)
        {
            using (var transaction = SqlHandler.Instance.conn.BeginTransaction())
            {
                var tmp = new { Bid = bid };
                SqlHandler.Instance.conn.Execute("DELETE FROM borrow WHERE bid = @Bid;", tmp);
                SqlHandler.Instance.conn.Execute("DELETE FROM books WHERE id = @Bid;", tmp);
                transaction.Commit();
            }
            return true;
        }

        public static bool AddBook(BookEntity book)
        {
            return SqlHandler.Instance.conn.Execute("INSERT INTO work_database.books (title, author, description, ISBN, inventory) VALUES (@Title, @Author, @Description, @ISBN, @Inventory);", book) == 1;
        }

        public static bool ModifyBook(BookEntity book)
        {
            return SqlHandler.Instance.conn.Execute("UPDATE work_database.books t SET t.title = @Title, t.author = @Author, t.description = @Description, t.ISBN = @ISBN, t.inventory = @Inventory WHERE t.id = @Id;", book) == 1;
        }

        public static BookEntity? FindBook(int book_id)
        {
            var optionalParams = new { Id = book_id };
            var res = SqlHandler.Instance.conn.Query<BookEntity>("SELECT * FROM books WHERE id = @Id;", optionalParams).ToList();
            if(res.Count > 0) return res[0];
            return null;
        }

        public static List<BookEntity>? FindBook(BookEntity book)
        {
            var res = SqlHandler.Instance.conn.Query<BookEntity>("SELECT * FROM books WHERE " +
                "title REGEXP @Title AND \r\n" +
                "author REGEXP @Author AND \r\n" +
                "description REGEXP @Description AND \r\n" +
                "ISBN REGEXP @ISBN;", book)
                .ToList();
            if (res.Count > 0) return res;
            return null;
        }
    }
}
