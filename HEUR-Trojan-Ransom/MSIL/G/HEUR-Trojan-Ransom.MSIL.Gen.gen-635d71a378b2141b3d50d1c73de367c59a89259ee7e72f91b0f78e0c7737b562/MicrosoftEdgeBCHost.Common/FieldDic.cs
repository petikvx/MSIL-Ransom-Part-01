using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FieldDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldDic()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralReader()
	{
	}
}
