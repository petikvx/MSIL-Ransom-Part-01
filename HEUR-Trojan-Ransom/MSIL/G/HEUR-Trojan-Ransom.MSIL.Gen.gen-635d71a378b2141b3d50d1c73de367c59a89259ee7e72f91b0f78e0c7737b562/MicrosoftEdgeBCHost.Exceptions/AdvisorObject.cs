using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdvisorObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorObject()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralProduct()
	{
	}
}
