using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ClassAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralReponse()
	{
	}
}
