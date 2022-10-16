using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MappingBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveException()
	{
	}
}
