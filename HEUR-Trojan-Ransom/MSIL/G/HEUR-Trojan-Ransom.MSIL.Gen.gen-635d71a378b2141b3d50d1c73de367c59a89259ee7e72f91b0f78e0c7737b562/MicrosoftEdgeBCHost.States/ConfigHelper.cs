using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigHelper()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralList()
	{
	}
}
