using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PageBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceBridge()
	{
	}
}
