using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SetterAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralCollection()
	{
	}
}
