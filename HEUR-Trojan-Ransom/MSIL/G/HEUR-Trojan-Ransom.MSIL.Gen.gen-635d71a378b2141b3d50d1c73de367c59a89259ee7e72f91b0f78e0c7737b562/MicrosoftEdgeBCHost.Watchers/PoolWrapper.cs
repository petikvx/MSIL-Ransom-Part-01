using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PoolWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		WriteRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteRef()
	{
	}
}
