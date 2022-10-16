using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SpecificationValException : Attribute, _003CModule_003E, SpecificationValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationValException()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInstance()
	{
	}
}
