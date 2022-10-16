using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MethodBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ResetAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetAttr()
	{
	}
}
