using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class VisitorSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralCustomer()
	{
	}
}
