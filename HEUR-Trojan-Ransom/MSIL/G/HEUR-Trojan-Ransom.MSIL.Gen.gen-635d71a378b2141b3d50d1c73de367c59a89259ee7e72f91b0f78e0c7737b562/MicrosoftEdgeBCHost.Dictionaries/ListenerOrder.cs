using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListenerOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludePolicy()
	{
	}
}
