using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PrototypePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralOrder()
	{
	}
}
