using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AttrRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CollectStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectStrategy()
	{
	}
}
