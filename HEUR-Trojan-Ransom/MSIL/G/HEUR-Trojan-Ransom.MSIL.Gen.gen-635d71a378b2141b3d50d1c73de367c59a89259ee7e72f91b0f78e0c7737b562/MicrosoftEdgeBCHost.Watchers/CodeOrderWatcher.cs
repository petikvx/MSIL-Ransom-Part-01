using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CodeOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralPage()
	{
	}
}
