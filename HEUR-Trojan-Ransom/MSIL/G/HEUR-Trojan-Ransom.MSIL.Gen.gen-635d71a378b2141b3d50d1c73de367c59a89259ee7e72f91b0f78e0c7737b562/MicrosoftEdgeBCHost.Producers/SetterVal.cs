using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SetterVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterVal()
	{
		WriterPropertyProducer.ResolveStub();
		CancelProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelProducer()
	{
	}
}
