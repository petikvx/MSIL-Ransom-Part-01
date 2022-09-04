using System;

public class WinsockSendEventArgs : EventArgs
{
	private int _bTotal;

	private int _bSent;

	private string _IP;

	public string DestinationIP => _IP;

	public int BytesSent => _bSent;

	public int BytesTotal => _bTotal;

	public double SentPercent => Math.Round((double)_bSent / (double)_bTotal * 100.0, 2);

	public WinsockSendEventArgs(string dest_ip, int bytes_sent, int bytes_total)
	{
		_IP = dest_ip;
		_bTotal = bytes_total;
		_bSent = bytes_sent;
	}
}
