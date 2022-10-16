using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WorkerFilterPolicy : Attribute, _003CModule_003E, WorkerFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
