using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StructAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralConfiguration()
	{
	}
}
