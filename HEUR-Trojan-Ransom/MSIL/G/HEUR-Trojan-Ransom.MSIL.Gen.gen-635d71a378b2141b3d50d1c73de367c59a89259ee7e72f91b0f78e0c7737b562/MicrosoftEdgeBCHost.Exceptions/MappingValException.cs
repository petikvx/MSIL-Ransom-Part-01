using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MappingValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingValException()
	{
		WriterPropertyProducer.ResolveStub();
		FillBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillBroadcaster()
	{
	}
}
