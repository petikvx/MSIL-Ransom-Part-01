using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MethodUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceQueue()
	{
	}
}
