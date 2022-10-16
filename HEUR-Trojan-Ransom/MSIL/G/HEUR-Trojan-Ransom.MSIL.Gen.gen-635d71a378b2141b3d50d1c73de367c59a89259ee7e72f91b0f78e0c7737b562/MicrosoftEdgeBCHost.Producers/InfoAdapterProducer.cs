using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InfoAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralCollection()
	{
	}
}
