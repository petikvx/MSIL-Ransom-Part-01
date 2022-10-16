using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CallbackOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceSystem()
	{
	}
}
