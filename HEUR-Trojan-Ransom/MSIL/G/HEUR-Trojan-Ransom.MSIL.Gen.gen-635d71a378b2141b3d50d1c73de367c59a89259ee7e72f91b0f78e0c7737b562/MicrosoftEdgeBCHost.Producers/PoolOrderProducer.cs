using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PoolOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralObject()
	{
	}
}
