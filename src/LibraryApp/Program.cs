namespace BookLibraryApp;

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book("Гордость и предубеждение", "роман", 1813, "Джейн Остин", false);
        Book b2 = new Book("451° по Фаренгейту", "антиутопия/научная фантастика", 1953, "Рэй Брэдбери", false);
        Book b3 = new Book("Портрет Дориана Грея", "философский роман", 1890, "Оскар Уайльд", true);
        Book b4 = new Book("Унесённые ветром", "исторический роман", 1936, "Маргарет Митчелл", true);
        Book b5 = new Book("Маленький принц", "философская сказка", 1943, "Антуан де Сент‑Экзюпери", false);
        Book b6 = new Book("Молчание ягнят", "триллер/детектив", 1988, "Томас Харрис", true);
        Book b7 = new Book("Марсианские хроники", "научная фантастика", 1950, "Рэй Брэдбери", false);
        Book b8 = new Book("Грозовой перевал", "роман/трагедия", 1847, "Эмили Бронте", false);
        Book b9 = new Book("Бойцовский клуб", "психологический триллер", 1996, "Чак Паланик", true);
        Book b10 = new Book("Властелин колец: Братство Кольца", "эпическое фэнтези", 1954, "Дж.Р.Р. Толкин", false);
        Library c1 = new Library("Сборник №1");
        c1.AddBook(b1);
        c1.AddBook(b2);
        c1.AddBook(b3);
        c1.AddBook(b4);
        c1.AddBook(b5);
        c1.AddBook(b6);
        c1.AddBook(b7);
        c1.AddBook(b8);
        c1.AddBook(b9);
        c1.AddBook(b10);
        c1.ShowAllBooks();
        c1.ShowBooksByGenre("роман");
        b5.MarkAsCompleted();
        c1.DelBook(b9);
    }
}