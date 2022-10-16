using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InvocationSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralBridge()
	{
	}
}
