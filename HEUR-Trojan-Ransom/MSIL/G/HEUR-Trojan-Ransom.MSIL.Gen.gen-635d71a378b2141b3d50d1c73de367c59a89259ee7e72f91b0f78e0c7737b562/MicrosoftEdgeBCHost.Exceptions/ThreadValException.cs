using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ThreadValException : Attribute, _003CModule_003E, ThreadValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadValException()
	{
		WriterPropertyProducer.ResolveStub();
		FlushObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushObject()
	{
	}
}
