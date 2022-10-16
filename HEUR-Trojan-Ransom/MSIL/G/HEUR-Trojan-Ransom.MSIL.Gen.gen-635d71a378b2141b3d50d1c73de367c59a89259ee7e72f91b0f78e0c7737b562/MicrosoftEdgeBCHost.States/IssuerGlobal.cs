using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IssuerGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceExpression()
	{
	}
}
