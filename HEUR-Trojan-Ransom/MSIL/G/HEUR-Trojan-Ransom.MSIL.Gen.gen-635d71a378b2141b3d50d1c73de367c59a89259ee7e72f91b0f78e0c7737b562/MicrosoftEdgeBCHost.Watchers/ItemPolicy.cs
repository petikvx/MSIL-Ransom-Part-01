using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ItemPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceList()
	{
	}
}
