using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TaskOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralPage()
	{
	}
}
