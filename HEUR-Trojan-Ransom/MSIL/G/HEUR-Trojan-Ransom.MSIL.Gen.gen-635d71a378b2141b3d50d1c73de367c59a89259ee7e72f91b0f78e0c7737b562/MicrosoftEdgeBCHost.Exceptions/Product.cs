using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class Product : Attribute, _003CModule_003E, Product
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Product()
	{
		WriterPropertyProducer.ResolveStub();
		SetupObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupObject()
	{
	}
}
