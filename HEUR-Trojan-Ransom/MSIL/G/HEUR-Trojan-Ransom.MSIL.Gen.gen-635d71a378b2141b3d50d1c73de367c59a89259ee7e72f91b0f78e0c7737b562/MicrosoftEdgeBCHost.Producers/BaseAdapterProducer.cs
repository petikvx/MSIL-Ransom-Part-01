using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BaseAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralException()
	{
	}
}
