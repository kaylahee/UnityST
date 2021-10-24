using System;

enum DMGTYPE
{
    PYDMG,
    FIREDMG,
    ICEDMG
}

class Player
{
    // 물리 방어
    int AttDef = 5;
    // 불 방어
    int FireDef = 5;
    // 물 방어 
    int IceDef = 5;

    int Hp = 100;

    public Player()
    {

    }

    public Player(int _Hp)
    {
        Hp = _Hp;
    }

    static void Func(int _Value)
    {

    }

    static void Func2(int _Value, int _Value2)
    {

    }
    // Damageint
    // 함수 오버로딩
    public void Damage(int _Damage)
    {
        Hp -= _Damage;
    }

    // Damagefloat
    public void Damage(float _Damage)
    {

    }

    // Damagefloatint
    // 뒤에 자료형까지 이름으로 본다고 생각하면 오버로딩에 대해 생각할 수 있다
    // 내용은 다르게
    public void Damage(float _dddd, int _Type)
    {

    }

    // Damageintint
    public void Damage(int _Damage, DMGTYPE _Type)
    {
        switch (_Type)
        {
            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;
            default:
                break;
        }

        Damage(_Damage);
    }
}

namespace _29OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player(1000);
            NewPlayer.Damage(100, DMGTYPE.FIREDMG);
        }
    }
}
