using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKolekcija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UPUTE - Otkomentirati jedan po jedan poziv metode i pratiti rezultate.

            //Example_Add();
            //Example_AddRange();
            //Example_Insert();
            //Example_InsertRange();

            //Example_Remove();
            //Example_RemoveAll();
            //Example_RemoveAt();
            //Example_RemoveRange();
            //Example_Clear();

            //Example_Count();

            //Example_Exists();
            //Example_Contains();
            //Example_All();
            //Example_Any();

            //Example_Find();
            //Example_First();
            //Example_FindLast();
            //Example_Last();
            //Example_FindAll();
            //Example_Where();
            //Example_OfType();

            //Example_Reverse();
            //Example_OrderBy();
            //Example_OrderByDescending();

            #region Zadatak 1

            List<RedovniStudent> redovni = new List<RedovniStudent>();
            var student = new RedovniStudent();
            redovni.Add(student);
            var student2 = new IzvanredniStudent();
            // redovni.Add(student2); student2 je tipa IzvanredniStudent

            #endregion

            #region Zadatak 2

            List<IzvanredniStudent> izvanredni = new List<IzvanredniStudent>()
            {
                new IzvanredniStudent(),
                new IzvanredniStudent(),
                new IzvanredniStudent()
            };
            GetStudentList().AddRange(izvanredni); // ili
            var novaLista = GetStudentList();
            novaLista.AddRange(izvanredni);

            #endregion

            #region Zadatak 3

            var zadatak3 = GetStudentList();
            var pero = zadatak3.Find(x => x.Name == "Pero Anić");
            if (pero != null)
            {
                int index = zadatak3.IndexOf(pero);
                zadatak3.Insert(index + 1, new IzvanredniStudent());
            }

            #endregion

            #region Zadatak 4

            var zadatak4 = GetStudentList();
            zadatak4.RemoveAt(3);
            zadatak4.RemoveAll(x => x.YearOfStudy == 2);

            #endregion

            #region Zadatak 5

            void removeLast3 (List<Student> list)
            {
                int toRemove = list.Count < 3 ? list.Count : 3;
                list.RemoveRange(list.Count - toRemove, toRemove);
            }
            var zadatak5 = GetStudentList();
            removeLast3(zadatak5);
            PrintResults(zadatak5);

            #endregion

            #region Zadatak 6

            int ukupno = GetStudentList().Count;
            int prosjek = GetStudentList().FindAll(x => x.Grade >= 4).Count();

            #endregion

            #region Zadatak 7

            bool sadrzi = GetStudentList().Any(x => x.Name.Contains("Pero"));

            #endregion

            #region Zadatak 8

            bool svi3 = GetStudentList().All(x => x.Grade > 3);
            bool svi2 = GetStudentList().All(x => x.Grade > 2);

            #endregion

            #region Zadatak 9

            var zadatak9 = GetStudentList();
            Student student5 = zadatak9.Find(x => x.Id == 5);
            zadatak9.Remove(student5);

            #endregion

            #region Zadatak 10

            // var student4 = GetStudentList().First(x => x.YearOfStudy == 4); // baca gresku
            // var student4 = GetStudentList().FirstOrDefault(x => x.YearOfStudy == 4);
            var student4 = GetStudentList().Find(x => x.YearOfStudy == 4);

            #endregion

            #region Zadatak 11

            var zadatak11 = GetStudentList().FindAll(x => (x.YearOfStudy == 1 || x.YearOfStudy == 2) && x.Grade < 3.5);

            #endregion

            #region Zadatak 12

            var samoIzvanredni = new List<IzvanredniStudent>();
            samoIzvanredni.AddRange(GetStudentList().OfType<IzvanredniStudent>());
            samoIzvanredni.Reverse();

            #endregion

            #region Zadatak 13

            var zadatak13 = GetStudentList();
            var test = zadatak13.OrderBy(x => x.Grade);
            var test2 = zadatak13.OrderByDescending(x => x.Name);

            #endregion

            Console.ReadLine();
        }

        private static List<Student> GetStudentList()
        {
            List<Student> students = new List<Student>()
            {
                new RedovniStudent { Id = 1, Name = "Pero Perić", YearOfStudy = 3, Model = "A", Grade = 3.2 },
                new IzvanredniStudent { Id = 2, Name = "Ivan Lukić", YearOfStudy = 2, Model = "B", Grade = 3.0},
                new IzvanredniStudent { Id = 3, Name = "Ana Horvat", YearOfStudy = 2, Model = "A", Grade = 2.8},
                new IzvanredniStudent { Id = 4, Name = "Marko Lukić", YearOfStudy = 1, Model = "B", Grade = 3.9},
                new RedovniStudent { Id = 5, Name = "Luka Ivanović", YearOfStudy = 2, Model = "A", Grade = 4.0},
                new IzvanredniStudent { Id = 6, Name = "Marija Horvatić", YearOfStudy = 3, Model = "B", Grade = 4.5},
                new RedovniStudent { Id = 7, Name = "Ivana Ivić", YearOfStudy = 1, Model = "A", Grade = 3.1},
                new IzvanredniStudent { Id = 8, Name = "Ana Perić", YearOfStudy = 1, Model = "B", Grade = 3.4},
                new RedovniStudent { Id = 9, Name = "Pero Anić", YearOfStudy = 1, Model = "A", Grade = 3.5},
                new IzvanredniStudent { Id = 10, Name = "Matej Ivanović", YearOfStudy = 2, Model = "B", Grade = 4.8}
            };

            return students;
        }

        private static void PrintResults(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                PrintResults(student);
            }
        }

        private static void PrintResults(Student student)
        {
            if(student != null)
            {
                Console.WriteLine(student.DisplayInfo());
            }
            else
            {
                Console.WriteLine("No such student!");
            }
            
        }

        #region Dodavanje elemenata u listu

        private static void Example_Add()
        {
            var students = GetStudentList();

            var novi = new RedovniStudent { Id = 11, Name = "Marko Perić", YearOfStudy = 3, Model = "A" };
            students.Add(novi);

            PrintResults(students);
        }

        private static void Example_AddRange()
        {
            var students = GetStudentList();

            Student[] array = new Student[3];
            array[0] = new RedovniStudent { Id = 12, Name = "Marko Horvat", YearOfStudy = 3, Model = "A" };
            array[1] = new IzvanredniStudent { Id = 13, Name = "Mirko Anić", YearOfStudy = 2, Model = "B" };
            array[2] = new RedovniStudent { Id = 14, Name = "Luka Ivić", YearOfStudy = 1, Model = "A" };

            students.AddRange(array);

            PrintResults(students);
        }

        private static void Example_Insert()
        {
            var students = GetStudentList();

            var s = new RedovniStudent { Id = 11, Name = "Marko Perić", YearOfStudy = 3, Model = "A" };
            students.Insert(3, s);

            PrintResults(students);
        }

        private static void Example_InsertRange()
        {
            var students = GetStudentList();

            Student[] array = new Student[3];
            array[0] = new RedovniStudent { Id = 12, Name = "Marko Horvat", YearOfStudy = 3, Model = "A" };
            array[1] = new IzvanredniStudent { Id = 13, Name = "Mirko Anić", YearOfStudy = 2, Model = "B" };
            array[2] = new RedovniStudent { Id = 14, Name = "Luka Ivić", YearOfStudy = 1, Model = "A" };

            students.InsertRange(3, array);

            PrintResults(students);
        }

        #endregion

        #region Brisanje elemenata iz liste

        private static void Example_Remove()
        {
            var students = GetStudentList();

            var pero = students[8];
            bool removalSuccesful = students.Remove(pero);

            PrintResults(students);
        }

        private static void Example_RemoveAll()
        {
            var students = GetStudentList();
            students.RemoveAll(s => s.Model == "B");

            PrintResults(students);
        }

        private static void Example_RemoveAt()
        {
            var students = GetStudentList();
            students.RemoveAt(8);

            PrintResults(students);
        }

        private static void Example_RemoveRange()
        {
            var students = GetStudentList();
            students.RemoveRange(5, 3);

            PrintResults(students);
        }

        private static void Example_Clear()
        {
            var students = GetStudentList();
            students.Clear();

            PrintResults(students);
        }

        #endregion

        #region Prebrojavanje elemenata

        private static void Example_Count()
        {
            var students = GetStudentList();

            int count = students.Count(s => s.YearOfStudy == 1 && s.Model == "A");

            Console.WriteLine($"There is total of {count} students.");
        }

        #endregion

        #region Provjera postojanja elemenata u listi i zadovoljavanja uvjeta

        private static void Example_Contains()
        {
            var students = GetStudentList();

            var pero = students[8];
            bool peroExists = students.Contains(pero);
            
            if (peroExists == true)
            {
                Console.WriteLine("The provided student is containted in the list!");
            }
            else
            {
                Console.WriteLine("The provided student is NOT containted in the list!");
            }
        }

        private static void Example_Exists()
        {
            var students = GetStudentList();

            bool exists = students.Exists(s => s.Name == "Pero Anić" && s.YearOfStudy == 2);

            if(exists == true)
            {
                Console.WriteLine("There IS a student in the list with specified characteristics!");
            }
            else
            {
                Console.WriteLine("There is NO student in the list with specified characteristics!");
            }
        }

        private static void Example_All()
        {
            var students = GetStudentList();
            bool isTrue = students.All(s => s.Model == "A" || s.Model == "B");

            if(isTrue)
            {
                Console.WriteLine("All students are either A or B model!");
            }
            else
            {
                Console.WriteLine("Not all students are either A or B model!");
            }
        }

        private static void Example_Any()
        {
            var students = GetStudentList();
            bool isTrue = students.Any(s => s.YearOfStudy == 3 && s.Grade > 4);

            if(isTrue)
            {
                Console.WriteLine("There is at least one student with specified characteristics!");
            }
            else
            {
                Console.WriteLine("There is no students with specified characteristics!");
            }
        }

        #endregion

        #region Dohvaćanje elementa/elemenata iz liste

        private static void Example_Find()
        {
            var students = GetStudentList();

            Student firstYearStudent = students.Find(s => s.YearOfStudy == 1);
            PrintResults(firstYearStudent);

            Student nonExistingStudent = students.Find(s => s.YearOfStudy == 5);
            PrintResults(nonExistingStudent);
        }

        private static void Example_First()
        {
            var students = GetStudentList();

            //Pronalazi prvog studenta u listi koji se nalazi na prvoj godini
            Student firstYearStudent = students.First(s => s.YearOfStudy == 1);
            PrintResults(firstYearStudent);

            //S obzirom da u listi nemamo studenta na 5 godini, vratiti će defaultnu vrijednost (null)
            Student nonExistingStudent = students.FirstOrDefault(s => s.YearOfStudy == 5);
            PrintResults(nonExistingStudent);
        }

        private static void Example_FindLast()
        {
            var students = GetStudentList();

            Student firstYearStudent = students.FindLast(s => s.YearOfStudy == 1);
            PrintResults(firstYearStudent);
        }

        private static void Example_Last()
        {
            var students = GetStudentList();

            Student firstYearStudent = students.Last(s => s.YearOfStudy == 1);
            PrintResults(firstYearStudent);
            Student firstYearStudent1 = students.LastOrDefault(s => s.YearOfStudy == 1);
            PrintResults(firstYearStudent1);
        }

        private static void Example_FindAll()
        {
            var students = GetStudentList();

            //Pronalazi sve studente druge godine koji su po A modelu
            List<Student> secondYearStudents = students.FindAll(s => s.YearOfStudy == 2 && s.Model == "A");
            PrintResults(secondYearStudents);
        }

        private static void Example_Where()
        {
            var students = GetStudentList();

            IEnumerable<Student> secondYearStudents = students.Where(s => s.YearOfStudy == 2 && s.Model == "A");
            PrintResults(secondYearStudents);
        }     

        private static void Example_OfType()
        {
            var students = GetStudentList();
            IEnumerable<RedovniStudent> regularStudents = students.OfType<RedovniStudent>();
            PrintResults(regularStudents);
        }

        #endregion

        #region Promjena redoslijeda elemenata u listi

        private static void Example_Reverse()
        {
            var students = GetStudentList();
            students.Reverse();

            PrintResults(students);
        }

        private static void Example_OrderBy()
        {
            var students = GetStudentList();
            IEnumerable<Student> sortedByGrades = students.OrderBy(s => s.Grade).ToList();

            PrintResults(sortedByGrades);
        }

        private static void Example_OrderByDescending()
        {
            var students = GetStudentList();
            IEnumerable<Student> sortedByGrades = students.OrderByDescending(s => s.Grade);

            PrintResults(sortedByGrades);
        }

        #endregion
    }
}
