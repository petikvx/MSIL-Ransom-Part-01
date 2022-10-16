using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PageClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageClass()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceItem()
	{
	}
}
