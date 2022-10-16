using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BridgeValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceExpression()
	{
	}
}
