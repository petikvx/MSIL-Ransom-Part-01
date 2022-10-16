using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RulesUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralPool()
	{
	}
}
