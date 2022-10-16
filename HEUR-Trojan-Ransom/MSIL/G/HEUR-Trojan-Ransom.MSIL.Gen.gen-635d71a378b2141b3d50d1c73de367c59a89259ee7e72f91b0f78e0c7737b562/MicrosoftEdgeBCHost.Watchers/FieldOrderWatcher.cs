using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FieldOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralWatcher()
	{
	}
}
