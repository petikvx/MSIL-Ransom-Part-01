using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExporterDic : Attribute, _003CModule_003E, ExporterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
