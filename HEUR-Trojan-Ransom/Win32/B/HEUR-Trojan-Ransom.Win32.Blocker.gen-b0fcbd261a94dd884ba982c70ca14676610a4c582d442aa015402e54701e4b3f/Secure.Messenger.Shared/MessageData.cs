using System;

namespace Secure.Messenger.Shared;

[Serializable]
public class MessageData
{
	public string MessageBody;

	public MessageData(string messageBody)
	{
		MessageBody = messageBody;
	}
}
