using System;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Storage;

namespace DevDefined.OAuth.Provider.Inspectors;

public class ConsumerValidationInspector : IContextInspector
{
	private readonly IConsumerStore _consumerStore;

	public ConsumerValidationInspector(IConsumerStore consumerStore)
	{
		if (consumerStore == null)
		{
			throw new ArgumentNullException("consumerStore");
		}
		_consumerStore = consumerStore;
	}

	public void InspectContext(ProviderPhase phase, IOAuthContext context)
	{
		if (!_consumerStore.IsConsumer(context))
		{
			throw Error.UnknownConsumerKey(context);
		}
	}
}
