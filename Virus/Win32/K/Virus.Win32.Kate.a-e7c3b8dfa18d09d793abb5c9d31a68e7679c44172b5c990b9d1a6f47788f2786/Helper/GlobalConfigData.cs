namespace Helper;

public class GlobalConfigData
{
	public string ProxyServer;

	public int ProxyPort;

	public string ProxyUser;

	public string ProxyPass;

	public int ConnectDelayTime = 5;

	public int TryTimes = 3;

	public int RepeatTime;

	public int HttpTimeout = 20000;

	public int HttpTryTimes = 3;

	public bool WriteToLogFile;
}
