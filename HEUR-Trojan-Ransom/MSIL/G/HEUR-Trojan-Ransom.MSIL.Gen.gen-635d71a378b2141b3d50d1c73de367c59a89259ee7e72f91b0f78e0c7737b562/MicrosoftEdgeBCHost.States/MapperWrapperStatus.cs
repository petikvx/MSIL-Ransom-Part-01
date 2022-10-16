using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MapperWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		EnableAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableAttribute()
	{
	}
}
