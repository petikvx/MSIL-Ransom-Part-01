using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class VisitorAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralParser()
	{
	}
}
