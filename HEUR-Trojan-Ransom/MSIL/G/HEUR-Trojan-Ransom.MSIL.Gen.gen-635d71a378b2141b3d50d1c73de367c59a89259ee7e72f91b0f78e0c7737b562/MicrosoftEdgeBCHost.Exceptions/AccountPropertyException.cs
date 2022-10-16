using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AccountPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralClient()
	{
	}
}
