using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SetDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetDatabase()
	{
	}
}
