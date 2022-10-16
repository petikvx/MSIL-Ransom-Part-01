using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SetterBridgeAnnotation : Attribute, _003CModule_003E, SetterBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrintFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintFactory()
	{
	}
}
