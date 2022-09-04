namespace rundll32;

public struct ircConnectionDetails
{
	private string _host;

	private int _port;

	public string host => _host;

	public int port => _port;

	public ircConnectionDetails(string host, int port)
	{
		_host = host;
		_port = port;
	}
}
