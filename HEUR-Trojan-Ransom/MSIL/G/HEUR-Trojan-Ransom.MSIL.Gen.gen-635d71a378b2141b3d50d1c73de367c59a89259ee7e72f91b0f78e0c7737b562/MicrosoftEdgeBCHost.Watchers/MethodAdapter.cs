using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MethodAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceMapping()
	{
	}
}
