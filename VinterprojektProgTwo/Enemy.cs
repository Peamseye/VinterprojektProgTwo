
public class Enemy
{

private int EHp = 100;

public void SetEHp(int eh) {
EHp = eh;
if (EHp < 0) EHp = 0;
}

public int GetHp() {
    return EHp;
}

}

