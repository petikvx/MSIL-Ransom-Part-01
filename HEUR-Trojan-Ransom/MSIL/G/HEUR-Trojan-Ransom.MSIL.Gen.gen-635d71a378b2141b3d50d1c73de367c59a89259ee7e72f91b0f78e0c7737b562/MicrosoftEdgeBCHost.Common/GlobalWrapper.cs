using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GlobalWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		StopAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopAlgo()
	{
	}
}
