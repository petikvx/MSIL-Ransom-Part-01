using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProccesorOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralToken()
	{
	}
}
