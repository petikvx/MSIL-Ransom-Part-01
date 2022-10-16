using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BaseBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RateVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateVal()
	{
	}
}
