using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SetterOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralComposer()
	{
	}
}
