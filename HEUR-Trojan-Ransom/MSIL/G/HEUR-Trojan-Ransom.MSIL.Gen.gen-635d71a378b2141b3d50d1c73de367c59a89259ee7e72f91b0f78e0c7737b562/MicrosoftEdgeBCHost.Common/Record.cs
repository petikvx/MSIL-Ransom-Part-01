using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Record : Attribute, _003CModule_003E, Record
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Record()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
