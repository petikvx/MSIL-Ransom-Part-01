namespace System.ServiceModel.Activation;

internal interface IActivationService
{
	_003F ActivationServiceName { get; }

	_003F ProtocolName { get; }

	_003F CreateQueue();

	_003F FindQueue();

	_003F StopService();
}
