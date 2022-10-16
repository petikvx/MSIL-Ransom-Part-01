using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AnnotationBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateParam()
	{
	}
}
