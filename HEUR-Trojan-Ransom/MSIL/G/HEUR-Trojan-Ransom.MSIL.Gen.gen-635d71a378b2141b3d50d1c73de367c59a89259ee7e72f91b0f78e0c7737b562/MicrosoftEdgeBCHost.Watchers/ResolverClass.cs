using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ResolverClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverClass()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceItem()
	{
	}
}
