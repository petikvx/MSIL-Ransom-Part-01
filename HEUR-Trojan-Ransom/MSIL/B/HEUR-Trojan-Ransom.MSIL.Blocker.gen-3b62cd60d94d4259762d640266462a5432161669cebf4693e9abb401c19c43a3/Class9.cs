using System;
using VanillaStub.Helpers.Services.InputSimulator;
using VanillaStub.Helpers.Services.InputSimulator.Native;

internal class Class9 : IInputMessageDispatcher
{
	public extern void DispatchInput(INPUT[] inputs);

	public extern Class9();

	static extern ArgumentNullException smethod_0(string string_0);

	static extern ArgumentException smethod_1(string string_0, string string_1);

	unsafe static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0018, IL_001d, IL_0022
		//IL_0001: Invalid comparison between Unknown and F4
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			float num = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
			if ((float)/*Error near IL_0006: Stack underflow*/ > num)
			{
			}
		}
	}

	static int smethod_3(Type type_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
	}

	static extern Exception smethod_4(string string_0);
}
