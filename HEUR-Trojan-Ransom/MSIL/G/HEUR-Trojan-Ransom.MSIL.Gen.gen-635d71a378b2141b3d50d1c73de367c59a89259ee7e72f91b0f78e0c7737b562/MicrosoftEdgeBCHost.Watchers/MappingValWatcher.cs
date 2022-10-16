using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MappingValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceTemplate()
	{
	}
}
