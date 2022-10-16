using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StubValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceObject()
	{
	}
}
