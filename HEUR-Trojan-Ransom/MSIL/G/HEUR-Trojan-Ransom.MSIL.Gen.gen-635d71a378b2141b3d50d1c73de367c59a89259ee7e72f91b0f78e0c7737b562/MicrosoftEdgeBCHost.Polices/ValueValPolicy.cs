using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValueValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CallPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallPool()
	{
	}
}
