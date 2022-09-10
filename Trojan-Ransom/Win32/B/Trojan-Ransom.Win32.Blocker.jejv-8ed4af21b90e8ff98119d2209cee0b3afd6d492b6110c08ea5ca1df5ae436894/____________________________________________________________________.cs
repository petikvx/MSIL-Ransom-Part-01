using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class ____________________________________________________________________
{
	public string _;

	public string __;

	public int ___;

	public int ____;

	public void _()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MessageBoxIcon val = default(MessageBoxIcon);
			MessageBoxButtons val2 = default(MessageBoxButtons);
			DialogResult val3;
			switch (___)
			{
			default:
				if ((nint)Type.EmptyTypes.LongLength + -29162 == -2349)
				{
					goto case 3;
				}
				goto IL_0069;
			case 1:
				val = (MessageBoxIcon)64;
				goto IL_0069;
			case 2:
				val = (MessageBoxIcon)32;
				goto IL_0069;
			case 4:
				val = (MessageBoxIcon)48;
				goto IL_0069;
			case 3:
				{
					val = (MessageBoxIcon)48;
					goto IL_0069;
				}
				IL_0069:
				switch (____)
				{
				default:
					switch ((nint)Type.EmptyTypes.LongLength + 0)
					{
					case 0:
						goto IL_0096;
					}
					break;
				case 1:
					val2 = (MessageBoxButtons)0;
					goto IL_0096;
				case 2:
					val2 = (MessageBoxButtons)4;
					goto IL_0096;
				case 3:
					val2 = (MessageBoxButtons)1;
					goto IL_0096;
				case 4:
					{
						val2 = (MessageBoxButtons)2;
						goto IL_0096;
					}
					IL_0096:
					val3 = MessageBox.Show(this._, __, val2, val);
					______________________________________________________________.______________(_003CModule_003E._____<string>(1464211711u), _003CModule_003E.___<string>(2505485571u) + ((Enum)val3).ToString());
					return;
				}
				goto case 3;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.____<string>(1187660804u), _003CModule_003E.______<string>(342612184u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
