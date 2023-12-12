public class StrongestStrategy: IChooseWarrior, IChooseTarget
{
    public Warrior ChooseTarget(List<Warrior> livingTargets)
    {
        return livingTargets.OrderByDescending(target => target.Health).FirstOrDefault();
    }

    public Warrior ChooseWarrior(List<Warrior> livingWarriors)
    {
        return livingWarriors.OrderByDescending(target => target.Health).FirstOrDefault();
    }
}