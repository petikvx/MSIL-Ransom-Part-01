using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PrototypeFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceReader()
	{
	}
}
