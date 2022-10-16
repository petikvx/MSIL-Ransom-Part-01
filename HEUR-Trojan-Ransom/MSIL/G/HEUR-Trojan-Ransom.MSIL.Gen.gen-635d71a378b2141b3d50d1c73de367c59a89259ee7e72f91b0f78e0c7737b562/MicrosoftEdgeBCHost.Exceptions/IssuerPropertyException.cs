using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IssuerPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralSpecification()
	{
	}
}
