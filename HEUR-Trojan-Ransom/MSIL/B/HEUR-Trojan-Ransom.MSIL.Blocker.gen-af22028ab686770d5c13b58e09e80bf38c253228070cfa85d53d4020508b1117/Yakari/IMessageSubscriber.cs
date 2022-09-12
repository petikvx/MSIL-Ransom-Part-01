namespace Yakari;

public interface IMessageSubscriber
{
	event MessageReceived OnMessageReceived;

	void StartSubscription();

	void StopSubscription();

	void MessageReceived(string message);
}
