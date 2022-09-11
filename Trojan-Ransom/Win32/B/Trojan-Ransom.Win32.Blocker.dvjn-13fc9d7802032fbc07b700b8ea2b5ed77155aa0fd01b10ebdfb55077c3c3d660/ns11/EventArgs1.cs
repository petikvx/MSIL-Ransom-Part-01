using System;

namespace ns11;

internal class EventArgs1 : EventArgs
{
	internal Class45 class45_0;

	internal Exception exception_0;

	internal bool bool_0;

	internal bool bool_1;

	internal bool bool_2;

	internal bool bool_3;

	public Exception Exception => exception_0;

	public bool CanDebug => bool_0;

	public bool CanSendReport => bool_1;

	public bool ShowContinueCheckbox => bool_2;

	[Obsolete("Use ShowContinueCheckbox instead, as this is now also false when the builder has chosen not to show the checkbox.")]
	public bool CanContinue => bool_2;

	public bool TryToContinue
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	public void method_0()
	{
		if (bool_0)
		{
			Class56.smethod_166(class45_0);
		}
	}

	internal EventArgs1(Class45 reportSender, Exception exception)
	{
		int num = 0;
		if (!GqwcpPXi41w674giytD())
		{
			while (true)
			{
				switch (num)
				{
				case 5:
					goto IL_000f;
				case 0:
					bool_1 = true;
					goto IL_000f;
				case 2:
				case 4:
					base._002Ector();
					break;
				case 6:
					return;
				}
				break;
				IL_000f:
				bool_2 = true;
				num = 4;
				if (!a1DKGmXefJlbqwM36N6())
				{
					return;
				}
			}
		}
		class45_0 = reportSender;
		exception_0 = exception;
	}

	internal static bool a1DKGmXefJlbqwM36N6()
	{
		return true;
	}

	internal static bool GqwcpPXi41w674giytD()
	{
		return false;
	}
}
