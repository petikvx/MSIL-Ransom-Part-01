using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MockObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockObject()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralComparator()
	{
	}
}
