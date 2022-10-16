using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GetterAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralParam()
	{
	}
}
