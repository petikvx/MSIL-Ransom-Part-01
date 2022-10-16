using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RequestPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralOrder()
	{
	}
}
