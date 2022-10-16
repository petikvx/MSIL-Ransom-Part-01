using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FactoryWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutMerchant()
	{
	}
}
