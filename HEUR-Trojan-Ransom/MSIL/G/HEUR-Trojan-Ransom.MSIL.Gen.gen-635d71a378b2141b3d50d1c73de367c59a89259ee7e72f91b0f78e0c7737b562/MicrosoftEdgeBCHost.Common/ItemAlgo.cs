using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ItemAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralParam()
	{
	}
}
