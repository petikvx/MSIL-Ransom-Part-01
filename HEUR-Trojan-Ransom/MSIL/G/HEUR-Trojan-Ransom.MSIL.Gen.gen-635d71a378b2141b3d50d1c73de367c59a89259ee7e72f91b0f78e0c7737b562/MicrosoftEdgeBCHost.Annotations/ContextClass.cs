using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ContextClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextClass()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceThread()
	{
	}
}
