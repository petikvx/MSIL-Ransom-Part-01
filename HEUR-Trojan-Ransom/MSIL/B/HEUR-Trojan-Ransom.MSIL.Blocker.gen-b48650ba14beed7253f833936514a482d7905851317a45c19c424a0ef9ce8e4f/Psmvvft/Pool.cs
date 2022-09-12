using System;

namespace Psmvvft;

internal class Pool
{
	private static Pool CompareStub;

	[STAThread]
	private static int Main()
	{
		HelperUtilsWrapper.MovePool();
		HelperUtilsWrapper.ReflectPool();
		HelperUtilsWrapper.CallPool();
		return 0;
	}

	internal static bool CollectStub()
	{
		return CompareStub == null;
	}

	internal static Pool ForgotStub()
	{
		return CompareStub;
	}
}
