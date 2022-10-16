using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestsOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsOrder()
	{
		WriterPropertyProducer.ResolveStub();
		SetMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetMerchant()
	{
	}
}
