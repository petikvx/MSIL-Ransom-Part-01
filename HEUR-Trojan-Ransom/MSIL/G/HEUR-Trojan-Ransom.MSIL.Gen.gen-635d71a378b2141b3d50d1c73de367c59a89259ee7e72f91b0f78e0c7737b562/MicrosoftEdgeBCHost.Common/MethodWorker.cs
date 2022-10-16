using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MethodWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ResetWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetWriter()
	{
	}
}
