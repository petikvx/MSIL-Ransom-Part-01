using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamsValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceCollection()
	{
	}
}
