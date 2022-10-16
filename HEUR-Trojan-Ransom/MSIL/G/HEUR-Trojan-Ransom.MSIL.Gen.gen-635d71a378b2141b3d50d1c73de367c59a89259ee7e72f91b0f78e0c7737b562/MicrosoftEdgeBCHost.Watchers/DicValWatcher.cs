using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DicValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceImporter()
	{
	}
}
