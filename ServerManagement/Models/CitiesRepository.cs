namespace ServerManagement.Models;

public class CitiesRepository
{

    public static List<string> Cities = new List<string>()
    {
        "Toronto",
        "Montreal",
        "Ottawa",
        "Calgary",
        "Halifax"
    };

    public static List<String> GetCities() => Cities;
}