using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParserBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SearchAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchAttribute()
	{
	}
}
