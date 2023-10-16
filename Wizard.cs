class Wizard:Human{


public Wizard(): base("pepe",3,25,12,50){}


    public override int Attack(Human target)
    {
        int dmg = Intelligence * 3;
        Health +=dmg;
        target.Health -= dmg;
        return target.Health;
    }

    public void heal (Human target){
        target.Health+= Intelligence*3; 
    }
}

