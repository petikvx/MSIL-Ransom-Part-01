using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StructHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructHelper()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralThread()
	{
	}
}
