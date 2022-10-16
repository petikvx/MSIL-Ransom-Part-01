using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ThreadPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralConfig()
	{
	}
}
