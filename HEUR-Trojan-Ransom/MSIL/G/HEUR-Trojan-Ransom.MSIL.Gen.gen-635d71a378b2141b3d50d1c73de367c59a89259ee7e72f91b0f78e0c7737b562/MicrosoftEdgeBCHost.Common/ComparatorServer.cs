using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ComparatorServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorServer()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralClient()
	{
	}
}
