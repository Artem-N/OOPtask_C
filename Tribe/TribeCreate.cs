public class Tribe
{
    private readonly Random random = new();
    public string Name { get; set; }
    public List<Warrior> Members { get; set; } = [];
    public IChooseWarrior chooseTactique { get; set; }
    public IChooseTarget chooseTactiqueT { get; set; }

    public Tribe(
        string name,
        int numWarriors,
        int numArchers,
        int numHunters,
        IChooseTarget ct,
        IChooseWarrior cw
        )
    {
        Name = name;
        //Members = new List<Warrior>();
        GenerateRandomTribe(numWarriors, numArchers, numHunters);
        chooseTactique = cw;
        chooseTactiqueT = ct;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Tribe {Name} Members:");
        foreach (var member in Members)
        {
            Console.WriteLine($"Attacker - {member.Name}, (Health: {member.Health}, Attack: {member.AttackPower}, Defense: {member.Defense})");
        }
    }

    public void PopulateTribe(int numWarriors, int numArchers, int numHunters)
    {
        List<Warrior> randomMembers =
        [
            .. Enumerable.Range(1, numWarriors).Select(i => new Warrior("Warrior", 1, 1, 1)),
            .. Enumerable.Range(1, numArchers).Select(i => new Archer("Archer", 1, 1, 1)),
            .. Enumerable.Range(1, numHunters).Select(i => new Hunter("Hunter", 1, 1, 1)),
        ];


        // Shuffle the list to randomize the order
        Members = [.. randomMembers.OrderBy(_ => random.Next())];
    }

    private void AssignRandomAttributes(IEnumerable<Warrior> warriors, int minHealth, int maxHealth, int minAttack, int maxAttack, int minDefense, int maxDefense)
    {
        foreach (var warrior in warriors)
        {
            warrior.Health = random.Next(minHealth, maxHealth + 1);
            warrior.AttackPower = random.Next(minAttack, maxAttack + 1);
            warrior.Defense = random.Next(minDefense, maxDefense + 1);
        }
    }
   
    public void GenerateRandomTribe(int numWarriors, int numArchers, int numHunters)
    {
        PopulateTribe(numWarriors, numArchers, numHunters);

        AssignRandomAttributes(Members.OfType<Warrior>(), 80, 100, 7, 10, 5, 9);
        AssignRandomAttributes(Members.OfType<Archer>(), 60, 80, 8, 13, 3, 7);
        AssignRandomAttributes(Members.OfType<Hunter>(), 70, 90, 6, 10, 4, 8);
    }

    public bool HasLivingWarriors()
    {
        Members = Members.Where(warrior => warrior.Health > 0).ToList();
        return Members.OfType<Warrior>().Any(warrior => warrior.IsAlive());
    }
}
