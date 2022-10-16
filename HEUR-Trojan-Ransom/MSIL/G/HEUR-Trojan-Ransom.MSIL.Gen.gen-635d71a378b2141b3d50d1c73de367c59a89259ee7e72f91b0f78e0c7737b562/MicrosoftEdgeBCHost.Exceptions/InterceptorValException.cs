using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InterceptorValException : Attribute, _003CModule_003E, InterceptorValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorValException()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveObject()
	{
	}
}
