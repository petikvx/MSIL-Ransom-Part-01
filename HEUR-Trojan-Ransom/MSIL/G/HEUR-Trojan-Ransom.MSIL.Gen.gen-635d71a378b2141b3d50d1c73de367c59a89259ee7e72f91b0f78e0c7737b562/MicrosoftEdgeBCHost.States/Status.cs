using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class Status : System.Attribute, _003CModule_003E, Status
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Status()
	{
		WriterPropertyProducer.ResolveStub();
		PatchError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchError()
	{
	}
}
