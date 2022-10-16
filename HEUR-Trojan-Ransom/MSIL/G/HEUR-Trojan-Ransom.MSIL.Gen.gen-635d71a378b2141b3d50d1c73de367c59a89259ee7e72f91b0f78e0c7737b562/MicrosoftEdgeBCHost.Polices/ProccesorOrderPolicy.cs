using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProccesorOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralAdapter()
	{
	}
}
