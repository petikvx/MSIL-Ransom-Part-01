using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CustomerFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StartIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartIdentifier()
	{
	}
}
