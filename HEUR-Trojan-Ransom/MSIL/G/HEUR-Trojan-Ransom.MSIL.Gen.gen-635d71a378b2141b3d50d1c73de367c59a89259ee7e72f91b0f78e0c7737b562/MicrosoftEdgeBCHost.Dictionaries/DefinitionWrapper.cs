using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DefinitionWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		PatchBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchBroadcaster()
	{
	}
}
