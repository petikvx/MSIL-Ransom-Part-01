using pal.EventLog;

namespace pal.EventLogAnalyzer.ConsoleClient.Filters;

internal class NullFilter : IInputFilter
{
	public object Parameter
	{
		get
		{
			return new object();
		}
		set
		{
		}
	}

	public bool Filter(IEventLogRecord recordToFilter)
	{
		return false;
	}
}
