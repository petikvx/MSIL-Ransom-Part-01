using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ItemBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RevertVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertVal()
	{
	}
}
