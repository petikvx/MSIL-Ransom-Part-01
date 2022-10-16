using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FacadeValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceImporter()
	{
	}
}
