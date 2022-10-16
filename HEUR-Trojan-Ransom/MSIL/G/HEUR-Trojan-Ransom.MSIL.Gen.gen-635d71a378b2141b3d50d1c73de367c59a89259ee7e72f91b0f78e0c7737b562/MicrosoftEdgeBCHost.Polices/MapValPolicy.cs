using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RestartThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartThread()
	{
	}
}
