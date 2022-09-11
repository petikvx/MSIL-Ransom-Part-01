using System;

public class WinsockDataArrivalEventArgs : EventArgs
{
	private int _bTotal;

	private string _IP;

	private int _Port;

	public int TotalBytes => _bTotal;

	public string SourceIP => _IP;

	public int SourcePort => _Port;

	public WinsockDataArrivalEventArgs(int bytes_total, string source_ip, int source_port)
	{
		_bTotal = bytes_total;
		_IP = source_ip;
		_Port = source_port;
	}
}
