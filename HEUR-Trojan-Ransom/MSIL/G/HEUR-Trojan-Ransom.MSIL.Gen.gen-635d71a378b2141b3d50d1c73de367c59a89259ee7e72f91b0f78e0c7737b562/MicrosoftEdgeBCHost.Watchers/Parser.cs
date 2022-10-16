using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class Parser
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Parser()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeCode()
	{
	}
}
