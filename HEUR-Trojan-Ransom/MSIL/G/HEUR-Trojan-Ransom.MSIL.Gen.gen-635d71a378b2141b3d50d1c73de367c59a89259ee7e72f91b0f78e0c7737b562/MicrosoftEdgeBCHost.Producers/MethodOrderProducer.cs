using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MethodOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralMethod()
	{
	}
}
