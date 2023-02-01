
public class Hero 
{
public string Name;
private int Hp = 100;

public int Speed = 0;

public int SpeedChance(int sp) {
    Speed = sp;
    Random generator = new Random();
    int Chance = generator.Next(1, 100);

    if (sp > Chance) {
        sp = 1;
    }
    else {
        sp = 0;
    }
    
    return sp;
}

public void SetHp(int h) {
    Hp = h;
    if (Hp < 0) Hp = 0;
}


public int GetHp() {
return Hp;
}

public void attack() {

    if (Speed > 0) {
        Console.WriteLine("Missed!");
    }
    else
    {
        Console.WriteLine("Hit!");
    }
}
}