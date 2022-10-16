using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DicOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralResolver()
	{
	}
}
