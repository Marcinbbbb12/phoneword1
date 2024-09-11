using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
namespace Core;
public static class PhonewordTranslator
{
    public static string ToNumber(string raw)
}
if (string.IsNullOrWhiteSpace(raw))
    return null;
    raw = raw.ToUpperInvariant();
    var newNumber = new StringBuilder();
foreach (var c in raw)
    {
    if("-0123456789".Contains(c))
    newNumber.Append(c);
    else
    return null;
    }
    }
    return newNumber.ToString();
}
static bool Contains(this string keyString, char c)
{
    return keyString.IndexOf(c) >= 0;
}
static int? TranslateToNumber(char c)
{
    for (int i = 0; i < digits.Lenght; i++)
    {
        if (digits[i].Contains(c))
            return 2 + i;
    }
    return null;
}
}