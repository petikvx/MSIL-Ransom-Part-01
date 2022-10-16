using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StubWrapperDic : Attribute, _003CModule_003E, StubWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
