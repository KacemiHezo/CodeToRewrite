public class Program
{

    public static void Main(string[] args)
    {
        string[] getfishtxt = { "reel" };
        Random rand = new Random();
        int numberwater = rand.Next(1, 100);
        int fishnumber = rand.Next(1, 6);

        while (numberwater >= 1 && numberwater <= 70)
        {
            Random r = new Random();

            string[] nofishtxt = { "nothing yet", "sinkin the hopes and dreams", "no food for you I guess" };

            Console.WriteLine(nofishtxt[r.Next(0, nofishtxt.Length)]);

        }
        if (numberwater >= 70 && numberwater <= 100)
        {
            Console.WriteLine("oh shit a fish! type REEL!!");
            string notreel = "";

            while (!getfishtxt.Contains(notreel))
            {
                Console.WriteLine("not that!!");
                notreel = Console.ReadLine()?.ToLower().Trim() ?? string.Empty;
            }

            string fish_name = "";
            string fish_txt = "";
            Console.WriteLine("you got a" + fish_name);
            Console.WriteLine(fish_txt);
        }
    }

}
/* public static void Main()
{
    NPC npc = new NPC();

    for (int i = 1; i <= 6; i++)
    {
        try
        {
            Fish fish = npc.SellFish(i);
            Console.WriteLine(fish);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}


    public static void Main()
{
    FishDatabase fishDatabase = new FishDatabase();

    int fishNumber = 3; // Example fish number

    Fish fish = fishDatabase.GetFishByNumber(fishNumber);

    if (fish != null)
    {
        Console.WriteLine($"Fish Name: {fish.Name}");
        Console.WriteLine($"Fish Rarity: {fish.Rarity}");
        Console.WriteLine($"Fish Description: {fish.Description}");
    }
    else
    {
        Console.WriteLine("Fish not found.");
    }
}*/