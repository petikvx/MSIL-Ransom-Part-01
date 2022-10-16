using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MockUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockUtils()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceTests()
	{
	}
}
