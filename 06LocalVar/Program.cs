using System;

class Player
{
    // 멤버 변수 -> 클래스 내부에 있다고 해서 멤버변수
    int Att;
    int Hp;

    void Fight()
    {
        // 선언되는 순간 지역변수는 메모리화 되고 끝나면 사라지는 => 일회용
        int Damage = 0;
        Console.WriteLine("플레이어가 싸운다");
    }
} //  게임에서 사용하기 위해 여기까지 설계함

namespace _06LocalVar
{
    // C#은 고지식한 객체 지향 언어 = 클래스 밖에 모르는 바보
    // 프로그램의 시작조차도 클래스 안에 묶어놔야 함
    class Program
    {
        // 시작용 함수가 있는 것
        static void Main(string[] args)
        {
            // 클레스 안에 있으면 멤버변수

            // 함수 안에 있으면 지역변수라고 함
            // 지역변수 규칙1
            // { 
            //    내부에서만 사용가능
            // }
            int ATT = 0;
            ATT = 50;

            // 객체화라고 하는 굉장히 중요한 작업
            // 클래스 = 설계도
            // Player의 설계대로 플레이어를 만드는데 그 이름을 NewPlayer라고 하라
            //Player NewPlayer1 = new Player();
            //Player NewPlayer2 = new Player();

            Console.WriteLine("지역변수를 공부해 봅시다.");
        }
    }
}
