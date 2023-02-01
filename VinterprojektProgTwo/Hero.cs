
public class Hero 
{
public string Name;
private int Hp = 100;

public int Speed = 50;

public int SpeedChance(int s) {
    Speed = s;
    Random generator = new Random();
    int Chance = generator.Next(1, 100);

    if (s > Chance) {
        s = 1;
    }
    else {
        s = 0;
    }
    
    return s;
}

public void SetHp(int h) {
    Hp = h;
    if (Hp < 0) Hp = 0;
}


public int GetHp() {
return Hp;
}

public void attack() {

    
}
}