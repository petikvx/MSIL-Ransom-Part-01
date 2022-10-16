using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReaderAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralProduct()
	{
	}
}
