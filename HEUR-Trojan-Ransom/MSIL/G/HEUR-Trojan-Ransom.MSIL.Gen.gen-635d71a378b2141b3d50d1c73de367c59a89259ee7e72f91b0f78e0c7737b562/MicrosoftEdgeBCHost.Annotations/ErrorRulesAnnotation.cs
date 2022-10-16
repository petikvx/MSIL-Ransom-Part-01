using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ErrorRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SortTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortTemplate()
	{
	}
}
