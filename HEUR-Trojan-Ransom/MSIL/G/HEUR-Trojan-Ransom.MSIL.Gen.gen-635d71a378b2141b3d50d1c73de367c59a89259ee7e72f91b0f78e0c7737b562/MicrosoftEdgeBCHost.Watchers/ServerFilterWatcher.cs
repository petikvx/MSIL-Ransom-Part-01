using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ServerFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		EnableAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableAuthentication()
	{
	}
}
