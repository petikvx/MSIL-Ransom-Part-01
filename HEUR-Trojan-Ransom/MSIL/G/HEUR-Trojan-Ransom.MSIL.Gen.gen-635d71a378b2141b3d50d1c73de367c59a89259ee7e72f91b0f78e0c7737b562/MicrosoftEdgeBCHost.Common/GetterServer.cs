using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GetterServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterServer()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralContainer()
	{
	}
}
