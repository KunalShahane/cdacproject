namespace Entities
{

    public class Book
    {
        public int book_id { get; set; }

        public string author { get; set; }
        public string genre { get; set; }

        public string isbn { get; set; }
        public double price { get; set; }
        public string title { get; set; }

        public Book()
        {     }

        public Book(int book_id, string author, string genre, string isbn, double price, string title)
        {
            this.book_id = book_id;
            this.author = author;
           this. genre = genre;
            this.isbn = isbn;
            this.price = price;
           this. title = title;
        }
    }

    
}
