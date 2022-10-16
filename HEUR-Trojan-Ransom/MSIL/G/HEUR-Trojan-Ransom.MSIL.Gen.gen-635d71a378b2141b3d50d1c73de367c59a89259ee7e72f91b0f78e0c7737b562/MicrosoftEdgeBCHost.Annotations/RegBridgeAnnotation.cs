using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RegBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InitEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitEvent()
	{
	}
}
