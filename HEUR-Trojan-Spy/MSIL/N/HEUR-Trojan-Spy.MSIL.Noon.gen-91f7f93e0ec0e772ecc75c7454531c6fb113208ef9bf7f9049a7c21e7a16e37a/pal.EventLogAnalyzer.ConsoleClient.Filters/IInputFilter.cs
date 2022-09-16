using pal.EventLog;

namespace pal.EventLogAnalyzer.ConsoleClient.Filters;

internal interface IInputFilter
{
	object Parameter { get; set; }

	bool Filter(IEventLogRecord recordToFilter);
}
