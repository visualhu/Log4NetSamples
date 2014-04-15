using log4net.Layout;

public class CustomPatternLayout : PatternLayout
{
    public CustomPatternLayout()
    {
        AddConverter("property", typeof(XPatternLayoutConverter));
    }
}
