using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SetterOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterOrder()
	{
		WriterPropertyProducer.ResolveStub();
		RestartStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartStruct()
	{
	}
}
