
namespace Extensions;

static class ConsoleExtension
{
    public static void PrintLine(this string text)
        => Console.WriteLine(text);
    
    public static void Print(this string text)
        => Console.WriteLine(text);
}