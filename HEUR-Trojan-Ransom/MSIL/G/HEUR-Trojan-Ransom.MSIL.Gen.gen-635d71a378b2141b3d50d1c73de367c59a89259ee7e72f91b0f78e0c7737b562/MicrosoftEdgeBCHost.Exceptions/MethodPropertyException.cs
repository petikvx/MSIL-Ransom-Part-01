using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MethodPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralAccount()
	{
	}
}
