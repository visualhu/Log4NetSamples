using log4net.Layout;

namespace Core.Log.Logger.Extension
{
    public class CustomPatternLayout : PatternLayout
    {
        public CustomPatternLayout()
        {
            AddConverter("property", typeof(XPatternLayoutConverter));
        }
    }
}
