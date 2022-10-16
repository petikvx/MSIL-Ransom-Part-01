using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReaderValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceRole()
	{
	}
}
