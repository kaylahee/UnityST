﻿using System;

// 행동에 대해 설명
// 지형에서 움직인다 /  몬스터를 공격한다 / NPC와 대화한다 / 스킬을 사용한다,
class Player
{
    // 명사만으로는 부족
    int ATT;
    int HP;

    // 행동으로 나타나게 되는데 이것을 표현하는 것을 멤버함수라고 함
    // 굉장히 다양한 방법으로 함수를 선언할 수 있음
    /*리턴값*/ void /*리턴값*/ Move /*인자값*/()
    { // <- 함수 시작

    } // <- 함수의 끝

    void Fight()
    {

    }
    void SkillUse()
    {

    }
    void Talk()
    {

    }
}

// RPG를 만든다 -> 프로젝트 만든다
// 주인공이 있다 -> 클래스
// 주인공이 공격력이 있다 -> 멤버변수
// 주인공이 공격력으로 때린다 -> 멤버함수