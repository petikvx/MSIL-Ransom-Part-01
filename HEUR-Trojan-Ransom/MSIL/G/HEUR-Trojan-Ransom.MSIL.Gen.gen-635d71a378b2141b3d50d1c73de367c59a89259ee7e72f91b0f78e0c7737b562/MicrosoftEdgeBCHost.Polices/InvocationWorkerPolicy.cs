using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InvocationWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceExpression()
	{
	}
}
