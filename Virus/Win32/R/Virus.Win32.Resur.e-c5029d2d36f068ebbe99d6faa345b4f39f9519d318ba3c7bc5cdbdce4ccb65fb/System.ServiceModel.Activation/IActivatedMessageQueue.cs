using System.ServiceModel.Channels;

namespace System.ServiceModel.Activation;

internal interface IActivatedMessageQueue
{
	App App { get; }

	ListenerChannelContext ListenerChannelContext { get; }

	bool HasStartedQueueInstances { get; }

	void OnQueueInstancesStopped();

	void Delete();

	void LaunchQueueInstance();

	ListenerExceptionStatus Register(BaseUriWithWildcard url);

	void SetEnabledState(bool enabled);

	void UnregisterAll();
}
