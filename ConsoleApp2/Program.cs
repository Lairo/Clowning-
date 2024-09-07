namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Clown oneClown = new Clown();
            oneClown.Name = "Boffo";
            oneClown.Height = 14;
            oneClown.WhoAreYou();

            Clown anotherClown = new Clown();
            anotherClown.Name = "Biff";
            anotherClown.Height = 16;
            anotherClown.WhoAreYou();

            Clown clown3 = new Clown();
            clown3.Name = anotherClown.Name;
            clown3.Height = oneClown.Height - 3;
            clown3.WhoAreYou();

            anotherClown.Height *= 2;
            anotherClown.WhoAreYou();
        }
    }
}
