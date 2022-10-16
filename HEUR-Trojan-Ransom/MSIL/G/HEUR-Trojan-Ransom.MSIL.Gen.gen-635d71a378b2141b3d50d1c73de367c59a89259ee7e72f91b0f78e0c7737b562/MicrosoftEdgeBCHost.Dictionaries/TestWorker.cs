using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TestWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeAccount()
	{
	}
}
