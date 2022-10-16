using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class GetterBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CloneVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneVal()
	{
	}
}
