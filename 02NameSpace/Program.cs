using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 문법을 공부할 때, 응용법까지 욕심내는 경우가 있다.
// 게임 프로그래밍에서는 실제 코드를 짜면서 보기 전까지는 응용에 대해 느낄 수 없다.
// 프로그래밍에서는 경우가 무한대이다.
// ex) 배열이라는 것을 배웠고, 이것은 인벤토리를 만들때 쓸 수 있다 / 오브젝트를 관리할 때 쓸 수 있다.

// 프로그래머가 2명 (보통 각자 다른 분야를 맡게 됨) /  Rpg를 만들기로 함

// 몬스터
// 무기
// 아이템

// A 프로그래머
// hp 포션
// B 프로그래머
// mp 포션

// 클래스의 이름들은 전문적 용어로 식별자 
// => 어떠한 코드적 내용을 묶는 하나의 명칭
// 식별자가 겹칠 때의 문제는 사용할 때이다.

// A 프로그래머
namespace APRO
{
    // 네임스페이스는 개념의 표현보다는 개념의 분류
    class /*APRO.*/Potion
    {
        // 플레이어가 마시면 HP가 차는 내용
    }
}


// B 프로그래머
namespace BPRO
{
    class /*BPRO.*/Potion
    {
        // 플레이어가 마시면 MP가 차는 내용
    }

}

class Player
{

}

namespace _02NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
