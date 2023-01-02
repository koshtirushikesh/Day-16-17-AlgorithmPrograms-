namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.DisplayInserctionSort();

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.DisplayBubbleSort();

            Anagram anagram = new Anagram();
            anagram.AnagramDisplay();

            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.FindPrimeNumber(1000);

        }
    }
}