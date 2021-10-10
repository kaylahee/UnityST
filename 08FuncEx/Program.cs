using System;

class Player
{
    // 접근제한 지정자를 입력하지 않으면 디폴트로 private
    // private이 일반적이기 때문이다
    // 속성들은 외부에서 접근하지 못하는게 일반적으로 좋다.
    // 공격력은 공격력 그 자체만으로 의미가 있지만, 그 의미가 명확해지지 않는다.
    private int LV = 1;
    private int AT = 10;
    private int HP = 100;

    // 플레이어의 레벨이 얼마인지 알고 싶다
    // 인자 값이 아니고 리턴값을 사용
    // 리턴값이란 객체가 자신의 상태를 외부에 알려주는 용도로 사용
    // 외부에 알려줘야하기 때문에 알려주는 순간 함수가 끝나게 됨
    // 이 return이라는 문장을 사용하면 얼마나 많은 코드가 return 아래에 있든 함수가 종료하게 됨
    public int GetLv()
    {
        // 리턴을 하는 순간 함수가 끝나고 아래에 친 코드들은 모두 의미가 없다.
        LV = 10000;

        return LV;
    }




    // 어떤 상태(멤버변수)가 변화하는 순간, 각각 증가시키거나.
    public void LVUP()
    {
        AT = 100;
        HP = 1000;
    }
    public void SetHP(int _HP)
    {
        // HP가 0이 되는 순간만 체크할 수도 있고, 100이 되는 순간만 체크할 수도 있다.
        // 가장 큰 핵심은 디버깅이 된다.
        HP = _HP;
    }

    // 함수는 보통 선언과 내용으로 나뉘게 됨
    
    public void Func()
        // void[리턴값] Func[이름 혹은 식별자] ()[인자값]
    {

    }

    // 함수란 보통 클래스 외부와의 소통을 위해서 만듬
    // (int _Dmg)를 넣는다는 것은 외부에서 한 개의 int 값을 넣어서 플레이어에게 전달해주겠다
    public void Damage1(int _Dmg)
    {
        HP = HP - _Dmg;
    }

    // 리턴값은 자신이 리턴해주려는 자료형과 동일한 자료형이어야 한다,
    public int DamageToHPReturn(int _Dmg, int _Dmg1, int _Dmg2)
    {
        HP = HP - _Dmg;
        return HP;
    }
    // 개수는 신경 안써도 될 정도로 100개 이상은 넣어줄 수 있다.
    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }
} 
// 플레이어가 어떤 사양과 내용을 가짐 
// 아직 만든 건 아님

namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        { 
            Player NewPlayer = new Player();
            // 그래서 필요한 것이 함수이다
            //NewPlayer.LVUP();

            //NewPlayer.SetHP(1000);
            
            // 이런 식으로 외부의 값을 받아서 객체가 내부의 상태를 변화시키기 위해
            // 함수를 선언하는 경우가 많다.
            //NewPlayer.Damage1(10);
            //NewPlayer.Damage1(20);
            //NewPlayer.Damage2(10,20);

            Console.WriteLine(NewPlayer.GetLv());

            Console.WriteLine(NewPlayer.DamageToHPReturn(50, 20, 30));
        }
    }
}
