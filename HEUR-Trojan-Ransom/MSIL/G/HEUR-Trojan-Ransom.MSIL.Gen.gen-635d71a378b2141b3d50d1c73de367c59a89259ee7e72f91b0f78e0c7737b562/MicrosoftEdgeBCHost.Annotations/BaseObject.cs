using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BaseObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseObject()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralTemplate()
	{
	}
}
