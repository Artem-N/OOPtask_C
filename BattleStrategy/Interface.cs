public interface IChooseWarrior
{
    Warrior? ChooseTarget(List<Warrior> livingTargets);

    //Warrior ChooseTarget(List<Warrior> warriors);
    Warrior ChooseWarrior(List<Warrior> livingWarriors);
}

public interface IChooseTarget
{
    Warrior ChooseTarget(List<Warrior> livingTargets);
}
