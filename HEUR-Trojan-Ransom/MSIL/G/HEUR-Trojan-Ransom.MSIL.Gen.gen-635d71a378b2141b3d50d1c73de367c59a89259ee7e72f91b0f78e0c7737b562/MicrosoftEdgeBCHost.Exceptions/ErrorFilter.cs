using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ErrorFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorFilter()
	{
		WriterPropertyProducer.ResolveStub();
		StopAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopAuthentication()
	{
	}
}
