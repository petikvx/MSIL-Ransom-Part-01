using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PropertyAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralVal()
	{
	}
}
