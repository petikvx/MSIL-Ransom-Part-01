using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParameterBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StartAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartAttr()
	{
	}
}
