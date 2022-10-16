using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PolicyFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyFacade()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralPolicy()
	{
	}
}
