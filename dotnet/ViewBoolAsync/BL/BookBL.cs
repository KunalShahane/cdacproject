using DAL;
using Entities;

namespace BL
{
    public class BookBL
    {
        BookDAL bDal = new BookDAL();
        public async Task <List<Book>> getAllBook()
        {
            return await bDal.getAllBook();
        }
    }
}
