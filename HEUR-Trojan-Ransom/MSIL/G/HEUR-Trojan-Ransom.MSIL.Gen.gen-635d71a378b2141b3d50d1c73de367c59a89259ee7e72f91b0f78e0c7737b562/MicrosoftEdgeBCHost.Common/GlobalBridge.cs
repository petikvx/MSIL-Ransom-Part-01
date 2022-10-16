using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GlobalBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalBridge()
	{
		WriterPropertyProducer.ResolveStub();
		CalcExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcExporter()
	{
	}
}
