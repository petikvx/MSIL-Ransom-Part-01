using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AdvisorBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorBridge()
	{
		WriterPropertyProducer.ResolveStub();
		WriteRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteRecord()
	{
	}
}
