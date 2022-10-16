using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InitializerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralVal()
	{
	}
}
