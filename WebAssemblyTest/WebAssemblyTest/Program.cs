using DotNetJS;
using Microsoft.JSInterop;

namespace WebAssemblyTestNameSpace;

public partial class Program
{
    // Entry point is invoked by the JavaScript runtime on boot.
    public static void Main()
    {
    }

    [JSInvokable] // The method is invoked from JavaScript.
    public static  Dto ChangeDtoIdTo2(Uri fcsLoc, Guid wksDocId, Dto dto)
    {
        Console.WriteLine(" start");
        Console.WriteLine(fcsLoc.ToString());

        Console.WriteLine(wksDocId.ToString());
        Console.WriteLine(dto.Name);
        Console.WriteLine(dto.Id);
        Console.WriteLine(" end");
        dto.Id = 2;
        return dto;
    }


}
public class Dto
{
    public string Name { get; set; }
    public int Id { get; set; }
}
