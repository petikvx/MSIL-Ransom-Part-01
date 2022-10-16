using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PageRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PostClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostClass()
	{
	}
}
