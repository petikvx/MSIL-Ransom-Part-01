using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class GlobalGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceListener()
	{
	}
}
