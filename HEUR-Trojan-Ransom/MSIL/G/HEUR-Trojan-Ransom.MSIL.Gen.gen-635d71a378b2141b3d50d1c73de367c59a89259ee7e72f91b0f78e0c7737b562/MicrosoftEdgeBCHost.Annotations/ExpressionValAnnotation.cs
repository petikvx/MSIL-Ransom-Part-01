using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExpressionValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfacePublisher()
	{
	}
}
