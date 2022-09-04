using System;
using System.Net.Sockets;

public class WinsockErrorReceivedEventArgs : EventArgs
{
	private string m_errorMsg;

	private string m_function;

	private SocketError m_errorCode;

	private string m_Details;

	public string Message => m_errorMsg;

	public string Function => m_function;

	public SocketError ErrorCode => m_errorCode;

	public string Details => m_Details;

	public WinsockErrorReceivedEventArgs(string error_message)
		: this(error_message, null)
	{
	}

	public WinsockErrorReceivedEventArgs(string error_message, string function_name)
		: this(error_message, function_name, null)
	{
	}

	public WinsockErrorReceivedEventArgs(string error_message, string function_name, string extra_details)
		: this(error_message, function_name, extra_details, SocketError.Success)
	{
	}

	public WinsockErrorReceivedEventArgs(string error_message, string function_name, string extra_details, SocketError error_code)
	{
		m_errorMsg = error_message;
		m_function = function_name;
		m_Details = extra_details;
		m_errorCode = error_code;
	}
}
