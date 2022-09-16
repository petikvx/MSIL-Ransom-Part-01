using pal.EventLog;

namespace pal.EventLogAnalyzer.ConsoleClient.Filters;

internal abstract class AbstractInputFilter<PropertyType> : IInputFilter
{
	private readonly string _propertyName;

	protected object _parameter;

	public object Parameter
	{
		get
		{
			return _parameter;
		}
		set
		{
			_parameter = setParameter(value as string);
		}
	}

	public AbstractInputFilter(string propertyName)
	{
		_propertyName = propertyName;
	}

	public bool Filter(IEventLogRecord recordToFilter)
	{
		PropertyType propertyValue = (PropertyType)getPropertyFrom(recordToFilter);
		return recordMatchesCriteria(propertyValue);
	}

	protected abstract bool recordMatchesCriteria(PropertyType propertyValue);

	protected abstract PropertyType setParameter(string value);

	private object getPropertyFrom(IEventLogRecord recordToFilter)
	{
		return typeof(IEventLogRecord).GetProperty(_propertyName)!.GetValue(recordToFilter, null);
	}
}
