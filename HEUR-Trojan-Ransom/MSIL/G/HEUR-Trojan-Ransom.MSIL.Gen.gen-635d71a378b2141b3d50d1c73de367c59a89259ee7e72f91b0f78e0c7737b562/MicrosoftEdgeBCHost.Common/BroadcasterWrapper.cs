using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BroadcasterWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		OrderAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderAttribute()
	{
	}
}
