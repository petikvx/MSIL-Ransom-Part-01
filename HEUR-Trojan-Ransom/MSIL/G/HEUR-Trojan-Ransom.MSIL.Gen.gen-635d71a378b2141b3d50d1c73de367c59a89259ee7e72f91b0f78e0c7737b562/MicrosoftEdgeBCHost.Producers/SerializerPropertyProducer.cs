using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SerializerPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralInvocation()
	{
	}
}
