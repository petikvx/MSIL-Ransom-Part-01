using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ListenerFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FillAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillAttr()
	{
	}
}
