using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MapperWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CreateTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateTokenizer()
	{
	}
}
