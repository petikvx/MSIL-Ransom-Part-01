using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StateBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeExporter()
	{
	}
}
