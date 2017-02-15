public class Day
{
    private string fullName;
    private string shortName;

    public Day(string fullName, string shortName) {
        this.fullName = fullName;
        this.shortName = shortName;
    }

    public string FullName {
        get { return fullName; }
    }
    public string ShortName {
        get { return shortName; }
    }

    public override string ToString()
    {
        return $"{fullName} - {shortName}";
    }
}
