using System;

//等待用户输入
Console.Write("用户：");
var input = Console.ReadLine();

//循环
while (input != "quit")
{
    var result =   kernel.InvokeStreamingAsync(summarize);
    await foreach (var item in result)
    {
        Console.Write(item.ToString());
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("用户：");
    input = Console.ReadLine();
}
