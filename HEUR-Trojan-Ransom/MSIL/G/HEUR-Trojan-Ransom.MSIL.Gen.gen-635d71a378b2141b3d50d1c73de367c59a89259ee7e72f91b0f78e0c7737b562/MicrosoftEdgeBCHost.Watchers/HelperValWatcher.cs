using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class HelperValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceImporter()
	{
	}
}
