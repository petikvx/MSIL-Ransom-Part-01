using System;
using System.Diagnostics;

namespace pal.EventLogAnalyzer.ConsoleClient.Filters;

internal class EventTypeFilter : AbstractInputFilter<EventLogEntryType>
{
	public EventTypeFilter(string propertyName)
		: base(propertyName)
	{
	}

	protected override bool recordMatchesCriteria(EventLogEntryType propertyValue)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return propertyValue == (EventLogEntryType)_parameter;
	}

	protected override EventLogEntryType setParameter(string value)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		return (EventLogEntryType)Enum.Parse(typeof(EventLogEntryType), value, ignoreCase: true);
	}
}
