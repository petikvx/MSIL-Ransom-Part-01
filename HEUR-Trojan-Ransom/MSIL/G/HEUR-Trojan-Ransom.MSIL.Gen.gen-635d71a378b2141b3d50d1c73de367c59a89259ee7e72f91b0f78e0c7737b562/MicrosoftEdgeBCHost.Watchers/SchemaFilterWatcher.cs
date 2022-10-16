using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SchemaFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeCreator()
	{
	}
}
