using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FieldValException : Attribute, _003CModule_003E, FieldValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldValException()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
