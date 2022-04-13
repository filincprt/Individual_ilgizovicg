using System;

namespace individual_ilgizovich
{
    class Program
    {
        struct Student
        {
            public string Name, age;
            public int GroupNomber;
            public int[] progress;
            public Student(string Name, int GroupNomber, int[] marks, string age)
            {
                this.Name = Name;
                this.GroupNomber = GroupNomber;
                progress = marks;
                this.age = age;
            }

            static void Main(string[] args)
            {
                Student[] students = new Student[2];
                for (int i = 0; i < students.Length; i++)
                {
                    Console.Write("Введите имя и инициалы {0}-ого студента 220 группы: ", i + 1);
                    students[i].Name = Console.ReadLine();
                    Console.Write("Введите, через запятую, 5 оценок {0}-ого студента 220 группы: ", i + 1);
                    students[i].progress = Console.ReadLine().Split(',').Select(a => Convert.ToInt32(a)).ToArray();
                    Console.Write("Введите возраст студента {0}-ого студента 220 группы: ", i + 1);
                    students[i].age = Console.ReadLine();
                    //
                    Console.WriteLine("-------------------------------------");
                }

                Student[] students2 = new Student[2];
                for (int i = 0; i < students.Length; i++)
                {
                    Console.Write("Введите имя и инициалы {0}-ого студента 260 группы: ", i + 1);
                    students2[i].Name = Console.ReadLine();
                    Console.Write("Введите, через запятую, 5 оценок {0}-ого студента 260 группы: ", i + 1);
                    students[i].progress = Console.ReadLine().Split(',').Select(a => Convert.ToInt32(a)).ToArray();
                    Console.Write("Введите возраст студента {0}-ого студента 260 группы: ", i + 1);
                    students2[i].age = Console.ReadLine();

                    //
                    Console.WriteLine("-------------------------------------");
                }
                    double a = students.Average(s => Convert.ToInt32(s.age));
                    double b = students2.Average(s => Convert.ToInt32(s.age));

                if (a < b)
                {
                    Console.WriteLine("Средний возраст студентов 220 гр ниже, чем у 260й: " + students.Average(s => Convert.ToInt32(s.age)));
                }
                else
                {
                    Console.WriteLine("Средний возраст студентов 260 гр ниже, чем у 220й: " + students2.Average(s => Convert.ToInt32(s.age)));
                }
                Console.WriteLine();
                Console.WriteLine("------------Отладка------------ ");
                Console.WriteLine("Средний возраст студентов 220 гр: " + students.Average(s => Convert.ToInt32(s.age)));
                Console.WriteLine("Средний возраст студентов 260 гр: " + students2.Average(s => Convert.ToInt32(s.age)));

                Console.ReadLine();
                }
            }
        }
    }