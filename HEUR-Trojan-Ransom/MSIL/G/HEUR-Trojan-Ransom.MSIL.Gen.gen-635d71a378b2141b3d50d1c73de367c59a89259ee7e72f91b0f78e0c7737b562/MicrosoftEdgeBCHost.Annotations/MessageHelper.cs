using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MessageHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralCreator()
	{
	}
}
