using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MappingWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingWorker()
	{
		WriterPropertyProducer.ResolveStub();
		NewWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewWriter()
	{
	}
}
