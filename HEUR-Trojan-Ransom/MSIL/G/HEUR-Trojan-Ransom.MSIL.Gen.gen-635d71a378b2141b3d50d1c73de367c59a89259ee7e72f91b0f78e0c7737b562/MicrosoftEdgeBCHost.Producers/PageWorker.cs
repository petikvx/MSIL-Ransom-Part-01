using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PageWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageWorker()
	{
		WriterPropertyProducer.ResolveStub();
		StartWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartWriter()
	{
	}
}
