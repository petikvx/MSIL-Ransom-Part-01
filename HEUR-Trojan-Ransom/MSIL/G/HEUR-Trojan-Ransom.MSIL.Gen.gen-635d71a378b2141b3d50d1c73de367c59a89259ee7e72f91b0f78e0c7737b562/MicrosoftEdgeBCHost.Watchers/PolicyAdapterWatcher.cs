using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PolicyAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralReponse()
	{
	}
}
