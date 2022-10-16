using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StubValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CountWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountWrapper()
	{
	}
}
