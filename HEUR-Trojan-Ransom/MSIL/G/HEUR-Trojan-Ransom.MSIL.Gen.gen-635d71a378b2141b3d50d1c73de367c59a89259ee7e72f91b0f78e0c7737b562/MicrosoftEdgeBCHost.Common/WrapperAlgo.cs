using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WrapperAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralQueue()
	{
	}
}
