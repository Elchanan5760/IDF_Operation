

using IDF_Operation.models;



namespace IDF
{
    public class Program()
    {
        static void Main(string[] args)
        {
            Idf idf = new Idf("Eyle Zamir");
            Aircraft name = idf.Aircraft();
            Console.WriteLine(name.AmmunitionCapacity = 10);
        }
    }
}
