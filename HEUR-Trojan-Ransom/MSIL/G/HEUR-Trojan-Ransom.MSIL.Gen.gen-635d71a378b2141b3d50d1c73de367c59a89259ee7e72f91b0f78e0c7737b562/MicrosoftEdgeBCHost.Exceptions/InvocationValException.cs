using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InvocationValException : Attribute, _003CModule_003E, InvocationValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationValException()
	{
		WriterPropertyProducer.ResolveStub();
		FindFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindFactory()
	{
	}
}
