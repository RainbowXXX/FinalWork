using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork.Entities
{
    public class BookEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string ISBN { get; set; }
        public int Inventory {  get; set; }

        //System.Int32 id, System.String title, System.String author, System.String description, System.String ISBN, System.Int32 inventory
        public BookEntity(int id, string title, string? author, string? description, string ISBN, int inventory)
        {
            Id = id;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description;
            Author = author;
            this.ISBN = ISBN ?? throw new ArgumentNullException(nameof(ISBN));
            Inventory = inventory;
        }
    }
}
