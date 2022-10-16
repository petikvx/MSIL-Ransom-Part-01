using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TemplateBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SearchGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchGlobal()
	{
	}
}
