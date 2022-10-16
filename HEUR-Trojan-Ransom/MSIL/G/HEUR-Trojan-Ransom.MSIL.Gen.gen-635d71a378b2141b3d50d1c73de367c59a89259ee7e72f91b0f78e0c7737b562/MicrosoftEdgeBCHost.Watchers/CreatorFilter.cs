using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CreatorFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorFilter()
	{
		WriterPropertyProducer.ResolveStub();
		MoveComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveComposer()
	{
	}
}
