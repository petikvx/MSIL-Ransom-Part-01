using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ThreadContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadContext()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceContainer()
	{
	}
}
