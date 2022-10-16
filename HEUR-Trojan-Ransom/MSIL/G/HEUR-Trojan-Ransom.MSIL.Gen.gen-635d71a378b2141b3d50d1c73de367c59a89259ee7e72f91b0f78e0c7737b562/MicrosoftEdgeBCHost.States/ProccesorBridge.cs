using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProccesorBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RateException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateException()
	{
	}
}
