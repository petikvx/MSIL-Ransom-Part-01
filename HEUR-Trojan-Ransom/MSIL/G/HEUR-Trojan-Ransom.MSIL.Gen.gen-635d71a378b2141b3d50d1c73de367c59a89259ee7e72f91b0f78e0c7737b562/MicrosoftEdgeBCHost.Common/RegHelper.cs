using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RegHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralSerializer()
	{
	}
}
