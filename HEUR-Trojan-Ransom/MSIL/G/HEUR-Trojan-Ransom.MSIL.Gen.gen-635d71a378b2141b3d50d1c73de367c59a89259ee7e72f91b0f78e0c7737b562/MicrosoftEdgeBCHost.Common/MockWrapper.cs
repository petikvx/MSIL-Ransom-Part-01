using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MockWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		StartSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartSetter()
	{
	}
}
