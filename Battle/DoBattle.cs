class Battle
{
    public Tribe Tribe1 { get; set; }
    public Tribe Tribe2 { get; set; }

    public Battle(Tribe tribe1, Tribe tribe2)
    {
        Tribe1 = tribe1;
        Tribe2 = tribe2;
    }

    public string ConductBattle()
    {
        Console.WriteLine("Before Battle:");
        Tribe1.DisplayInfo();
        Tribe2.DisplayInfo();

        while (Tribe1.HasLivingWarriors() && Tribe2.HasLivingWarriors())
        {
            DoStep(Tribe1, Tribe2);
            DoStep(Tribe2, Tribe1);

            Console.WriteLine($"\n{Tribe1.Name}");
            Tribe1.DisplayInfo();
            Console.WriteLine($"\n{Tribe2.Name}");
            Tribe2.DisplayInfo();
        }

        Console.WriteLine("After Battle:");

        if (Tribe1.HasLivingWarriors())
        {
            Console.WriteLine($"\n{Tribe1.Name} wins !");
            return Tribe1.Name;
        }
        else
        {
            Console.WriteLine($"\n{Tribe2.Name} wins !");
            return Tribe2.Name;
        }
    }

    private void DoStep(Tribe attackerTribe, Tribe defenderTribe)
    {
        Warrior attackerWarrior = attackerTribe.chooseTactique.ChooseWarrior(attackerTribe.Members.OfType<Warrior>().Where(warrior => warrior.IsAlive()).ToList());
        Warrior defenderWarrior = defenderTribe.chooseTactiqueT.ChooseTarget(defenderTribe.Members.Where(target => target is Warrior && target.IsAlive()).OfType<Warrior>().ToList());

        if (attackerWarrior != null)
        {
            attackerWarrior.Attack(defenderWarrior);
            Console.WriteLine($"\n{attackerTribe.Name} attacker: {attackerWarrior.Name}, target: {defenderTribe.Name}");
        }

        if (!defenderWarrior.IsAlive())
        {
            Console.WriteLine($"{defenderTribe.Name} loses a member {defenderWarrior}");
            defenderTribe.DisplayInfo();
        }
    }
}


