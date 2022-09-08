using System;

namespace Orcus.Commands.TextChat;

public class SendTextMessageEventArgs : EventArgs
{
	public string Message { get; }

	public SendTextMessageEventArgs(string message)
	{
		Message = message;
	}
}
