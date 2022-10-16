using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FilterAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralConfiguration()
	{
	}
}
