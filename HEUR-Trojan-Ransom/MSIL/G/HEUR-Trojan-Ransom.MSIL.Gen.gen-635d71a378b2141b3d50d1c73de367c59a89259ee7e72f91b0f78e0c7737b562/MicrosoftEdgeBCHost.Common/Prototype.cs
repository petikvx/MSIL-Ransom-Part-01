using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Prototype : Attribute, _003CModule_003E, Prototype
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Prototype()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInstance()
	{
	}
}
