using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RefValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceMock()
	{
	}
}
