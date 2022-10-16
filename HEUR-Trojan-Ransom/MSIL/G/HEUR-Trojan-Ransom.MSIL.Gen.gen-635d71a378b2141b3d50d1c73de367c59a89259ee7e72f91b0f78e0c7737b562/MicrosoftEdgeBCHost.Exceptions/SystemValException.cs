using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SystemValException : Attribute, _003CModule_003E, SystemValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemValException()
	{
		WriterPropertyProducer.ResolveStub();
		CreateObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateObject()
	{
	}
}
