using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DescriptorWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralRules()
	{
	}
}
