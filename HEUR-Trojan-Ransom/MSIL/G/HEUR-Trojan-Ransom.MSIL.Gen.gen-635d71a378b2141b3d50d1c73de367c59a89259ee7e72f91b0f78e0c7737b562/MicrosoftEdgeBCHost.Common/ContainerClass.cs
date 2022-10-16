using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContainerClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerClass()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceRegistry()
	{
	}
}
