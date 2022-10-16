using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WriterRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterRules()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateProxy()
	{
	}
}
