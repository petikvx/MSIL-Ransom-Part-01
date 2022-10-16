using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class UtilsAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralVal()
	{
	}
}
