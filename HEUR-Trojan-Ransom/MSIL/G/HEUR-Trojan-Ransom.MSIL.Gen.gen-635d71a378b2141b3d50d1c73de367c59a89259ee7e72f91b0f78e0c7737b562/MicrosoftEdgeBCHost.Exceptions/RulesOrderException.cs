using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RulesOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ManageRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageRegistry()
	{
	}
}
