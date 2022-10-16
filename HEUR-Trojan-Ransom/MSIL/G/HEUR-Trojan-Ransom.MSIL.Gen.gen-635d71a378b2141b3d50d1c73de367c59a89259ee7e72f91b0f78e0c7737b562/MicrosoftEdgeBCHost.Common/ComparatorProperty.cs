using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ComparatorProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorProperty()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceBridge()
	{
	}
}
