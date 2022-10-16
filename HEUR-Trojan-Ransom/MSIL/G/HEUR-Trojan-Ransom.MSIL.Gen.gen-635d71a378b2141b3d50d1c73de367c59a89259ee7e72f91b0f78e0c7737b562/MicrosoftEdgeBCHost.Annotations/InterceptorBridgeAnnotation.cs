using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InterceptorBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetIdentifier()
	{
	}
}
