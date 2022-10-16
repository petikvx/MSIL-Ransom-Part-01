using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ObjectValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceDescriptor()
	{
	}
}
