using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CodeAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralMessage()
	{
	}
}
