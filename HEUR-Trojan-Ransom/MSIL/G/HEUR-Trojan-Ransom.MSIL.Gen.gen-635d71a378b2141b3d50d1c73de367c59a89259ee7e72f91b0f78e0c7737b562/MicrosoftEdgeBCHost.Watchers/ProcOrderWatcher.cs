using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProcOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralHelper()
	{
	}
}
