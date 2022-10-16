using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RulePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralClient()
	{
	}
}
