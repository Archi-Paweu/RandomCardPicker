namespace PickACard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz liczbę generowanych kart: ");

            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickACard(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }

            else
            {
                Console.WriteLine("Wpisz prawidłową liczę.");
            }
        }
    }
}