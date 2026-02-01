using Objektai__list_advance_7;
using Objektai__list_advance_7.ND._1_kiekio_radimas;
using Objektai__list_advance_7.ND._10_Rikiavimas_pagal_kelis_kriterijus;
using Objektai__list_advance_7.ND._11_Visų_atitikimas;
using Objektai__list_advance_7.ND._13_Konversija_į_žodyną;
using Objektai__list_advance_7.ND._2_Pirmasis_elementas;
using Objektai__list_advance_7.ND._5_Maksimali_reikšmė;
using Objektai__list_advance_7.ND._6_Sumavimas;
using Objektai__list_advance_7.ND._8_Grupavimas;
using Objektai__list_advance_7.ND._9_Anoniminių_objektų_kūrimas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace Paskaita7_Objektai_list_advance_LinQ
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //var p = new Program();
            //var numbersList = new List<int> { 1, 2, 3, 4, 5 };
            //var newNumbersList = numbersList.Where(x => x > 2);



            //PrintList(newNumbersList.ToList());

            //var studentsList = new List<Student>
            //{
            //    new Student("Jonas", "Jonaitis", 20),
            //    new Student("Ieva", "Kazlauskaitė", 19),
            //    new Student("Mantas", "Petrauskas", 21),
            //    new Student("Eglė", "Jankauskienė", 22),
            //    new Student("Tomas", "Vaitkus", 20)
            //};

            //var newStudent = studentsList.Select(x => x.Vardas).ToList();

            //PrintList(newStudent);


            //var prekiuSarasas = new List<PrekiuSarasas>
            //{
            //    new PrekiuSarasas("Pienas", 2),
            //    new PrekiuSarasas("Duona", 1),
            //    new PrekiuSarasas("Kiaušiniai", 10),
            //    new PrekiuSarasas("Sūris", 1),
            //    new PrekiuSarasas("Obuoliai", 6)

            //};

            //var prekiuSarasasOrder = prekiuSarasas.OrderBy(x => x.Kaina).ToList();


            //foreach (var element in prekiuSarasasOrder)
            //{
            //    Console.WriteLine($" pavadinimas: {element.Preke} kaina: {element.Kaina}");
            //}


            //ND
            //1
            //var employeList = new List<Employee>
            //{
            //     new Employee("Jonas", "Jonaitis", 28),
            //     new Employee("Ieva", "Kazlauskaitė", 24),
            //     new Employee("Mantas", "Petrauskas", 35),
            //     new Employee("Eglė", "Jankauskienė", 31),
            //     new Employee("Tomas", "Vaitkus", 22)

            //};

            //var employeeListCount = employeList.Count;

            //Console.WriteLine(employeeListCount);

            //2

            //var textList = new List<Article>
            //{
            //    new Article("Apie C#", "C# yra objektinė programavimo kalba, naudojama .NET platformoje."),
            //    new Article("LINQ", "LINQ leidžia patogiai filtruoti, rūšiuoti ir transformuoti kolekcijas."),
            //    new Article("Klasės", "Klasė aprašo objekto struktūrą ir elgesį (savybes ir metodus)."),
            //    new Article("Sąrašai", "List<T> yra dinaminė kolekcija, kurioje gali būti bet kiek elementų."),
            //    new Article("Konstruktorius", "Konstruktorius inicijuoja objekto būseną sukūrimo metu.")
            //};

            //var textListObjectStartsA = textList.First(x => x.Title.StartsWith("A"));

            //Console.WriteLine(textListObjectStartsA.Title);

            //3

            //var marksList = new List<int> { 5, 6, 1, 1, 2, 3, 8, 9, 9, 9, 9, 5 };

            //var haveBadMarks = marksList.Any(x => x < 4);

            //Console.WriteLine(haveBadMarks);

            //4

            //var categoryNameList = new List<string>
            //{
            //    "Maistas",
            //    "Gėrimai",
            //    "Gėrimai",
            //    "Buitis",
            //    "Elektronika",
            //    "Drabužiai",
            //    "Knygos",
            //    "Knygos",
            //    "Sportas",
            //    "Knygos",
            //    "Grožis"
            //};

            //var categoryNameListFiltered = categoryNameList.Distinct().ToList();

            //PrintList(categoryNameListFiltered);

            //5

            //var carList = new List<Car>
            //{
            //    new Car("Golf", "Volkswagen", 650),
            //    new Car("Corolla", "Toyota", 750),
            //    new Car("Octavia", "Skoda", 700),
            //    new Car("Civic", "Honda", 680),
            //    new Car("Model 3", "Tesla", 520)
            //};

            //var carWithMaxRange = carList.Max(x => x.Range);

            //Console.WriteLine(carWithMaxRange);

            //6

            //var productsList = new List<Product>

            //    {
            //        new Product(2, "Pienas"),
            //        new Product(1, "Duona"),
            //        new Product(4, "Sūris"),
            //        new Product(3, "Kava"),
            //        new Product(5, "Šokoladas")
            //    };

            //var allProductsSum = productsList.Sum(x => x.Price);

            //Console.WriteLine(allProductsSum);

            //7

            //var newsList = new List<string> 
            //{ 
            //    "Mieste atidarytas naujas parkas.",
            //    "Rytoj prognozuojamas sniegas ir plikledis.",
            //    "Lietuvos krepšinio rinktinė laimėjo draugiškas rungtynes.",
            //    "Universitete paskelbta nauja stipendijų programa.",
            //    "Prasidėjo žiemos išpardavimai parduotuvėse.",
            //    "Lietuvos krepšinio rinktinė laimėjo draugiškas rungtynes.",
            //    "Universitete paskelbta nauja stipendijų programa.",
            //    "Prasidėjo žiemos išpardavimai parduotuvėse."
            //};

            //var topNewsList = newsList.Take(5).ToList();

            //PrintList(topNewsList);

            //8

            //var studentsList = new List<Student>
            //{
            //    new Student("First year", "John"),
            //    new Student("Second year", "Emily"),
            //    new Student("First year", "Michael"),
            //    new Student("Third year", "Sophia"),
            //    new Student("Second year", "Daniel")
            //};
            //var studentsGroupBy = studentsList.GroupBy(x => x.CourseYear).ToList();

            //foreach (var group in studentsGroupBy)

            //{
            //    foreach (var student in group)
            //    {
            //        Console.WriteLine($" group: {group.Key} student name: {student.Name}");
            //    }
            //    ;
            //}
            //;

            //9

            //var employeeList = new List<Employee2>
            //    {
            //        new Employee2(1500, "John"),
            //        new Employee2(1800, "Emily"),
            //        new Employee2(2200, "Michael"),
            //        new Employee2(1600, "Sophia"),
            //        new Employee2(2000, "Daniel")
            //    };

            //var employeeListSelect = employeeList.Select(employeeObject =>

            //new
            //{
            //    Name = employeeObject.Name,

            //    AnnualSalary = employeeObject.MonthlySalary * 12
            //}).ToList();

            //foreach (var employee in employeeListSelect)
            //{
            //    Console.WriteLine($"employee name:{employee.Name} employe annual salary: {employee.AnnualSalary}"
            //    );
            //}

            //10

            //var personList = new List<Person>
            //{
            //    new Person("Aom", "Dommano"),
            //    new Person("Com", "Bommano"),
            //    new Person("Bom", "Dommano"),
            //    new Person("Aom", "Commano"),
            //};

            //var personListOrder = personList.OrderBy(x => x.Surname).ThenBy(x => x.Name).ToList();

            //foreach (var person in personListOrder)
            //{
            //    Console.WriteLine($"name: {person.Name} surname: {person.Surname}");
            //}

            //11

            //var ordersList = new List<Order>
            //{
            //    new Order("Order A1001", true),
            //    new Order("Order A1002", false),
            //    new Order("Order A1003", true),
            //    new Order("Order A1004", false),
            //    new Order("Order A1005", true)
            //}
            //;

            //var ordersIsSent = ordersList.All(x => x.IsSent);

            //Console.WriteLine(ordersIsSent ? "All orders are sent" : "Not all orders are sent");

            //12

            //var productsList = new List<Product>
            //{
            //    new Product(2, "Milk"),
            //    new Product(1, "Bread"),
            //    new Product(4, "Cheese"),
            //    new Product(3, "Coffee"),
            //    new Product(5, "Chocolate"),
            //    new Product(6, "Tea"),
            //    new Product(2, "Butter"),
            //    new Product(7, "Olive oil"),
            //    new Product(3, "Pasta")
            //};

            //var last3ProductsList = productsList.Skip(6).Take(3).ToList();

            //foreach (var product in last3ProductsList)
            //{
            //    Console.WriteLine(product.Name);

            //}

            //13

            //var usersList = new List<User>
            //{
            //    new User(8342, "john_doe"),
            //    new User(1907, "emily99"),
            //    new User(5621, "mike_dev"),
            //    new User(4470, "sophia_k"),
            //    new User(9083, "daniel22"),
            //    new User(2715, "lisa.green")
            //};

            //var usersListToDictionary = usersList.ToDictionary(obj => obj.ID, obj => obj);

            //foreach (var user in usersListToDictionary)
            //{
            //    Console.WriteLine($"key:{user.Key} value:  {user.Value}");
            //}

            //14

            //var monthsList = new List<string>
            //{
            //    "January", "February", "March", "April", "May", "June",
            //    "July", "August", "September", "October", "November", "December"
            //};

            //var monthsListWhere = monthsList.Where((value, index) => index % 2 == 0).ToList();

            //PrintList(monthsListWhere);

            //15

            //var intList1 = new List<int>
            //{
            //    10,11,12,13,14,15,16,17,18,19,20,21
            //};

            //var intList2 = new List<int>
            //{
            //    1,2,3,4,5,6,7,8,9,10,11
            //};

            //var mergeIntLists = intList1.Concat(intList2).ToList();

            //var mergeIntLists2 = intList1.Union(intList2).ToList();

            //PrintList(mergeIntLists);
            //PrintList(mergeIntLists2);

        }

        internal static void PrintList<T>(List<T> list)
        {

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

        }
    }
}
