using System;

class FightUnit
{
    // 외부 자식 내부 까지만
    // 디폴트 접근제한지정자는 private
    protected string Name = "NONE";
    protected int AT = 10;
    // protected int ItemAT = 10;
    protected int HP = 100;

    /*public static virtual void Test()
    {
    this가 없어서 virtual 안됨.
    }*/

    // 이 문법의 핵심은
    // 자식에서 만약 나의 /*같은 이름의 함수나 프로퍼티*/를 재구현했다면
    // 자식의 형태의 /*같은 이름의 함수나 프로퍼티*/를 호출해 주세요
    // 이걸 오버라이딩
    // 다형성(동적바인딩)의 핵심 문법 중 하나이다.
    public virtual int GetAT()
    {
        Console.WriteLine("FIGHTUNIT의 GETAT");
        return AT;
    }

    public virtual int TestVirtual(int _VALUE, int _ValUE1)
    {
        return AT;
    }

    // 프로퍼티는 VIRTUAL
    public virtual int DMGAT
    {
        get
        {
            Console.WriteLine("FIGHTUNIT의 DMGAT");
            return AT;
        }
    }

    // 업캐스팅
    // DamageFightUnit
    // 첫번째 상속의 개념을 지키기 위해서
    // (코드 재활용성)(코드를 적게 치고 최대한의 효과를 누리고 싶다.)
    public void Damage(FightUnit _OtherFightUnit)
    {
        // 각자 플레이어면 플레이어의 것
        // _OtherFightUnit.AT
        int AT = _OtherFightUnit.DMGAT;
        Console.WriteLine(_OtherFightUnit.Name + "에게" + AT + "만큼의 데미지를 입었습니다.");
        HP -= AT;
    }

    // 생성자는 오버라이딩을 할 수 없다.
    /*public virtual FightUnit()
    {
        
    }*/

    // 오버로딩
    // DamagePlayer
    /*public void Damage(Player _OtherFightUnit, int DamagePlus)
    {
        // _OtherFightUnit

        Console.WriteLine(_OtherFightUnit.Name + "에게" + _OtherFightUnit.AT + "만큼의 데미지를 입었습니다.");
        HP -= _OtherFightUnit.AT;
    }*/
}

class Player : FightUnit
{ 
    int ItemAt = 5;

    // 나는 부모님의 GetAT를 재구현했다
    public override int DMGAT
    {
        get
        {
            Console.WriteLine("플레이어의 DMGAT");
            return AT + ItemAt;
        }
    }

    public Player()
    {
    }

    public Player(string _Name)
    {
        Name = _Name;
    }
}

class Monster : FightUnit
{
    int MonsterLv = 2;

    public override int GetAT()
    {
        Console.WriteLine("Monster의 GETAT");
        return AT + MonsterLv;
    }

    public Monster(string _Name/*, int _MonsterStartLv*/)
    {
        Name = _Name;
    }
}

namespace _30Overraiding
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            Player NewPlayer = new Player("플레이어");
            Monster NewMonster = new Monster("몬스터");
            // FightUnit NewFight = new FightUnit();

            // NewPlayer.GetAT();

            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);

        }
    }
}
