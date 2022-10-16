using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InstanceValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralTest()
	{
	}
}
