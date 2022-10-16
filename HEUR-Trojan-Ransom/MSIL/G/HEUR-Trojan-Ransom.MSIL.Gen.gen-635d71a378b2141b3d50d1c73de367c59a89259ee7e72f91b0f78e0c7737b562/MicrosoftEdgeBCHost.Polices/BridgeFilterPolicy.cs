using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal sealed class BridgeFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] MapStub(object info)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
