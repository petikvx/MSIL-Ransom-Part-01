using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FieldFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeDatabase()
	{
	}
}
