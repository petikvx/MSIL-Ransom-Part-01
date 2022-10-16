using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttrValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrValDic()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralIterator()
	{
	}
}
