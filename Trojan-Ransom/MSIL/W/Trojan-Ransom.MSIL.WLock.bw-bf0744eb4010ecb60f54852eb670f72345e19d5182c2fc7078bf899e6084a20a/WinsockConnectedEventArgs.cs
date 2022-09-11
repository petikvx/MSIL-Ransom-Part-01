using System;

public class WinsockConnectedEventArgs : EventArgs
{
	private string _IP;

	private int _Port;

	public string SourceIP => _IP;

	public int SourcePort => _Port;

	public WinsockConnectedEventArgs(string source_ip, int source_port)
	{
		_IP = source_ip;
		_Port = source_port;
	}
}
