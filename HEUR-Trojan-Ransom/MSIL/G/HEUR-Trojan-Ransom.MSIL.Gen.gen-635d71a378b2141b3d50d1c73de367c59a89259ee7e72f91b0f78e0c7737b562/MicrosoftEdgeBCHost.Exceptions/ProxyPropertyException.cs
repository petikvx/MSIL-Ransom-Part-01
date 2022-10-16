using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProxyPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralException()
	{
	}
}
