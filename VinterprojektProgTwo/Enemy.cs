
public class Enemy
{

private int EHp = 100;

public int SetEHp(int eh) {
EHp = eh;
if (EHp < 0) EHp = 0;
}

}