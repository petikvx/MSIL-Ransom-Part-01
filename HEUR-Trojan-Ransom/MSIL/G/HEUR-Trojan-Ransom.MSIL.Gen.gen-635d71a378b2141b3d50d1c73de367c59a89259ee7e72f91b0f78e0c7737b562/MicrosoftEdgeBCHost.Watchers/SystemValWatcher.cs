using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SystemValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceMessage()
	{
	}
}
