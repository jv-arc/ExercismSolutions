abstract class Character
{
    private string _type;
    protected Character(string characterType)
    {
        _type = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public string ToString()
    {
        return $"Character is a {_type}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if(target.Vulnerable())
        {
            return 10;
        }
        return 6;
    }

}

class Wizard : Character
{
    private bool _spellPrepared = false; 
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if(_spellPrepared)
        {
            return 12;
        }
        return 3;
    }

    public override bool Vulnerable()
    {
        return !_spellPrepared;
    }

    public void PrepareSpell()
    {
        _spellPrepared = true;
    }
}
