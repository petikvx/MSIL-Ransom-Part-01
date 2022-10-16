using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralInitializer()
	{
	}
}
