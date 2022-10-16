using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IssuerObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerObject()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralProduct()
	{
	}
}
