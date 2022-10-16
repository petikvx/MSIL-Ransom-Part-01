using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CallbackWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceCustomer()
	{
	}
}
