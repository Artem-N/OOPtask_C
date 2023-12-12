public class RandomTactiqueStrategy : IChooseWarrior, IChooseTarget
{
    private readonly Random random = new Random();

    public Warrior ChooseTarget(List<Warrior> livingTargets)
    {
        if (livingTargets.Count > 0)
        {
            return livingTargets[random.Next(livingTargets.Count)];
        }
        else
        {
            return null;
        }
    }

    public Warrior ChooseWarrior(List<Warrior> livingWarriors)
    {
        if (livingWarriors.Count > 0)
        {
            return livingWarriors[random.Next(livingWarriors.Count)];
        }
        else
        {
            return null; 
        }
    }
}
