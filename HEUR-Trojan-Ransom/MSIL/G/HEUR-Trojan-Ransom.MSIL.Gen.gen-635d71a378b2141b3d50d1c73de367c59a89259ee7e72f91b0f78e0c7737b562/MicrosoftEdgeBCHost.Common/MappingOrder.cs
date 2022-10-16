using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MappingOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingOrder()
	{
		WriterPropertyProducer.ResolveStub();
		StopBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopBase()
	{
	}
}
