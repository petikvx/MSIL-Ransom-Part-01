using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContextAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralVal()
	{
	}
}
