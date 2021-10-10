using System;

// 객체 지향 프로그래밍에서는 가장 처음으로 해야할 일이 내가 rpg를 만들고 싶다.
// 그럼 플레이어가 필요하다 몬스터가 필요하다 등등을 정하게 됨
// class Dragon
// {
//     int AT; // 멤버변수
//     int HP; // 멤버변수
//     // 멤버함수.
//     void Damage()
//     {
//         HP = HP - 10;
//     }
// }
class Player
{ // -> 클래스의 내부

    // 객체 지향의 캡슐화 은닉화를 대표하는 문법 -> 접근제한 지정자이다.

    // 이렇게 세가지 접근제한 지정자가 존재
    public int HP; // 외부에도 공개
    protected int ATT; // 자식에게만 공개
    private int DEF; // 내부에만 공개

    public void Fight()
    {
        Console.WriteLine("싸운다.");
    }
} // -> 클래스의 끝

// 클래스의 외부
namespace _07ClassAccess
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            // 만들어진 객체의 내용을 사용하기 위해서는 객체의 이름.을 사용함
            // 나오지 않는 이유는 접근 제한 지정자라는 문법을 사용하지 않아서 
            // => 외부에 공개하지 않기로 함


            NewPlayer.HP = 0;
            NewPlayer.Fight();

        }
    }
}
