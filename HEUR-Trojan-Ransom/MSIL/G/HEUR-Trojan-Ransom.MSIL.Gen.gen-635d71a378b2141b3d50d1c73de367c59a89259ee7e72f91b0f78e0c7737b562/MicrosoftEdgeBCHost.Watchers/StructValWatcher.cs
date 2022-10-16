using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StructValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceConfiguration()
	{
	}
}
