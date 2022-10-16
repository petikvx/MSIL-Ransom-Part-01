using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SchemaValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceProperty()
	{
	}
}
