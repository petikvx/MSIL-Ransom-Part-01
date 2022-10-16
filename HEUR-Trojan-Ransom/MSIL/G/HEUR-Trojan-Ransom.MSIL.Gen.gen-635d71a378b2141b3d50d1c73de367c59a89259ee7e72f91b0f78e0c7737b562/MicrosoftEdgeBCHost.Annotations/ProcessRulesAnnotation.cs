using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProcessRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateClass()
	{
	}
}
