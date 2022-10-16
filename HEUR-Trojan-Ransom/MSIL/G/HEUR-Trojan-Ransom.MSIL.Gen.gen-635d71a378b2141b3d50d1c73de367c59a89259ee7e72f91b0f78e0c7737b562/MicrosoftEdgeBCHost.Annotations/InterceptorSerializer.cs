using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InterceptorSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralBridge()
	{
	}
}
