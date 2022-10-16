using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InstanceFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceFilter()
	{
		WriterPropertyProducer.ResolveStub();
		TestProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestProduct()
	{
	}
}
