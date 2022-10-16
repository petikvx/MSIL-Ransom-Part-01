using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcDic : Attribute, _003CModule_003E, ProcDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcDic()
	{
		WriterPropertyProducer.ResolveStub();
		PatchFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchFactory()
	{
	}
}
