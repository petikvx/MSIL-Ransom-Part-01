using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FacadeWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeWorker()
	{
		WriterPropertyProducer.ResolveStub();
		WriteDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteDatabase()
	{
	}
}
