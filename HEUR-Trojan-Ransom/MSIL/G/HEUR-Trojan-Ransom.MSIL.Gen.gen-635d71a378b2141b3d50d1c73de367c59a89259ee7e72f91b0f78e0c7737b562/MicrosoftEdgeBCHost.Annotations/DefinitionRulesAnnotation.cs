using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DefinitionRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		MapPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapPredicate()
	{
	}
}
