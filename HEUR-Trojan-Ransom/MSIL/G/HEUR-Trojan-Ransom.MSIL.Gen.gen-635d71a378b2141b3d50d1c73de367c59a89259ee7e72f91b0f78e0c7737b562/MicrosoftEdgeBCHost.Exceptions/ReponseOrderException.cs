using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ReponseOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotConsumer()
	{
	}
}
