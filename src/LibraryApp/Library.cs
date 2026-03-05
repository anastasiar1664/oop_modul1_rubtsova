namespace BookLibraryApp
{
    class Library
    {
        public string Collection;
        public List<Book> Books;
        public Library(string collection)
        {
            Collection = collection;
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
            System.Console.WriteLine($"Книга - {book.Title} добавлена в коллекцию {Collection}");
        }
        public void ShowAllBooks()
        {
            System.Console.WriteLine($"Книга из коллекции - {Collection}");
            for (int i = 0; i < Books.Count; i++)
            {
                System.Console.Write($"{i + 1}. ");
                Books[i].ShowInfo();
            }
        }
        public void ShowCount()
        {
            System.Console.WriteLine($"Всего книг в коллекции {Collection}: {Books.Count}");
        }
        public void DelBook(Book book)
        {
            Books.Remove(book);
            System.Console.WriteLine($"Книга - {book.Title} удалена из коллекции {Collection}");
        }
        public void ShowBooksByGenre(string genre)
        {
            System.Console.WriteLine($"Книги жанра '{genre}' из коллекции '{Collection}':");
            bool found = false;

            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Genre == genre)
                {
                    System.Console.Write($"{i + 1}. ");
                    Books[i].ShowInfo();
                    found = true;
                }
            }

            if (!found)
            {
                System.Console.WriteLine("Книги указанного жанра не найдены.");
            }
        }
    }
}