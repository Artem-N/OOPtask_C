
public class WeakestStrategy : IChooseWarrior, IChooseTarget
{
    public Warrior ChooseWarrior(List<Warrior> livingWarriors)
    {
        return livingWarriors.OrderBy(target => target.Health).FirstOrDefault();
    }
    public Warrior ChooseTarget(List<Warrior> livingTargets)
    {
        return livingTargets.OrderBy(target => target.Health).FirstOrDefault();
    }
}
