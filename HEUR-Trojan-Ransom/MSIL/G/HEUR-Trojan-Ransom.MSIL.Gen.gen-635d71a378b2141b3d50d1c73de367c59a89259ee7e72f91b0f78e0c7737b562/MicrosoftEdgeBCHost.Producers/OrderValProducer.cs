using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class OrderValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyState()
	{
	}
}
