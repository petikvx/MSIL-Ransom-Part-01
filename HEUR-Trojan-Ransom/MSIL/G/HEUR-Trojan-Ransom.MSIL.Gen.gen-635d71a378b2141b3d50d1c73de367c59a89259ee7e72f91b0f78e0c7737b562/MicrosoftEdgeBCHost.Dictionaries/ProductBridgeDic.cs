using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProductBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInvocation()
	{
	}
}
