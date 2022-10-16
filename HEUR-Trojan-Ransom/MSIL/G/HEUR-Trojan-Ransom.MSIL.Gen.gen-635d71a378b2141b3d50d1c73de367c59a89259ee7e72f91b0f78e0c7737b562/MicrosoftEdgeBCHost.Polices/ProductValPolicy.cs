using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProductValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CreateSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateSystem()
	{
	}
}
