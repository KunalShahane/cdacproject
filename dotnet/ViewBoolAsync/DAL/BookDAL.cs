using Entities;
using MySqlConnector;
using System.Data;


namespace DAL
{
    public class BookDAL
    {
        private readonly string connstr = "Server =localhost ;Database=test; Uid=root; Pwd=root";
        public async Task<List<Book>> getAllBook()
        {  
            List<Book> books = new List<Book>(); 
            using (var conn = new MySqlConnection(connstr))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from book";


                    using(var reader = await cmd.ExecuteReaderAsync())
                    {
                        while ( await reader.ReadAsync()) 
                        {  
                            var bk = new Book
                            {
                                book_id= Convert.ToInt32(reader["book_id"]),
                                title = Convert.ToString(reader["title"]),
                                author = Convert.ToString(reader["author"]),
                                genre =  Convert.ToString(reader["genre"]),
                                isbn = Convert.ToString(reader["isbn"]),
                                price = Convert.ToDouble(reader["price"])
                                


                            };
                            books.Add(bk);
                        }
                        

                    }

                }
            }
            return books;
        }

    }
}
