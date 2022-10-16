using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StructSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralBridge()
	{
	}
}
