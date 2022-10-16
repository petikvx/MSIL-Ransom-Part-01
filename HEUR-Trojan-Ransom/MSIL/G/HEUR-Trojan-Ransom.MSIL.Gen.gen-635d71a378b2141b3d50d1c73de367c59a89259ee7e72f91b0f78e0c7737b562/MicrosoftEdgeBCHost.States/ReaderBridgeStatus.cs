using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReaderBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CreatePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreatePrinter()
	{
	}
}
