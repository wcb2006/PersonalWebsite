using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers;

// Sparar besökarens språkval i cookien som CookieRequestCultureProvider läser
// vid varje request. Cookie i stället för /en/-prefix i URL:en: då slipper vi
// röra routingen och alla asp-controller/asp-action-länkar i vyerna.
public class CultureController : Controller
{
    [HttpGet]
    public IActionResult Set(string culture, string? returnUrl)
    {
        Response.Cookies.Append(
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
            new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddYears(1), // annars försvinner valet när webbläsaren stängs
                IsEssential = true,                          // funktionscookie, undantagen samtyckeskrav
                Path = "/",
                HttpOnly = false,
                SameSite = SameSiteMode.Lax
            });

        // LocalRedirect kastar på externa URL:er, så en manipulerad returnUrl
        // inte kan användas som open redirect.
        return LocalRedirect(string.IsNullOrEmpty(returnUrl) ? "/" : returnUrl);
    }
}
