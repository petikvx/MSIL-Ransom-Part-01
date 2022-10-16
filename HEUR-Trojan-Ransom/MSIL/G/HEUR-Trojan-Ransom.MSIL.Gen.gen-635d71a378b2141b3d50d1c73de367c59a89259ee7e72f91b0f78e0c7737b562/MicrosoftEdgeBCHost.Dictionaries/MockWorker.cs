using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MockWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockWorker()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyList()
	{
	}
}
