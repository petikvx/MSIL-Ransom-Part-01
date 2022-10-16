using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DispatcherObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherObject()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralPage()
	{
	}
}
