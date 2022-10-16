using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AnnotationBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeWriter()
	{
	}
}
