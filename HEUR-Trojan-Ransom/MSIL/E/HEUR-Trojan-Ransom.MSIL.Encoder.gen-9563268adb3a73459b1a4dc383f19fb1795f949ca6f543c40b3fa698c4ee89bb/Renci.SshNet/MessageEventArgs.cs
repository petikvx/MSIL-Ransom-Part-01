using System;

namespace Renci.SshNet;

public class MessageEventArgs<T> : EventArgs
{
	public T Message { get; private set; }

	public MessageEventArgs(T message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		Message = message;
	}
}
