using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StubOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		LoginPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginPolicy()
	{
	}
}
