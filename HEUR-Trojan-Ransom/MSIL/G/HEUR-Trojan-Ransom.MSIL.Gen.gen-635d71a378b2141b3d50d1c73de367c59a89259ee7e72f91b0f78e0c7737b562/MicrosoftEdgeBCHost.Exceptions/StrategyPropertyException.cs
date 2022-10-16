using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StrategyPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralRepository()
	{
	}
}
