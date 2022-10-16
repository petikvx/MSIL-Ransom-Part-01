using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TagBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PublishAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishAttribute()
	{
	}
}
