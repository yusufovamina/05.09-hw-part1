using Task2;

Student student = new Student("Atilla", "Ismail", "Vusal", "FBAS 3 22 2", 14);


student.SetGrades(0, new int[] { 11, 12, 10 });
student.SetGrades(1, new int[] { 11, 8, 9 });
student.SetGrades(2, new int[] { 9, 10, 10 });


student.PrintStudentInfo();


namespace Task2
{
    enum Subjects
    {
        Programming = 0,
        Administration,
        Design
    }
    class Student
    {
        private string firstName;
        private string lastName;
        private string fatherName;
        private string group;
        private int age;
        private int[][] grades;

        public Student(string firstName, string lastName, string fatherName, string group, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fatherName = fatherName;
            this.group = group;
            this.age = age;

            grades = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                grades[i] = new int[0];
            }
        }

        public void SetGrades(int subjectIndex, int[] subjectGrades)
        {
            if (subjectIndex < 0 || subjectIndex >= 3)
            {
                Console.WriteLine("Invalid subject index.");
                return;
            }

            grades[subjectIndex] = subjectGrades;
        }

        public int[] GetGrades(int subjectIndex)
        {
            if (subjectIndex < 0 || subjectIndex >= 3)
            {
                Console.WriteLine("Invalid subject index.");
                return new int[0];
            }

            return grades[subjectIndex];
        }

        public double GetAverageGrade(int subjectIndex)
        {
            if (subjectIndex < 0 || subjectIndex >= 3)
            {
                Console.WriteLine("Invalid subject index.");
                return 0;
            }

            int[] subjectGrades = grades[subjectIndex];
            if (subjectGrades.Length == 0)
            {
                return 0;
            }

            return subjectGrades.Average();
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Full Name: {lastName} {firstName} {fatherName}");
            Console.WriteLine($"Group: {group}");
            Console.WriteLine($"Age: {age}");

            for (int i = 0; i < 3; i++)
            {
                string subjectName = "";
                switch (i)
                {
                    case 0:
                        subjectName = "Programming";
                        break;
                    case 1:
                        subjectName = "Administration";
                        break;
                    case 2:
                        subjectName = "Design";
                        break;
                }

                double averageGrade = GetAverageGrade(i);
                Console.WriteLine($"Average Grade in {subjectName}: {averageGrade:F2}");
            }
        }
    }
}