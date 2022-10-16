using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InterceptorValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralRecord()
	{
	}
}
