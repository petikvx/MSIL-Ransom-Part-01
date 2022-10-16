using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ServerVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerVal()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutPredicate()
	{
	}
}
