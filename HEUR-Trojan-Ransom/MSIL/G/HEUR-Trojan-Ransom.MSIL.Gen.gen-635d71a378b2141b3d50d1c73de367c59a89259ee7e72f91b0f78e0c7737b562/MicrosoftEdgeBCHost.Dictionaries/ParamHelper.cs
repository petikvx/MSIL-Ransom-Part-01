using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralCreator()
	{
	}
}
