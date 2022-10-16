using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ValueBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueBridge()
	{
		WriterPropertyProducer.ResolveStub();
		CalcTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcTests()
	{
	}
}
