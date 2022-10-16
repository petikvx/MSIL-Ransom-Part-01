using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TemplateValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateValDic()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralPolicy()
	{
	}
}
