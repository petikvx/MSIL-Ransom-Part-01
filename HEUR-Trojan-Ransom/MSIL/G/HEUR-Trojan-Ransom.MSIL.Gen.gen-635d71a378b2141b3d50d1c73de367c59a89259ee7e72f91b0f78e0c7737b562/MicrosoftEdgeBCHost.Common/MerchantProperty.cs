using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MerchantProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantProperty()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceBridge()
	{
	}
}
