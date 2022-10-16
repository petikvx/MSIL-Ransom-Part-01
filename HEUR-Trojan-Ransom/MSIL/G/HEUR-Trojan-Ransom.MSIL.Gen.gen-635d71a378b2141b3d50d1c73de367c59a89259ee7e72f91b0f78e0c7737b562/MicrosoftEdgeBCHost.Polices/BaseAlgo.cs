using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BaseAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralConfiguration()
	{
	}
}
