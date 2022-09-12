using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Neutron;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using Siticone.UI.WinForms.Suite;
using cCMBEkOBGIwpDnI0MY;
using fJpF6sGRwSPY0tjIER;
using mLChtR0pUQjVeOabmX;
using zjWSh2Z73jBs4TcJ0x;

namespace Fatality_Menu;

public class Login : Form
{
	private bool el63s50mWD;

	private Point k0F3aTH8al;

	public bool isFlash;

	private IContainer fft3Anw7dX;

	private Timer byn3jAUCJD;

	private SiticoneDragControl r0f31acOaX;

	private SiticoneRoundedGradientButton eyk3wRDhtd;

	private SiticoneTransition swM3XnBYWJ;

	private SiticoneRoundedGradientButton zF63nsRwSP;

	private SiticoneControlBox a0t3cjIER9;

	private SiticoneControlBox YrL3RP1SY4;

	private SiticoneRoundedTextBox uG53L7Ccaw;

	private SiticoneRoundedTextBox cGS30yB0Pj;

	private Label DPw37JniIN;

	private Label MLP3QaBOKy;

	private SiticoneShadowForm LPH3g1a50Q;

	internal static Login rCI0YMrWfAnqLit022g;

	public Login()
	{
		lQTlMsrjqIKcEdgq1YG();
		aKWxkvrO90nBvMcDJMN();
		fft3Anw7dX = null;
		((Form)this)._002Ector();
		tX73ujxe8a();
	}

	private void RidOKVVkv(object sender, PaintEventArgs e)
	{
	}

	private void aSESr0fdD(object sender, MouseEventArgs e)
	{
		int num = 2;
		while (true)
		{
			el63s50mWD = true;
			int num2 = 1;
			if (!u9XTnSrrytnajiXyeg7())
			{
				goto IL_0024;
			}
			goto IL_0028;
			IL_0028:
			while (true)
			{
				switch (num2)
				{
				case 1:
					goto IL_000b;
				default:
					return;
				case 2:
					break;
				case 0:
					return;
				}
				break;
				IL_000b:
				k0F3aTH8al = e.get_Location();
				num2 = 0;
				if (u9XTnSrrytnajiXyeg7())
				{
					continue;
				}
				goto IL_0024;
			}
			continue;
			IL_0024:
			num2 = num;
			goto IL_0028;
		}
	}

	private void OdNzkhDWd(object sender, MouseEventArgs e)
	{
		int num = 4;
		while (true)
		{
			IL_00b1:
			bool flag = el63s50mWD;
			int num2 = 0;
			if (sun0kyrhwnAoddFPkoh() == null)
			{
				goto IL_000e;
			}
			goto IL_0096;
			IL_0096:
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 2:
					goto IL_0022;
				case 1:
					jaA5oTrMlxYIDyyecCG(this);
					num2 = 0;
					if (sun0kyrhwnAoddFPkoh() != null)
					{
						num2 = num;
					}
					continue;
				default:
					return;
				case 4:
					goto IL_00b1;
				case 0:
					return;
				}
				break;
			}
			goto IL_000e;
			IL_000e:
			if (flag)
			{
				num2 = 0;
				if (sun0kyrhwnAoddFPkoh() == null)
				{
					goto IL_0022;
				}
				goto IL_0096;
			}
			break;
			IL_0022:
			miyMxfrXqPFXjrqh6No(this, new Point(HZ5VJVrIJXXBmL75BYr(this).X - k0F3aTH8al.X + e.get_X(), HZ5VJVrIJXXBmL75BYr(this).Y - k0F3aTH8al.Y + JF6Krbr7RPRsQmyyOsU(e)));
			num2 = 1;
			if (sun0kyrhwnAoddFPkoh() != null)
			{
				break;
			}
			goto IL_0096;
		}
	}

	private void E663YwHLSe(object sender, MouseEventArgs e)
	{
		int num = 1;
		while (true)
		{
			el63s50mWD = false;
			int num2 = 0;
			if (sun0kyrhwnAoddFPkoh() != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				break;
			default:
				return;
			case 0:
				return;
			}
		}
	}

	private void oCR33iF15b(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		while (true)
		{
			Loader object_ = new Loader();
			int num2 = 2;
			if (sun0kyrhwnAoddFPkoh() != null)
			{
				goto IL_001e;
			}
			goto IL_003b;
			IL_003b:
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 1:
					goto IL_0024;
				case 3:
					goto end_IL_003b;
				default:
					tkb46frGQI6OptrKdV3(this);
					return;
				case 4:
					return;
				}
				N0LI2Frt8CHNh4LMC0i(this);
				num2 = 1;
				if (sun0kyrhwnAoddFPkoh() == null)
				{
					continue;
				}
				goto IL_001e;
				IL_0024:
				HkC1PTrDCFlB8dViBc9(object_);
				num2 = 0;
				if (sun0kyrhwnAoddFPkoh() == null)
				{
					continue;
				}
				goto IL_001e;
				continue;
				end_IL_003b:
				break;
			}
			continue;
			IL_001e:
			num2 = num;
			goto IL_003b;
		}
	}

	private void SG33JWUAD7(object sender, EventArgs e)
	{
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		Process[] source6 = default(Process[]);
		bool flag12 = default(bool);
		Process[] source = default(Process[]);
		bool flag3 = default(bool);
		Process[] source4 = default(Process[]);
		bool flag2 = default(bool);
		bool flag11 = default(bool);
		Process[] processesByName = default(Process[]);
		Process[] source5 = default(Process[]);
		bool flag = default(bool);
		bool flag9 = default(bool);
		int num3 = default(int);
		Process[] array = default(Process[]);
		RegistryKey registryKey2 = default(RegistryKey);
		bool flag10 = default(bool);
		bool flag7 = default(bool);
		bool flag8 = default(bool);
		Process[] source3 = default(Process[]);
		bool flag6 = default(bool);
		Process[] source2 = default(Process[]);
		bool flag5 = default(bool);
		string object_ = default(string);
		bool flag4 = default(bool);
		bool flag13 = default(bool);
		while (true)
		{
			IL_05e2:
			RegistryKey registryKey = (RegistryKey)S3lAvRrE5115DTo5U9f(Registry.LocalMachine, UJCOdqrqYdxMO8gXxrg(1742));
			int num2 = 0;
			if (sun0kyrhwnAoddFPkoh() == null)
			{
				goto IL_047e;
			}
			goto IL_0494;
			IL_0494:
			while (true)
			{
				switch (num2)
				{
				case 55:
				case 80:
					source6 = (Process[])Qkjhemrwuv65MoffJ9Q(XaXlykERDhtdRwMnBY.oXbWkAhpNa(2586));
					num2 = 0;
					if (!u9XTnSrrytnajiXyeg7())
					{
						continue;
					}
					goto case 5;
				case 5:
					flag12 = source6.Count() > 0;
					num2 = 62;
					if (!u9XTnSrrytnajiXyeg7())
					{
						continue;
					}
					goto case 71;
				case 71:
					if (flag12)
					{
						goto case 76;
					}
					num2 = 41;
					if (u9XTnSrrytnajiXyeg7())
					{
						continue;
					}
					goto IL_00f7;
				case 76:
					HvcsberY4m1Meli24NQ();
					num2 = 66;
					if (u9XTnSrrytnajiXyeg7())
					{
						continue;
					}
					goto case 6;
				case 6:
				case 19:
					source = (Process[])Qkjhemrwuv65MoffJ9Q(UJCOdqrqYdxMO8gXxrg(2664));
					goto case 61;
				case 61:
					flag3 = source.Count() > 0;
					num = 22;
					goto case 22;
				case 22:
					if (flag3)
					{
						goto case 17;
					}
					goto case 27;
				case 17:
					HvcsberY4m1Meli24NQ();
					num2 = 75;
					if (sun0kyrhwnAoddFPkoh() == null)
					{
						continue;
					}
					goto IL_00f7;
				case 27:
					source4 = (Process[])Qkjhemrwuv65MoffJ9Q(UJCOdqrqYdxMO8gXxrg(2690));
					num2 = 35;
					if (!u9XTnSrrytnajiXyeg7())
					{
						continue;
					}
					goto case 53;
				case 53:
					flag2 = source4.Count() > 0;
					num2 = 35;
					if (u9XTnSrrytnajiXyeg7())
					{
						continue;
					}
					goto IL_00f7;
				case 79:
					flag11 = processesByName.Count() > 0;
					goto case 39;
				case 39:
					if (!flag11)
					{
						num2 = 2;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00f7;
					}
					goto IL_0616;
				case 78:
					processesByName = Process.GetProcessesByName((string?)UJCOdqrqYdxMO8gXxrg(2722));
					num2 = 79;
					if (sun0kyrhwnAoddFPkoh() == null)
					{
						continue;
					}
					goto IL_00f7;
				case 77:
					HvcsberY4m1Meli24NQ();
					num2 = 24;
					if (sun0kyrhwnAoddFPkoh() != null)
					{
						continue;
					}
					goto case 38;
				case 38:
					AXFXKJr0by0Oi9SuqO7(0);
					goto case 6;
				case 75:
					AXFXKJr0by0Oi9SuqO7(0);
					goto case 27;
				case 74:
					source5 = (Process[])Qkjhemrwuv65MoffJ9Q(XaXlykERDhtdRwMnBY.oXbWkAhpNa(2704));
					goto case 9;
				case 9:
					flag = source5.Count() > 0;
					num2 = 18;
					if (u9XTnSrrytnajiXyeg7())
					{
						continue;
					}
					goto case 6;
				case 8:
				case 73:
					flag9 = num3 < array.Length;
					num2 = 7;
					if (sun0kyrhwnAoddFPkoh() != null)
					{
						continue;
					}
					goto case 10;
				case 10:
					if (flag9)
					{
						num2 = 14;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00f7;
					}
					goto case 33;
				case 33:
					registryKey2 = (RegistryKey)S3lAvRrE5115DTo5U9f(Registry.CurrentUser, UJCOdqrqYdxMO8gXxrg(2180));
					num = 36;
					goto case 36;
				case 36:
					flag10 = registryKey2 == null;
					num2 = 14;
					if (!u9XTnSrrytnajiXyeg7())
					{
						continue;
					}
					goto case 67;
				case 67:
					if (!flag10)
					{
						goto case 45;
					}
					goto case 37;
				case 45:
					MessageBox.Show(XaXlykERDhtdRwMnBY.oXbWkAhpNa(2260), XaXlykERDhtdRwMnBY.oXbWkAhpNa(2134), (MessageBoxButtons)0, (MessageBoxIcon)16);
					goto case 46;
				case 46:
					Application.Exit();
					goto case 48;
				case 48:
					AXFXKJr0by0Oi9SuqO7(1);
					goto case 37;
				case 37:
				case 42:
					Registry.CurrentUser.OpenSubKey((string)UJCOdqrqYdxMO8gXxrg(2508));
					goto case 40;
				case 40:
					flag7 = registryKey2 == null;
					num2 = 70;
					if (sun0kyrhwnAoddFPkoh() == null)
					{
						continue;
					}
					return;
				case 72:
					if (!flag8)
					{
						goto case 52;
					}
					goto case 13;
				case 52:
				case 68:
					MessageBox.Show((string)UJCOdqrqYdxMO8gXxrg(1888), (string)UJCOdqrqYdxMO8gXxrg(2134), (MessageBoxButtons)0, (MessageBoxIcon)16);
					num = 15;
					goto case 15;
				case 15:
					HvcsberY4m1Meli24NQ();
					goto case 29;
				case 29:
					AXFXKJr0by0Oi9SuqO7(1);
					num = 16;
					goto case 13;
				case 13:
				case 16:
					array = (Process[])SdIAsBrHmBtCNw055FF();
					num2 = 57;
					if (sun0kyrhwnAoddFPkoh() == null)
					{
						continue;
					}
					goto case 11;
				case 11:
					AXFXKJr0by0Oi9SuqO7(0);
					num2 = 62;
					if (sun0kyrhwnAoddFPkoh() == null)
					{
						continue;
					}
					goto IL_00f7;
				case 70:
					if (flag7)
					{
						goto case 55;
					}
					goto case 28;
				case 28:
					MessageBox.Show(XaXlykERDhtdRwMnBY.oXbWkAhpNa(2260), (string)UJCOdqrqYdxMO8gXxrg(2134), (MessageBoxButtons)0, (MessageBoxIcon)16);
					goto case 4;
				case 4:
					HvcsberY4m1Meli24NQ();
					goto case 34;
				case 34:
					AXFXKJr0by0Oi9SuqO7(1);
					num2 = 55;
					if (sun0kyrhwnAoddFPkoh() == null)
					{
						continue;
					}
					goto IL_00f7;
				case 69:
					AXFXKJr0by0Oi9SuqO7(0);
					goto case 78;
				case 66:
					AXFXKJr0by0Oi9SuqO7(0);
					goto case 3;
				case 3:
				case 41:
					source3 = (Process[])Qkjhemrwuv65MoffJ9Q(XaXlykERDhtdRwMnBY.oXbWkAhpNa(2616));
					goto case 24;
				case 24:
					flag6 = source3.Count() > 0;
					goto case 47;
				case 47:
					if (flag6)
					{
						goto case 51;
					}
					goto case 31;
				case 51:
					HvcsberY4m1Meli24NQ();
					goto case 20;
				case 20:
					Environment.Exit(0);
					num = 31;
					goto case 31;
				case 31:
				case 54:
					source2 = (Process[])Qkjhemrwuv65MoffJ9Q(UJCOdqrqYdxMO8gXxrg(2642));
					num2 = 59;
					if (sun0kyrhwnAoddFPkoh() == null)
					{
						continue;
					}
					goto IL_00f7;
				case 65:
					flag5 = fb0ha9rdkRxpkf8Mw6g(object_, XaXlykERDhtdRwMnBY.oXbWkAhpNa(2148));
					goto case 44;
				case 44:
					if (!flag5)
					{
						num2 = 26;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00f7;
					}
					goto case 56;
				case 56:
					array[num3].Kill();
					goto case 11;
				case 62:
					HvcsberY4m1Meli24NQ();
					num2 = 25;
					if (u9XTnSrrytnajiXyeg7())
					{
						continue;
					}
					return;
				case 60:
					HvcsberY4m1Meli24NQ();
					num = 7;
					goto case 7;
				case 7:
					AXFXKJr0by0Oi9SuqO7(0);
					goto case 74;
				case 59:
					flag4 = source2.Count() > 0;
					num = 49;
					goto case 49;
				case 49:
					if (!flag4)
					{
						num = 6;
						goto case 6;
					}
					goto case 77;
				case 58:
					Application.Exit();
					goto case 69;
				case 57:
					object_ = string.Empty;
					goto case 30;
				case 30:
					num3 = 0;
					goto case 8;
				case 25:
				case 26:
				case 50:
					num3++;
					goto case 8;
				case 35:
					if (!flag2)
					{
						goto case 74;
					}
					num = 60;
					goto case 60;
				case 14:
				case 32:
					object_ = (string)UoaeB6rPpxomIIONvPs(array[num3]);
					num2 = 5;
					if (!u9XTnSrrytnajiXyeg7())
					{
						continue;
					}
					goto case 65;
				case 18:
					if (!flag)
					{
						goto case 78;
					}
					goto case 58;
				case 1:
					goto IL_05e2;
				case 23:
					goto IL_0616;
				case 12:
					goto IL_061b;
				case 2:
				case 43:
					goto IL_0621;
				case 63:
					goto end_IL_05e2;
				case 21:
				case 64:
					return;
					IL_00f7:
					num2 = num;
					continue;
				}
				break;
			}
			goto IL_047e;
			IL_047e:
			flag8 = registryKey == null;
			num2 = 72;
			if (u9XTnSrrytnajiXyeg7())
			{
				goto IL_0494;
			}
			goto IL_0616;
			IL_0616:
			HvcsberY4m1Meli24NQ();
			goto IL_061b;
			IL_061b:
			AXFXKJr0by0Oi9SuqO7(0);
			goto IL_0621;
			IL_0621:
			flag13 = isFlash;
			break;
			continue;
			end_IL_05e2:
			break;
		}
		if (flag13)
		{
		}
	}

	private void dUZ3dtZcii(object sender, EventArgs e)
	{
		int num = 10;
		StreamReader streamReader = default(StreamReader);
		int num3 = default(int);
		bool flag = default(bool);
		string path = default(string);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			while (true)
			{
				IL_01a1:
				string object_ = string.Empty;
				int num2 = 0;
				if (sun0kyrhwnAoddFPkoh() == null)
				{
					goto IL_012b;
				}
				goto IL_0133;
				IL_0133:
				while (true)
				{
					switch (num2)
					{
					case 24:
						((TextBox)uG53L7Ccaw).set_Text((string)zvxFEcr2eWr6TfMx3tS(streamReader));
						goto case 17;
					case 17:
						((TextBox)cGS30yB0Pj).set_Text(streamReader.ReadLine());
						num2 = 2;
						if (sun0kyrhwnAoddFPkoh() != null)
						{
							continue;
						}
						goto case 7;
					case 7:
					case 18:
						mRYQcKro2HflW3V5qbV(byn3jAUCJD);
						num2 = 23;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_005d;
					case 22:
						Application.Exit();
						goto case 2;
					case 2:
					case 12:
					case 16:
						num3++;
						break;
					case 15:
					case 20:
						break;
					case 21:
						if (!flag)
						{
							goto case 2;
						}
						goto case 3;
					case 3:
						processes[num3].Kill();
						goto case 11;
					case 11:
						AXFXKJr0by0Oi9SuqO7(0);
						num2 = 22;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_005d;
					case 19:
						path = (string)UJCOdqrqYdxMO8gXxrg(2752);
						goto case 6;
					case 6:
						streamReader = new StreamReader(path);
						num2 = 24;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto case 2;
					case 14:
						if (flag2)
						{
							num2 = 0;
							if (u9XTnSrrytnajiXyeg7())
							{
								continue;
							}
							goto IL_005d;
						}
						goto case 5;
					case 5:
						flag3 = YaKI7HrixrshpxFIVAn(UJCOdqrqYdxMO8gXxrg(2752));
						goto case 4;
					case 4:
						if (!flag3)
						{
							goto case 7;
						}
						goto case 19;
					default:
						object_ = (string)UoaeB6rPpxomIIONvPs(processes[num3]);
						goto case 8;
					case 8:
						flag = fb0ha9rdkRxpkf8Mw6g(object_, UJCOdqrqYdxMO8gXxrg(2148));
						goto case 21;
					case 1:
						goto IL_012b;
					case 9:
						goto IL_01a1;
					case 10:
						goto end_IL_01a1;
					case 23:
						return;
					}
					break;
				}
				goto IL_0071;
				IL_012b:
				num3 = 0;
				goto IL_0071;
				IL_0071:
				flag2 = num3 < processes.Length;
				num2 = 14;
				if (sun0kyrhwnAoddFPkoh() != null)
				{
					goto IL_005d;
				}
				goto IL_0133;
				IL_005d:
				num2 = num;
				goto IL_0133;
				continue;
				end_IL_01a1:
				break;
			}
		}
	}

	private void DvY3iPKBa2(object sender, EventArgs e)
	{
	}

	private void q7Z3lx21vg(object sender, EventArgs e)
	{
	}

	private void nm03NLETb3(object sender, EventArgs e)
	{
	}

	private void t3L3WDdnu1(object sender, EventArgs e)
	{
	}

	private void HUO36Ry72n(object sender, EventArgs e)
	{
	}

	private void k3x3rPyJHu(object sender, EventArgs e)
	{
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		Loader loader = default(Loader);
		int num12 = default(int);
		int num14 = default(int);
		int num16 = default(int);
		int num18 = default(int);
		FileStream fileStream2 = default(FileStream);
		string path2 = default(string);
		StreamWriter streamWriter = default(StreamWriter);
		int num7 = default(int);
		int num8 = default(int);
		int num10 = default(int);
		int num19 = default(int);
		int num21 = default(int);
		int num23 = default(int);
		FileStream fileStream3 = default(FileStream);
		string path4 = default(string);
		StreamWriter streamWriter3 = default(StreamWriter);
		int num25 = default(int);
		int num27 = default(int);
		int num31 = default(int);
		int num29 = default(int);
		FileStream fileStream4 = default(FileStream);
		StreamWriter streamWriter4 = default(StreamWriter);
		int num34 = default(int);
		int num35 = default(int);
		int num39 = default(int);
		int num37 = default(int);
		while (true)
		{
			bool flag = lstTktraH5GEIHwIcsC(MW7MgJrTZTqfKNFoAVS(uG53L7Ccaw), MW7MgJrTZTqfKNFoAVS(cGS30yB0Pj));
			while (true)
			{
				if (flag)
				{
					goto IL_002d;
				}
				int num2 = 6;
				if (!u9XTnSrrytnajiXyeg7())
				{
					goto IL_0599;
				}
				goto IL_05b0;
				IL_05f7:
				loader = new Loader();
				goto IL_05e2;
				IL_05b0:
				switch (num2)
				{
				case 3:
					break;
				case 2:
					continue;
				default:
					goto IL_002d;
				case 1:
					goto IL_0599;
				case 8:
					goto IL_05e2;
				case 4:
					goto IL_05f7;
				case 9:
					goto IL_0615;
				case 6:
				case 7:
					return;
				}
				break;
				IL_0599:
				N0LI2Frt8CHNh4LMC0i(this);
				num2 = 7;
				if (sun0kyrhwnAoddFPkoh() != null)
				{
					num2 = num;
				}
				goto IL_05b0;
				IL_05e2:
				((Control)loader).Show();
				num2 = 1;
				if (sun0kyrhwnAoddFPkoh() != null)
				{
					goto IL_002d;
				}
				goto IL_05b0;
				IL_002d:
				try
				{
					string path = (string)UJCOdqrqYdxMO8gXxrg(2752);
					while (true)
					{
						IL_0167:
						FileStream fileStream = null;
						int num3 = 4;
						if (!u9XTnSrrytnajiXyeg7())
						{
							goto IL_0144;
						}
						goto IL_0148;
						IL_0148:
						while (true)
						{
							switch (num3)
							{
							case 4:
								try
								{
									fileStream = new FileStream(path, FileMode.OpenOrCreate);
									while (true)
									{
										StreamWriter streamWriter2 = new StreamWriter(fileStream, (Encoding)RqEPy3rvLjGtCVPcpYM());
										int num11 = 0;
										if (!u9XTnSrrytnajiXyeg7())
										{
											num11 = num12;
										}
										switch (num11)
										{
										case 2:
											continue;
										case 1:
											goto end_IL_004a;
										}
										try
										{
											E353e0rl50mckJp4wr6(streamWriter2, MW7MgJrTZTqfKNFoAVS(uG53L7Ccaw));
											int num13 = 0;
											if (!u9XTnSrrytnajiXyeg7())
											{
												num13 = num14;
											}
											switch (num13)
											{
											}
										}
										finally
										{
											if (streamWriter2 != null)
											{
												while (true)
												{
													JwjfdIrA0LeM9j67xvh(streamWriter2);
													int num15 = 1;
													if (!u9XTnSrrytnajiXyeg7())
													{
														num15 = num16;
													}
													switch (num15)
													{
													case 1:
													case 2:
														goto end_IL_00b1;
													}
													continue;
													end_IL_00b1:
													break;
												}
											}
										}
										break;
										continue;
										end_IL_004a:
										break;
									}
								}
								finally
								{
									bool flag3 = fileStream != null;
									while (flag3)
									{
										int num17 = 1;
										if (sun0kyrhwnAoddFPkoh() != null)
										{
											num17 = num18;
										}
										while (true)
										{
											switch (num17)
											{
											case 1:
												eJm8eWrZyEI8iMx5xIk(fileStream);
												num17 = 0;
												if (sun0kyrhwnAoddFPkoh() != null)
												{
													continue;
												}
												goto end_IL_0110;
											default:
												goto end_IL_0110;
											case 2:
												break;
											case 0:
												goto end_IL_0110;
											}
											goto IL_0123;
											continue;
											end_IL_0110:
											break;
										}
										break;
										IL_0123:;
									}
								}
								goto IL_012b;
							default:
								goto IL_012b;
							case 3:
								break;
							case 1:
								fileStream2 = null;
								goto case 5;
							case 5:
								try
								{
									fileStream2 = new FileStream(path2, FileMode.OpenOrCreate);
									int num4 = 0;
									if (u9XTnSrrytnajiXyeg7())
									{
										goto IL_0194;
									}
									goto IL_01b3;
									IL_01b3:
									switch (num4)
									{
									case 2:
										break;
									default:
										goto end_IL_017d;
									case 1:
										try
										{
											E353e0rl50mckJp4wr6(streamWriter, MW7MgJrTZTqfKNFoAVS(uG53L7Ccaw));
											int num5 = 1;
											if (sun0kyrhwnAoddFPkoh() != null)
											{
												goto end_IL_0148;
											}
											while (true)
											{
												switch (num5)
												{
												case 1:
													streamWriter.WriteLine(((TextBox)cGS30yB0Pj).get_Text());
													num5 = 0;
													if (u9XTnSrrytnajiXyeg7())
													{
														continue;
													}
													break;
												case 0:
													break;
												}
												break;
											}
										}
										finally
										{
											if (streamWriter != null)
											{
												int num6 = 1;
												if (sun0kyrhwnAoddFPkoh() != null)
												{
													num6 = num7;
												}
												while (true)
												{
													switch (num6)
													{
													case 1:
														JwjfdIrA0LeM9j67xvh(streamWriter);
														num6 = 0;
														if (!u9XTnSrrytnajiXyeg7())
														{
															continue;
														}
														break;
													case 0:
														break;
													}
													break;
												}
											}
										}
										goto end_IL_017d;
									case 0:
										goto end_IL_017d;
									}
									goto IL_0194;
									IL_0194:
									streamWriter = new StreamWriter(fileStream2, (Encoding)RqEPy3rvLjGtCVPcpYM());
									num4 = 1;
									if (sun0kyrhwnAoddFPkoh() != null)
									{
										num4 = num8;
									}
									goto IL_01b3;
									end_IL_017d:;
								}
								finally
								{
									bool flag2 = fileStream2 != null;
									int num9 = 0;
									if (u9XTnSrrytnajiXyeg7())
									{
										goto IL_0288;
									}
									goto IL_028e;
									IL_028e:
									switch (num9)
									{
									case 2:
										break;
									default:
										goto IL_0288;
									case 1:
										goto end_IL_0258;
									}
									goto IL_026e;
									IL_0288:
									if (flag2)
									{
										goto IL_026e;
									}
									goto end_IL_0258;
									IL_026e:
									eJm8eWrZyEI8iMx5xIk(fileStream2);
									num9 = 1;
									if (!u9XTnSrrytnajiXyeg7())
									{
										num9 = num10;
									}
									goto IL_028e;
									end_IL_0258:;
								}
								goto end_IL_0148;
							case 2:
								goto end_IL_0148;
							}
							goto IL_0167;
							IL_012b:
							path2 = (string)UJCOdqrqYdxMO8gXxrg(2752);
							num3 = 1;
							if (sun0kyrhwnAoddFPkoh() == null)
							{
								continue;
							}
							goto IL_0144;
							continue;
							end_IL_0148:
							break;
						}
						break;
						IL_0144:
						num3 = num19;
						goto IL_0148;
					}
				}
				catch
				{
					while (true)
					{
						try
						{
							AkpEQyrewYqJaG0Lv6Z(UJCOdqrqYdxMO8gXxrg(2752));
							int num20 = 1;
							if (!u9XTnSrrytnajiXyeg7())
							{
								num20 = num21;
							}
							while (true)
							{
								switch (num20)
								{
								case 1:
									AkpEQyrewYqJaG0Lv6Z(UJCOdqrqYdxMO8gXxrg(2752));
									num20 = 0;
									if (sun0kyrhwnAoddFPkoh() != null)
									{
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						catch
						{
							int num22 = 0;
							if (!u9XTnSrrytnajiXyeg7())
							{
								num22 = num23;
							}
							switch (num22)
							{
							}
						}
						while (true)
						{
							string path3 = (string)UJCOdqrqYdxMO8gXxrg(2752);
							if (sun0kyrhwnAoddFPkoh() != null)
							{
								switch (2)
								{
								case 4:
								case 8:
									break;
								default:
									continue;
								case 7:
									goto IL_0359;
								case 2:
									goto IL_035c;
								case 1:
									goto IL_0479;
								case 3:
									goto IL_0485;
								case 5:
									goto IL_0488;
								case 6:
									goto end_IL_02a8;
								}
								break;
							}
							goto IL_0359;
							IL_0488:
							try
							{
								fileStream3 = new FileStream(path4, FileMode.OpenOrCreate);
								if (sun0kyrhwnAoddFPkoh() != null)
								{
									goto end_IL_02a8;
								}
								switch (1)
								{
								default:
									goto end_IL_0489;
								case 1:
									streamWriter3 = new StreamWriter(fileStream3, Encoding.UTF8);
									break;
								case 2:
									break;
								case 0:
									goto end_IL_0489;
								}
								try
								{
									E353e0rl50mckJp4wr6(streamWriter3, MW7MgJrTZTqfKNFoAVS(cGS30yB0Pj));
									int num24 = 0;
									if (!u9XTnSrrytnajiXyeg7())
									{
										num24 = num25;
									}
									switch (num24)
									{
									}
								}
								finally
								{
									int num26;
									if (streamWriter3 != null)
									{
										num26 = 0;
										if (!u9XTnSrrytnajiXyeg7())
										{
											goto IL_051c;
										}
										goto IL_0520;
									}
									goto end_IL_04f5;
									IL_051c:
									num26 = num27;
									goto IL_0520;
									IL_0520:
									while (true)
									{
										switch (num26)
										{
										case 1:
											goto end_IL_0520;
										}
										((IDisposable)streamWriter3).Dispose();
										num26 = 1;
										if (sun0kyrhwnAoddFPkoh() == null)
										{
											continue;
										}
										goto IL_051c;
										continue;
										end_IL_0520:
										break;
									}
									end_IL_04f5:;
								}
								end_IL_0489:;
							}
							catch
							{
								int num28 = 0;
								if (!u9XTnSrrytnajiXyeg7())
								{
									num28 = num29;
								}
								switch (num28)
								{
								default:
									goto end_IL_0532;
								}
								end_IL_0532:;
							}
							finally
							{
								bool flag4 = fileStream3 != null;
								int num30 = 1;
								if (!u9XTnSrrytnajiXyeg7())
								{
									num30 = num31;
								}
								switch (num30)
								{
								case 1:
									if (flag4)
									{
										break;
									}
									num31 = 2;
									goto end_IL_0551;
								case 2:
								case 3:
									goto end_IL_0551;
								}
								eJm8eWrZyEI8iMx5xIk(fileStream3);
								end_IL_0551:;
							}
							goto end_IL_02a8;
							IL_0359:
							fileStream4 = null;
							goto IL_035c;
							IL_035c:
							try
							{
								fileStream4 = new FileStream(path3, FileMode.OpenOrCreate);
								int num32 = 1;
								if (!u9XTnSrrytnajiXyeg7())
								{
									goto IL_0391;
								}
								goto IL_0395;
								IL_0395:
								while (true)
								{
									switch (num32)
									{
									case 1:
										break;
									default:
										goto end_IL_0395;
									case 2:
										try
										{
											E353e0rl50mckJp4wr6(streamWriter4, MW7MgJrTZTqfKNFoAVS(uG53L7Ccaw));
											if (u9XTnSrrytnajiXyeg7())
											{
												switch (0)
												{
												}
											}
										}
										finally
										{
											if (streamWriter4 != null)
											{
												goto IL_03ec;
											}
											int num33 = 0;
											if (sun0kyrhwnAoddFPkoh() != null)
											{
												num33 = num34;
											}
											goto IL_03ff;
											IL_03ec:
											JwjfdIrA0LeM9j67xvh(streamWriter4);
											num33 = 2;
											if (u9XTnSrrytnajiXyeg7())
											{
												goto IL_03ff;
											}
											goto end_IL_03d5;
											IL_03ff:
											switch (num33)
											{
											case 1:
												break;
											default:
												goto end_IL_03d5;
											case 0:
											case 2:
												goto end_IL_03d5;
											}
											goto IL_03ec;
											end_IL_03d5:;
										}
										goto end_IL_0395;
									case 0:
										goto end_IL_0395;
									}
									streamWriter4 = new StreamWriter(fileStream4, (Encoding)RqEPy3rvLjGtCVPcpYM());
									num32 = 2;
									if (u9XTnSrrytnajiXyeg7())
									{
										continue;
									}
									goto IL_0391;
									continue;
									end_IL_0395:
									break;
								}
								goto end_IL_035d;
								IL_0391:
								num32 = num35;
								goto IL_0395;
								end_IL_035d:;
							}
							catch
							{
								int num36 = 0;
								if (sun0kyrhwnAoddFPkoh() != null)
								{
									num36 = num37;
								}
								switch (num36)
								{
								}
							}
							finally
							{
								bool flag5 = fileStream4 != null;
								int num38 = 0;
								if (sun0kyrhwnAoddFPkoh() != null)
								{
									goto IL_0449;
								}
								goto IL_045e;
								IL_045e:
								switch (num38)
								{
								case 1:
									eJm8eWrZyEI8iMx5xIk(fileStream4);
									goto end_IL_0435;
								case 2:
									goto end_IL_0435;
								}
								goto IL_0449;
								IL_0449:
								if (flag5)
								{
									num38 = 1;
									if (!u9XTnSrrytnajiXyeg7())
									{
										num38 = num39;
									}
									goto IL_045e;
								}
								end_IL_0435:;
							}
							goto IL_0479;
							IL_0479:
							path4 = (string)UJCOdqrqYdxMO8gXxrg(2752);
							goto IL_0485;
							IL_0485:
							fileStream3 = null;
							goto IL_0488;
						}
						continue;
						end_IL_02a8:
						break;
					}
				}
				goto IL_0615;
				IL_0615:
				xUIlCGrLPNAyoNyP6ua(UJCOdqrqYdxMO8gXxrg(2784), UJCOdqrqYdxMO8gXxrg(62), (MessageBoxButtons)0, (MessageBoxIcon)64);
				goto IL_05f7;
			}
		}
	}

	private void i3P3IbhHci(object sender, EventArgs e)
	{
		int num = 1;
		Register register = default(Register);
		while (true)
		{
			IL_0052:
			((Control)this).Hide();
			int num2 = 0;
			if (!u9XTnSrrytnajiXyeg7())
			{
				goto IL_0025;
			}
			goto IL_003b;
			IL_003b:
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				default:
					goto end_IL_003b;
				case 1:
					goto IL_0052;
				case 3:
					return;
				}
				((Control)register).Show();
				num2 = 3;
				if (u9XTnSrrytnajiXyeg7())
				{
					continue;
				}
				goto IL_001f;
				continue;
				end_IL_003b:
				break;
			}
			goto IL_0025;
			IL_0025:
			register = new Register();
			num2 = 2;
			if (sun0kyrhwnAoddFPkoh() != null)
			{
				goto IL_001f;
			}
			goto IL_003b;
			IL_001f:
			num2 = num;
			goto IL_003b;
		}
	}

	private void VaR3bMQ2qH(object sender, EventArgs e)
	{
		while (true)
		{
			AXFXKJr0by0Oi9SuqO7(0);
			if (u9XTnSrrytnajiXyeg7())
			{
				switch (0)
				{
				case 1:
					break;
				default:
					return;
				case 0:
					return;
				}
				continue;
			}
			break;
		}
	}

	protected override void Dispose(bool disposing)
	{
		int num = 6;
		bool flag = default(bool);
		while (true)
		{
			IL_0073:
			int num2;
			if (!disposing)
			{
				num2 = 5;
				if (sun0kyrhwnAoddFPkoh() != null)
				{
					goto IL_001c;
				}
				goto IL_0020;
			}
			goto IL_0059;
			IL_001c:
			num2 = num;
			goto IL_0020;
			IL_0059:
			int num3 = ((fft3Anw7dX != null) ? 1 : 0);
			goto IL_0048;
			IL_0048:
			flag = (byte)num3 != 0;
			num2 = 1;
			if (!u9XTnSrrytnajiXyeg7())
			{
				goto IL_001c;
			}
			goto IL_0020;
			IL_0020:
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!flag)
					{
						goto IL_000f;
					}
					goto case 2;
				case 5:
					break;
				case 3:
					goto IL_0059;
				case 6:
					goto IL_0073;
				case 2:
					fft3Anw7dX.Dispose();
					goto default;
				default:
					ddWtqlr50vKoe2t3QhG(this, disposing);
					return;
				case 7:
					return;
				}
				break;
				IL_000f:
				num2 = 0;
				if (u9XTnSrrytnajiXyeg7())
				{
					continue;
				}
				goto IL_001c;
			}
			num3 = 0;
			goto IL_0048;
		}
	}

	private void tX73ujxe8a()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected O, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected O, but got Unknown
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Expected O, but got Unknown
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0c: Expected O, but got Unknown
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected O, but got Unknown
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Expected O, but got Unknown
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected O, but got Unknown
		//IL_0cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Expected O, but got Unknown
		//IL_0cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce5: Expected O, but got Unknown
		//IL_0cef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Expected O, but got Unknown
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc0: Expected O, but got Unknown
		//IL_0fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe6: Expected O, but got Unknown
		//IL_1288: Unknown result type (might be due to invalid IL or missing references)
		//IL_1292: Expected O, but got Unknown
		//IL_136d: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e9: Expected O, but got Unknown
		int num = 123;
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		while (true)
		{
			fft3Anw7dX = new Container();
			while (true)
			{
				IL_16e2:
				Animation val = new Animation();
				int num2 = 5;
				if (u9XTnSrrytnajiXyeg7())
				{
					goto IL_0c83;
				}
				goto IL_13f0;
				IL_13f0:
				while (true)
				{
					switch (num2)
					{
					case 185:
						a0t3cjIER9.set_FillColor(kc7H5GrmLeqm9ruBm8g());
						num2 = 100;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto case 100;
					case 100:
						OdWfmprSpVDpBeMULT7(GstcpSrfwr8Sp4Zhaaa(a0t3cjIER9), a0t3cjIER9);
						goto case 46;
					case 46:
						VR4Yy0rn5CDMoWZkF2r(a0t3cjIER9, t2lApMrRHtB3qamD9yH());
						goto case 121;
					case 121:
						GSxhcKrNhWnIHahRQrd(a0t3cjIER9, new Point(341, 4));
						num2 = 184;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto case 35;
					case 35:
						ApeCIsr4uuxjs0pVK78(byn3jAUCJD, new EventHandler(SG33JWUAD7));
						goto case 10;
					case 10:
						GIDLbqrJkm9BVJHMueq(r0f31acOaX, this);
						num2 = 176;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 52;
					case 52:
						aU8uHbr10Y8mMIUogve(swM3XnBYWJ, DPw37JniIN, (DecorationType)0);
						num2 = 177;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 184:
						SQOlHkrco07h1UX8Hcl(a0t3cjIER9, new Padding(4, 5, 4, 5));
						goto case 117;
					case 117:
						cm2rcNrxINT5E45VKhG(a0t3cjIER9, XaXlykERDhtdRwMnBY.oXbWkAhpNa(194));
						goto case 3;
					case 3:
						WbkeV1r8Nk8eHRqb6b0(mvvhU6rQKRleuf1Jo27(a0t3cjIER9), a0t3cjIER9);
						num2 = 77;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 183:
						j0y0bYhx4wVZ00M1ZnL(this, (FormBorderStyle)0);
						num2 = 140;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 49;
					case 49:
						((Control)DPw37JniIN).set_Size(new Size(265, 30));
						num2 = 32;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 182:
						HhAxLCrpJAwHET3wJuG(zF63nsRwSP, 42);
						num = 112;
						goto case 112;
					case 112:
						((Control)zF63nsRwSP).set_Text((string)UJCOdqrqYdxMO8gXxrg(3110));
						goto case 159;
					case 159:
						YSxQu7rUINaLEUq3WbS(zF63nsRwSP, new EventHandler(k3x3rPyJHu));
						goto case 21;
					case 21:
						kYaiCDhVkMih5IoM02X(f1MyI1h1MvbsSomlpjZ(eyk3wRDhtd), eyk3wRDhtd);
						goto case 8;
					case 8:
						uIgZJEhyRv2T6WLnU0j(yjXCFBhmPCQkib5BMDl(eyk3wRDhtd), eyk3wRDhtd);
						goto case 11;
					case 11:
						((Animator)swM3XnBYWJ).SetDecoration((Control)(object)eyk3wRDhtd, (DecorationType)0);
						goto case 155;
					case 155:
						rtmMlnh4xqpQAtj8K9D(eyk3wRDhtd, Ye434LhfBj4kRX6mUai());
						goto case 160;
					case 160:
						((SiticoneGradientButton)eyk3wRDhtd).set_FillColor2(Color.Empty);
						num2 = 171;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto case 145;
					case 145:
						((ControlCollection)s8vTNYhNhm3LY5A7kHi(this)).Add((Control)(object)MLP3QaBOKy);
						num = 6;
						goto case 6;
					case 6:
						aU8uHbr10Y8mMIUogve(swM3XnBYWJ, this, (DecorationType)0);
						num2 = 183;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 181:
						uk4YSPrsUPEYRZj7eqH(MLP3QaBOKy, new Size(0, 28));
						goto case 61;
					case 61:
						HhAxLCrpJAwHET3wJuG(MLP3QaBOKy, 36);
						goto case 86;
					case 86:
						kYaiCDhVkMih5IoM02X(((SiticoneGradientButton)zF63nsRwSP).get_CheckedState(), zF63nsRwSP);
						num2 = 7;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 180:
						VyRMjGhHaxH0jIaEgOg(((SiticoneTextBox)cGS30yB0Pj).get_DisabledState(), zUA5jaht5Z4aiyoMm7U(208, 208, 208));
						num2 = 14;
						if (!u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 37;
					case 37:
						J9yTDDhDUOZSKlF9prH(MkWejyhMu5ff0TY1ueL(cGS30yB0Pj), zUA5jaht5Z4aiyoMm7U(226, 226, 226));
						goto case 156;
					case 156:
						dZX6ZZhGVJa3MalErro(MkWejyhMu5ff0TY1ueL(cGS30yB0Pj), zUA5jaht5Z4aiyoMm7U(138, 138, 138));
						num = 142;
						goto case 142;
					case 142:
						FvjdABhqP5GjOxAnP8e(MkWejyhMu5ff0TY1ueL(cGS30yB0Pj), cGS30yB0Pj);
						goto case 141;
					case 141:
						tkTWKxhEsT3WWLH4qB9(MkWejyhMu5ff0TY1ueL(cGS30yB0Pj), Color.FromArgb(138, 138, 138));
						goto case 43;
					case 43:
						UAXTQwhYeK9QIihQ92a(cGS30yB0Pj, kc7H5GrmLeqm9ruBm8g());
						num2 = 162;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 179:
						break;
					case 178:
						pP2xephSQc7IPT3vSvF(this, (AutoScaleMode)1);
						num2 = 9;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 177:
						iaCQPmhef4fyWDR1lrA(DPw37JniIN, (object)new Font(XaXlykERDhtdRwMnBY.oXbWkAhpNa(80), 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
						goto case 4;
					case 4:
						eTeFSWh5atR4eEWLwvU(DPw37JniIN, O1noUphLGTsrxPpoOVO());
						num = 111;
						goto case 111;
					case 111:
						GSxhcKrNhWnIHahRQrd(DPw37JniIN, new Point(10, 14));
						num = 170;
						goto case 170;
					case 170:
						cm2rcNrxINT5E45VKhG(DPw37JniIN, UJCOdqrqYdxMO8gXxrg(118));
						goto case 49;
					case 176:
						mvI8DVr9UDlKfy0bmgP(a0t3cjIER9, (AnchorStyles)9);
						num2 = 87;
						if (!u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 89;
					case 89:
						JXjxMUr6L5VhMl3hHfc(a0t3cjIER9, 10);
						goto case 27;
					case 27:
						a0t3cjIER9.set_ControlBoxType((ControlBoxType)0);
						goto case 44;
					case 44:
						aU8uHbr10Y8mMIUogve(swM3XnBYWJ, a0t3cjIER9, (DecorationType)0);
						num = 185;
						goto case 185;
					case 175:
						YSxQu7rUINaLEUq3WbS(YrL3RP1SY4, new EventHandler(VaR3bMQ2qH));
						goto case 94;
					case 94:
						ysupHwrKyQmTJb6BsW5(swM3XnBYWJ, (AnimationType)1);
						num2 = 169;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto case 81;
					case 81:
						cm2rcNrxINT5E45VKhG(MLP3QaBOKy, XaXlykERDhtdRwMnBY.oXbWkAhpNa(646));
						goto case 181;
					case 174:
						J9yTDDhDUOZSKlF9prH(MkWejyhMu5ff0TY1ueL(uG53L7Ccaw), Color.FromArgb(226, 226, 226));
						goto case 104;
					case 104:
						dZX6ZZhGVJa3MalErro(MkWejyhMu5ff0TY1ueL(uG53L7Ccaw), zUA5jaht5Z4aiyoMm7U(138, 138, 138));
						num2 = 0;
						if (sun0kyrhwnAoddFPkoh() != null)
						{
							continue;
						}
						goto default;
					default:
						FvjdABhqP5GjOxAnP8e(MkWejyhMu5ff0TY1ueL(uG53L7Ccaw), uG53L7Ccaw);
						num2 = 30;
						if (!u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 42;
					case 42:
						tkTWKxhEsT3WWLH4qB9(MkWejyhMu5ff0TY1ueL(uG53L7Ccaw), zUA5jaht5Z4aiyoMm7U(138, 138, 138));
						num2 = 168;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 173:
						OdWfmprSpVDpBeMULT7(GstcpSrfwr8Sp4Zhaaa(YrL3RP1SY4), YrL3RP1SY4);
						num = 151;
						goto case 151;
					case 151:
						VR4Yy0rn5CDMoWZkF2r(YrL3RP1SY4, t2lApMrRHtB3qamD9yH());
						num2 = 150;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 172:
						((Control)zF63nsRwSP).set_Font(new Font(XaXlykERDhtdRwMnBY.oXbWkAhpNa(704), 9f));
						num2 = 20;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 171:
						iaCQPmhef4fyWDR1lrA(eyk3wRDhtd, (object)new Font(XaXlykERDhtdRwMnBY.oXbWkAhpNa(704), 9f));
						goto case 149;
					case 149:
						eTeFSWh5atR4eEWLwvU(eyk3wRDhtd, t2lApMrRHtB3qamD9yH());
						goto case 56;
					case 56:
						((ButtonState)((SiticoneGradientButton)eyk3wRDhtd).get_HoveredState()).set_Parent((CustomButtonBase)(object)eyk3wRDhtd);
						num2 = 31;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 169:
						((Animator)swM3XnBYWJ).set_Cursor((Cursor)null);
						num2 = 40;
						if (sun0kyrhwnAoddFPkoh() != null)
						{
							continue;
						}
						goto case 47;
					case 47:
						val.set_AnimateOnlyDifferences(true);
						goto case 72;
					case 72:
						S37GWQrbNgOcqttrU9u(val, (PointF)OUSmkXrkp8bxUNf5R9P(componentResourceManager, XaXlykERDhtdRwMnBY.oXbWkAhpNa(2822)));
						num = 76;
						goto case 76;
					case 76:
						EupRW6ruNuN56jYbN6G(val, 0f);
						goto case 110;
					case 110:
						val.set_MaxTime(1f);
						goto case 165;
					case 165:
						val.set_MinTime(0f);
						num2 = 89;
						if (sun0kyrhwnAoddFPkoh() != null)
						{
							continue;
						}
						goto case 92;
					case 92:
						iHEqvLrzKaehopWE6JY(val, (PointF)OUSmkXrkp8bxUNf5R9P(componentResourceManager, UJCOdqrqYdxMO8gXxrg(2868)));
						num2 = 75;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto case 70;
					case 70:
						((TextBox)uG53L7Ccaw).set_TextAlign((HorizontalAlignment)2);
						num = 101;
						goto case 101;
					case 101:
						BYaoSvhIIYIrRKdU9E2(cGS30yB0Pj, bool_0: true);
						num2 = 132;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 168:
						UAXTQwhYeK9QIihQ92a(uG53L7Ccaw, kc7H5GrmLeqm9ruBm8g());
						num2 = 1;
						if (!u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 62;
					case 62:
						VyRMjGhHaxH0jIaEgOg(BkI6yoh0mYXs1qtQsDK(uG53L7Ccaw), zUA5jaht5Z4aiyoMm7U(94, 148, 255));
						goto case 93;
					case 93:
						((TextBoxState)BkI6yoh0mYXs1qtQsDK(uG53L7Ccaw)).set_Parent((TextBox)(object)uG53L7Ccaw);
						num2 = 10;
						if (sun0kyrhwnAoddFPkoh() != null)
						{
							continue;
						}
						goto case 25;
					case 25:
						UYVJ48hP3MTHDEIYN5E(uG53L7Ccaw, O1oQR7h7lwP7AL0ARhe());
						goto case 51;
					case 51:
						((TextBoxState)zkMxnBhdrWArpdiH73j(uG53L7Ccaw)).set_BorderColor(zUA5jaht5Z4aiyoMm7U(94, 148, 255));
						num2 = 23;
						if (!u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 129;
					case 129:
						FvjdABhqP5GjOxAnP8e(zkMxnBhdrWArpdiH73j(uG53L7Ccaw), uG53L7Ccaw);
						num2 = 128;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 167:
						HhAxLCrpJAwHET3wJuG(cGS30yB0Pj, 40);
						goto case 90;
					case 90:
						sGAxuahlG1FalWImkdA(cGS30yB0Pj, (HorizontalAlignment)2);
						goto case 107;
					case 107:
						VxbYdPhApxNejATjuLl(cGS30yB0Pj, bool_0: true);
						goto case 158;
					case 158:
						yp69SuhZeAqyscAADpL(DPw37JniIN, bool_0: true);
						goto case 52;
					case 166:
						G8xatLh82B29wSpBLk2(this, new EventHandler(dUZ3dtZcii));
						num2 = 81;
						if (!u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 98;
					case 98:
						IyjhiQhp9CaFGvZGj16(this, bool_0: false);
						goto case 50;
					case 50:
						iD05gChCScPgy1C2PEW(this);
						num2 = 148;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 164:
						pqGuCdhwA3mYMjtfkVr(cGS30yB0Pj, "");
						num2 = 69;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 60;
					case 60:
						GSxhcKrNhWnIHahRQrd(MLP3QaBOKy, new Point(-2, 251));
						goto case 40;
					case 40:
						SQOlHkrco07h1UX8Hcl(MLP3QaBOKy, new Padding(4, 0, 4, 0));
						goto case 81;
					case 163:
						cm2rcNrxINT5E45VKhG(YrL3RP1SY4, UJCOdqrqYdxMO8gXxrg(1660));
						goto case 153;
					case 153:
						WbkeV1r8Nk8eHRqb6b0(YrL3RP1SY4.get_ShadowDecoration(), YrL3RP1SY4);
						num2 = 15;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 15;
					case 15:
						uk4YSPrsUPEYRZj7eqH(YrL3RP1SY4, new Size(68, 45));
						num2 = 14;
						if (!u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 144;
					case 144:
						((Control)YrL3RP1SY4).set_TabIndex(34);
						goto case 175;
					case 162:
						((TextBoxState)BkI6yoh0mYXs1qtQsDK(cGS30yB0Pj)).set_BorderColor(zUA5jaht5Z4aiyoMm7U(94, 148, 255));
						goto case 114;
					case 114:
						FvjdABhqP5GjOxAnP8e(BkI6yoh0mYXs1qtQsDK(cGS30yB0Pj), cGS30yB0Pj);
						goto case 154;
					case 154:
						((TextBox)cGS30yB0Pj).set_ForeColor(O1oQR7h7lwP7AL0ARhe());
						goto case 82;
					case 82:
						VyRMjGhHaxH0jIaEgOg(zkMxnBhdrWArpdiH73j(cGS30yB0Pj), zUA5jaht5Z4aiyoMm7U(94, 148, 255));
						goto case 79;
					case 79:
						((TextBoxState)zkMxnBhdrWArpdiH73j(cGS30yB0Pj)).set_Parent((TextBox)(object)cGS30yB0Pj);
						goto case 64;
					case 64:
						GSxhcKrNhWnIHahRQrd(cGS30yB0Pj, new Point(68, 119));
						goto case 134;
					case 134:
						SQOlHkrco07h1UX8Hcl(cGS30yB0Pj, new Padding(6));
						num2 = 80;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 161:
						cm2rcNrxINT5E45VKhG(uG53L7Ccaw, UJCOdqrqYdxMO8gXxrg(526));
						num2 = 113;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto case 106;
					case 106:
						IhA5EKhTIMIlI56HcHM(cGS30yB0Pj, UJCOdqrqYdxMO8gXxrg(546));
						num2 = 180;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 157:
						hYrj4hhn2FYWXUBpZv8(this, new Size(479, 288));
						goto case 85;
					case 85:
						((ControlCollection)s8vTNYhNhm3LY5A7kHi(this)).Add((Control)(object)eyk3wRDhtd);
						num2 = 0;
						if (sun0kyrhwnAoddFPkoh() != null)
						{
							continue;
						}
						goto case 12;
					case 12:
						ukNDoihckry6rys1XPD(s8vTNYhNhm3LY5A7kHi(this), zF63nsRwSP);
						goto case 18;
					case 18:
						ukNDoihckry6rys1XPD(s8vTNYhNhm3LY5A7kHi(this), a0t3cjIER9);
						num2 = 33;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 152:
						aU8uHbr10Y8mMIUogve(swM3XnBYWJ, uG53L7Ccaw, (DecorationType)0);
						num = 124;
						goto case 124;
					case 124:
						((TextBox)uG53L7Ccaw).set_DefaultText((string)UJCOdqrqYdxMO8gXxrg(506));
						goto case 41;
					case 41:
						((TextBoxState)MkWejyhMu5ff0TY1ueL(uG53L7Ccaw)).set_BorderColor(zUA5jaht5Z4aiyoMm7U(208, 208, 208));
						goto case 174;
					case 150:
						GSxhcKrNhWnIHahRQrd(YrL3RP1SY4, new Point(410, 4));
						goto case 135;
					case 135:
						SQOlHkrco07h1UX8Hcl(YrL3RP1SY4, new Padding(4, 5, 4, 5));
						num2 = 109;
						if (sun0kyrhwnAoddFPkoh() != null)
						{
							continue;
						}
						goto case 163;
					case 147:
						uk4YSPrsUPEYRZj7eqH(cGS30yB0Pj, new Size(354, 46));
						num = 167;
						goto case 167;
					case 146:
						ukNDoihckry6rys1XPD(s8vTNYhNhm3LY5A7kHi(this), uG53L7Ccaw);
						num2 = 68;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 143:
						((Control)this).set_Text((string)UJCOdqrqYdxMO8gXxrg(3056));
						goto case 166;
					case 140:
						((Control)this).set_Name(XaXlykERDhtdRwMnBY.oXbWkAhpNa(3110));
						goto case 28;
					case 28:
						nS6YaLhQMEW0jNKpQpX(this, (FormStartPosition)1);
						num2 = 91;
						if (sun0kyrhwnAoddFPkoh() != null)
						{
							continue;
						}
						goto case 143;
					case 139:
						goto IL_0beb;
					case 39:
						goto IL_0bf6;
					case 17:
						goto IL_0c01;
					case 138:
						((ShadowDecoration)xR33AJh68rBcVeJhE6P(zF63nsRwSP)).set_Parent((Control)(object)zF63nsRwSP);
						num = 120;
						goto case 120;
					case 120:
						uk4YSPrsUPEYRZj7eqH(zF63nsRwSP, new Size(382, 41));
						goto case 182;
					case 137:
						aU8uHbr10Y8mMIUogve(swM3XnBYWJ, zF63nsRwSP, (DecorationType)0);
						goto case 63;
					case 63:
						rtmMlnh4xqpQAtj8K9D(zF63nsRwSP, Color.DarkRed);
						goto case 45;
					case 45:
						DLALFchJIO73ElJyT3O(zF63nsRwSP, Color.Empty);
						goto case 172;
					case 136:
						goto IL_0c83;
					case 53:
						goto IL_0c99;
					case 23:
						goto IL_0cb3;
					case 13:
						goto IL_0cc4;
					case 91:
						goto IL_0ccf;
					case 127:
						goto IL_0cda;
					case 130:
						goto IL_0cee;
					case 133:
						bvm8DghBUptUFsrAQkh(val, new Padding(50));
						goto case 22;
					case 22:
						MBTvZhhWIeF2MQZLZTv(val, 1f);
						num = 54;
						goto case 54;
					case 54:
						J30HpchrjaqZDGcypsj(val, 0f);
						goto case 5;
					case 5:
						val.set_ScaleCoeff((PointF)OUSmkXrkp8bxUNf5R9P(componentResourceManager, XaXlykERDhtdRwMnBY.oXbWkAhpNa(2964)));
						num2 = 119;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto case 46;
					case 132:
						lY9kZVh2PvJglR8FaJE(cGS30yB0Pj, O1oQR7h7lwP7AL0ARhe());
						goto case 88;
					case 88:
						((Control)cGS30yB0Pj).set_Cursor((Cursor)HrSCyghomXQLT3hsJmK());
						num2 = 131;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto case 19;
					case 19:
						((SiticoneTextBox)uG53L7Ccaw).set_BorderColor(O1oQR7h7lwP7AL0ARhe());
						goto case 55;
					case 55:
						bouUgahXAesHiMnQM37(uG53L7Ccaw, Cursors.get_IBeam());
						num2 = 152;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 131:
						aU8uHbr10Y8mMIUogve(swM3XnBYWJ, cGS30yB0Pj, (DecorationType)0);
						num = 106;
						goto case 106;
					case 128:
						((Control)uG53L7Ccaw).set_Location(new Point(68, 60));
						num2 = 26;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 126:
						eTeFSWh5atR4eEWLwvU(MLP3QaBOKy, t2lApMrRHtB3qamD9yH());
						goto case 60;
					case 125:
						JXjxMUr6L5VhMl3hHfc(YrL3RP1SY4, 10);
						num2 = 49;
						if (!u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 57;
					case 57:
						((Animator)swM3XnBYWJ).SetDecoration((Control)(object)YrL3RP1SY4, (DecorationType)0);
						goto case 83;
					case 83:
						pOC3plrCeZB3lJVlK2Y(YrL3RP1SY4, kc7H5GrmLeqm9ruBm8g());
						num2 = 29;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 119:
						CGauJChhjG98yjUilSv(val, (PointF)OUSmkXrkp8bxUNf5R9P(componentResourceManager, UJCOdqrqYdxMO8gXxrg(3010)));
						num2 = 105;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 118:
						((Control)eyk3wRDhtd).add_Click((EventHandler)i3P3IbhHci);
						num2 = 67;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 116:
						((ShadowDecoration)pYjVM3hiPWnST7u0wS0(uG53L7Ccaw)).set_Parent((Control)(object)uG53L7Ccaw);
						num2 = 87;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 115:
						NFEsyqha1jAhRqkeoAR(cGS30yB0Pj, '*');
						goto case 164;
					case 113:
						((TextBox)uG53L7Ccaw).set_PasswordChar('\0');
						num2 = 78;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 109:
						ukNDoihckry6rys1XPD(((Control)this).get_Controls(), DPw37JniIN);
						goto case 145;
					case 108:
						((ControlBoxState)GstcpSrfwr8Sp4Zhaaa(YrL3RP1SY4)).set_IconColor(Color.White);
						goto case 173;
					case 105:
						val.set_TimeCoeff(0f);
						goto case 24;
					case 24:
						iH68kXhjW90cHkp5YmW(val, 1f);
						num = 95;
						goto case 95;
					case 95:
						RctpMahOkKCfy9isaRp(swM3XnBYWJ, val);
						num2 = 71;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 103:
						eyk3wRDhtd = new SiticoneRoundedGradientButton();
						goto case 2;
					case 2:
						xgIe9Dry2JnNYvBBjZX(this);
						num2 = 35;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 10;
					case 102:
						zF63nsRwSP = new SiticoneRoundedGradientButton();
						goto case 103;
					case 99:
						WbkeV1r8Nk8eHRqb6b0(xR33AJh68rBcVeJhE6P(eyk3wRDhtd), eyk3wRDhtd);
						num2 = 74;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 97:
						((TextBox)uG53L7Ccaw).set_SelectedText("");
						goto case 116;
					case 96:
						cm2rcNrxINT5E45VKhG(zF63nsRwSP, UJCOdqrqYdxMO8gXxrg(724));
						num2 = 138;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 87:
						((Control)uG53L7Ccaw).set_Size(new Size(354, 46));
						goto case 34;
					case 34:
						((Control)uG53L7Ccaw).set_TabIndex(41);
						num2 = 42;
						if (!u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 70;
					case 84:
						((ShadowDecoration)pYjVM3hiPWnST7u0wS0(cGS30yB0Pj)).set_Parent((Control)(object)cGS30yB0Pj);
						num2 = 147;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_0cda;
					case 80:
						cm2rcNrxINT5E45VKhG(cGS30yB0Pj, UJCOdqrqYdxMO8gXxrg(566));
						goto case 115;
					case 78:
						pqGuCdhwA3mYMjtfkVr(uG53L7Ccaw, "");
						num2 = 97;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 77:
						((Control)a0t3cjIER9).set_Size(new Size(68, 45));
						num2 = 66;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto case 54;
					case 75:
						movfOuhFi3kZDoDJ3o0(val, (PointF)componentResourceManager.GetObject(XaXlykERDhtdRwMnBY.oXbWkAhpNa(2916)));
						num2 = 20;
						if (sun0kyrhwnAoddFPkoh() != null)
						{
							continue;
						}
						goto case 30;
					case 30:
						val.set_MosaicSize(0);
						goto case 133;
					case 74:
						uk4YSPrsUPEYRZj7eqH(eyk3wRDhtd, new Size(382, 41));
						goto case 14;
					case 14:
						HhAxLCrpJAwHET3wJuG(eyk3wRDhtd, 43);
						num2 = 16;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 73:
						kYaiCDhVkMih5IoM02X(VJ30kKh9bHDDH000eV4(zF63nsRwSP), zF63nsRwSP);
						goto case 36;
					case 36:
						GSxhcKrNhWnIHahRQrd(zF63nsRwSP, new Point(49, 185));
						goto case 96;
					case 71:
						BYaoSvhIIYIrRKdU9E2(uG53L7Ccaw, bool_0: true);
						goto case 19;
					case 69:
						fEgVbEhvWj8B8PFNYHF(cGS30yB0Pj, "");
						num2 = 84;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto case 21;
					case 68:
						ukNDoihckry6rys1XPD(s8vTNYhNhm3LY5A7kHi(this), cGS30yB0Pj);
						num2 = 109;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 67:
						((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
						goto case 178;
					case 66:
						HhAxLCrpJAwHET3wJuG(a0t3cjIER9, 35);
						goto case 65;
					case 65:
						mvI8DVr9UDlKfy0bmgP(YrL3RP1SY4, (AnchorStyles)9);
						goto case 125;
					case 59:
						aU8uHbr10Y8mMIUogve(swM3XnBYWJ, MLP3QaBOKy, (DecorationType)0);
						num = 38;
						goto case 38;
					case 38:
						iaCQPmhef4fyWDR1lrA(MLP3QaBOKy, (object)new Font((string)UJCOdqrqYdxMO8gXxrg(614), 10f));
						goto case 126;
					case 58:
						yp69SuhZeAqyscAADpL(MLP3QaBOKy, bool_0: true);
						goto case 59;
					case 48:
						cm2rcNrxINT5E45VKhG(eyk3wRDhtd, UJCOdqrqYdxMO8gXxrg(808));
						goto case 99;
					case 33:
						((ControlCollection)s8vTNYhNhm3LY5A7kHi(this)).Add((Control)(object)YrL3RP1SY4);
						num2 = 146;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 32:
						HhAxLCrpJAwHET3wJuG(DPw37JniIN, 38);
						num2 = 1;
						if (sun0kyrhwnAoddFPkoh() == null)
						{
							continue;
						}
						goto IL_00cf;
					case 31:
						GSxhcKrNhWnIHahRQrd(eyk3wRDhtd, new Point(49, 232));
						num2 = 48;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 29:
						cWKlqEr3HXKboqJVEpd(GstcpSrfwr8Sp4Zhaaa(YrL3RP1SY4), Color.FromArgb(232, 17, 35));
						num2 = 108;
						if (u9XTnSrrytnajiXyeg7())
						{
							continue;
						}
						goto IL_00cf;
					case 26:
						SQOlHkrco07h1UX8Hcl(uG53L7Ccaw, new Padding(6));
						goto case 161;
					case 20:
						((Control)zF63nsRwSP).set_ForeColor(t2lApMrRHtB3qamD9yH());
						goto case 73;
					case 16:
						((Control)eyk3wRDhtd).set_Text((string)UJCOdqrqYdxMO8gXxrg(788));
						goto case 118;
					case 9:
						UwDfR8hRRkjQRw4sfA6(this, Color.Black);
						goto case 157;
					case 7:
						uIgZJEhyRv2T6WLnU0j(((SiticoneGradientButton)zF63nsRwSP).get_CustomImages(), zF63nsRwSP);
						goto case 137;
					case 1:
						NwoSvWhggdqxLok7ZGR(DPw37JniIN, UJCOdqrqYdxMO8gXxrg(3056));
						goto case 58;
					case 122:
						goto IL_16e2;
					case 123:
						goto end_IL_16e2;
					case 148:
						return;
					}
					break;
				}
				goto IL_0387;
				IL_0c83:
				componentResourceManager = new ComponentResourceManager(r6D9mPrV4lak1BikGmp(dFuuTlrgQjICwPaGlJu(33554439)));
				goto IL_0c99;
				IL_0c99:
				byn3jAUCJD = new Timer(fft3Anw7dX);
				num = 23;
				goto IL_0cb3;
				IL_0cb3:
				r0f31acOaX = new SiticoneDragControl(fft3Anw7dX);
				goto IL_0cc4;
				IL_0cc4:
				a0t3cjIER9 = new SiticoneControlBox();
				goto IL_0ccf;
				IL_0ccf:
				YrL3RP1SY4 = new SiticoneControlBox();
				goto IL_0cda;
				IL_0cda:
				swM3XnBYWJ = new SiticoneTransition();
				num = 130;
				goto IL_0cee;
				IL_0cee:
				uG53L7Ccaw = new SiticoneRoundedTextBox();
				num2 = 6;
				if (sun0kyrhwnAoddFPkoh() == null)
				{
					goto IL_0beb;
				}
				goto IL_13f0;
				IL_0beb:
				cGS30yB0Pj = new SiticoneRoundedTextBox();
				goto IL_0bf6;
				IL_0bf6:
				DPw37JniIN = new Label();
				goto IL_0c01;
				IL_0c01:
				MLP3QaBOKy = new Label();
				goto IL_0387;
				IL_0387:
				LPH3g1a50Q = new SiticoneShadowForm(fft3Anw7dX);
				num2 = 102;
				if (!u9XTnSrrytnajiXyeg7())
				{
					goto IL_00cf;
				}
				goto IL_13f0;
				IL_00cf:
				num2 = num;
				goto IL_13f0;
				continue;
				end_IL_16e2:
				break;
			}
		}
	}

	internal static void lQTlMsrjqIKcEdgq1YG()
	{
		XaXlykERDhtdRwMnBY.jXRWMU6APG();
	}

	internal static void aKWxkvrO90nBvMcDJMN()
	{
		zB3PVH9hASM2TtLqpf.unC5KZCzPQ9Xt();
	}

	internal static bool u9XTnSrrytnajiXyeg7()
	{
		return rCI0YMrWfAnqLit022g == null;
	}

	internal static Login sun0kyrhwnAoddFPkoh()
	{
		return rCI0YMrWfAnqLit022g;
	}

	internal static Point HZ5VJVrIJXXBmL75BYr(object object_0)
	{
		return ((Form)object_0).get_Location();
	}

	internal static int JF6Krbr7RPRsQmyyOsU(object object_0)
	{
		return ((MouseEventArgs)object_0).get_Y();
	}

	internal static void miyMxfrXqPFXjrqh6No(object object_0, Point point_0)
	{
		((Form)object_0).set_Location(point_0);
	}

	internal static void jaA5oTrMlxYIDyyecCG(object object_0)
	{
		((Control)object_0).Update();
	}

	internal static void N0LI2Frt8CHNh4LMC0i(object object_0)
	{
		((Control)object_0).Hide();
	}

	internal static DialogResult HkC1PTrDCFlB8dViBc9(object object_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((Form)object_0).ShowDialog();
	}

	internal static void tkb46frGQI6OptrKdV3(object object_0)
	{
		((Form)object_0).Close();
	}

	internal static object UJCOdqrqYdxMO8gXxrg(int int_0)
	{
		return XaXlykERDhtdRwMnBY.oXbWkAhpNa(int_0);
	}

	internal static object S3lAvRrE5115DTo5U9f(object object_0, object object_1)
	{
		return ((RegistryKey)object_0).OpenSubKey((string)object_1);
	}

	internal static void HvcsberY4m1Meli24NQ()
	{
		Application.Exit();
	}

	internal static void AXFXKJr0by0Oi9SuqO7(int int_0)
	{
		Environment.Exit(int_0);
	}

	internal static object SdIAsBrHmBtCNw055FF()
	{
		return Process.GetProcesses();
	}

	internal static object UoaeB6rPpxomIIONvPs(object object_0)
	{
		return ((Process)object_0).MainWindowTitle;
	}

	internal static bool fb0ha9rdkRxpkf8Mw6g(object object_0, object object_1)
	{
		return ((string)object_0).Contains((string)object_1);
	}

	internal static object Qkjhemrwuv65MoffJ9Q(object object_0)
	{
		return Process.GetProcessesByName((string?)object_0);
	}

	internal static bool YaKI7HrixrshpxFIVAn(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object zvxFEcr2eWr6TfMx3tS(object object_0)
	{
		return ((TextReader)object_0).ReadLine();
	}

	internal static void mRYQcKro2HflW3V5qbV(object object_0)
	{
		((Timer)object_0).Start();
	}

	internal static object MW7MgJrTZTqfKNFoAVS(object object_0)
	{
		return ((TextBox)object_0).get_Text();
	}

	internal static bool lstTktraH5GEIHwIcsC(object object_0, object object_1)
	{
		return snvDE3LFc7xuQSJqWC.Login(object_0, object_1);
	}

	internal static object RqEPy3rvLjGtCVPcpYM()
	{
		return Encoding.UTF8;
	}

	internal static void E353e0rl50mckJp4wr6(object object_0, object object_1)
	{
		((TextWriter)object_0).WriteLine((string?)object_1);
	}

	internal static void JwjfdIrA0LeM9j67xvh(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static void eJm8eWrZyEI8iMx5xIk(object object_0)
	{
		((Stream)object_0).Dispose();
	}

	internal static void AkpEQyrewYqJaG0Lv6Z(object object_0)
	{
		File.Delete((string)object_0);
	}

	internal static DialogResult xUIlCGrLPNAyoNyP6ua(object object_0, object object_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show((string)object_0, (string)object_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	internal static void ddWtqlr50vKoe2t3QhG(object object_0, bool bool_0)
	{
		((Form)object_0).Dispose(bool_0);
	}

	internal static RuntimeTypeHandle dFuuTlrgQjICwPaGlJu(int token)
	{
		return aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(token);
	}

	internal static Type r6D9mPrV4lak1BikGmp(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void xgIe9Dry2JnNYvBBjZX(object object_0)
	{
		((Control)object_0).SuspendLayout();
	}

	internal static void ApeCIsr4uuxjs0pVK78(object object_0, object object_1)
	{
		((Timer)object_0).add_Tick((EventHandler)object_1);
	}

	internal static void GIDLbqrJkm9BVJHMueq(object object_0, object object_1)
	{
		((SiticoneDragControl)object_0).set_TargetControl((Control)object_1);
	}

	internal static void mvI8DVr9UDlKfy0bmgP(object object_0, AnchorStyles anchorStyles_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Anchor(anchorStyles_0);
	}

	internal static void JXjxMUr6L5VhMl3hHfc(object object_0, int int_0)
	{
		((SiticoneControlBox)object_0).set_BorderRadius(int_0);
	}

	internal static void aU8uHbr10Y8mMIUogve(object object_0, object object_1, DecorationType decorationType_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((Animator)object_0).SetDecoration((Control)object_1, decorationType_0);
	}

	internal static Color kc7H5GrmLeqm9ruBm8g()
	{
		return Color.Black;
	}

	internal static object GstcpSrfwr8Sp4Zhaaa(object object_0)
	{
		return ((SiticoneControlBox)object_0).get_HoveredState();
	}

	internal static void OdWfmprSpVDpBeMULT7(object object_0, object object_1)
	{
		((ControlBoxState)object_0).set_Parent((ControlBox)object_1);
	}

	internal static Color t2lApMrRHtB3qamD9yH()
	{
		return Color.White;
	}

	internal static void VR4Yy0rn5CDMoWZkF2r(object object_0, Color color_0)
	{
		((SiticoneControlBox)object_0).set_IconColor(color_0);
	}

	internal static void GSxhcKrNhWnIHahRQrd(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static void SQOlHkrco07h1UX8Hcl(object object_0, Padding padding_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Margin(padding_0);
	}

	internal static void cm2rcNrxINT5E45VKhG(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static object mvvhU6rQKRleuf1Jo27(object object_0)
	{
		return ((SiticoneControlBox)object_0).get_ShadowDecoration();
	}

	internal static void WbkeV1r8Nk8eHRqb6b0(object object_0, object object_1)
	{
		((ShadowDecoration)object_0).set_Parent((Control)object_1);
	}

	internal static void HhAxLCrpJAwHET3wJuG(object object_0, int int_0)
	{
		((Control)object_0).set_TabIndex(int_0);
	}

	internal static void pOC3plrCeZB3lJVlK2Y(object object_0, Color color_0)
	{
		((SiticoneControlBox)object_0).set_FillColor(color_0);
	}

	internal static void cWKlqEr3HXKboqJVEpd(object object_0, Color color_0)
	{
		((ControlBoxState)object_0).set_FillColor(color_0);
	}

	internal static void uk4YSPrsUPEYRZj7eqH(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void YSxQu7rUINaLEUq3WbS(object object_0, object object_1)
	{
		((Control)object_0).add_Click((EventHandler)object_1);
	}

	internal static void ysupHwrKyQmTJb6BsW5(object object_0, AnimationType animationType_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Animator)object_0).set_AnimationType(animationType_0);
	}

	internal static object OUSmkXrkp8bxUNf5R9P(object object_0, object object_1)
	{
		return ((ResourceManager)object_0).GetObject((string)object_1);
	}

	internal static void S37GWQrbNgOcqttrU9u(object object_0, PointF pointF_0)
	{
		((Animation)object_0).set_BlindCoeff(pointF_0);
	}

	internal static void EupRW6ruNuN56jYbN6G(object object_0, float float_0)
	{
		((Animation)object_0).set_LeafCoeff(float_0);
	}

	internal static void iHEqvLrzKaehopWE6JY(object object_0, PointF pointF_0)
	{
		((Animation)object_0).set_MosaicCoeff(pointF_0);
	}

	internal static void movfOuhFi3kZDoDJ3o0(object object_0, PointF pointF_0)
	{
		((Animation)object_0).set_MosaicShift(pointF_0);
	}

	internal static void bvm8DghBUptUFsrAQkh(object object_0, Padding padding_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Animation)object_0).set_Padding(padding_0);
	}

	internal static void MBTvZhhWIeF2MQZLZTv(object object_0, float float_0)
	{
		((Animation)object_0).set_RotateCoeff(float_0);
	}

	internal static void J30HpchrjaqZDGcypsj(object object_0, float float_0)
	{
		((Animation)object_0).set_RotateLimit(float_0);
	}

	internal static void CGauJChhjG98yjUilSv(object object_0, PointF pointF_0)
	{
		((Animation)object_0).set_SlideCoeff(pointF_0);
	}

	internal static void iH68kXhjW90cHkp5YmW(object object_0, float float_0)
	{
		((Animation)object_0).set_TransparencyCoeff(float_0);
	}

	internal static void RctpMahOkKCfy9isaRp(object object_0, object object_1)
	{
		((Animator)object_0).set_DefaultAnimation((Animation)object_1);
	}

	internal static void BYaoSvhIIYIrRKdU9E2(object object_0, bool bool_0)
	{
		((Control)object_0).set_AllowDrop(bool_0);
	}

	internal static Color O1oQR7h7lwP7AL0ARhe()
	{
		return Color.Red;
	}

	internal static void bouUgahXAesHiMnQM37(object object_0, object object_1)
	{
		((Control)object_0).set_Cursor((Cursor)object_1);
	}

	internal static object MkWejyhMu5ff0TY1ueL(object object_0)
	{
		return ((SiticoneTextBox)object_0).get_DisabledState();
	}

	internal static Color zUA5jaht5Z4aiyoMm7U(int int_0, int int_1, int int_2)
	{
		return Color.FromArgb(int_0, int_1, int_2);
	}

	internal static void J9yTDDhDUOZSKlF9prH(object object_0, Color color_0)
	{
		((TextBoxState)object_0).set_FillColor(color_0);
	}

	internal static void dZX6ZZhGVJa3MalErro(object object_0, Color color_0)
	{
		((TextBoxState)object_0).set_ForeColor(color_0);
	}

	internal static void FvjdABhqP5GjOxAnP8e(object object_0, object object_1)
	{
		((TextBoxState)object_0).set_Parent((TextBox)object_1);
	}

	internal static void tkTWKxhEsT3WWLH4qB9(object object_0, Color color_0)
	{
		((TextBoxState)object_0).set_PlaceholderForeColor(color_0);
	}

	internal static void UAXTQwhYeK9QIihQ92a(object object_0, Color color_0)
	{
		((SiticoneTextBox)object_0).set_FillColor(color_0);
	}

	internal static object BkI6yoh0mYXs1qtQsDK(object object_0)
	{
		return ((SiticoneTextBox)object_0).get_FocusedState();
	}

	internal static void VyRMjGhHaxH0jIaEgOg(object object_0, Color color_0)
	{
		((TextBoxState)object_0).set_BorderColor(color_0);
	}

	internal static void UYVJ48hP3MTHDEIYN5E(object object_0, Color color_0)
	{
		((TextBox)object_0).set_ForeColor(color_0);
	}

	internal static object zkMxnBhdrWArpdiH73j(object object_0)
	{
		return ((SiticoneTextBox)object_0).get_HoveredState();
	}

	internal static void pqGuCdhwA3mYMjtfkVr(object object_0, object object_1)
	{
		((SiticoneTextBox)object_0).set_PlaceholderText((string)object_1);
	}

	internal static object pYjVM3hiPWnST7u0wS0(object object_0)
	{
		return ((SiticoneTextBox)object_0).get_ShadowDecoration();
	}

	internal static void lY9kZVh2PvJglR8FaJE(object object_0, Color color_0)
	{
		((SiticoneTextBox)object_0).set_BorderColor(color_0);
	}

	internal static object HrSCyghomXQLT3hsJmK()
	{
		return Cursors.get_IBeam();
	}

	internal static void IhA5EKhTIMIlI56HcHM(object object_0, object object_1)
	{
		((TextBox)object_0).set_DefaultText((string)object_1);
	}

	internal static void NFEsyqha1jAhRqkeoAR(object object_0, char char_0)
	{
		((TextBox)object_0).set_PasswordChar(char_0);
	}

	internal static void fEgVbEhvWj8B8PFNYHF(object object_0, object object_1)
	{
		((TextBox)object_0).set_SelectedText((string)object_1);
	}

	internal static void sGAxuahlG1FalWImkdA(object object_0, HorizontalAlignment horizontalAlignment_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TextBox)object_0).set_TextAlign(horizontalAlignment_0);
	}

	internal static void VxbYdPhApxNejATjuLl(object object_0, bool bool_0)
	{
		((TextBox)object_0).set_UseSystemPasswordChar(bool_0);
	}

	internal static void yp69SuhZeAqyscAADpL(object object_0, bool bool_0)
	{
		((Control)object_0).set_AutoSize(bool_0);
	}

	internal static void iaCQPmhef4fyWDR1lrA(object object_0, object object_1)
	{
		((Control)object_0).set_Font((Font)object_1);
	}

	internal static Color O1noUphLGTsrxPpoOVO()
	{
		return SystemColors.ButtonFace;
	}

	internal static void eTeFSWh5atR4eEWLwvU(object object_0, Color color_0)
	{
		((Control)object_0).set_ForeColor(color_0);
	}

	internal static void NwoSvWhggdqxLok7ZGR(object object_0, object object_1)
	{
		((Control)object_0).set_Text((string)object_1);
	}

	internal static void kYaiCDhVkMih5IoM02X(object object_0, object object_1)
	{
		((ButtonState)object_0).set_Parent((CustomButtonBase)object_1);
	}

	internal static void uIgZJEhyRv2T6WLnU0j(object object_0, object object_1)
	{
		((ButtonImages)object_0).set_Parent((CustomButtonBase)object_1);
	}

	internal static void rtmMlnh4xqpQAtj8K9D(object object_0, Color color_0)
	{
		((SiticoneGradientButton)object_0).set_FillColor(color_0);
	}

	internal static void DLALFchJIO73ElJyT3O(object object_0, Color color_0)
	{
		((SiticoneGradientButton)object_0).set_FillColor2(color_0);
	}

	internal static object VJ30kKh9bHDDH000eV4(object object_0)
	{
		return ((SiticoneGradientButton)object_0).get_HoveredState();
	}

	internal static object xR33AJh68rBcVeJhE6P(object object_0)
	{
		return ((SiticoneGradientButton)object_0).get_ShadowDecoration();
	}

	internal static object f1MyI1h1MvbsSomlpjZ(object object_0)
	{
		return ((SiticoneGradientButton)object_0).get_CheckedState();
	}

	internal static object yjXCFBhmPCQkib5BMDl(object object_0)
	{
		return ((SiticoneGradientButton)object_0).get_CustomImages();
	}

	internal static Color Ye434LhfBj4kRX6mUai()
	{
		return Color.DarkRed;
	}

	internal static void pP2xephSQc7IPT3vSvF(object object_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)object_0).set_AutoScaleMode(autoScaleMode_0);
	}

	internal static void UwDfR8hRRkjQRw4sfA6(object object_0, Color color_0)
	{
		((Control)object_0).set_BackColor(color_0);
	}

	internal static void hYrj4hhn2FYWXUBpZv8(object object_0, Size size_0)
	{
		((Form)object_0).set_ClientSize(size_0);
	}

	internal static object s8vTNYhNhm3LY5A7kHi(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static void ukNDoihckry6rys1XPD(object object_0, object object_1)
	{
		((ControlCollection)object_0).Add((Control)object_1);
	}

	internal static void j0y0bYhx4wVZ00M1ZnL(object object_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Form)object_0).set_FormBorderStyle(formBorderStyle_0);
	}

	internal static void nS6YaLhQMEW0jNKpQpX(object object_0, FormStartPosition formStartPosition_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Form)object_0).set_StartPosition(formStartPosition_0);
	}

	internal static void G8xatLh82B29wSpBLk2(object object_0, object object_1)
	{
		((Form)object_0).add_Load((EventHandler)object_1);
	}

	internal static void IyjhiQhp9CaFGvZGj16(object object_0, bool bool_0)
	{
		((Control)object_0).ResumeLayout(bool_0);
	}

	internal static void iD05gChCScPgy1C2PEW(object object_0)
	{
		((Control)object_0).PerformLayout();
	}
}
