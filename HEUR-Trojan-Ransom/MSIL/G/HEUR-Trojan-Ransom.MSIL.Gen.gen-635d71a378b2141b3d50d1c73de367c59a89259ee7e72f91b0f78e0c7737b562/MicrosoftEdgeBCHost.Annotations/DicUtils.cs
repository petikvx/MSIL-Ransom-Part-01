using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DicUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicUtils()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceParser()
	{
	}
}
