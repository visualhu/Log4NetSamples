using log4net.Layout;

namespace Log4Net_WCF.Logger.Extension
{
    public class CustomPatternLayout : PatternLayout
    {
        public CustomPatternLayout()
        {
            AddConverter("property", typeof(XPatternLayoutConverter));
        }
    }
}
