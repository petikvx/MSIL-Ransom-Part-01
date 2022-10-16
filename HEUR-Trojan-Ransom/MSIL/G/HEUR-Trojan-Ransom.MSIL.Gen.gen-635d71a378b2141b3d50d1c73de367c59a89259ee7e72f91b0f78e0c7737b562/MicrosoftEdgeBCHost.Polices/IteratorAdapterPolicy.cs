using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IteratorAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralRequest()
	{
	}
}
