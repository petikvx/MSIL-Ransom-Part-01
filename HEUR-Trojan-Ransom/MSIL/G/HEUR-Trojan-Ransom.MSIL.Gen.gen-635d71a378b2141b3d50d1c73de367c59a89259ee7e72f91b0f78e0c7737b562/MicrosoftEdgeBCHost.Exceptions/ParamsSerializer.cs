using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamsSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralCustomer()
	{
	}
}
