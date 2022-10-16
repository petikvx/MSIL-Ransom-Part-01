using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ItemAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceEvent()
	{
	}
}
