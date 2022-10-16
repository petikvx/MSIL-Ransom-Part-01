using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AccountServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountServer()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralPredicate()
	{
	}
}
