using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RecordAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceConnection()
	{
	}
}
