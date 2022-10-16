using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DisableDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableDefinition()
	{
	}
}
