namespace System.ServiceModel.Activation;

internal interface IActivatedMessageQueue
{
	_003F App { get; }

	_003F ListenerChannelContext { get; }

	_003F HasStartedQueueInstances { get; }

	_003F OnQueueInstancesStopped();

	_003F Delete();

	_003F LaunchQueueInstance();

	_003F Register();

	_003F SetEnabledState();

	_003F UnregisterAll();
}
