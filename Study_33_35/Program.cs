﻿/*
//[I] 네임스페이스 추가
using System;

namespace TypeDefinitionWithUsing
{
    //[II] Gilbut.Education.CSharp.Lecture 형식을 Project 별칭으로 줄여서 사용
    using Project = Gilbut.Education.CSharp.Lecture;

    public class TypeDefinitionWithUsing
    {
        public static void Main(string[] args)
        {
            //[1] 기본 호출
            Gilbut.Education.CSharp.Lecture l =
                new Gilbut.Education.CSharp.Lecture();
            Console.WriteLine(l);
            //[2] using 지시문 사용 호출
            Project p = new Project();
            Console.WriteLine(p);
        }
    }
}

namespace Gilbut
{
    namespace Education
    {
        namespace CSharp
        {
            public class Lecture
            {
                public override string ToString()
                {
                    return "Lecture 클래스 호출됨";
                }
            }
        }
    }
}
*/

/*
using System;

class Say
{
    //[1] 필드(멤버 변수)
    private string message = "안녕하세요."; // 필드 이니셜라이저

    //[2] 메서드
    public void Hi()
    {
        //this.message = "반갑습니다.";
        Console.WriteLine(this.message);
    }
}

class FieldInitializer
{
    static void Main()
    {
        Say say = new Say();
        say.Hi();
    }
}
*/

//[?] public과 private 액세스 한정자  
using System;

public class TestClass
{
    // 필드 선언
    // 접근 한정자(Access Modifier): public, private, protected, ...
    // private(비공개): 해당 클래스내에서만 사용
    private static string name = "홍길동";

    // public(공개;제한없음): 다른 클래스에서도 사용 가능
    public static string siteName = "길벗"; // public 필드는 권장하지 않음

    // 메서드 선언
    public static string GetName()
    {
        return name;
    }
}

class PublicPrivate
{
    static void Main()
    {
        // TestClass.name; -> private 멤버는 외부에 노출되지 않음
        Console.WriteLine(TestClass.siteName); // public 멤버는 외부에 노출
        // private 필드의 값을 외부에 공개하고자할 때에는 public으로 공개
        Console.WriteLine(TestClass.GetName());
    }
}
