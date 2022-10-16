using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdapterOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterceptor()
	{
	}
}
