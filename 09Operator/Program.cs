using System;

class Player
{
    int HP = 100;

    void Damage(int _HP)
    {
        HP = HP - 10;
    }

    bool ReturnTrue()
    {
        return true;
    }

    public int Plus(int _Left, int _Right)
    {
        int Result = _Left +_Right;

        return Result;
    }
}

namespace _09Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            int Result = 0;
            int Left = 7;
            int Right = 3;

            // = 대입연산자,
            // 함수에서 리턴된 값이나 혹은 연산이 된 값을 받을 수 있는 변수에 넣어줘라
            // 리터럴 값일 때도 있다.

            // 산술연산자
            // 리턴값이라는 것은 외부에 연산값이나 객체 상태값 등을 끝나고 나면 외부에 반환하는 것을 말함
            // 이런식으로 = 연산자가 있다면 오른쪽부터 실행된다.
            // 연산자의 우선순위라고 한다.
            // 산술연산자에는 * / % 가 먼저되고
            // + -가 된다.
            Result = NewPlayer.Plus(Left, Right); // 더하기
            Result = Left - Right; // 빼기
            Result = Left * Right; // 곱하기
            Result = Left / Right; // 나누기
            Result = Left % Right; // 나머지
            
            // ()연산자는 연산자의 실행순서를 내가 지정해줄 수 있게 된다
            Result = (Left + Right) * 10;
            // 이런식으로 산술 연산을 할 수 있다
            // 한가지 주의할 점은 나누기와 나머지에는 0을 넣으면 안된다.
            // 10 / 0은 수학에서 불가능 
            // 컴퓨터에서는 제로디비전이라고 해서 아예 오류가 나버림
            // 프로그램이 실행 도중에 터질 정도의 오류이기 때문에 주의해야함

            // 연산자는 함수와 비슷함

            // 비교연산자
            // 비교연산자는 논리형으로 리턴될 수 있다.
            // 논리형은 bool
            // 정수를 넣어줄 수 있다 (음수도 포함)
            int Number = 36778923;

            // 100, 200은 상수, 정수형 상수라고 함 (정수로 표현되는 상수)
            // bool은 참과 거짓이 있는데 참과 거짓이 상수화된 것이 true와 false라는 말
            bool BResult = true;
            BResult = false;
             
            // 이런식으로 참과 거짓을 통해서
            // 나중에 배울 조건문에서 정말 유용하게 이용되게 됨
            BResult = Left > Right; // Left가 Right보다 큰가? 참이라면 true 거짓이라면 false 값을 리턴
            BResult = Left < Right; // Left가 Right보다 작은가?
            BResult = Left <= Right; // Left가 Right보다 작거나 같은가?
            BResult = Left >= Right; // Left가 Right보다 크거나 같은가?
            BResult = Left == Right; // Left가 Right와 같은가?
            BResult = Left != Right; // Left가 Right와 다른가?

            // bool 논리 연산자
            // bool 논리 연산자는 참과 거짓을 연산하는 연산자
            // 둘이 맞다면/ 둘다 틀리다면/ 둘이 같다면
            BResult = !(Left > Right); // true면 flase
            BResult = !false; // flase면 true

            BResult = true && false; // AND
            BResult = true && true; // AND
            // 연속되어 있을 때 그 중 단 1개라도 false면 false이다
            BResult = true && true && false; // AND

            // 이것은 하나라도 true가 있으면 true
            BResult = true || false; // OR
            BResult = false || false; // OR

            // 양쪽이 다르다면 true / 같다면 false가 되는 연산
            BResult = true ^ false; // XOR
            BResult = true ^ true; // XOR
            BResult = false ^ true; // XOR
            BResult = false ^ false; // XOR

            // 축약 연산자
            Result = 0;
            // 산술 연산자를 이렇게 축약해서 사용할 수 있다.
            Result = Result + 10;
            Result += 10;

            Result /= 10;
            Result *= 10;



        }
    }
}
