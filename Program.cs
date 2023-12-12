class Program
{
    static void Main()
    {
        // Create tribes with specific strategies
        IChooseTarget targetStrategy1 = new SequentialTactiqueStrategy();  
        IChooseWarrior warriorStrategy1 = new WeakestStrategy();  
        Tribe tribe1 = new("Tribe1", 1, 1, 1, targetStrategy1, warriorStrategy1);

        IChooseTarget targetStrategy2 = new SequentialTactiqueStrategy();  
        IChooseWarrior warriorStrategy2 = new StrongestStrategy();  
        Tribe tribe2 = new("Tribe2", 1, 1, 1, targetStrategy2, warriorStrategy2);

        Battle battle1 = new (tribe1, tribe2);

        IChooseTarget targetStrategy3 = new SequentialTactiqueStrategy();
        IChooseWarrior warriorStrategy3 = new WeakestStrategy();
        Tribe tribe3 = new("Tribe3", 1, 1, 1, targetStrategy3, warriorStrategy3);

        IChooseTarget targetStrategy4 = new SequentialTactiqueStrategy();
        IChooseWarrior warriorStrategy4 = new StrongestStrategy();
        Tribe tribe4 = new("Tribe4", 1, 1, 1, targetStrategy4, warriorStrategy4);

        Battle battle2 = new(tribe3, tribe4);

        Tournament round = new ([battle1, battle2]);

        List<string> roundWinners = round.ConductTournament();

        Console.WriteLine("\nWinners:");
        foreach (var winner in roundWinners)
        {
            Console.WriteLine(winner);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
