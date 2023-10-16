class Ninja:Human{

    public Ninja(): base("ninja",2,2,75,2){}

    public override int Attack(Human target)
    {   int dmg = Dexterity;
        Random random = new Random();
        if (random.Next(1, 6) == 1) 
        {
            dmg += 10;
            
        }
        Health +=dmg;
        target.Health -= dmg;
        return target.Health;
        
    }

    public void Steal(Human target){
        int dmg = 5;
        target.Health-=dmg;
        Health+=dmg;
    }
}