using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DefinitionServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionServer()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralWatcher()
	{
	}
}
