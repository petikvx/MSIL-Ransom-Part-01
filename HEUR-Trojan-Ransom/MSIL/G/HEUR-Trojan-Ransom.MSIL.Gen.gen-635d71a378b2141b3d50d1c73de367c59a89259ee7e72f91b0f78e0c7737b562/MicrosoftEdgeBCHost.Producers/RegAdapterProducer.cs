using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RegAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralConfiguration()
	{
	}
}
