using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CallbackValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackValException()
	{
		WriterPropertyProducer.ResolveStub();
		CountValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountValue()
	{
	}
}
