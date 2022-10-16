using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CollectionBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionBridge()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutMapper()
	{
	}
}
