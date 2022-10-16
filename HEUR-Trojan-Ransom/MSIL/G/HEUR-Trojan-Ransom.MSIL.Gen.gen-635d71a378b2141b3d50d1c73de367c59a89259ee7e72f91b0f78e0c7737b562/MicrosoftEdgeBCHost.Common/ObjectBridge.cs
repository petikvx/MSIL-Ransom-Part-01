using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObjectBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RateAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateAdapter()
	{
	}
}
