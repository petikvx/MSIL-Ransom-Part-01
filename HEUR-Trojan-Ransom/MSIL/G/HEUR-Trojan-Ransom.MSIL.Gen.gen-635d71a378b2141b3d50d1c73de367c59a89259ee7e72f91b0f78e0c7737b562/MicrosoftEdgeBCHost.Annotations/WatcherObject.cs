using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WatcherObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherObject()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralPage()
	{
	}
}
