namespace com.poweriwb.PowerDesk;

public class TerminalSessionData
{
	public int SessionId;

	public TermServicesManager.WTS_CONNECTSTATE_CLASS ConnectionState;

	public string StationName;

	public TerminalSessionData(int sessionId, TermServicesManager.WTS_CONNECTSTATE_CLASS connState, string stationName)
	{
		SessionId = sessionId;
		ConnectionState = connState;
		StationName = stationName;
	}

	public override string ToString()
	{
		return $"{SessionId} {ConnectionState} {StationName}";
	}
}
