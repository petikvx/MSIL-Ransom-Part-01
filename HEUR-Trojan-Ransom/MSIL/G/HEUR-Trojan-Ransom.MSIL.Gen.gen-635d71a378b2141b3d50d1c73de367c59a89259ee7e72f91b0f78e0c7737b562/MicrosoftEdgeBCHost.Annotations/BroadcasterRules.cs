using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BroadcasterRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterRules()
	{
		WriterPropertyProducer.ResolveStub();
		FindProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindProperty()
	{
	}
}
