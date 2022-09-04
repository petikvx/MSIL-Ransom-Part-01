using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace werdbn;

public class TpywM
{
	public class XSzp
	{
		private Type BlWK;

		public XSzp(Type t)
		{
			BlWK = t;
		}

		public void V52o7D()
		{
			Activator.CreateInstance(BlWK);
		}

		internal static bool CniMT4PDJgjKgqe99X6()
		{
			return true;
		}

		internal static bool LW6w2CPcm5vST1YUhwe()
		{
			return false;
		}
	}

	public object LTSSN093iqxyy09a3T3vccIqDy9d1()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		vm19ifaeRpnWujM5Q5();
		if (!zoQAspHKhML5ItgbaV())
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
				}
				catch (Exception object_)
				{
					B0C9R0S8gNwfm3gCgP(object_);
					ProjectData.ClearProjectError();
				}
				new decimal(896414L);
				while (true)
				{
					new decimal(492166L);
					new decimal(2076L);
				}
			}
			f1AInUPWX86QJPnrLbE("@Bjvs\u0090,‚.„yIŠ'[>:o?0Q}3cx7$e)j‰Y‡>2\\gu^}4l7^<.FrH_<<^7\u0081V.&‘[‹", (MsgBoxStyle)0, null);
		}
		return 0;
	}

	public static byte[] IQt6Kicea(ref byte[] F4SV52o7, string ti)
	{
		zoQAspHKhML5ItgbaV();
		byte[] bytes = default(byte[]);
		if (vm19ifaeRpnWujM5Q5())
		{
			bytes = Encoding.Default.GetBytes(ti);
		}
		checked
		{
			int num = (F4SV52o7.Length - 1) * 2;
			for (int i = 0; i <= num; i++)
			{
				F4SV52o7[unchecked(i % F4SV52o7.Length)] = (byte)unchecked(checked(unchecked(F4SV52o7[i % F4SV52o7.Length] ^ bytes[i % bytes.Length]) - unchecked((int)F4SV52o7[checked(i + 1) % F4SV52o7.Length]) + 256) % 256);
			}
			Array.Resize(ref F4SV52o7, F4SV52o7.Length - 1);
			return F4SV52o7;
		}
	}

	private void ZLx6dz6iwGk943tW8568x0GW()
	{
		int num = 7;
		if (!zoQAspHKhML5ItgbaV())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
			case 6:
			case 7:
				do
				{
					vm19ifaeRpnWujM5Q5();
				}
				while (!zoQAspHKhML5ItgbaV());
				goto default;
			default:
				do
				{
					num = 5;
				}
				while (zoQAspHKhML5ItgbaV());
				break;
			case 5:
			case 8:
				while (true)
				{
				}
			case 9:
				try
				{
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return;
				}
			}
		}
	}

	private void bX178Z9gfrhZ2r069()
	{
		zoQAspHKhML5ItgbaV();
		if (vm19ifaeRpnWujM5Q5())
		{
		}
		try
		{
		}
		catch (Exception object_)
		{
			B0C9R0S8gNwfm3gCgP(object_);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	internal static void B0C9R0S8gNwfm3gCgP(object object_0)
	{
		ProjectData.SetProjectError((Exception)object_0);
	}

	internal static void AZGFUPzQ7RZOEpCVYC()
	{
		ProjectData.ClearProjectError();
	}

	internal static MsgBoxResult f1AInUPWX86QJPnrLbE(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}

	internal static bool vm19ifaeRpnWujM5Q5()
	{
		return true;
	}

	internal static bool zoQAspHKhML5ItgbaV()
	{
		return false;
	}

	internal static DialogResult sVU1wbPP5I4vRr5x5ps(object object_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show((string)object_0);
	}
}
