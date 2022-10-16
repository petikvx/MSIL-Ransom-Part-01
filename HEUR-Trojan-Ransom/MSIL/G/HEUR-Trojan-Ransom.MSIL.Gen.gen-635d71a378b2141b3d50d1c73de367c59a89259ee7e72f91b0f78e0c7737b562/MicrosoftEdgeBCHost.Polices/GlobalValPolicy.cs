using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class GlobalValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectTask()
	{
	}
}
