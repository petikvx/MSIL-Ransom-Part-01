using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AuthenticationFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PatchConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchConfig()
	{
	}
}
