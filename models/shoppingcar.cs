using System.Collections.Generic;
using System.Linq;

namespace LABORATORY.models.Enums;

 public class CarritoCompras
{
 private readonly List <Book>_book= new();
 public IReadOnlyCollection<Book> Book =>_book;


 public void AddBookInventory(Book book)
 {
    if(book is not null &&_book.Any(a => a == book))
    {
        _book.Add(book);
    }
 }


public void DeleteBookCarritoCompras(Book Booktitle)
 {
    if(_book.Any( s => s == Booktitle))
    {
      var bookselected = _book.First( s => s == Booktitle );
      _book.Remove(bookselected);
    }
 }



public Book SearchBookInCarritoCompras(Book Booktitle)
 {
    if(_book.Any( s => s == Booktitle))
    {
      return _book.First( s => s == Booktitle );
      
    }
    throw new Exception("Book not found");

 }
 
}


