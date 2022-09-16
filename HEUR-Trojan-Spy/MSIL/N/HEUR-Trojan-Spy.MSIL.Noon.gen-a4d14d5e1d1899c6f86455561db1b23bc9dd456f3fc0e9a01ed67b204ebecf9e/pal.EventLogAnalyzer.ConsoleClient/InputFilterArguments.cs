using System.Collections.Generic;
using pal.EventLog;
using pal.EventLogAnalyzer.ConsoleClient.Filters;

namespace pal.EventLogAnalyzer.ConsoleClient;

internal class InputFilterArguments
{
	private const string GENERATED_TIME_PROPERTY = "GeneratedTime";

	private const string EVENT_LOG_MESSAGE_PROPERTY = "Message";

	private const string COMPUTER_NAME_PROPERTY = "Computer";

	private const string EVENT_SOURCE_PROPERTY = "Source";

	private const string USER_NAME_PROPERTY = "User";

	private const string EVENT_ID_PROPERTY = "EventId";

	private const string EVENT_TYPE_PROPERTY = "Type";

	private readonly List<IInputFilter> _filters = new List<IInputFilter>();

	private readonly Dictionary<string, IInputFilter> _knownInputFilters = new Dictionary<string, IInputFilter>();

	public InputFilterArguments()
	{
		_knownInputFilters.Add("-after", new AfterDateTimeFilter("GeneratedTime"));
		_knownInputFilters.Add("-before", new BeforeDateTimeFilter("GeneratedTime"));
		_knownInputFilters.Add("-at", new AtDateTimeFilter("GeneratedTime"));
		_knownInputFilters.Add("-startsWith", new StringStartsWithFilter("Message"));
		_knownInputFilters.Add("-contains", new StringContainsFilter("Message"));
		_knownInputFilters.Add("-computer", new StringEqualityFilter("Computer"));
		_knownInputFilters.Add("-source", new StringEqualityFilter("Source"));
		_knownInputFilters.Add("-user", new StringEqualityFilter("User"));
		_knownInputFilters.Add("-eventId", new IntegerEqualityFilter("EventId"));
		_knownInputFilters.Add("-type", new EventTypeFilter("Type"));
		_knownInputFilters.Add("-category", new NullFilter());
	}

	public bool Filter(IEventLogRecord record)
	{
		foreach (IInputFilter filter in _filters)
		{
			if (!filter.Filter(record))
			{
				return false;
			}
		}
		return true;
	}

	public void Add(IInputFilter inputFilter)
	{
		_filters.Add(inputFilter);
	}

	public bool IsKnown(string @switch)
	{
		return _knownInputFilters.ContainsKey(@switch);
	}

	public void Add(string @switch, string parameter)
	{
		IInputFilter inputFilter = _knownInputFilters[@switch];
		inputFilter.Parameter = parameter;
		_filters.Add(inputFilter);
	}
}
