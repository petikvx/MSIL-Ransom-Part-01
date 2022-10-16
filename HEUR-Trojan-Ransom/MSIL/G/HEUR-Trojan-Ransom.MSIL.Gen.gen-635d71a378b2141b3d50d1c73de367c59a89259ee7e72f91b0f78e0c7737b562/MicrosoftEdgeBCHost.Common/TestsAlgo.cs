using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TestsAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralParam()
	{
	}
}
