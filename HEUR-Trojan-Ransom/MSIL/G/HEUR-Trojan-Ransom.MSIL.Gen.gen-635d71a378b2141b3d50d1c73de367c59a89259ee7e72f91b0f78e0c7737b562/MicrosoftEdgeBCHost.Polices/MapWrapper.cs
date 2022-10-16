using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		StopAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopAttribute()
	{
	}
}
