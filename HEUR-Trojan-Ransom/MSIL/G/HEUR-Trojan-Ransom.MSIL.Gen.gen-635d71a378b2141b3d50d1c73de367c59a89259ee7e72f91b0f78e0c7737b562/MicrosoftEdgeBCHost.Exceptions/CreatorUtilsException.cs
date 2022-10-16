using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CreatorUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralBase()
	{
	}
}
