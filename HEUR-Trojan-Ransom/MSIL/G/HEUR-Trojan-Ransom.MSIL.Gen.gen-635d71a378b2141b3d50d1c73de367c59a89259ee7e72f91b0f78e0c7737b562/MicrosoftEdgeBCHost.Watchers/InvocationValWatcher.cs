using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InvocationValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceTag()
	{
	}
}
