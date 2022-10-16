using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FilterRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PatchDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchDefinition()
	{
	}
}
