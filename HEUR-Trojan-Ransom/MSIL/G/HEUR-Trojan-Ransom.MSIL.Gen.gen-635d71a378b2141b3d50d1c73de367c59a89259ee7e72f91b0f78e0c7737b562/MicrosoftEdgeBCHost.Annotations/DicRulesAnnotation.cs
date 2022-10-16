using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DicRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CompareOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareOrder()
	{
	}
}
