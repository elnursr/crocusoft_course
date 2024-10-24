namespace taskReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple()
            {
                Price = 1.3,
                Sort = "app"
            };
            Pinapple pinapple = new Pinapple
            {
                Price = 2.8,
                Sort = "pnp"
            };
            Orange orange = new Orange
            {
                Price = 3.7,
                Sort = "orng"
            };
            Fruit[] basket = { apple, pinapple, orange };


            for (int i = 0; i < basket.Length; i++)
            {
                basket[i].getTaste();
                basket[i].getInfo();
            }
        }
    }
}