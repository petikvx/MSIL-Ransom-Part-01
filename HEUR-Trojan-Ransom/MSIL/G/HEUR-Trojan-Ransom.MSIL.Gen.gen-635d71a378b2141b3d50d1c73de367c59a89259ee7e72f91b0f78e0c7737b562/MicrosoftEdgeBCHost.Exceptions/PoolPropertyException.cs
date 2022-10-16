using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PoolPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralCreator()
	{
	}
}
