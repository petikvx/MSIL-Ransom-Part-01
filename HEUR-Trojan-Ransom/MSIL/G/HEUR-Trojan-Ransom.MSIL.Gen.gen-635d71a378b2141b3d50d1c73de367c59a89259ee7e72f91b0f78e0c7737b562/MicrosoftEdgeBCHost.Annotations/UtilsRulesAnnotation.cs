using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class UtilsRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PopDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopDispatcher()
	{
	}
}
