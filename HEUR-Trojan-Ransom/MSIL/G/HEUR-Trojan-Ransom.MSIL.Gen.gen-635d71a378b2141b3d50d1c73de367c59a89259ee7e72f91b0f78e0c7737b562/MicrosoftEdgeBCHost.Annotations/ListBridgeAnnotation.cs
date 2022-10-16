using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ListBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CompareDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareDescriptor()
	{
	}
}
