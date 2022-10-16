using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SerializerFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ManageTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageTemplate()
	{
	}
}
