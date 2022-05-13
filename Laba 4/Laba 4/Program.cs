using System;

// 25 Варіант

namespace laba
{
    abstract class Education // створюємо абстрактний клас навчальний заклад
    {
        public int students; //створюємо змінну для кількості студентів
        public int teachers; //створюємо змінну для кількості вчителів
        public int year; //створюємо змінну для року заснування установи
        public int period; //створюємо змінну для періоду навчання
        public int payment; //створюємо змінну для ціни навчання за рік
        public abstract void Yst(); //створюємо метод для виводу загальної інформації (кількість студентів, вчителів, рік)
        public abstract void Payment(); //створюємо метод для підрахунку суми оплати за навчання


    }

    class School : Education // клас-спадкоємець школа, успадкований від навчального закладу
    {
        public School(int students, int teachers, int year) // конструктор, у який ми записуємо кількість студентів, вчителів і рік заснування школи
        {
            this.students = students;
            this.teachers = teachers;
            this.year = year;
        }

        public School(int period, int payment) // конструктор, у який ми записуємо період навчання і вартість навчання у школі
        {
            this.period = period;
            this.payment = payment;
        }

        public override void Yst() // перевизначаємо метод для школи
        {
            Console.WriteLine("Welcome to our school! ");
            Console.WriteLine();
            Console.WriteLine($"It has more than {students} students and about {teachers} teachers");
            Console.WriteLine($"The school was built in {year}");
            Console.WriteLine();

        }

        public override void Payment() // перевизначаємо метод для школи
        {
            int result = this.payment * this.period;
            Console.WriteLine(result + " hryvnas");
        }

    }

    class University : Education // клас-спадкоємець університет, успадкований від навчального закладу
    {
        public University(int students, int teachers, int year) // конструктор, у який ми записуємо кількість студентів, вчителів і рік заснування школи
        {
            this.students = students;
            this.teachers = teachers;
            this.year = year;
        }

        public University(int period, int payment) // конструктор, у який ми записуємо період навчання і вартість навчання в університеті
        {
            this.period = period;
            this.payment = payment;
        }
        public University() // пустий конструктор
        {

        }

        public override void Yst() // перевизначаємо метод для університету
        {
            Faculty faculty = new Faculty();
            Console.WriteLine("Welcome to our university! ");
            Console.WriteLine();
            Console.WriteLine($"It has more than {students} students and about {teachers} teachers");
            Console.WriteLine($"Apart from this our university was built in {year}");
            Console.WriteLine();
        }

        public override void Payment() // перевизначаємо метод для університету
        {
            int result = this.payment * this.period;
            Console.WriteLine(result + " hryvnas");
        }
    }

    class Faculty : University // клас-спадкоємець факультет, успадкований від університету
    {
        public int faculties; // змінна кількості факультетів

        public Faculty() // пустий конструктор
        {

        }

        public Faculty(int faculties) // встановлюємо кількість факультетів
        {
            this.faculties = faculties;
        }

        public void Print() // метод, у якому виводимо кількість факультетів
        {
            Console.WriteLine($"Amount of faculties : {faculties}");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Where do you want to study (write school or uni)");
                string choice = Console.ReadLine();
                if (choice == "school")
                {
                    Education school = new School(1200, 100, 1939); // створюємо об'єкт класу школа і задаємо значення
                    school.Yst(); // викликаємо метод із загальною інформацією
                    Console.WriteLine("Enter how many years do you want to study here : ");

                    int n = int.Parse(Console.ReadLine());
                    Education school2 = new School(n, 30000); // створюємо ще один об'єкт класу школа і задаємо значення для вартості і періоду навчання


                    Console.WriteLine("It will cost : ");
                    school2.Payment(); // викликаємо метод для підрахунку вартості навчання
                }

                Console.WriteLine();

                if (choice == "uni")
                {
                    Education uni = new University(36000, 1000, 1898); // створюємо об'єкт класу університет і задаємо значення
                    Faculty faculty = new Faculty(18); // створюємо об'єкт класу факультет і задаємо значення
                    faculty.Print(); // викликаємо метод виводу кількості факультетів
                    uni.Yst(); // викликаємо метод виводу загальної інформації

                    Console.WriteLine("Enter how many years do you want to study here : ");

                    int d = int.Parse(Console.ReadLine());
                    Education uni2 = new University(d, 45000); // створюємо ще один об'єкт класу університет і задаємо значення для вартості і періоду навчання

                    Console.WriteLine("It will cost : ");
                    uni2.Payment(); // викликаємо метод для підрахунку вартості навчання
                }
            }
        }
    }
}