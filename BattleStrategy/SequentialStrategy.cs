public class SequentialTactiqueStrategy : IChooseWarrior, IChooseTarget
{
    private int currentWarriorIndex = 0;

    public Warrior ChooseTarget(List<Warrior> livingTargets)
    {
        if (livingTargets.Count > 0)
        {
            currentWarriorIndex %= livingTargets.Count;
            var target = livingTargets[currentWarriorIndex];
            currentWarriorIndex += 1;
            return target;
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
            currentWarriorIndex %= livingWarriors.Count;
            var warrior = livingWarriors[currentWarriorIndex];
            currentWarriorIndex += 1;
            return warrior;
        }
        else
        {
            return null; 
        }
    }
}