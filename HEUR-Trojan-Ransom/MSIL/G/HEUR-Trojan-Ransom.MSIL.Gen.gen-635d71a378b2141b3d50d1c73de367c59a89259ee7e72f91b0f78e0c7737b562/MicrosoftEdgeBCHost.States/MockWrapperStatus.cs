using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MockWrapperStatus : System.Attribute, _003CModule_003E, MockWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
