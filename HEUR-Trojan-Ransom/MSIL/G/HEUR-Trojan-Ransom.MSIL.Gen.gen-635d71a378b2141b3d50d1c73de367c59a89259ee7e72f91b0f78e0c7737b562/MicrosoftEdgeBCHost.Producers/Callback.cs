using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class Callback
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Callback()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptIdentifier()
	{
	}
}
