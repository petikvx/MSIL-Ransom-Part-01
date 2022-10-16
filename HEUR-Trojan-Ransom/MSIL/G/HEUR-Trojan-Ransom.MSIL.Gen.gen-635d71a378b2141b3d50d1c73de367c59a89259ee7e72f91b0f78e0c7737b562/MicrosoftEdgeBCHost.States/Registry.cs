using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class Registry : System.Attribute, _003CModule_003E, Registry
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Registry()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInstance()
	{
	}
}
