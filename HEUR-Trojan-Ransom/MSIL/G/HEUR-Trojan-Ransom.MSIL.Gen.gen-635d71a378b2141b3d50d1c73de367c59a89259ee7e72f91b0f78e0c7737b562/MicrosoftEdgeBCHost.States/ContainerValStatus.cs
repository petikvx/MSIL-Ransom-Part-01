using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ContainerValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralOrder()
	{
	}
}
