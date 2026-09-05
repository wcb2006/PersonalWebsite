using System.Globalization;

namespace PersonalWebsite.Models;

// Databasinnehåll kan inte ligga i .resx - resx kompileras vid build, medan
// texterna här ändras i drift. Därför har varje översättningsbart fält en
// engelsk syskonkolumn, och den här hjälparen väljer mellan dem.
public static class LocalizedText
{
    public static string? Pick(string? sv, string? en) =>
        CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en"
            && !string.IsNullOrWhiteSpace(en)
                ? en
                : sv;
}
