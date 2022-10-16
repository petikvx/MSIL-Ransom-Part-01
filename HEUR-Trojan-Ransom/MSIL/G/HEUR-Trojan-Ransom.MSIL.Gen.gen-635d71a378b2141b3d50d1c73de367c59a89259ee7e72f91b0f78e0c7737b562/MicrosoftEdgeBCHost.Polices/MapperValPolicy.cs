using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapperValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceAttribute()
	{
	}
}
