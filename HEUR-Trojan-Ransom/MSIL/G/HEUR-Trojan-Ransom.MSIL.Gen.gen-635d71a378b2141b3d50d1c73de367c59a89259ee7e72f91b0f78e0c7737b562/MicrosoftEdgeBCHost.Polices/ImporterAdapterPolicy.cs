using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ImporterAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralContainer()
	{
	}
}
