using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProcBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcBridge()
	{
		WriterPropertyProducer.ResolveStub();
		SetupMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupMessage()
	{
	}
}
