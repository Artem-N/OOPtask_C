public class Warrior
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }

    public Warrior(string name, int health, int attackPower, int defense)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
        Defense = defense;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    
   public virtual void TakeDamage(int damage)
    {
        int reducedDamage = Math.Max(0, damage - Defense);
        Health -= reducedDamage;
    }
    public void Attack(Warrior otherWarrior)
    {
        if (IsAlive())
        {
            otherWarrior.TakeDamage(AttackPower);
        }
    }
}
