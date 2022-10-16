using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MappingWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PostIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostIdentifier()
	{
	}
}
