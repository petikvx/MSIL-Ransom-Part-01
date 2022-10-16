using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TagFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralRef()
	{
	}
}
