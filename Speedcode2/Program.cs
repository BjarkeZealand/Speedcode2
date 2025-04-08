namespace Speedcode2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] Ingredients = { "200 g Hvedemel(ca. 3 1/2 dl)", "2 teskefulde Bagepulver", "1/2 teskefuld Fint salt", "2 Æg", "150 g Sukker (ca. 1 3/4 dl)","1 teskefuld Vaniljesukker", "125 g smeltet smør", "2 Modne Banaer", "100 g mørk chokolade" };
            List<string> IngredientsList = new List<string>(Ingredients);
            for (int i = 0; i < IngredientsList.Count; i++)
            {
                Console.WriteLine(IngredientsList[i]);
            }
            Console.WriteLine("vi skal bage banankage");


        }
    }
}
