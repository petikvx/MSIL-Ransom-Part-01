using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IteratorWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorWorker()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateCreator()
	{
	}
}
