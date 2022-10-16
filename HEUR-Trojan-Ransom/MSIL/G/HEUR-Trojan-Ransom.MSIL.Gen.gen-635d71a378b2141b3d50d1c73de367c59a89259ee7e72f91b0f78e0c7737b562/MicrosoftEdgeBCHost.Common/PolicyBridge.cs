using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PolicyBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyBridge()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteExporter()
	{
	}
}
