using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WrapperFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceComposer()
	{
	}
}
