using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RefValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceAttribute()
	{
	}
}
