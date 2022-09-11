using System;

public class WinsockReceiveProgressEventArgs : EventArgs
{
	private int _bTotal;

	private int _bIn;

	private string _IP;

	public string SourceIP => _IP;

	public int BytesReceived => _bIn;

	public int BytesTotal => _bTotal;

	public double ReceivedPercent => Math.Round((double)_bIn / (double)_bTotal * 100.0, 2);

	public WinsockReceiveProgressEventArgs(string source_ip, int bytes_received, int bytes_total)
	{
		_IP = source_ip;
		_bTotal = bytes_total;
		_bIn = bytes_received;
	}
}
