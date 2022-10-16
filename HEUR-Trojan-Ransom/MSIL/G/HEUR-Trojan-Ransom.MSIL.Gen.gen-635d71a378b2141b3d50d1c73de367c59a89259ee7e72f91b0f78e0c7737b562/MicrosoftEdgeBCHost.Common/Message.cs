using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Message : Attribute, _003CModule_003E, Message
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Message()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
