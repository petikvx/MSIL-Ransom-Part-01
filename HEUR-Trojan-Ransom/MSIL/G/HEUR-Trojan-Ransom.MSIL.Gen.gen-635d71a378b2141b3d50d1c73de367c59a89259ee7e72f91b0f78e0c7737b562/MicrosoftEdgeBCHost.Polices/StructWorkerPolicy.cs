using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StructWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceExpression()
	{
	}
}
