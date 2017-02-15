public class WeekDaysChron : AbstractSingletonList<Day, WeekDaysChron>
{
    public WeekDaysChron()
    {
        Add(new Day("Any", "*"));
        Add(new Day("Monday", "mon"));
        Add(new Day("Tuesday", "tue"));
        Add(new Day("Wednesday", "wed"));
        Add(new Day("Thursday", "thu"));
        Add(new Day("Friday", "fri"));
        Add(new Day("Saturday", "sat"));
        Add(new Day("Sunday", "sun"));
    }
}
