using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MockBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockBridge()
	{
		WriterPropertyProducer.ResolveStub();
		LoginRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginRecord()
	{
	}
}
