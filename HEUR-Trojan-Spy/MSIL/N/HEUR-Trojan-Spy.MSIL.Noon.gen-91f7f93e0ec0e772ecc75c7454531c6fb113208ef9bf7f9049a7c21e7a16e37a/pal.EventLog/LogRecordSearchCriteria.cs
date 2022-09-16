namespace pal.EventLog;

public class LogRecordSearchCriteria
{
	private string _message;

	private string _source;

	public string Source => _source;

	public string Message => _message;

	public LogRecordSearchCriteria(string source, string message)
	{
		_source = source;
		_message = message;
	}
}
