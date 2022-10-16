using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DispatcherContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherContext()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceUtils()
	{
	}
}
