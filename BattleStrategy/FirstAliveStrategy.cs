public class FirstAliveStrategy : IChooseWarrior, IChooseTarget
{
    public Warrior ChooseTarget(List<Warrior> livingTargets)
    {
        return livingTargets.FirstOrDefault();
    }

    public Warrior ChooseWarrior(List<Warrior> livingWarriors)
    {
        return livingWarriors.FirstOrDefault();
    }
}