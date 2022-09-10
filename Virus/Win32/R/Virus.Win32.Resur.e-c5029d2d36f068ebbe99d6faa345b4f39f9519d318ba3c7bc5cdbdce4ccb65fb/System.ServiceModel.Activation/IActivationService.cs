namespace System.ServiceModel.Activation;

internal interface IActivationService
{
	string ActivationServiceName { get; }

	string ProtocolName { get; }

	IActivatedMessageQueue CreateQueue(ListenerAdapter la, App app);

	IActivatedMessageQueue FindQueue(int queueId);

	void StopService();
}
