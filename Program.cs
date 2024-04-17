using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//Тема: Перевантаження операторів.
//Індексатори і властивості
//Модуль 5


namespace _09._04._24_c_
{


    //////Task_1

    class Magazine
    {
        private string name;
        private int foundingYear;
        private string description;
        private string phone;
        private string email;
        private int employees;

        public Magazine()
        {
            name = "Magazine Name";
            foundingYear = 1988;
            description = "Magazine description";
            phone = "+0000 111 22 33";
            email = "magazine@email.com";
            employees = 15;
        }


        public string Name { get { return name; } set { name = value; } }

        public int FoundingYear
        {
            get { return foundingYear; }
            set { foundingYear = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public void SetData()
        {
            Console.Write("set name:\t\t");
            name = Console.ReadLine();
            Console.Write("set founding year:\t");
            foundingYear = int.Parse(Console.ReadLine());
            Console.Write("set description:\t");
            description = Console.ReadLine();
            Console.Write("set contact phone:\t");
            phone = Console.ReadLine();
            Console.Write("set email:\t\t");
            email = Console.ReadLine();
            Console.Write("set number of employees:\t");
            email = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine($"magazine name:\t\t{name}");
            Console.WriteLine($"founding:\t\t{foundingYear}");
            Console.WriteLine($"magazine description:\t{description}");
            Console.WriteLine($"phone:\t\t\t{phone}");
            Console.WriteLine($"email:\t\t\t{email}");
            Console.WriteLine($"number of employees:\t{employees}");
        }

        public static Magazine operator +(Magazine magazine, int increase)
        {
            magazine.Employees += increase;
            return magazine;
        }
        public static Magazine operator -(Magazine magazine, int reduce)
        {
            magazine.Employees -= reduce;
            return magazine;
        }

        public static bool operator ==(Magazine magazine_1, Magazine magazine_2)
        {
            return magazine_1.Employees == magazine_2.Employees;
        }
        public static bool operator !=(Magazine magazine_1, Magazine magazine_2)
        {
            return magazine_1.Employees != magazine_2.Employees;
        }
        public static bool operator >(Magazine magazine_1, Magazine magazine_2)
        {
            return magazine_1.Employees > magazine_2.Employees;
        }
        public static bool operator <(Magazine magazine_1, Magazine magazine_2)
        {
            return magazine_1.Employees < magazine_2.Employees;
        }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Magazine otherMagazine = (Magazine)obj;
            return Employees == otherMagazine.Employees;
        }
    }



    //////Task_2


    class Store
    {
        private string name;
        private string adress;
        private string description;
        private string phone;
        private string email;
        private double area;

        public Store()
        {
            name = "Store Name";
            adress = "Store Adress";
            description = "Store Description";
            phone = "+0000 111 22 33";
            email = "store@email.com";
            area = 125.5;
        }
        public string Name { get { return name; } set { name = value; } }
        public string Adress { get { return adress; } set {  adress = value; } }
        public string Description {  get { return description; } set {  description = value; } }
        public string Phone {  get { return phone; } set {  phone = value; } }
        public string Email { get { return email; } set { email = value; } }
        public double Area {  get { return area; } set {  area = value; } }

        public void SetData()
        {
            Console.Write("set name:\t\t");
            name = Console.ReadLine();
            Console.Write("set adress:\t");
            adress = Console.ReadLine();
            Console.Write("set description:\t");
            description = Console.ReadLine();
            Console.Write("set contact phone:\t");
            phone = Console.ReadLine();
            Console.Write("set email:\t\t");
            email = Console.ReadLine();
            Console.Write("set area:\t\t");
            area = double.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"store name:\t\t{name}");
            Console.WriteLine($"store adress:\t\t{adress}");
            Console.WriteLine($"store description:\t{description}");
            Console.WriteLine($"store phone: \t\t{phone}");
            Console.WriteLine($"store email:\t\t{email}");
            Console.WriteLine($"store area:\t\t{area} m^2");
        }
        public static Store operator +(Store store, int increase)
        {
            store.Area += increase;
            return store;
        }
        public static Store operator -(Store store, int reduce)
        {
            store.Area -= reduce;
            return store;
        }

        public static bool operator ==(Store store_1, Store store_2)
        {
            return store_1.Area == store_2.Area;
        }
        public static bool operator !=(Store store_1, Store store_2)
        {
            return store_1.Area != store_2.Area;
        }
        public static bool operator >(Store store_1, Store store_2)
        {
            return store_1.Area > store_2.Area;
        }
        public static bool operator <(Store store_1, Store store_2)
        {
            return store_1.Area < store_2.Area;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Store otherStore = (Store)obj;
            return Area == otherStore.Area;
        }
    }



    //////Task_3


    public class Book
    {
        private string title;
        private string author;
        private int year;

        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }
        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public int Year { get { return year; } set { year = value; } }


    }
    public class ListOfBooksToRead
    {
        private Book[] books;
        private int count;

        public ListOfBooksToRead(int capacity)
        {
            books = new Book[capacity];
            count = 0;
        }
        public void AddBook(string title, string author, int year)
        {
            if (count == books.Length)
            {
                Book[] newArray = new Book[books.Length * 2];

                for (int i = 0; i < count; i++)
                {
                    newArray[i] = books[i];
                }

                books = newArray;
            }
                books[count] = new Book(title, author, year);
                count++;
 
                Console.WriteLine($"book \"{title}\" by {author} added into list"); 
        }
        public void RemoveBook(string title)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].Title == title)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }

                    books[count - 1] = null;
                    count--;
                    Console.WriteLine($"book \"{title}\" removed from list");
                    return;
                }
            }
            Console.WriteLine($"book \"{title}\" not found");
        }
        public void ContainBook(string title)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (books[i].Title.ToLower() == title.ToLower())
                {
                    Console.WriteLine($"{i + 1}. \"{books[i].Title}\" by {books[i].Author} | {books[i].Year}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"book \"{title}\" not found");
            }
        }

        public void Show()
        {
            if (count == 0)
            {
                Console.WriteLine("empty list");
                return;
            }

            Console.WriteLine("book list:\n");

            for (int i = 0; i < count; i++)
            {
                Book book = books[i];
                Console.WriteLine($"{i + 1}. \"{book.Title}\" by {book.Author} | {book.Year}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //            Завдання 1
            //В одному з попередніх практичних завдань ви створювали клас «Журнал».
            //Додайте до вже створеного класу інформацію про кількість працівників.
            //Виконайте навантаження
            //+(для збільшення кількості працівників на вказану кількість),
            //— (для зменшення кількості працівників на вказану кількість),
            //== (перевірка на рівність кількості працівників),
            //< і > (перевірка на меншу чи більшу кількість працівників),
            //!= і Equals.
            //Використовуйте механізм властивостей полів класу.

            Console.WriteLine($"Task 1\n");
            Magazine magazine = new Magazine();
            magazine.Show();
            Console.WriteLine();

            Console.WriteLine("+ :");
            magazine.Employees += 10;
            Console.WriteLine($"number of employees 1:\t{magazine.Employees}");
            Console.WriteLine();

            Console.WriteLine("- :");
            magazine.Employees -= 20;
            Console.WriteLine($"number of employees 1:\t{magazine.Employees}");
            Console.WriteLine();


            Magazine magazine_2 = new Magazine();
            magazine_2.Name = "Magazine Name_2";
            Console.WriteLine($"set number of employees \"{magazine_2.Name}\"");
            magazine_2.Employees = 5;
            Console.WriteLine($"number of employees 2:\t{magazine_2.Employees}");
            Console.WriteLine();

            Console.WriteLine("== :");
            Console.WriteLine($"number of employees 1:\t{magazine.Employees}");
            Console.WriteLine($"number of employees 2:\t{magazine_2.Employees}");
            if (magazine == magazine_2)
            {
                Console.WriteLine("number of employees is same");
            }
            else
            {
                Console.WriteLine("number of employees is different");
            }
            Console.WriteLine();

            Console.WriteLine("!= :");
            magazine_2.Employees += 10;
            Console.WriteLine($"number of employees 1:\t{magazine.Employees}");
            Console.WriteLine($"number of employees 2:\t{magazine_2.Employees}");
            if (magazine != magazine_2)
            {
                Console.WriteLine("number of employees is different");
            }
            else
            {
                Console.WriteLine("number of employees is same");
            }
            Console.WriteLine();

            Console.WriteLine("> < :");
            Console.WriteLine($"number of employees 1:\t{magazine.Employees}");
            Console.WriteLine($"number of employees 2:\t{magazine_2.Employees}");
            if (magazine > magazine_2)
            {
                Console.WriteLine($"\"{magazine.Name}\" has more employees than \"{magazine_2.Name}\"");
            }
            else if (magazine < magazine_2)
            {
                Console.WriteLine($"\"{magazine.Name}\" has less employees than \"{magazine_2.Name}\"");
            }
            else
            {
                Console.WriteLine("number of employees is same");
            }
            Console.WriteLine();

            Console.WriteLine("Equals :");
            Console.WriteLine($"number of employees 1:\t{magazine.Employees}");
            Console.WriteLine($"number of employees 2:\t{magazine_2.Employees}");
            Console.WriteLine($"is equal to:\t\t{magazine.Equals(magazine_2)}");
            Console.WriteLine();

            magazine.Employees += 10;
            Console.WriteLine($"number of employees 1:\t{magazine.Employees}");
            Console.WriteLine($"number of employees 2:\t{magazine_2.Employees}");
            Console.WriteLine($"is equal to:\t\t{magazine.Equals(magazine_2)}");
            Console.WriteLine();

            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.WriteLine();


            //Завдання 2
            //В одному з попередніх практичних завдань ви створювали клас «Магазин».
            //Додайте до вже створеного класу інформацію про площу магазину.
            //Виконайте навантаження
            //+(для збільшення площі магазину на вказаний розмір),
            //— (для зменшення площі магазину на вказаний розмір),
            //== (перевірка на рівність площ магазинів),
            //< і > (перевірка магазинів менших або більших за площею),
            //!= і Equals.
            //Використовуйте механізм властивостей полів класу.  

            Console.WriteLine($"Task 2\n");
            Store store = new Store();
            store.Show();
            Console.WriteLine();

            Console.WriteLine("+ :");
            store.Area += 10;
            Console.WriteLine($"\"{store.Name}\" area:\t{store.Area} m^2");
            Console.WriteLine();

            Console.WriteLine("- :");
            store.Area -= 20;
            Console.WriteLine($"\"{store.Name}\" area:\t{store.Area} m^2");
            Console.WriteLine();

            Store store_2 = new Store();
            store_2.Name = "Store Name_2";
            Console.WriteLine($"set area \"{store_2.Name}\"");
            store_2.Area = 115.5;
            Console.WriteLine($"\"{store_2.Name}\" area:\t{store_2.Area} m^2");
            Console.WriteLine();

            Console.WriteLine("== :");
            Console.WriteLine($"\"{store.Name}\" area:\t{store.Area} m^2");
            Console.WriteLine($"\"{store_2.Name}\" area:\t{store_2.Area} m^2");
            if (store == store_2)
            {
                Console.WriteLine("area of stores are same");
            }
            else
            {
                Console.WriteLine("area of stores are different");
            }
            Console.WriteLine();

            Console.WriteLine("!= :");
            store_2.Area += 10;
            Console.WriteLine($"\"{store.Name}\" area:\t{store.Area} m^2");
            Console.WriteLine($"\"{store_2.Name}\" area:\t{store_2.Area} m^2");
            if (store != store_2)
            {
                Console.WriteLine("area of stores are different");
            }
            else
            {
                Console.WriteLine("area of stores are same");
            }
            Console.WriteLine();

            Console.WriteLine("> < :");
            Console.WriteLine($"\"{store.Name}\" area:\t{store.Area} m^2");
            Console.WriteLine($"\"{store_2.Name}\" area:\t{store_2.Area} m^2");
            if (store > store_2)
            {
                Console.WriteLine($"\"{store.Name}\" has bigger area than \"{store_2.Name}\"");
            }
            else if (store < store_2)
            {
                Console.WriteLine($"\"{store.Name}\" has smaller area than \"{store_2.Name}\"");
            }
            else
            {
                Console.WriteLine("areas are same");
            }
            Console.WriteLine();

            Console.WriteLine("Equals :");
            Console.WriteLine($"\"{store.Name}\" area:\t{store.Area} m^2");
            Console.WriteLine($"\"{store_2.Name}\" area:\t{store_2.Area} m^2");
            Console.WriteLine($"is equal to:\t\t{store.Equals(store_2)}");
            Console.WriteLine();

            store.Area += 10;
            Console.WriteLine($"\"{store.Name}\" area:\t{store.Area} m^2");
            Console.WriteLine($"\"{store_2.Name}\" area:\t{store_2.Area} m^2");
            Console.WriteLine($"is equal to:\t\t{store.Equals(store_2)}");
            Console.WriteLine();

            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.WriteLine();

            //Завдання 3
            //Створіть додаток «Список книг до прочитання».
            //Додаток має дозволяти додавати книги до списку, видаляти книги
            //зі списку, перевіряти чи є книга у списку, і т.д.
            //Використовуйте механізм властивостей, навантаження операторів,
            //індексаторів. 

            Console.WriteLine($"Task 3\n");

            ListOfBooksToRead listOfBooks = new ListOfBooksToRead(10);

            listOfBooks.Show();
            Console.WriteLine("\nadding book to the list:\n");
            listOfBooks.AddBook("About Love", "A.Uthor", 1899);
            listOfBooks.AddBook("About Flower", "Aut Hor", 1999);
            listOfBooks.AddBook("About Cat", "Aut Hor", 1999);
            listOfBooks.AddBook("About Death", "A.Uthor", 1909);
            listOfBooks.AddBook("About Woman", "A.U.Thor", 2009);
            listOfBooks.AddBook("About Love", "A.Uthor", 1910);
            listOfBooks.AddBook("About Aliens", "A.U.Thor", 2019);

            Console.WriteLine();
            listOfBooks.Show();

            Console.WriteLine("\nremoving book to the list:\n");
            listOfBooks.RemoveBook("About Man");
            listOfBooks.RemoveBook("About Death");

            Console.WriteLine();
            listOfBooks.Show();

            Console.WriteLine("\nchecking if book is in the list:\n");
            listOfBooks.ContainBook("About Death");
            listOfBooks.ContainBook("About Love");
            listOfBooks.ContainBook("About alienS");

            Console.WriteLine();
        }
    }
}
