using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class HelperAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralModel()
	{
	}
}
