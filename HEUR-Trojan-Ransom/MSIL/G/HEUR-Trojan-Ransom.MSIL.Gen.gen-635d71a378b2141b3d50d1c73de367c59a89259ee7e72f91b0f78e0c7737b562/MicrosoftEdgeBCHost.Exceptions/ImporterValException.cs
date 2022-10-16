using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ImporterValException : Attribute, _003CModule_003E, ImporterValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterValException()
	{
		WriterPropertyProducer.ResolveStub();
		DisableError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableError()
	{
	}
}
