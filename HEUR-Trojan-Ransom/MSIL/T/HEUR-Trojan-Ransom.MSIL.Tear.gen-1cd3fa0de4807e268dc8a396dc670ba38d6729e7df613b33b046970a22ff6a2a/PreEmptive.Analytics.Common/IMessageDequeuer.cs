using System.Collections.Generic;

namespace PreEmptive.Analytics.Common;

public interface IMessageDequeuer
{
	IList<Message> DequeueMessages();

	IList<Message> PeekMessages();
}
