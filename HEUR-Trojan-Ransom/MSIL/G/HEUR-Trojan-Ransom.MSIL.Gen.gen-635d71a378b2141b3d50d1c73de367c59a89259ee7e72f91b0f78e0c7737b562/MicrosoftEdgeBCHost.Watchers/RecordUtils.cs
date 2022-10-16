using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RecordUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordUtils()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceAdapter()
	{
	}
}
