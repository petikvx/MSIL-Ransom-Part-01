namespace PreEmptive.Analytics.Common;

public interface IMessageQueue : IMessageDequeuer
{
	bool Stopped { get; }

	void Start();

	void Stop();

	void Queue(Message message);

	void SendDisabledChanged(bool stop);

	void SendMessages();
}
