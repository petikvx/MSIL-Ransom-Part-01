using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ReponseUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralStruct()
	{
	}
}
