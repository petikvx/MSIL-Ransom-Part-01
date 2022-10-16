using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BridgeWrapperDic : Attribute, _003CModule_003E, BridgeWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
