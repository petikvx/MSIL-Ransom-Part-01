using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CreatorOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralRecord()
	{
	}
}
