using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ReponseValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseValDic()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralTemplate()
	{
	}
}
