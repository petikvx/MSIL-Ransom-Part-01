using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PoolValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceAttribute()
	{
	}
}
