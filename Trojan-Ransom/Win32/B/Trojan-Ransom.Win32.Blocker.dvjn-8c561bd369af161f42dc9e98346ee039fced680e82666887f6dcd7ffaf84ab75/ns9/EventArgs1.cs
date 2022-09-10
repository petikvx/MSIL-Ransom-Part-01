using System;

namespace ns9;

internal class EventArgs1 : EventArgs
{
	internal Class29 class29_0;

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
			Class33.smethod_93(class29_0);
		}
	}

	internal EventArgs1(Class29 reportSender, Exception exception)
	{
		while (true)
		{
			bool_1 = true;
			while (true)
			{
				bool_2 = true;
				int num = 4;
				if (qKSA3JrrPdIbfZtgjYy())
				{
					return;
				}
				while (true)
				{
					switch (num)
					{
					default:
						num = 3;
						if (!qKSA3JrrPdIbfZtgjYy())
						{
							continue;
						}
						goto end_IL_0032;
					case 1:
					case 5:
						break;
					case 0:
						goto end_IL_0032;
					case 2:
					case 4:
						base._002Ector();
						goto case 3;
					case 3:
						class29_0 = reportSender;
						exception_0 = exception;
						return;
					case 6:
						return;
					}
					break;
				}
				continue;
				end_IL_0032:
				break;
			}
		}
	}

	internal static bool O1fSj7r70m64d3WZ5Db()
	{
		return true;
	}

	internal static bool qKSA3JrrPdIbfZtgjYy()
	{
		return false;
	}
}
