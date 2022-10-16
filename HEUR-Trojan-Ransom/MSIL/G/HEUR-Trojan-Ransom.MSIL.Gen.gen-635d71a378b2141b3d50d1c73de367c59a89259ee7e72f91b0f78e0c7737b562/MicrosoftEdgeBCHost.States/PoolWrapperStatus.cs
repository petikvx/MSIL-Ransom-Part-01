using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PoolWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		TestAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestAttribute()
	{
	}
}
