using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PageAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceCode()
	{
	}
}
