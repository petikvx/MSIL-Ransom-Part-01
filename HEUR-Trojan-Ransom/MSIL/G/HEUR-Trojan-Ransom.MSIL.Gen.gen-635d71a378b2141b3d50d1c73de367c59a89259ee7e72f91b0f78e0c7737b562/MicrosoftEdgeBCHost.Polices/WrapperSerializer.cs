using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WrapperSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralGetter()
	{
	}
}
