using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PrototypeSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralAlgo()
	{
	}
}
