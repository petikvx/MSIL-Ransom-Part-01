using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TestsVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsVal()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInfo()
	{
	}
}
