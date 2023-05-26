using csgo_sharecode.CSGOSharecode.Base58;
using csgo_sharecode.CSGOSharecode.Exceptions;
using csgo_sharecode.CSGOSharecode.Structs;
using System.Text.RegularExpressions;

public class CSGOSharecodeDecoder
{
    private static Regex CSGOPattern = new(@"^CSGO(-?[\w]{5}){5}$");
    public static Crosshair Decode(string code)
    {
        if (!CSGOPattern.IsMatch(code))
            throw new InvalidSharecodeException();

        string originalCode = code;
        var decoded = CustomBase58.Decode(code.Substring(4).Replace("-", ""));

        return new Crosshair(originalCode, decoded);
    }
}
