using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RoleSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralBroadcaster()
	{
	}
}
