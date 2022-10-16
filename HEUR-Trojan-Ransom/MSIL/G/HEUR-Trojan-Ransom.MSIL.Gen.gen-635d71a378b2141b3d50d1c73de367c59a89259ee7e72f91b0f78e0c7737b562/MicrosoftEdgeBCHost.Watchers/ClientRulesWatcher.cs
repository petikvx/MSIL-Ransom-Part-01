using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ClientRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PostException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostException()
	{
	}
}
