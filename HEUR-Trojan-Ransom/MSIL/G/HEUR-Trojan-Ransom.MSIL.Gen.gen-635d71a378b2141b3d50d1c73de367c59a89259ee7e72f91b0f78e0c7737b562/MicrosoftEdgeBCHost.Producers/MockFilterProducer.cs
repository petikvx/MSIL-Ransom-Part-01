using System;
using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal sealed class MockFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UIntPtr StopStub(object res)
	{
		return (UIntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatIssuer()
	{
	}
}
