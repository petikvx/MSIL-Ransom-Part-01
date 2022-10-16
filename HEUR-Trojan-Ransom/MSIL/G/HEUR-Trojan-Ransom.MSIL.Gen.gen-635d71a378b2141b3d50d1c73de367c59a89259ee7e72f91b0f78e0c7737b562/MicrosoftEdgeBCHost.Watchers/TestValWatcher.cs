using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceParser()
	{
	}
}
