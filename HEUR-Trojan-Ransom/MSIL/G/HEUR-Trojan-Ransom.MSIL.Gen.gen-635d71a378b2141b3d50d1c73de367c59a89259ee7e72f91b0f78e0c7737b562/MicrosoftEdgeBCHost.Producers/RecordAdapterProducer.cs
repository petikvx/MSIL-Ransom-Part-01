using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RecordAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralService()
	{
	}
}
