namespace The_chViewer;

public class SimpleLogger
{
	public enum MessageLevel
	{
		None,
		Success,
		Information,
		Debug,
		DebugError,
		Error
	}

	public delegate void HandleLogger(string message, MessageLevel messageLevel);

	public event HandleLogger EventLog;

	public void Log(string message, MessageLevel messageLevel)
	{
		if (this.EventLog != null)
		{
			this.EventLog(message, messageLevel);
		}
	}
}
