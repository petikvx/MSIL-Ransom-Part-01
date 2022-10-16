using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AccountReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralIssuer()
	{
	}
}
