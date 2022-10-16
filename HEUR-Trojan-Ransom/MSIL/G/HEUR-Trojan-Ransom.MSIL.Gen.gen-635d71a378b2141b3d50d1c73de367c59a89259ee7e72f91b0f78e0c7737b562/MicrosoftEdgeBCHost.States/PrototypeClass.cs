using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PrototypeClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeClass()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceObserver()
	{
	}
}
