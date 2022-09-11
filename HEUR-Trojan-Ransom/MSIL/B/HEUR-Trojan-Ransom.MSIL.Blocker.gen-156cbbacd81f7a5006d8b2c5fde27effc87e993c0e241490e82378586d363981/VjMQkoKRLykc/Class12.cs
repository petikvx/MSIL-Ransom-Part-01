using System.Threading;

namespace VjMQkoKRLykc;

internal sealed class Class12
{
	internal static ContextCallback contextCallback_0;

	private readonly IOCompletionCallback iocompletionCallback_0;

	private ExecutionContext executionContext_0;

	private readonly uint jJ482qRXeyXMMguPZe6ipN8ZUmedbptaLMcQN90rpofi;

	private unsafe NativeOverlapped* pNativeOverlapped_0;

	internal uint uint_0;

	static Class12()
	{
		contextCallback_0 = smethod_0;
	}

	public unsafe Class12(IOCompletionCallback iocompletionCallback_1, ExecutionContext executionContext_1, uint uint_1, uint uint_2)
	{
		iocompletionCallback_0 = iocompletionCallback_1;
		executionContext_0 = executionContext_1;
		jJ482qRXeyXMMguPZe6ipN8ZUmedbptaLMcQN90rpofi = uint_1;
		uint num = (uint_0 = uint_2);
	}

	internal unsafe static void smethod_0(object object_0)
	{
		Class12 @class = (Class12)object_0;
		@class.iocompletionCallback_0(@class.jJ482qRXeyXMMguPZe6ipN8ZUmedbptaLMcQN90rpofi, @class.uint_0, @class.pNativeOverlapped_0);
	}
}
