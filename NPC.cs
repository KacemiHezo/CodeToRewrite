using System;
using System.Collections.Generic;
using System.Linq;

public class NPC
{
    private Random random = new Random();
    private List<Fish> fishDatabase;

    public NPC()
    {
        fishDatabase = new List<Fish>
        {
            new Fish (1, "araneacis",FishRarity.Common,"a fish with 8 fins and 2 stag beetles like pincers, they make good pets"),
            new Fish (2, "sicmn", FishRarity.Common, "a black and white fish, looks skinny, almost like a skeleton, its patterns are used for shoes" ),
            new Fish (3, "pislique", FishRarity.Common, "a fish whose scales look like they are melting, usually used as a spice, it has a weird sweet and spicy taste" ),
            new Fish (4, "chocolate shark", FishRarity.Rare, "a shark that lives in swamps, its name comes from the pattern on its skin, it's toxic to eat" ),
            new Fish (5, "wuopod", FishRarity.Rare, "an octopus-like animal that has two main tentacles and 6 smaller ones. They like to make human faces out of kelp" ),
            new Fish (6, "crocodish", FishRarity.Rare, "a crocodile whose spikes look like a salad, a lot of people often eat them alive" )
        };
    }

    public Fish SellFish(int fishNumber)
    {
        var fish = fishDatabase.Find(f => f.Number == fishNumber);
        if (fish == null)
        {
            throw new ArgumentException("Invalid fish number.");
        }

        switch (fish.Rarity)
        {
            case FishRarity.Common:
                fish.Price = random.Next(500, 2001) / 100.0m;
                break;
            case FishRarity.Rare:
                fish.Price = random.Next(700, 4001) / 100.0m;
                break;
        }

        return fish;
    }
}