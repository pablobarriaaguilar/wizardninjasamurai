using System.Diagnostics.Contracts;

class Samurai:Human{

    public Samurai():base("samurai",10,10,10,200){}

    public override int Attack(Human target)
    {
        int dmg = Strength;
        target.Health-=dmg;
        if(target.Health < 50){
            target.Health = 0;
        }

        return target.Health;
    }

    public void Meditate(){
        Health = 200;
    }
}