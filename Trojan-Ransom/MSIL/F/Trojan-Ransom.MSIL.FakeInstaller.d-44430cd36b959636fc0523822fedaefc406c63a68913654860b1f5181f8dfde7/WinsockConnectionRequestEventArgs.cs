using System;
using System.Net;
using System.Net.Sockets;

public class WinsockConnectionRequestEventArgs : EventArgs
{
	private Socket _client;

	private bool _cancel;

	public Socket Client => _client;

	public string ClientIP
	{
		get
		{
			IPEndPoint iPEndPoint = (IPEndPoint)_client.RemoteEndPoint;
			return iPEndPoint.Address.ToString();
		}
	}

	public bool Cancel
	{
		get
		{
			return _cancel;
		}
		set
		{
			_cancel = value;
		}
	}

	public WinsockConnectionRequestEventArgs(Socket new_client)
	{
		_cancel = false;
		_client = new_client;
	}
}
