using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CustomerGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceStrategy()
	{
	}
}
