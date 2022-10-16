using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AttrValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceRole()
	{
	}
}
