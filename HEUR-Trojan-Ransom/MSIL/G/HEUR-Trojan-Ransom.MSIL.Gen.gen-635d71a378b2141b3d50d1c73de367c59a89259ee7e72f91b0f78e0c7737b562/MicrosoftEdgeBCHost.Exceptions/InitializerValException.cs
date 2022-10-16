using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InitializerValException : Attribute, _003CModule_003E, InitializerValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerValException()
	{
		WriterPropertyProducer.ResolveStub();
		AddIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddIssuer()
	{
	}
}
