using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AccountValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountValException()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyIdentifier()
	{
	}
}
