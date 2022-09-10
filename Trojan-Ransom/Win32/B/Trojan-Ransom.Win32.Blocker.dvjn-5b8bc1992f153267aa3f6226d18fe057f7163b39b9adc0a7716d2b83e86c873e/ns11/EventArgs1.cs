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
			Class58.smethod_105(class45_0);
		}
	}

	internal EventArgs1(Class45 reportSender, Exception exception)
	{
		while (true)
		{
			bool_1 = true;
			while (true)
			{
				bool_2 = true;
				base._002Ector();
				while (true)
				{
					class45_0 = reportSender;
					while (true)
					{
						exception_0 = exception;
						if (!Iy9ccwZxfvCEwEPArWq())
						{
							break;
						}
						switch (6)
						{
						case 2:
						case 5:
							goto end_IL_0003;
						case 0:
							goto end_IL_003a;
						case 1:
							goto end_IL_0043;
						case 6:
							return;
						}
						continue;
						end_IL_0003:
						break;
					}
					continue;
					end_IL_003a:
					break;
				}
				continue;
				end_IL_0043:
				break;
			}
		}
	}

	internal static bool Iy9ccwZxfvCEwEPArWq()
	{
		return true;
	}

	internal static bool EvcXCwZ9y3ObMkMnunU()
	{
		return false;
	}
}
