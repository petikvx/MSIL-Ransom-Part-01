namespace com.poweriwb.PowerDesk;

public class TerminalSessionInfo
{
	public string InitialProgram;

	public string ApplicationName;

	public string WorkingDirectory;

	public string OEMId;

	public int SessionId;

	public string UserName;

	public string WinStationName;

	public string DomainName;

	public TermServicesManager.WTS_CONNECTSTATE_CLASS ConnectState;

	public int ClientBuildNumber;

	public string ClientName;

	public string ClientDirectory;

	public int ClientProductId;

	public int ClientHardwareId;

	public TermServicesManager.WTS_CLIENT_ADDRESS ClientAddress;

	public TermServicesManager.WTS_CLIENT_DISPLAY ClientDisplay;

	public int ClientProtocolType;
}
