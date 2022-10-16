using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StateUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralReg()
	{
	}
}
