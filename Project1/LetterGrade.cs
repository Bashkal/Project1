namespace Project1
{    class LetterGrade
    {
        public static double gradecalc(double weight, double grade)
        {
            return weight / 100 * grade;
        }
        static void Main(string[] args)
        {
            double Weight = 0;
            double Grade = 0;
            char LetterGrade;
            while (Weight < 100)
            {
                Console.WriteLine("What is the weight of the assignment.½**");
                try
                {
                    double tempweight = Convert.ToDouble(Console.ReadLine());
                    if (tempweight + Weight > 100)
                    {
                        throw new ArithmeticException("Weight can not be bigger than 100");
                    }
                    else
                    {
                        Console.WriteLine("What is the grade of the assignment");
                        double tempgrade = Convert.ToDouble(Console.ReadLine());
                        Grade += gradecalc(tempweight, tempgrade);
                        Weight += tempweight;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
            switch (Grade)
            {
                case >= 90:
                    LetterGrade = 'A';
                    break;

                case >= 80:
                    LetterGrade = 'B';
                    break;
                case >= 70:
                    LetterGrade = 'C';
                    break;
                case >= 60:
                    LetterGrade = 'D';
                    break;
                case >= 50:
                    LetterGrade = 'E';
                    break;


                default:
                    LetterGrade = 'F';
                    break;




            }
            Console.WriteLine(Grade);
            Console.WriteLine(LetterGrade);

            List<string[]> list = new List<string[]>();
            string[] list2 = new string[3] { "NAME", "LNAME", "DEBT" };
            list.Add(list2);
            foreach (string[] s in list)
            {
                foreach (string a in s)
                {
                    Console.Write(a + "\t");
                }
            }
            Console.WriteLine();
            string[] ek = new string[] { "1", "2", "3" };
            list.Add(ek);
            foreach (string[] s in list)
            {
                foreach (string a in s)
                {
                    Console.Write(a + "\t");
                }
            }
        }
    }
}