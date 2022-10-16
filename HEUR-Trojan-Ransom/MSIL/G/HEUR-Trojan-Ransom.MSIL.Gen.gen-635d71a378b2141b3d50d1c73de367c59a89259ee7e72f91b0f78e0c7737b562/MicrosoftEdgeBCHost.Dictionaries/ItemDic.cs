using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ItemDic : Attribute, _003CModule_003E, ItemDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemDic()
	{
		WriterPropertyProducer.ResolveStub();
		OrderIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderIssuer()
	{
	}
}
