using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TemplateOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralServer()
	{
	}
}
