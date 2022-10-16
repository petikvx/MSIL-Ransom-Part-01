using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BridgePropertyPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgePropertyPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralStruct()
	{
	}
}
