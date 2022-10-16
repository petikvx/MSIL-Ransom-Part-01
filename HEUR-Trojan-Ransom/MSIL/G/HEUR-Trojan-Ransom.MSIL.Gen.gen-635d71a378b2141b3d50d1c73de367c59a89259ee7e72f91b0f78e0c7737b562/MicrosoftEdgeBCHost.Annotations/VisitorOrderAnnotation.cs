using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class VisitorOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralConsumer()
	{
	}
}
