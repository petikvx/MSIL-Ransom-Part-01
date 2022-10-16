using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InvocationBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		OrderCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderCode()
	{
	}
}
