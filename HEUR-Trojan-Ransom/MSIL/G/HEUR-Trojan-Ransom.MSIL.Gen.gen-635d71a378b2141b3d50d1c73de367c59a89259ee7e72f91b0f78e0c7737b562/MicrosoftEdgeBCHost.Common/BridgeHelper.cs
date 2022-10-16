using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BridgeHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeHelper()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralField()
	{
	}
}
