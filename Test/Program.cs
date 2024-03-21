using SomerenDAL;
using SomerenModel;


namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink test = new Drink(0, "test", "test-type", 3m, 0.21m, 20);
            DrinkDAO dao = new DrinkDAO();
            dao.AddDrink(test);

        }
    }
}