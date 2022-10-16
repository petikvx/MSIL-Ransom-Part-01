using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MessageWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralAttr()
	{
	}
}
