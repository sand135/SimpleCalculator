namespace Labb1
{
    internal class Calculator
    {
        public int FirstNumber{ get; set; }
        public int SecondNumber { get; set; }
        public int NumberInMemory { get; set; }

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = 0;
        }

        public override string ToString()
        {
            return $"First number: {FirstNumber}\nSecond number: {SecondNumber}\nNumber in memory: {NumberInMemory}";
        }

        public int SumNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public int MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public int SumInBetween()
        {
            var number1 = FirstNumber;
            var number2 = SecondNumber; 
            if (FirstNumber > SecondNumber)
            {
                number1 = SecondNumber;
                number2 = FirstNumber;
            }

            var sum = 0; 
            for(int i = number1; i<=number2; i++)
            {
                sum += i; 
            }
            return sum; 
        }
    }
}