using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InstanceAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralIndexer()
	{
	}
}
