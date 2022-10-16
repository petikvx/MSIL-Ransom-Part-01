using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExporterBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InsertSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertSerializer()
	{
	}
}
