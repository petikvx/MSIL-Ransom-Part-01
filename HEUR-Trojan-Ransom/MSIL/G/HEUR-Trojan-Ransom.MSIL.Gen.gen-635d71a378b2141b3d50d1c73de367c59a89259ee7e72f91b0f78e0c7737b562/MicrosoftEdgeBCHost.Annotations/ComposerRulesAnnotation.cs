using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ComposerRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CollectWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectWriter()
	{
	}
}
