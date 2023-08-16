int num1 = 0; int num2 = 0;

Console.WriteLine("계산기프로그램\n");

Console.WriteLine("첫번째 숫자를 입력하세요.");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("두번째 숫자를 입력하세요.");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("a 더하기 s 빼기 m 곱하기 d 나누기 입력하세요.");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"결과 : {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"결과 : {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"결과 : {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"결과 : {num1} / {num2} = " + (num1 / num2));
        break;
}