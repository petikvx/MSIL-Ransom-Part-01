using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DefinitionWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
