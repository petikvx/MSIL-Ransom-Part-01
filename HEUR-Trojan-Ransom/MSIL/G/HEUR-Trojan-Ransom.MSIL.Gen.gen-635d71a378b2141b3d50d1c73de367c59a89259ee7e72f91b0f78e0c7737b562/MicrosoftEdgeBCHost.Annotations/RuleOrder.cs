using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RuleOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleOrder()
	{
		WriterPropertyProducer.ResolveStub();
		MapItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapItem()
	{
	}
}
