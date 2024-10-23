namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(DateTime.Now);
            var date  = person.GetBirthDate();

            Console.WriteLine(date);
        }

        static void UseOut()
        {
            // var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);
            
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Concersion Failed");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            var sum = calculator.Add(1, 2, 3, 4);
            Console.WriteLine("Sum is {0}", sum);
        }
        
        static void UsePoints()
        {
            try
            {
                var point = new Point(1, 3);
                var point2 = new Point(4, 5);
             
                point.Move(null);

                Console.WriteLine("{0}{1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error has occurred.");
                throw;
            }
        }
    }   
}