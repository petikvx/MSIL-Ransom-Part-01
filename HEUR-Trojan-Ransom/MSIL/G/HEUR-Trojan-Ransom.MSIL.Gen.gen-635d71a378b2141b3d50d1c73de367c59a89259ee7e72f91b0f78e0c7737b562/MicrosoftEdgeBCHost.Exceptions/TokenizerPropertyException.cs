using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TokenizerPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralSchema()
	{
	}
}
