using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TestValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralTest()
	{
	}
}
