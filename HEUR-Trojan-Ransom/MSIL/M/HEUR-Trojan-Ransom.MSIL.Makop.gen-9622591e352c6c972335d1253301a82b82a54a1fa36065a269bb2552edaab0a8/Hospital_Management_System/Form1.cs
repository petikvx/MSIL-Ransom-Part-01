using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class Form1 : Form
{
	public enum ScreenSize
	{
		Small,
		Middle,
		Large,
		Extra
	}

	public string provider;

	public string datafile;

	public string username;

	public int Current_tokenNo;

	public int Current_RoomNo;

	public string login_type;

	public decimal cur_blood_amount;

	public int blood_available_id;

	private OleDbConnection myconnection;

	private Size smallSize;

	private Size middleSize;

	private Size largeSize;

	private IContainer components;

	internal SwitchValueState SwitchValueState;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PasswordTxt")]
	internal virtual TextBox PasswordTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UsernameTxt")]
	internal virtual TextBox UsernameTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button loginBtn
	{
		[CompilerGenerated]
		get
		{
			return _loginBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = loginBtn_Click;
			Button val = _loginBtn;
			while (true)
			{
				int num = 1243516944;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x328F421Du) % 8u)
					{
					case 7u:
						val = _loginBtn;
						num = ((int)num2 * -1713255883) ^ -2128513833;
						continue;
					case 6u:
						Form1.smethod_100((Control)(object)val, eventHandler_);
						num = (int)((num2 * 1527352496) ^ 0x389FDDFF);
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -462262988;
							num6 = -462262988;
						}
						else
						{
							num5 = -1165605264;
							num6 = -1165605264;
						}
						num = num5 ^ ((int)num2 * -65053481);
						continue;
					}
					case 4u:
						Form1.smethod_101((Control)(object)val, eventHandler_);
						num = ((int)num2 * -1798757971) ^ 0x6FD12D1A;
						continue;
					case 2u:
						_loginBtn = value;
						num = 1262129850;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1182776609;
							num4 = 1182776609;
						}
						else
						{
							num3 = 1324756566;
							num4 = 1324756566;
						}
						num = num3 ^ (int)(num2 * 1155434976);
						continue;
					}
					default:
						return;
					case 0u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual Button ExitBtn
	{
		[CompilerGenerated]
		get
		{
			return _ExitBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = ExitBtn_Click;
			Button exitBtn = default(Button);
			while (true)
			{
				int num = 533597746;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7C090E6Cu) % 8u)
					{
					case 7u:
					{
						exitBtn = _ExitBtn;
						int num5;
						int num6;
						if (exitBtn == null)
						{
							num5 = 1628924264;
							num6 = 1628924264;
						}
						else
						{
							num5 = 1394431844;
							num6 = 1394431844;
						}
						num = num5 ^ ((int)num2 * -761183077);
						continue;
					}
					case 6u:
						exitBtn = _ExitBtn;
						num = ((int)num2 * -1855098419) ^ 0x4C9E5F0E;
						continue;
					case 5u:
						Form1.smethod_101((Control)(object)exitBtn, eventHandler_);
						num = (int)(num2 * 342080889) ^ -1758839528;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (exitBtn == null)
						{
							num3 = -1484186522;
							num4 = -1484186522;
						}
						else
						{
							num3 = -523315161;
							num4 = -523315161;
						}
						num = num3 ^ (int)(num2 * 909492054);
						continue;
					}
					case 3u:
						Form1.smethod_100((Control)(object)exitBtn, eventHandler_);
						num = (int)((num2 * 1947344487) ^ 0x2D58B91B);
						continue;
					case 2u:
						_ExitBtn = value;
						num = 2014117003;
						continue;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual RadioButton StaffRadioBtn
	{
		[CompilerGenerated]
		get
		{
			return _StaffRadioBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = StaffRadioBtn_CheckedChanged;
			RadioButton staffRadioBtn = default(RadioButton);
			while (true)
			{
				int num = -440807902;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCCC29924u) % 8u)
					{
					case 7u:
					{
						staffRadioBtn = _StaffRadioBtn;
						int num5;
						int num6;
						if (staffRadioBtn != null)
						{
							num5 = 2026480354;
							num6 = 2026480354;
						}
						else
						{
							num5 = 593657355;
							num6 = 593657355;
						}
						num = num5 ^ ((int)num2 * -1306424635);
						continue;
					}
					case 6u:
						staffRadioBtn = _StaffRadioBtn;
						num = ((int)num2 * -485958263) ^ 0x4D193B8;
						continue;
					case 5u:
						Form1.smethod_103(staffRadioBtn, eventHandler_);
						num = (int)(num2 * 877482331) ^ -191087201;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (staffRadioBtn != null)
						{
							num3 = 489509246;
							num4 = 489509246;
						}
						else
						{
							num3 = 1929808871;
							num4 = 1929808871;
						}
						num = num3 ^ ((int)num2 * -1614886595);
						continue;
					}
					case 1u:
						_StaffRadioBtn = value;
						num = -2045897541;
						continue;
					case 0u:
						Form1.smethod_102(staffRadioBtn, eventHandler_);
						num = ((int)num2 * -53090632) ^ 0x5CC80425;
						continue;
					default:
						return;
					case 3u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual RadioButton AdminRadioBtn
	{
		[CompilerGenerated]
		get
		{
			return _AdminRadioBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = AdminRadioBtn_CheckedChanged;
			RadioButton adminRadioBtn = _AdminRadioBtn;
			if (adminRadioBtn != null)
			{
				goto IL_0082;
			}
			goto IL_00b4;
			IL_00b4:
			_AdminRadioBtn = value;
			int num = 113723924;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10BC870Au) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (adminRadioBtn == null)
					{
						num3 = 270829563;
						num4 = 270829563;
					}
					else
					{
						num3 = 1747357454;
						num4 = 1747357454;
					}
					num = num3 ^ ((int)num2 * -40867385);
					continue;
				}
				case 5u:
					adminRadioBtn = _AdminRadioBtn;
					num = ((int)num2 * -1112919482) ^ -1709521599;
					continue;
				case 2u:
					Form1.smethod_102(adminRadioBtn, eventHandler_);
					num = (int)((num2 * 409996943) ^ 0x520D4359);
					continue;
				case 1u:
					Form1.smethod_103(adminRadioBtn, eventHandler_);
					num = ((int)num2 * -1873593481) ^ -1533881447;
					continue;
				case 0u:
					break;
				default:
					return;
				case 3u:
					goto IL_00b4;
				case 4u:
					return;
				}
				break;
			}
			goto IL_0082;
			IL_0082:
			num = 208781974;
			goto IL_0087;
		}
	}

	internal virtual CheckBox ShowPasswd
	{
		[CompilerGenerated]
		get
		{
			return _ShowPasswd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = ShowPasswd_CheckedChanged;
			CheckBox showPasswd = default(CheckBox);
			while (true)
			{
				int num = -1361816023;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC071DDBAu) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (showPasswd == null)
						{
							num5 = 212250805;
							num6 = 212250805;
						}
						else
						{
							num5 = 1167680110;
							num6 = 1167680110;
						}
						num = num5 ^ (int)(num2 * 1941709155);
						continue;
					}
					case 5u:
						Form1.smethod_105(showPasswd, eventHandler_);
						num = ((int)num2 * -1997597947) ^ 0x6D88780F;
						continue;
					case 3u:
						showPasswd = _ShowPasswd;
						num = (int)(num2 * 1599769353) ^ -1612060666;
						continue;
					case 2u:
						_ShowPasswd = value;
						showPasswd = _ShowPasswd;
						num = -1431217614;
						continue;
					case 1u:
						Form1.smethod_104(showPasswd, eventHandler_);
						num = ((int)num2 * -1643631414) ^ 0x1773FE7A;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (showPasswd != null)
						{
							num3 = 133410775;
							num4 = 133410775;
						}
						else
						{
							num3 = 1267250526;
							num4 = 1267250526;
						}
						num = num3 ^ (int)(num2 * 1045813779);
						continue;
					}
					default:
						return;
					case 6u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	public Form1()
	{
		while (true)
		{
			int num = 1852229396;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5506276u) % 10u)
				{
				case 9u:
					Form1.smethod_0((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 1577454432) ^ 0x410BD9D0);
					continue;
				case 8u:
					smallSize = new Size(800, 600);
					num = ((int)num2 * -727041809) ^ 0x37F7E890;
					continue;
				case 6u:
					myconnection = Form1.smethod_1();
					num = (int)((num2 * 1505406873) ^ 0x38FFCEA4);
					continue;
				case 5u:
					Current_tokenNo = 1;
					Current_RoomNo = 0;
					num = ((int)num2 * -1928674629) ^ 0x10E0F911;
					continue;
				case 4u:
					num = ((int)num2 * -892564515) ^ 0x66CC2F41;
					continue;
				case 2u:
					middleSize = new Size(1440, 900);
					num = ((int)num2 * -1239438455) ^ -1400248387;
					continue;
				case 1u:
					largeSize = new Size(1900, 1200);
					SwitchValueState = new SwitchValueState("7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ivvipP+nX+LV/jV/j1/h16P//9//9a/waf9evIc/vqT83PX8Q/f83+V3+nt/k1/jbfuyf/13/rl/z+T//u76ZF026qquLOluk02y5rNp0kqf1epkWy/Tpl6/TRTXLx7/xb5z8bgrj5emv8Ws8/zV/7V/jT/vP/7Hf38D9j36NX+t3/Q1/zd/g1/g1/iH649eTz/6D/4D+SU2L31N+/7UEbzzm56+R/pr8OZ5f+9f4Pf/wX+PX+M34f+6n/cHPn0Rwfy/88h/9Gh4Q//k1f43fKPbxTU/6a/wav4H3529Af3/b+3vc5u9a+vmf/QPSlseqeJuHPv4DxnVTT/EHcPuP9Oc/Erb7Pel/4zovK2oouCoN/oleuyfhJ9TtfyA/v/1r4JVf99cY0Tuz3+7XYJ74Os+vvfNr/xrH+nv6X9A/fzzh8mv+7v/Sr0uYb9GvyR9EE/rrpP8W/frH/7r8za9vv/kN8NtvQlP+rX+J/v71fuG36PWf+rW2aCTJr/3r/Lpbvx5/82vJN7/lzq/za1S/Bo/0N/+lAPkbf7L1G5yCWTDE+/T/RLEwv/9Lvzbe/B1/o0/+rV9KL/06vxTM80t/bXQJwOl/9Vt+9d3f9nf5TX5XM/Ct35Q+TX7sdzn709K/4q/9NX6N3+c3+uQv+vVawvDXRN+/1q9x9GswiX/zX/obcN/bv8EpjebX+C31ZfPg73/p10G/P/a7/E5/avof/wkM6F/9rZJfryUcfkcaIMbx6a/B9P7Nf9vf8NdnKOb5Lbz//1q/zZ/za/22f86v9dv9OYztb/cbfvKvfQs0ZSL9ljs/9msA3q9jaPFb/ga/w2/56//mv/4p4fZrnNH/39H/f7n+jucfov//H7+GyFZDPSfJr7f+jWlo6fwfpFn7t/4N+ue/pY/Tf5L+wdR8kv4d9G/619M/W78Tvfab/wbp30ev/mnm5+/zW/76n/xJv9avs/Vj9N1v+OuvaQp/zS2a1l/v194iDH6934ia/TNolv6t/xSN/7f89Q+y//v//r//pd8UrQjlJP1vQfrf6Xc1YsaUTzGzv9Vv9dv+8b8emOS3+Q1aIvbv+Jds0ZCTFm/+xr8jwfntCc6P8Z/p707fp2/oH7DLJ7/Lb/Ln/Ja/zm/+67S/Gb76cQxlhqHQ/z/5Hf+c3/LX/Z3o3X////q//+/f/Ndtfytq8dv8ceDR36qirpJf+NsA8+Rb/xLI/AuZmikR5ddwv/1p/Ovv8mN/2k+l/zv9+fv/Bd/6LXd+/V/jVxCIX9fS/zdltvgtf7NPXvzmv8kp4cdT/JfQ//9kavYbKvV/V/r9t6T/T35NGffDX1M++yW/hnz279PPP4X+Dwn59X7hb/9b/iaf/C2/TfJrpX8IfZT+NaATEe+T3/LX+y1+vfTPxOD/CAz+d8cM/DbU9I/89X99xiH944G8/e1P5V9/l+M/9Q9I/1Qg/+f/1O/wU7/Rb/DH//ag6G9DPPOb/i6jPy39lT+JafpNDn5PIu9v81v+BvTh7/unpe1PyIef0Ie/1m/+6//mv8HvsvO7LDEfn/yWP/Zb/Fj6b4HIfxqITDz/6/0uz3+XH9u6Q7/8Nj+2xsT9er9D+g8Ax/8TOP56mKDfmED9RzQFv97v8Hsnv/lv8Nv+3tTNb5aCQn9q+vespKd/GDP0G/z6/9ev81smv3my/Rv8TvTR30Af/S6/ySe/4jf/9emNX/93pE/+PDT69dHoN/zNf8PtH/tdfow++6PQ6jf85Ff8GDPNb5P+G2DefxvMS8Ly64ExeMC/5a/7O1Pj71FjQfJ3IHbgF/Tnn1CAfZPf/Df7XX7zPzU91uGPhG3w/W/5G/3mvxH/QlBJBn/dX+Mv+jVZpEQn/JaJsMJv+MmXv/mPMQ/8yzLNv8bfRP//n+j/vy01/xPp5wn9/zP6/Q/Qz34j/R6f/Wv08w8DD/wG4IHfJfktf+yTv/m3SdLfGMT8GMT8rSBm6S8E9U9BfeKVT37D3zxJ/xEm5T/8zwHrHzv4ASbt1/oTit/23/mTf5dV9hv95snvcvqnpv9lKl9+H1/Sd/+GsAE3IyL9hr/L9E9L/+l/W9o8ZFb4dX97+nX8fxuC/ea/7q/1m/+6f/JvkP36Msd/cva3/Xm/HTX4jakB4fQOOH0EnAj3T37bf+feb/Db0Jf/E+bmN/7kV/w2n/zav95v+28kv/mv+9v+G7/lr0t9/fZ/WnrwR0lf/zyT+Df/df6vX+u3+b9+zd/y1/vNf73t3/o3/w1F0aSvfkza/NXU5nf85H+VGSaMf7t/R9GHDkr409/4d/mNqOEfhOmV6SKNKNOFuYJg/fpWXn+dT/Z+jI3HK52jF/T/Gf3/t9LP/iWotl/4m/86v0v5p6Vvfg/C4Tf+5F/4tdP/mRTXb/fbhSYj/QhzU2Bufgya868HGf46kOG3pW+bBNr2d/yNP/mTfr3170zo/lrVbwh8oTF/w1+ff3xLbMIv/jVCm2Dswu8CxtCfbCtZe/52v+B3/U21ASPxB/2aEHj+5nf+XX+t4Bv669f57X/DT/7q9L+hb3/73+Z3/Q2Cb2EPv/UvJWJYHont/da/9BvK378fdwgt+uv9Qb8ON/yN+Ivfkmz+z/wa7O/85r/L76Jm/Te2Zp3e/nV+AX+a/Hq/U/p3/o6/xq/x5/96v2P68C5+/rbpX/AL8fO3T9/8bvj5O6S/xbfw87dLfydu99ukf9svwM/fOf3nqK8//3f446mPX/MPol9/nV/vD0qcu/AbMx6/I+nhu9Tljzk7KOb5t/mNfgNrWB92fv5Sav3rPIJ1/LHf5fBPTe//Fqouf5ffSH+IykyPCPCf+nun//mvAa1JRvyvh0j+WmzAfvdkizBKSD5+81+XuQjPA/r/76g/v63/5762f93f7rf8dT/5138s/RMAMf3b6Ivf55P//rf9g/DdFg0k+a3+r1/vtwar0NCSimYl+bH0X+Km1e8D5v91P/mz/4Pf6Ndb/2Zgdvon+fd+W7b16Pd30L5/B+//GDdp9k/+vX8JpPqFpLd/7E9Lf/9/iw3xJ//kt+TTb/0av+ZvBn+m+TXK/1BcSMjIDLPvbNonF2TMiDy/BvkHv8Yl/f8vJax+H0zxrym///n6GQzYP/BrihD9dr+GGLZ/n/7/6xK8X6kooi1cAMLoN03/gl8Dsv2vv2MV+8mf/Wul/zHxZvZrZ8kvBe/8Rr9BSyz3O/7uv96f+hv+er/d7/2n/vrZb0iv/EP8yr/yd4hWnpLK+aXgCnarfv0/53f/jUe/NTX6T7jRP/OXSKMjavQLSGesfwOImQD9pWAi/u3X+y1/o9/yN/wtk9/lN6eWvxW1bH5zGhipwWSNb3/z3+hPpdlNWvn9t/29/9Tf/NfNSDX9pum/y13s/kvSxb8L1fUb/fa/N5mGX+93+V1+/9/810v/of+b+OW3nf4Bv+Wv/7v8ptTg70GDX+93SX//Eblov8nBXwtt+BvBnv0uv+nEgv/dybj9RujhD4BFTv9J7uLf/ueli3eA8BsyUn9C8Vv+Br/tb/ljZJ/v/mnpX/T7yPe/N77/ddY/TmMkJWqw/81//d/7N/+x3+dPzfTN3/zHfvPf6Pf+XX7z3/s3/w2+/6dm/3L1W8DxoZ7+EO7pT/kPBNJvAkg/RrhQD+nfyF99+dvIV7/s/8RXv/mvv/tjbMj/M/xp5uTfxpx88l8rDtVvSbB/Y29ufoyd6L/kd/lN6L2/7v+EKeHpgA6BEP6Glt9+PTGjv/4nRyRV9DGrvL9E2QfPX03/h5r8A+Q1/u65fv4v/WZgrd+ZhOUf+W0SmoZ/ilG78y+LAP0Nv9avnf0uz36fXy87JZR+DWhOmoC3f2r6q/9h+f5PoD9/5k9Nf+FPYST/42/1G9KM7f5p6aM/nL89WBB3sKDS5zo5/9E/L1+9gun7bX/vJP2TiMq/EXtcv3G6Q538Br/9937s99mj2fp12X7+Np/8r79++7ti3KQ0Dn4n+uS33Pn1fg00/I2s//DrCRl+ffIfft1TyOS//WtIBIj/v/01RLT+Mf38z/w1RCT/VPp/+mvI8y/95ixev176x+GL9I/6V2Rw5D+QH/HrfvJX/9q/Tva7fC5+7Z/0axgPF7/9ab/O7/27/O6//19g6AORJwr8kj81/efeyjDf/t9wun6X3+xPS6/PQKL/7rf6Dcnx+nUPXsOT+ONIJf6O1W/F9Pn1f8Gflv7BQvSDTw1tfv1fE1T5cabQM+r0N/ix3+6nfp+d3+B3pDa/hQD+jYmL/lwGTNj/SYz9d+4LFPgPv/7614UZxyjYhwTtfhlIbWn36yoL/Q5w9k5/TAkCOnxE//9Y/76vn+EhX+DX+G2SX0CewL/wm/y6vwlR5nc0w4cC/e3o87/jt//kV/2O9PNvkBFSRFqRmk54SL+UPvkN0//m18CQfg/Scr/+b/e93+D32futf/NfN/0Lfk1gD+X++/yWv85BhfH9eul/DCKn/8UPlOi/y++jP/603+TX+QN+l2dE+U/+1W/9duQRO6tlrIpB9V/6LVhtH7wkgL8GdPX/QR/+Jo53PjlRpknp/38N/T+j/xP//hpgyYf6E88x/f8nfg1xOvH7v/RbqqP5637y97Pk/NM8AAgZmOev/nVIcp77pKFp++RP/QWf/KrfiVngkz/q19r6bTD1zA/vzJT/er82pvyYp/z0N8OU/46Y8t+e2rwRkvzTvwa6+e3/GdYdEIrH9LmGMP/gr2FCGPz2pxJ3Xvz+f/63iCW/+6emf+YfL3wBpxNx+f/ya7BAd/jgkyfEBhgi9MQfRP8n7rK6BH+DJPj75a8hsoXPiBK/xr/0W4Ecvw1N+z9AYvMbgg2gO77lU+B3ok//Iprq/wrIpd/6a1Ui6JO/n2n3u/xfMvnX0Bu/LcvFr5te81dHn8hXv58S6tf+3X/qN/q1f4Pf+zci+v86B2f04W/w231/+7egkf4ef1r6J/yJ0nbv/5bo5tdvf0coECB18AvABr8G5OB31kH92r9VClKkP9H8Gr/GL6ipsxXm5dfjYPlb9AV8pf/01+FcmNLqtxJa/eaf/N6/+W/G8Qqed7+mmGzSHb/GT9Pvvyv93Kaffxv9JO7/Nf7oX1N+4jtk3hC1t6AbOvuFv/lvDr/+3h8FxH+zT/6qX/e3OaohOvT7n5ciuuF/2C9Ofq32F8IH/k1+3fQ/Qjbg1/1df2PFQJzqq18LrX8tdap/o9/8N0+JGiRD/8N/ybCZVqxo00uApFH9er/xj7GGJYi/Cz5HZLVF1v6T9tcDCr8O4XZBoe7fJO//2P/NVhNfPXpLbErfVn9aWv2H8u1/S0qm+e3YHzBAtXH6jwL2fwHYv6GEtb/Zwd9PrZnuHJD87vCwxBP+LX89Ckl+s4M/n77/dX9bcr9+W/rjT2KHQMKpX/9P5Bd+Ef79zX/9X/f3/nV+n5Rm9df4/f+V7F/5g/mz31zzKH/TPyV4vebg14A65b9+m7sIgn+zgwf01+/0yf/a/Pbo+DfQLprfAX7qb9v8jvjwx37b3/K3/M1/S04S/QIl9m+kv/+V9P8j7/MUuSUJmpPf/LdK/+VfA8z7h/xKYPFbfvL3/ua/Qfu7Az2Ju34bCtZ+d1AFHjMc409+8x8Lv5eff0KRfoxmMAcwp5/87r/lb/jbiJgj2+R+Uwf8r8Ovv8/v+Pv/+Tu/tUXhDxUUDu7/3zzY/+Dp7/Rb/ja/+W9z+usz0r8GC8Nvrv//NfyfgtCI4tnf5pN/8bf95FfpB9XvBH+ayPfb/ea/HYvAq19TUjR/LP3/D6a//+ZfQxJi/x39/Pvp/99VgHj+UPr8V+vv/yY6+Q3WgNmO6Z/03/81wCZ4m7jhk99K5DB9Q5yWPvu1hck/SUf4k6P43wxplV+Xhvl3/BoY5p/4D2KYv93B+f+NYBYM+Buw10SJCIbzdwP6nwfoYMLfnlpCe/7mv+6av0UMnv6+APubAyzleX4T4qR/+NdgZ+2vEMi/Edr/xuyh/eaUO/uNKHcG9qYEB/cjP6rfGemQ3yr9CDOR7h3Iq/8y2O43ITfxNyHu/u0O/hH+8zf/jde/Js8xfJ7f7uCvpw9/h0/+V3r3L+cB/ZG/tbz7p3PyhQckPfwCk9/D6H+X2Z/K/6Dl2//LCuivv4aqqH4XhEcp/TMCP/wDjNN/8XsK3M+o9W9H/Ql9vvVbmfjmf/s1/9V/9td6ihmCrfjNfk1mCfU3f11jOl+TrYD2gbn8q38N8bMW9P8/+9eQXMC36f939CcemNK/Sdv8S78t671fN/0zfw2Qt0pYZ3/y15Mp/XV/l+s/Lf3L7sgHf96v/Wtlvw2MCEkCGxHqmw3JH/o7fvKrfvtP/tffipJ4v85BA4vxu6qn+af8GhjhP/AbiRX4vfHVR/LV77L3p6Z//6fyOXJ2sCS/FlmSX4ssCXlAByM1JDQVv87B70J//M7kfjJvkBFN3zLl/qjfVN7/NdiO/tq/xr/1a7DjZ3xx64T+Cb+GOOIz/f1Pov//0l9DYj0Q9gf6O57fDgT57dQJBZXIA39jnVDyhT/5a9jVGgWeOCnJPy39vX+htPujf5cf++R/+3V/Q4qYD37x/22cy1/716l+HCPHp7lxMX5XEvrf6Df43X/qN/4F9OmXGPGP/d6/8Y9h1PAyEPv9tjTqb8ED3+Ux/jq/xq/9a7KR7/rbT3SoRN1f46//NcRnANvi+QN0uLB/f73+DjKcYai/PYaK4P4fYM8J0vSnmp8YzF8J5+m3MIOl3n4NMt6/7id/ErX5dXkS/sr/wPgOv176N/wa+OSTv0Pcm8IOvvrdxLP+XX7zPy39O/8w+fb3MkT4w34t+FlY1fiN0l/+W8HP+p2Mn/WxUMDEG79+u/traPgB14nl4b/9NTjhZXwn6zRd/BoSBIAQeP5i/fuZfvfH6e/b9P+/FIT4HYQQ7DTBZf47EWpsBQNP4DRhcn+LX+v/+q1/WygA8op+l+ZPTb+7JxLyh+pwf3d1mH5TptCf89PCphMdMTlMv/bv/dt9f/QbkOd+8AUrvfRvZsr9GASCwtBfN/2v+e+/8w+WN7cw+G/9jsZpAq//Wr8mOzHduNPwwR9J//89dIjHv4bwANgcJPgrPLL8hdruX/odMfxfIHzwO9GPv/PX+XWz3+U7XWkH///5vx3Znl+PU/GUzPgHGePf6jeES63D/7X/OGLr33HrF4IIv2PAB91vvlSKpIcQhN/l5DfmHKTEnT/GodK2GMlfXwLu3/zXVx/0+BNhot8E5Pg1IBf/GaHz2zi9+DtxEEWajLn8nv7/D9K/Mel4YHPf/RriSf82ye9MM/jPYNZtGAVq0WT8VTzU3+lXyiT/lWR7ydz+Op/8Bb/W1scmmCIyEPtife43TP+7344g/wa/S0Jc/FsQfzz/09L/6g+QeSxksv8Rhvf3/eFMOur14Cfo829JSgyUBrMZ9MzPf+l3kuDp9/2/JWb4FfTZb2v5/tfRYX9y/GM8/b+A/g+sf9GvIREjpvz3Umj4G9MOFvgr9LN/6XfmCOrHfuNP/kFSA79OSjJNVJ6QdaCk8V9HrPALDEloGn+N3/k3/uTP+h0/+d9J5H8dziX8qek/87ug5cEf2JlpNo0QhH/q18CIP/6XudXvo7P+6/7uP/XrQg5+K2rwD3ODf/+v4AYHTCa44Q/+KNDov/9tfuOD341FgH75Hf/v/5umnGUAsv/b9WnwHaHBEx3bV/T/P/TXkMTiY/3sT9b//zG/hqTL8fu/9AtY6/86ZLzTv+jX5ZH/Hb9N8jv8xp/8TeCJX+QTgHLhfy4hePdP439+n0/+p9/qN/ztfmMKI0X6t1jP/8YHax3nr/O7/9Svg3H+5tT6D/jTUsQ0NMjvCi/8izzwv+OPxzj/m9/hN2Zb+OvDr/gdv0Xf/kf87e/1Bb/xu4vs/3q/xq9HePz2wzmn7/wasnYHc4fn7/01ZLLxOTj6D/g1xBbgs3/pd8GgIbz/CATg1/3k72XrVvixIoT+LyMTR8sIv/fvATyRXfr1Vbn9KazcIPu/9q/Dw8cSWvIbwqAtdPzpf8HSfe83Tv8SK92/NQH4H34NAJj9chHl3wP0+PXTP5ahPv/lJs3w4/qD0gy/z+8y5TSDugGE7UFi5f/f+zV4hm0uwShCzPyOEgK/Q+9j4FN0rv8ne8rcMgZBUkMQBM/IDvwdsIC/tGcB/8LfJfnkf2Or93sxyn/oRAjxRyoXfEtdoH+CR/mv/jEyynOlye/wG/8uT3+j9I/6NWwmCUYNASF5nJyG+Iz54NfknNGPqSLE3EPv/0Z9+/976dz/Ifr/347+P9f/46Fp/jX+Tv39b6L//34Y6u+qbs4/wwPY+wNkAH+7GIC/4deRRMTv8rvrjz/t1/kD0n/s18Dicfa7TA05fuzXYLv46x78DE/f7/LkT0t/y79KHQK4LXB1Ao3wCciCb6z9j3DHb0GQfm/KUApvHaTGCPxaIMfvFOj9X/VrxHJov7NV/9Qf54oe/Rri9PwRv4aEVPgdj/mcnd39PzX99t8vWv4f+k1gAH93Xw6QUfmr2fj9Lj/xp6W/3kfS8M80wyNS/I6/jgxyZMzCL/s1YBY++TVhFv6G39Cahd8AHu73RAH8R78GiP/X/w1sDGDiT8QYmEwaGA7Pr+/9/1/6SIzB781kYJ3w24BVBnXh36f//yn6/5cKcE3//1vo/3/PryEhwi/6NUQX/o7o4MdVF375p6Zv/iCjC3+X3/A3/uRv/E1+nd+ECJMawoCWNArw1p/Gxo6a/rFkF345D+sXYQY/+e9/l9+Ucmu/8cHKMQMlIrcl5ebswW9CBuE3YYtwlyBpPlUyvJg199uf9utk6d/1a4ATfx+xB7/zJ7+ScDv4zdhGUOd/Inf+Tz5gtfm//1/CK78WR7i/k9Wbv45xGX9PodHv+WuI6OAZ6f//aPo/uAif79D/lzrib4FGvxto9Dv9xp/8Q0hO/8af/N0wE4c+w4Bef+kvgKH8bX7jT/4c1QtjDJv+/mN8V/A3J1LP/7T0X/2rGONSOOMv5VH8+dCPn/w39Pd/xn//Wf89t/k2xioCQZ3zWjfLw//2a3AKYcgvxEPW5Nf4fX8NWcP/DfX3v+LXECOIB+qQEGE78S/97hjk7+CrQwzzNw/z7Jri+Zv/KdEgFEBAfP8rnvz/8XdgVw/64dfaums8P2sb/uBfA97/HwCtlv5DvzHUoUgItDvGSCZBWGnB0P5r+vtv4L+3/g5RDj/Ok8468rdjHfnr/hr/za/BHlBnnn/73/jHWCOkv4Zoegz/19Df8Vn+a4iw4f/Aiuzhb/zJP0eJ9V8v+11OOtb/b/8dPvnfacp+mz8t/fdOWTr+MsPXrADIhm79BqoDfpNf73f/qd/wN/n1fv3fG37QX8Ko/10rnkLQ4NenYA/+j3DsPy0ci/QysfSAR2hw/Jd+oSiBn7K6EFmp36VvG557c/+DX0M8YAodOL0OHvsb9G+Cx+sx+PnXoYOPxT5gFeWfeitT+7chSvxdnv6p6V/x18kHfynY4afCdYdf95M/nhrd/VPTL35t5oDf5TeEIfzHeYj/ger0udUF1Y7NvWMtJmodwTJYi6HZ/3d+DXaJauYGNj2/s4j9r2cdN/oMuVGiya//a/wOvybPbjdfYsJE8O8/rbT5Z38NYYqf1P8b+fiHtc01aLIlcRKHiTAIfyf7S79fkA34dX+Xn/zT0j/1txD78GfQ0Oe/Job+l36XDSOCx9+Og0dOgzeWEJQi2FWn4U9nWv2FVwyCF0zEYRYdCO50v/1pYp9/hz/t9/ldfrPf/y8Qlxrp1F+H5YGA/Tj3/u6EKYYUza/BBMNv/6vqxl+b18N/054dpRSK0Omu0uj3pv+DVyf6Oz7/Rb+GJF9pUMxL+PtfuqM5pbvc+Z/wnwkx/maY2fSPwmfmJz7+c8BEp4aG4EVC+x/B2NK/5w8XGrT/N/tGv9VviHjpgpXJHoiFP39vpU/6e/7akk/5DTi8/u3pK7hRvwBJNUm+mp+A+BGowFndb5mP0z/yV0pvv57K1K/9a/z7v0ZUpoy/9fsoXf4k/QkawMAW+hmR4df4U/Tzf+lb6m/dYZr8T3+USBD5W+Tu/L5/Wrr6CfngL/t1iRq/aXe96k+gF0V9/AMr5qNf+zeEJwS6/Fq/9tY90AJ/zwwtkl8HKhXy/Runvy6N8jf47Xg1F/mn31OI8ut/C176PR7qr/FL/yBei/s1/v4/7tf4Nf7V/4IWR+j1//J//DV+jV/yF/0av8b/fp8iJSLQ7/9v0eLtr/o1fo0/7D+g30lL/Idkn5+T1Pznv4I05hm9+4dRHu1/+DV+jb+DjOzvThT4O/+KX+PX+A9IP/7gryaDQlQ4pBH/zb+YkP/01/g1/kEyxv/7MS1ckRX9i36GLCt99qf/J7/Gr/Hn0/t/E8H+Q397Uk5/OWnn/5LefUJD+ctIQ7e/xq/xTxC835WU0f9BEvq7/EuUzSbT/FfTLPy5X1Eig3jln6K+/yzi0B8jPfNr/V2/xq/x15IM/eP/NjHq30OJkP+ULPcbgkn9fUqwfjdq8/D3o4mi9r/8b6W/fwlp/b+KYJCoHP/1v8av8edRn9m/92v8Gv8+UfGP//PJSP611Nc7wp0s0v/0B1BgRbrol776NX6NP4pY9T+lefr1PyIv6z/6NX6NP5A+2yXD+S//abTITWrgp3/pr/Fr/NfU17/5W9F3JcGmsb6jycaq3epf+DV+jf/qIfmpvw1F5n8H/fw7qR3h+2Nb5JceUa6K9Oz/9Tf9Gr/Gv0d4/TfU94/9L4TTP0DC93v8Gr/Gf0tj/9fps/o//DV+jX+UuO0v/pMpyCMNfpf6v/ijybMjDv39qN8fJwb+4+jnX0vc+B/QHBZ/FvkIB6QXaX5m1PaPJ0naJ0b/h6m/P43m9u/+a4gm5AH+5QT7l/45v8av8eaf/DV+jb9g/Wv8Gv8ASftfTHP5jHD6J4kX94mWvwXh8X/QHP2afx7N0R//a/waP0Nz9m/8gxRgEo2Oic5/IOH+ixIa0+9FLEj9fqf6NX6N7/9fpCjI3P6f5Gn8R9TH30fs+UfQnP9iem/0HxPNiDQ/SbT/HYg2/8nfS7j+djTnJJm/grTLn0jz8VfRfP+2E/o/0eGnqI/fm2j3Z/03v8av8R//TzTu/4P0GM0Tvf5r/HHEc//WZ7/Gr/HLaK5+zz+B6PCvETya7z/ij/01fo3v/ZgsP/zlGfEf/f/fI9r/50SPf5B46DvEJ79+Q3xL9PgriBf+83+eBJn4//ej8f1t/xS1IR78m/5CGhPx4O9D8/IP0ud/w+/4a/wa/8vvTbxGY/rniLf+tN+WBJ7e+21pbP/bn0q8/Af/Gr/GwR9E46qJN4hvHxAdvrfza/wa/8hvQrT7HimNL36NX+N/+AEZIaLrDo35uzQ/v8mfTXPzJ/6D/+Zf+ef97f/Z3/1n/nkfffYrX/8Wv/jP/M7//Gf8p3/wrzU9+M78n/8//5e/9C/5rU5+4nf6F379v/WXfeuf+Kv/kn/4H/vN//XdP+gP/2d+1b/7e/7nf8KL//7X+c6f9vxv+8k/7M/7s//e/+Df+0P+49Pv/YO/6F/9V/6P3/bP+Ft+6eziD/lH/qX13/zTv8VP/Np//a/8Q/+qv//TX/LJF3//7/hP/xHLf+I//51+m//kj/mP/paD3+Jf3pr8HeUfOvprnv2Vv9af+c/+tf/+n/s3/XX/Y1r9I7/v3/2H/Iff/tXJn/u9d98+Pfw9fs3j3+8P+m2ad//r6Cz7L/6kv+OP+AWnf+Kf+cf/n9v/yr/+D/8Tf+FPzv6qP+L3/7X+mj87u3P35d+T/rv/0MO/5tf9Yy//op/8B/6N3/K/+AN+ya/6vX6df+Q3G3/rf/0lf9F/9G/8x2d/8N7v+hd+d+/+Ivnz/9xf9g/+UX/fr3/vF/yHi3//3xj91L/49n/7zf6PP/DZT/yih7tn/+sf89vPjn/9v+0Hf8z/8W/9hWX9xa+x8/CP+1d+z3/+j/z9/5UHb+7/h//jP/Ab/Sfr2T/011xNfvkv+FP+tn8ie/Vr763/y7/2N/iH/8A/+WdOfnBR/up/9h9Y/QW//H/76/7I3/qfqP+iJ//c3/ln/CW/5E/5J//3v//Pe/v37P4dv/jRX/sP/Maf/tF/8e/107/57/9b/7l/5j/45/zbv/Hpb/F3Hv9jf9dv/vhf/+xP/Q9+2W+b/ju/4jf4I/7Jf+5P+vX+kN/3v/zpf/uP+ed+l9/+l/zO/8xv9Q/887/z6D//s3/VH/Arvv0bjf+8P/JX/tNbf/6/8uA/OP0t9n7Hl//y7Df66M/8k//G//xXnP7Eb5JNFn/C7/Z3/A3n9X//6/xtv81f8t//RX/j//bv/2Ov9/7av+8P3v3vf9mf9n//e//0X7z45fXv9Tf9w//b3/lHrf+2f7/56ePf9T88/tP+03/jp9e/+lv/++/3j3/19/6yP+2P+BeS3+nv+X3/8D/7t6n+8fqv++V/3X/wl/2CP+6/+xN++1/nX//pj3/w+/4Wv/tnf8TLX/7n/PTf9pf8LrP9/d/rz/7D/tu//k/87f+e9R//R+783r/rv/fXfvK/tH/7n/PbLf6s3+O3uf+3fvwvHxxcn/wte3/lH/yP/+Sv/Z++/rP/9z/qd//Hln/6v/6rpv/5H/wP/Jn/2e/+6/9Jf+Jf/dGn3/0H/oBH9//wnd/on3/7H/5F//HRk9f/6r+492702z345b/Gn/n4W7/5yV/937z+dV/8G3/Tf/ngN/5df+o3vvsTv/L//qMnf8Q/+9f+bn/Bn/rR7/VvTE7+yV/3v/3Pfvf/8Vc8OP6D/vZf/Uv+4r/ok7e/8ew3/4ni91j9oft/079b/ic/sfOP/pu/91/7X6WP/4yf/lP+jBc/+Vd998/7Nf+9sz/xNz2+/7//83/Er/kP/j2/5ovf4Vf+ktUf8/YXHd/7zX/t3/D3+9V/9fc+/+Tbf+u//Z/8U8//tf/iL/mP/6s/+n//i37HP/Wv+M2++g3+1X/2f/lrfq3f9Oh/+5t2/s4/7dG/8PqX/9Sv/J//8r/723/5v/KXFV/81b/Zr/3Ft3/Zb/FXP/3pT/7G33P777r6/q/5x/9bv9kXf+ff9bf+ET/2r67+t9/lf/kH/9Tl7/6XvPn77/6q/+Z/+E3+0t/uv/rs3b/96O/66/63J3/Db/Nr/zp/59/+x/8nf/F/tH99/Zf+Y//pmz/7V1z+xO/7N1/8r//ixy+/t/yffuet/+t//j1/5c/s/rEX3//evzZ/8P0Hf+pf8RO/dbvK/p5f4w/Y/wP+tj/nX/yxv+mX/u3/5y/9i9vf5+zf/M74r/03/rBHv+H5b/zH/yV/xH/6y/6LX/af/rKzf/23+O9/p//7t/ivfuW/t/V3b/3dd/7uP+cf/wv+8T/rH/9r/uP/8j94+59O/t1fM/sNs18r+yf+wL9q8a//4Dsvzn+vR6fLH/zvn/+Xf+B/uvhl/85s7/e486+8+P6/VE5+yS/9m7/8bX+N/+JP+ff/9p/5s/7sP6N69gf+hpfz3/DP+v7v/3c8zed/7Pnnv+1sVT+YP//ksy/u/ke/5NGv+fnH6X9b/17/2r/zv139ivb3/Rs//mv/6r/mez/zvd/7r/6b/vC/9Yu/+c/89Nv/5t989Mf/TdVf9bf+Qf/eb/Cr//5/4zuH/9Nqtfx9/onvltNX3/0DTv+pL3+/s9nF7/0rn1b/xPWr6//gl6z+3V/68hf/T/UvWn7+v/6j/+w/9W//rt/5I//Dv/VX/e8/9s998Uu/9+//Hn/w//EP/QO//h+5/eKP/k7yG7/6G37Lf3rxH/zPu28Ofua/+Et/n//tyX/9N/6Hf+jDH//3/piDX/nvX/7j/+128d/d/Zv+iX/+H/ln/5x/6tsv/onDf7r8g9t/6O5v/Jc9efrX/F3fHv1dv+I7/1bz1/xN57/1v/bv/89/zR//L/7Bf9yf8Ved/LXpf/bnJX/i7/SH/kn/9j/xe//Gv9P3/8Pf7vf7Mz7/md/wj/vWn/FH/VP/xk//4l/8j/yhf/H/+O5P+CP+8h+Mf/PrP/L7f8gfW/wrf8KXf+mfPPnjftnVH/1Pnv+Cv+5npv/Df/Iv/Q9/8eSi/D/+4r/29/0z/9pf9A+9+y1+2X/3M7/fJ//xu//mr5397r/y6j86+X0++unf+/VPf/9//c9/v6+enHz7D/wDvvd//bJvv/nOxe938ib/Vf/wf/XgP/mP/+x/5V/61/+uv/Vf+YP/tb/6T/m3/72/94/55/+2v+Mf/TP/sT/zb/j3/7N/+J/51/+EX/1f/PN/2PGkXHz8e/3WZ3/FL/w7/svf7O1fcu+v+8P/+/+q/sX/0d/9ovqZ/+x3//ve/ap/52/4D07+nf8t+bf+9Kv/9X/5z/6H/+x//lv+qT/7r/gL/6q/8rf6Hf+jf/zX/Ief/JKP3/7vv/g/+yX/yz/4L138j//Gf5n8xb/BH/6//K1/yF/347/33/PXfPzZ//X7/MH/xJ909gdl/8p/+urX+C/qv2rxD/023/vH//e/5F/6DX+95je6+h8uv3N9/KsXf/Q/+Vf8Hn/aL/3jdv+bf+PX/0VHv8WbX/TiNzitful/8TfPf5s/+t3FP/U3zf6i3+mP/qv+lT/tP/pdf59/5J++92/+lX/JF3/q3/PH/Fe/97vD//I/+V1/+f/05/+q3+P+4t/6HX7wp/8Bf+B/9if92i9+0wf5//g7/Sv/+N7W3//v/KH/xh/+r/8b/+J37/4dv/+/9w998eyv+s4/9Z/+Z4f/yoO/93/+j/7bf+m3/PN/xf/9P/8v/9hf8it+m9/jv/pVv8Pf9H//n7/Jf/K3fu8nf/1f59f9g3/vR//tX/Uf/yn/yvG//gf/5f/E+A/5vXb/mWf/4j//e/6af/lf8Btv/We/+p/59797/M/8qv/qv/2X/7Rf/3f8N/703+Tgi/9s5//8zf/bf+K3/bf/mL9z/7e6fFB//Pf/+r/N7/9rvvlb/4c/7U/84vf6ux9++fePxn/ZP3Dw7O/4hX9t+Zv+gv/8d/gD/+Y/6s///h/05E/7tX+Tv+Dbp//LP/kf/w+T17/L3r/+7vm/u/ff/HOv/ov1xe//5W+1O5+f/HuLP277v/29vvdXvXnzyT/5d799sv4Tf8Xxr/+//rv/99/1ez75yX/5+uLX+1O/ePIf/ivTf+hf/g9+nd/mb/zN/oJ/9b/4a37B37L7P/7Je//dX/fiT/5Nv/NX/Cv/3r/0v/9bf9h//of/YX/4P/Pn/Z3/zl/3P/6D/+5f9If+YX/ZX/wH3P9L/90/58/+D37ln/u96r/8k7/7u/7Nv8NXf9sXf83/+cf+mX/YH/03/Ju/zbeyf+H3+xP+9H/j9cfP3/wpv9df9hf++3/t58k/8af9X3/sl//Qx3/p7/sLR49/6k/7P/6eV+/+t9/tX/lfzn7Lf/hf2P5nT37N3/Gv/9P++r/9V/8h83/o3t6/91f+2X/E7/t7/zF/45/17/4vv+Fv8B/8Dr/FZ8f/5X/wn/4b/+kP/txft3j9/d/+v/6Hzts/5fTV3/V37P4N//Nf/ce+u/vf/zanv++v91fu/xG/zbfvXvyh7a/8PX/DP/3X+Cc+/svXv3z/d/w3f42/7Vtvfs1/9U/44p9Y/OZ/379++it/4m968Ef+Pv/wx//Ef/2X/NV/7V91/Jv9/W/TP/L3vff3PP9jfslv+If84Nf7r/7vnaPv/pm/wV/+1//GPz7+s8o/5vcqj7/z1/yuX/yH/8c/+iv+yV/6L5z/nz/zu/+jv+R32zp4+Pg3+uN+jb/z1/mT/r7m91u32//8r3n5F/8hO3/pX/L9P+h//PTf/Pv/oF/23/zHv9m/9OLX+/3+ueJf/2d/wT/66/2jd/+m7A//Xv4f/sH/3ff/4n/mb37xj/y3f8qf+1ee/Z7/8//6E3/Nv/13/2X3Dz76k/7vV//KX//3r37Jv/Yb/ek7f/7rf+4fL/6hf/9X/sPj/+2/rf+Iv/Yv/ld++7/3+7/4X/vLx0f/xMmf8o/8k3/sH/zf/JP/1a8c/UF/9W/wj/+Xf+1H/8F/+t/9Xn/QX/GfX/27/+xf8O/8xb/nr/hP/50/+s/4Z/+U//jOV3/Bn/tP/u2/8u/+dX7Dn/zbftXvf1T90r/kxeLX+ck/7Bf9+P/6F/xVP/EHX/34f/OP/Om/9k989pf9h3/Zr/rD/u7/5c5o9J//R7/9P/Nn/eNvm1958ov+zZ/4ff7Wv/zf+o1/3e/9gv/k8vwHFx+d/bW/4P/6Df+ZP+i//p3/p7/m//7Nfpfy13n9n/wrv+v09/0z/rvpv/Uv/cL/+q/62/+z7/z6f/I/+Zf/7r/W/u/6xej4V/+O/9J/d++n0r/6N73zl3yeP/oD57/R7/eH/u3/3rPz/2z09P/6s/7b7f3f+Df83n919rf8xMGv98//E/f+yb/7n/vq1Xd+w1/3v0z/g/+++JcP/8Gdf+1f/Y1+wW/4D/xD//V9Iu0v/BU/9Ut//F/9C3/lH/vkj/9P/vrD/+xP+8nTP+2f+of//V/j9/wnf+pXHPwvv/Ef/d/9Vv/9r/3wl/4Jf88/enr5633vB8VHf/f/8hN/zF/0t/zK5Pd5/Pv+Rv/b73Xvt//3dn/PP2/2g//mT5/8vb/gX/zT/4XvzD/6K/+Y2Z/1x+3/q//9b/iffvkn/wt/ye/zg1/0a/z1v+Cf+93/vp/+Jf/04j9++e8eLX/s7/91fsu/54/63n/w7/63v/OLv/dP/uiPu/ynf/1/4x/7m/6c3+Uf+7d/n8Xv8IeXv8Hr3/Bv2/6J3X9zebD3T7/9L//U/+yv+we/+2f9vr/Nr374Z777537Lv/wfPvkX/ou/4r8+3PltH/ztxdF/tvhTfsN/+5/6++/+73/N//Z3/7s//uv89Ovf/8/+03/VPzppv/O3/5Z/Q/3H/fFH//7bf6T46nr77/ttftnBb//X/Pf/6T/+X178Ru9+k7/3z/2l/+I/82f/g3/cf/7sD/8P/vA/9o/+d/6Qf/M32Pm3nv1u2a/90/O/+h/6H//Yj/72v+JP/A//sD/rH/8D/vl/5N/4z/6Vf+Xf/n3+gUd/8N/wr/yTf8F/+Xv/pX/av/zr/Yf/0sf/7C9IV//4n/LXZr/Z+Pf/zf6pv/2/vfrt/p6/9Rd/9vc/PPnBH/F//ze/bPo/nZ59+y/8g0+m/9MX3/s9/77f+j9u/6lf+gvPPvlz17/wN/ut/rrf4Q/+j36Xf+D/+r3/tn9//PC//T1+n//zV/zZ//cf9fG/8Nv82r/J3/Lss//8zuv5f/LX/Cb131D/5+d/+l/+T/708Zd/36/6qvnkH//uP7HY/9f/qT/pD/jO+IvZ/3H8+fHv9yt/wcH6f/0TvnjwP/1N/+LO6d6//hv81i/+r39+a3z3v/qH/5bf4w/4ZX/l//n5H/d//EYX/8Wv+PX+2PYffH731/7Pjv763+cP+3Mf/Ld/+O/6F/xOf3P+h/8+x3/X6b/28vrpr/ev/Zf/21/4vb/ji7/6r3rxf//x/8Tv+Fv8ln/Sn/ln/C6/y29/9Hs8/q1/m9/yL/ov/6y/+d94cP0b/aa/w7/36t/9W77zrepve5f+2N3/6G/4PX6rX/Sf/qm/wR/+L6S/5MXv/0c/af7dv/oP/Qf+wW//9O/zR9f/xb/1G/7bf8pPXLXro7/vD/3j/oZ//p//q/6If/e/+wN++R/26O/49f6Gv/kv/W3/0j/zafrnHv8l/+TxX/rH/I1//N/133z0U7/yr/q7Hz2rHh7+a//On/0vf+ef+uP+6pd/5p/we/+6f8I/9Vf9Z3/33/Ctn/4Nf6M//i/48/77/+5//NN+2T+TP/gPi7/s1/7Lfs2/5V/+vT4/f3z8r/w1f+X+r3353/zH/0n+p1f/9N/53/5Hv/p/+I/+9ZODP/RP+1v+vouf/Ef+oX/9N/6NfuP/7De8+8Vv9Zv8i//6t7K/9uST5k/58/73v/1/+Qv/oP/+n/wn/5CDf/bX+vz3G/3bf9zf/X//Wn/nv/sb7v96v+N//Gccv3vz6X/y6/yXv80//U/+ib9L9mv/Ob/dlz/153zvvyOj/o/89f9q+1s9/t4/+CdM/9F/6r9d/eB3/Rv+mr/6H/izP/5Nf71f8qf9vbt/0cs/+/f4A/6T3/Z3nP/g4rsHv/Tf+KP/nt/g31z+Z3tv/tc/62cu/ut/7I/9qv5f/qMHJwfLT47+q0f/xB9zcPWn/G2/2//8+/7n/9u/++/8eb/TP/tbnY5+8dFnj3+DfzX/Lf6cX/D3/K5/xbdITXzvb/udlr/9T/3Un/B7/0/fvpf8yl/7l/3gH/4P/vl/7uk//D/9k//ok79m58mfdP529it+u1+Y/q7/xX/6H/3Lf8Kjf/Bf/Vf+qeLj/+bXePnr/vTl3/Vn/5d/zX/1v/0nf0P56L/8zT79i/7j7d/in/ord+Z/+N/zd+7/Fn/HH/GDv/Kf+j9+07/tL/4d/p0//O/6Nf6vv/bOT89/8nf41/+OP/M//7v+vf/y+tuf/Q7/yW/9X/6G/9Y/88//kb/tH/+f5v/bb3v+S//U2W/zu/9+1fLXf/m//znf+k3+sU//3IvPFg/+gv/8z/3N/vTf/G//zf+Q3V//3/6vf5+X/9Nf9u7v/Sv/r9/m733w4O/6z7//19X/5L/6e/2axdXi3/1j/pAHf/W//7/+pX/I//D5b/hv/eXf/t7in/7xX2PyP3/6+/+a/9ev87v83//yq7/rr/8f/uX/8j9/9R/89G/zW/wOs+/8fX/d3/NX/Fln//B3/tN/9pe+/gN+7Lf+Ay/+1j/41/17f93f+9f6i/+8h//tf/c3/3p/3P/1b/7j1//xX/OfFX/d31n+Yb/4zbcv/ok/7+Pf5j/+I+rf9d/9Pc/+9l/6Z41/wbf/wd/j6O/9TXf+7X/n3/1Fv9Uf/+bX/F//2N/oV+59+4/9m//ps8Uf8uK//ft+w9/mZ376X/0zfvsHp//Jn/jJ//CXJb/en/xH3v1fmvFv85v/zn/k7/in/dvrf/H5v/zr/63/1dXv/rv/oX/k9lX5H+03v+y/aj77v371n/bgt/0r/6K/6F/+V//dP+tf+af/r9/8y9/uj/3f/4cXf8nv99/9wj/0l/1m/9uv9Wf+97/sP/7sP/43/uN//Is/Yu8v+vPu/gb/6P0nf/9fun1n65f9zNs/4pf/jw/r//PvHN0f/w6/y+/0uzT/8V/3j/11P/jr9k//kemf9t/+wn8z+4P+xN/4N66P/82Hf+5f8Owv+oP+njt/9D/71/6y6k9f/Dbf+le//bf/Kb/un/RT23/sL3nyP/0zf/6f91f8yt/9f//D/76/+dd78Plv8pv85F/wr/xbv/cv+z/+2Du/03/yf93/RX/vx8/+/F/vv/tzf5e/7xcu/of1X7z7b/7lf/lf8fD3++t//O/+d//LP+Sv+T2+uPfd/+Rf+xt+5vzP/ce+ev1b/Ya/w3/0b9d/3vLXPfnH01/0F3zv4S/9JT/zR/53f/A/9Bv8nr/+L/7e7/Mb/R87/92v82v9BT/4Pf+y3+fXuvhfzn/BH/s//6W/29N/6Q/75/6K/+Uvfrv9p/43f0rx5+38or92+j//48/q3+7wr1x8+lvfPftf/6rf8j/8zu/61/0l60df/MM/88f/rld/9B/wP/yRv81ffvxL/s7/++/+vf+QP/neP/pn/rF//V/4T/2Vv+e3/9F/9bf7M9/+5f/G6W//D/+KX+PP+Od/8Bf9s996MV3/Pv/Yf5p/91//vf+U//Qf+SX/efoH/yZ/0t/yP/ytf9Af/OTXu/7j/93/7vf9I3+Px7/yH/7Lvvrn/rs/+PEf/Xv/l4vf67u/W/Fb/E+rP+tP/w++/wf8a2df3P9j/sl/9W/5w/7Bf+R/+Jsu/7hf+H//E/P/4I/7/r9493/85x/9w3/jH/sP/al/w99bPfwzDh7/cZ/v/n1//6/9Cy7+tb/in1n9ab/fX/0v/gl/2m/7mz78O7/7Nz34pa/+hD/qN/+H/rt3f/W//B/9xPkvfP70T9x79jv/2H/3D/wbn/0l/9zj//rz//wvHf/Gf+u/8+v9D//on/S3/Rd/6q/6s/+7f+TV27/7b/rdfuV/efEX/xc/8+w3+8P/xn/oL/uHf+oX/x9/y6f/ye/1Z578lb/XPzv5l3/pb/OH/1v/2Z9+9hf82l/8pm9fl//9f//f//1/9Z/5J3z7v/zzF//Sbz/5b/7pB6cHv82f+Hf823/F73L3dxoVWfUX/h2/2d/5r/6GzT/3j/8GO4/mxw9+nST58l729N/5R/+enR/7RX/GX3zxq+78B//qf/nj/92f/XvWv/Yf/1Nbf+KrP+T/OPzll3/Fb/03/MrRf/D0v7/6jf6z/+R/+XP/vP/zl/77/+cf9Efe/cN/q1/1Z/7Fv/WT33/5vT/vV/9Vv+KfefJH/7XrJ3/Q7/mn/bn//V//9rf48/7Wv/RX/5F/3qP/8J/5Q37XX/KH/Pa/4+/y+/5Gf+1f/Gv/q3/I4b/1e1z+CX/Nb/sP/ANf/q1/z+nv+bf/4ju/8K//t5K/4pft/Hp/2b/67z75/f/W//LP++9+y9/u//j9/62f/Kf/7e9e/Bm/28kXv+2z3+Uf/If/ut/v3/zj/pO/6R/8Bb/8y7/3P3/8R/5nf+2vvfXwLxp/9NmvOPzly1/0F/11H/3Z/+y/+vT8f/4Pr3+9n/nvfv2ffvIn/5OXTz//U37Tb/1lX/0Of/u/NvrDfps/4Nf6BX/gH3Dy6O/+J36n3+Mq/8Pv/w9/059Z/S9P/vHDr/6hP+3X+J9e/x6fJb/+vfxbf/wvvdj/b+7+rn/q3/ff7/3S3+tn/vFPPv4D/7P/6M/a//1/3/M/++4f9WO//5N/7B/8j//Dv/GP+x++/I3+wb/01//iJ3/967/2l/0Bf/hv8Yf/FcW3fvu/6W/+rd/87r/RqvqZ7/z6f+t//sd/68/6m3733/qv+Lt+g7/xHz14+L/+6X/xX/Vr/L7/3N/0z19N/9nzP3b67L/7P/6R3/CX/6q/7e//fX/FL/74P97Of6Pf9Xf41dff/iv+tn/31/t7/ox/6K/5k//cP/in/62//b/4y3+nv/pPePxn/rq/df7f/g1/5d/4m/wLf8iv/DP+yv/yzy1+/d/rj//O//Ln/NtHB+nv+OX/ePw7/46/2+6v9Rf/GT/50af/9p/2+/9+/8R//q/9qX/AT/2vf/F/+vf+/n/r/333J3/7v/lnfvx3+Rt+xX/0E8//sb/0/n/43/2J/8dv9cf+Zf/a3/U/zf+ov+p//ENX/+Pv93/8g3/rP/iP/Fnf+xOXf9Tbf+oX/93H//Xzv+FvOfp3/+SfTpb/1//2q369/+GX/vf/8k8//6//gz/13776c/6Ho/xPP3n8G+78+G8//p9/4b/9J/0Gf8CfNft7Xv2qf+i/mvztv87eP5X/1J+3vv5dfqvHv+bBL/yl678z+6/++bdP/6F/fP5r/g+jP/W7/+n/nf8O/+vj3+pv/Msv//S/6vU/Nf2Jv/Qv+It+rb/u9I/8a149+Yv+pt/st/yv/pb/9E/8xy7/m8+af2u7+BNPf42/96/8y/7K/3nvx/6JP+g/yv/VX3z67/zT937fv/nZL/5t/pvf7S/+737Df/Of+1v+zu/+ub/eH/wffO93/Hf/6tM/5zf+4/+DyX/z+/92f+sf+u1/8P/699a/9f/66cHkr/gH/rY/8g//w3/fV//J3/n3/YP/0cd//5/06/6bn/9blz+RfvQX/67f+Zv/mesXf8xf++8vfsU/+dst/uA//Zdd/H6/63d+wT/3R58+/8f+zj/qf/hj//5/5be5+C0f/kdP/+Hx7/R7/227P/GTv+av/kcWf+zrv+2//gf/jt9y/5/8pb/1H/7iP/0l/9s/+1v9Hj+182flf8x/8vf+5r/uv1L8zr/Gq9kf88f/O//TyV9x2v47f+Wf/B//07/4n/xN/7w/9f4f9lv8mf/oP7j6E7//f2Z/77/7i779p/xXf+kf9b+e7Dz76B/8K/+5v+9/Wf2dP/Of/d8Ps4Nf42w0+xfu/ie/5x/2H/8Rr+/8a/V/8xf9TPmHrL/9+zW/4b/yG/3Vv9fJi9/4L/pLXv1Ns/Xf8/f+Wf/h7/ev3f1N3v66v8Orn/ovf62/6e/+8f/1t/oHfp3qD//3fvfHzbv/40/8FdO/8if/rb/uH/rsxX/85zz/v/7Af/6vTy7/7N/uL/91/8s/5Gf+8l/++T+y3fzG3//iFy3/xr/pX/tj/+7/6t//e/6A//V3/WP+id/xD/89f+bgL/pt/r7fZvn3/Ha/6T/21/23v2v29/xRv/j3PBn9B//ovZ/4b/+3X2v5T/6Zv/U//y+N/pH/aqv9G3/vT3/TR5/9y5/8Vj/xT2f/1Gor/df/yt9y9Ff/3n/23/Uf/MF/1ec/+OQP+NN+vb/un/3v/tWv/qXf4lc9uvqJP2n/Z/6DX+t/+yf/2b/xn/91H2/l/9BPvbvY+el/94/6PeZfHv4Fv+///Se//Y/+j1/+f7a/8q/7C3/fX++v/bN/6d6D/+QP+Qv/9D/0n/7iD/6//+z//k/+V/+5X9189J+++Rt/u51/8V/5l/68P/4P+8N/t++f/lk/9rsfby3+09/gt/0nV//DH/+dv+i3/MX/5vwv+9X/24NvPfsz/tk/+W/5H363p//4X/cP7iz+9Ow3/vN+zeW3/+hf/s/8Mf/hP/hbfeerf+13/n3/8UU1S/73X/l7/t3/4S/9vX671f/4e/7X/8dv9Sf/Gf/57n/6Lx38Vr/ld/7YJ3/fV//cn7/1l43/0Hv/1X/7H/1Wn/62T/67v+i3/Q//sH/kV/0uP/N3fPtX7/zW+z/59Nde/5f/zT/46D85mv2L/9Ff+qsvZr/B7/lX/Pb/y0d/yee/0R/2z//l5Z/x62Z/6J/zZ//g5a/3/Hs/c/0//Nn/zfXf/e+dXH/x7/yJv96f91O/ze5v+Nv/3b/B4Xf/g3t/5O/xnzz7w16/+vsf/2erX/I3vR39Rb/J09/9X/qb/sHX03/s3/jyrxv/zr/T7/iHvP7rfuaX/xX/xv/5+/9Pf/2/+4tHv+/v/bv+fX/U3/X3/Ol/7t/03T/h9/ujfrd/+4/42//P//Fv+t//hD/kb3nxV/w6P/XX/Q2/+e/w1/z6P/4f/kE/9o/8X7/Nye/723/8+9376r9/c/XLf4fmb/n1XvzFv+6/+Pv/h//C7/5X/6+Te7/Xk//xz/5L/savTq/b3/OP/QP+qf/4X/5n9n/hf3znj/uFv+vf9df9n2//lzv/xV9Xr4vZPzf5Jf/87/cb/vj0//zWR3/Bb/RL/qBf8uv9S3/0H/pb/Dd/0f/1n/3Eb/q9f/9v+lv/lt/sN/qX/7Tf5a89/S//8H/n6V/5X/9lz/+b/+D87/qf/5b2b/wbfvU//ZPf+e3/nP/p4P/4M/6Mf+dv/it+/+/t/O6/6/3f8k8b/fa/xeLqn7n8tX/tv3L9r/5xf9TbX/Rr//hh9e/9ceu/6/f4M579bb/HX/mT/8Tv8A/9+X/f7/Frv/nyq//pT/5l/+3/+L1f9Jf/3s1f8kf/N7M/rf3H/uY/9p/4E//j/+Yv+uh3+93/iD9y9U//Q3/U7/nv/1l/zJ//y37i4fP/efzyN/g9kl/6h//mT//XP/IP+Hf+0D/rdxj/o1/91f/0+f+5+yf8Oad/0f/9l/0Xf/Sv8/v+Hr/2/3b2H/3n/9mv97uO/8s/4+7/ePhb/jb/xJf/7q/zR/3bv9Y//+OL8Z//h1R/5P/4a/5Gf/CL3+Sf+pf+lV/37n/6e/yNycO/9D+YXf1Jf9qf9I//st/ie3/Jr/gn/vH/6Ld49p2/8U/77f+c3+rf+0P+6//hxd/4l89P/7U/7h96l/+7f8zDf/K/+EOufs1f6x/7F37Bf/Ld3+A/+5Mvjv+bf+tv/z/+zYO3/+r/+h/s/rO/zy/7Z/7gf+yf++J/ef3b//dvf5Pf6r949Md/58/8dX/mqz/1j/rDz/+rv/Nf/Sv+6v3f+Y9/9P1/+z+49z//d//oJ//T3/zf/dn/0u/xN+88+x1/wV/1x/0HP/mf/DX/3S/69/69v+Fv3v1b/un/5n+o/s/v/Td/+f/97E98/id+75/5Nf7GT3/Zv/obvf1XfsFnv+Nfd/AP//YPfoff9cs/4E//K/6r6R/wv/5jf/lHv/SvfXvyR330b/67i7/99/oN/u+f+dP/p3/hP/+JP/YP3Pr4H/uFf8mf+xPZt36XX++/+J9+5mDx6/1Bf8x/8Sf8PX/Dfzn+Df6B9D//E59d/ol/8p/x2x7u/+V/6KM/9/d/81v8qQ/+j++3f/Lfuf2H7v7Xf8Kf82v/57//v/Tn/qV/1s/8I//rb/9b/nG/17//r335F/8jq9/wP/5PTn/f0z/xFxz8Xt//g376p/6Hf/fHfqN/8887/jX+53/wd2//69/m6X/2x/7ff/Ef8of9Np/9Jrt/2ug//19/zcWrv/G/+mfH3/2vfrd/4X/9n/+QX/AbXV7/7X/dn/l3/8xf+Df/F5/++X/2X//f/sk/+IXF7/nb/Df/+6/zP/z4//A3/5b/y9/V/ol/z6ODv3/rv/mvvv0P/6uzv6j5mX/33/9b0v/j7/pL/vW/4f/Y+fX+xJ/+veoH/+o/+xN/4T/zf/3P3zr5x36Nf+J3mf3Ov+zz3/O//SeL//mv+ef/0v/rb//9/qv//uCPP/tdf63ffOu3+daf+7sc/If/6e/16/17//0/9hf+o//h//7rf/b6xZ979x/9u/7if+t3vvi3/vo/5nf9Z/7Y3//ffPIf/KI//I/4Df+r9tf4vX/s3/61H9w7/7X/+vU/Vje/8lf+QX/13/fx6W/87/57f85/1vxG4/3/9o/4c/b+t/91ffofjNr/8Ys//idP/4H/+V//407+8Z/6DX+X3//3e5L/Bf/c6z/mt/+dfpd/7Df+4/+jf/zv/Z1X33/2j67//b/6n/iD/+Df6cf+j/+6/Ve/s/qH/pS/70/5Tf+kv2T2U4//21/nX/2X/oaD/+E7v+vf+ss+efuP/1r/+T/86/0u/83f8k8++I//gl/0z/9Jf+LeH/2H/hV/5x/4d/yR/8fxX/xn/q3//S/75b/wl/2+/8zf+0v/6z/2+P/6df7h/2r6T5Wvfqe3v/Iv/SOz//p3+PE/79/9i/+bO3/J//78z/vJV//o3/Kb5Z/Uf/fOs1/wvT/+T/uFb/7oz36Df+tPe5Ln/91uevIv/Xtf/WP/7C+rq//yt/6Nf9ff+8Xv+Iv+tk/+l//oN/2d/rW/6xf9jv/JX/jqd/6dfpPdv/a3+I+f/KP/2O/zF/7k//5X/7d3/8K/9l/Y+uyvP/s3/o8/5ff8yf/5V/+bf97v+3f/jetp9q1f8Xv/qn/n4M94k/yH3/nWP/73/LM/+PHf4rf4n/+l33D18d//4lck7X/z5m/+i36H//0Pmv8Rz3+bn/idfr//8L/9z/6On/q9//I/8N2rf/vH/4uTq+3/4N/5ty//5v/kp/62X/Ub/Dt/yJ/8u/wFv93+f3Lvd/0NHvyi//Q3/X3/3j/8H/sDvv+9P/aP+Pwv/bGLj/+T37r4M371b/Ov/yH/86/9m/7kv/2H/hW/x6/7f/97//6/dfwX/nl/wslf/U+9+bt+/9/5T29+m8e/6X/57Te/5Z/+9/5J/+w//b/+a09mL17M/qDf90/8u//Ev+i3+BXP//OfvPM/tc3z3+Mf+Ed2l//9n/CP/pN/67/8g1//X/wP/7uzv/Tul//h3/v57l/9d/4pf8h//Oh/PPw/v/xL/4yLP+NvfPf7/qn/8d/1Bzd/1Rd/36/8/f7Dj/75X/4z3/m9Xp585xf9hf/Cxa/+HX+b//TP+O2yf/YHV4//9OZq/gd/9ev+Lt9a/OQfPv30L/n+dx7/u5e/3f/8ZX7x3/2Jv/t/ML3zL/z07h/wC/+MX/d/+wf//n+g+gP+63/rr0v+g7+m+Q/+pb/hv33xa/34r/itfrff9Pf+dd79nv/Ev/OTv+h3+Dte/r5/y6+dteM/+M/5aPz3/Yn/xW/w3/+KX/z3f/qP/9F/7z/30e/2q3/6N/6Jf/6P/I/Pn539t//Sq0/+0N9kcvln/XX/8M+8+K/+qr/txa/zV7z5o//CH//v/ox/6s/5189nf9jf/t//en/n3/F3/nO/8O2j3+Tf+csOf8//rfx9/vHTZ79u9gf/3n/jr/lPfffTv+2X/u6Pf52z7V+r+LV+69/sF//W/8BPz/7mP/Df+qvyX/Ozv/cPefNT3/kP/+V/Ir/33/0Xf/5/+zv+Lp//p3d/zV9ULP6yL/+qP/Av/+onf+ff4G/4Z36tf/wn/ozf+A9Z/Sl/1f9+9Uv/od/yt/0N/+yf/AdWf8w/+Tv+4//Tb37xK1+8aP6Xf/0X/7L/+i/74/6DP/S/+v3+nJ/6/q/7P/7d/8Ov/A//i9/i3t/6j5z/0cXv9Q//jn/wr/708e/6n/8jf9TRiz/sf/87fvV/9Z/8zT9FqufT3d/mD/8/pn/Y7PQv/sH448u/5j/5mX/u0+y3mv9B3/rHP/39/vxf8Dvmv+3v9ODP+wf3f93/5vh/uv/8l/6ef/9/+2v9Tzuv/tk/+nf4rf6Y2b/yG/0Tf+XdP+vVb/4X/z6/5m/6+/9J7T/Y/Ft/5v/9rV/94//oX/qn//L//u/4vb77N//EH/Mb/Rp/3n/x/b/nD6kefuffXv17/+7T67/0z/p1/7df4zf7Vf/g4X/zq//dv/Qv/Md/+//xv//Nv/fdX/V3/g1//Rdl9mv82P/+5N1P/md/1b/2xz36Nw//vt/oL17933/Cr/h1jn6H3/Kf+gv+hdFv/nv+vf/c+nf5R5a/zh/7F/wXf9vsF/zl/+4f9V/9xX9o+nv+nr/W37v7h735y/6QT7f//cM/+5f9xw/+xX/823/bH/DPPflT/tnf4Q/6jz75G//of/Cf/vP/4T/vb/lrf71f8ct/r3949ef/Rn90Wf06O3/I6J/4M/+Nyz/xr/s1/6u9f/4v+os/+ot+9Z/yF9KiyOpv+0v+79d/57/wb53+ysPxX7z+wc4Xf/3f8Xdc/EF/8H/88L/4q//M45/8jX/R3/8X/Al/5G/176Tf/pM++Xv++v/5t/+lr/7xP/Gz/+hv3fr1Tv7GX+M//pX7f90/lf/Kv+S//fTp8Xr+Yvs//ss//+J3+kN/v9/9f/v7f4Pf8a/6NX+/j/7j3/7H//Tz3/Hg/PWf/U/9oq2/+k/5S7/zz/yBX4x+8P1X/+34X/7b/+rf5M73f5PqN/qHf/A//2l/0/yn/t7/9tWnv89v9zt+6//49i//+G88/1+/t/hvf58/+9f5/Ff+Jb/2H/QvXfyl//jv9Wcv6j/21/ixv+bfLSd/+S/cy/6+4+o/2p3+4f/F73P8r/72n/6R/9bZr/Wv/Z2jv+/wjzj/Nf+8b3//L1v+zB/zi/++z3+/h/f+nX/iYPfbf0/55k+788f+ZX/5n/cP7b6++t3/l51PXv/l/+lf+3f+g7/G9dHiN/q//9G/77O/vbl39Xf9S//9X/LFX/6LvvcT/9if/ps8/8Ff8b9967/4Vfv/0k/+b//M//F//ze/wfh//23/8z/0t/j1l+lv+2f867/FV//tX/Xb/J9v/pe/7VeXf+N/8V//sd/+7f7u3+fffHDn9/7pf/3j3/93+lt/09/rv/313r34zvQ3/m9/4X/zz/yVf+KXv9Vf+sv/wL/8r/r83n/43/7Vf9ef9nv9il95t/jH/9l/J3/1H/wH//C/+Bv9cz/2b/6C3+gvef2//a2f/ZO/bvl/Tf+V3/Tju6Nf8sn//Qf9ot9j/z/5we/xN/+6W7/Zv/Fr/+Hf/Vd/5d/yR/62/94/+YOTn57/X1/+gn/y7Ff/G4f/9t/z9/91v/fHf3b9rzz94tf99/7v9rf4y/+dv/+7f9L/+t/e/XP+6e1/9Nf+Df/S3+Xgv/qP/+79X/jP/Yvnf/TfdPDJv/RH/2H/5stfufu//4G/9//2M//w3t/2P07yv/j3efLP/GX//eT3+q1+wz/m4lt3/+jPf9nFv/2v/01/9J/7T/w9/+Lq3/urXn3yG/8Xv+pv/Rf/h7/wb/0bf/of+H1+4g//L37R73r2Fz/7nf+0H/yg/k3+nf/mP/mZb//Fv/w3nr35zf7Pv+vX+81/s9/lj/v7/47f7Nf+n3+dv/w3TX+j7/3DxW//j738L/6gR3/9X/Jv/fUv/sK/6Xf6nX6XV3/V3/sfZId/6x/+m376a/3C3+sf+gv+9T/vL/gb/5n678j/lP/sb/2ZX//Tv/iPfnia/MzvOPndf90XL37zP+nX/vh7f/cf8xf+pn/l7/Mr7/0uf9Het/f+jj/xd/gT8t/p9O/6q/7P8U8u/uKf+Jv+5d1f44/5s/78B7/+33j+5/zW/+dnf8fl4e/zx8x/9//m1/nl/9J3/8zf/vf/vT//mV/9rW//jz+1/n1+2d/5t3z1mz9r/rvz//nx7/e3nPxmv8/v9N/8BX/u3h/74u/94/6v1ed/3J979uO/w/80f/67/eRP/Zq/5y8s/5hv/3cvf9/6d/u3//O/7e/7M/6S5//OX/yvbX3r7v/0p3//1/h3/sIf/9P/rN/kT/nx//Rf/Jl/+J/+t/+8v/pb/93f/Avu/63/0N/1d/yff9qf+Bv+tl/9PT/54OO/6Oh/+H3u/in/yB/6e/45f+yfmP2av9ef8Ys//nzvp3/y//h3/8ff+x/63Ub/4S/+iV/wB31Wv1g++h0/2/4NDsd/x//6K5f/2+j73/8H/5jP/oR/7I/7D776+37VP/E//iMn/039j/2pv9Hv+t/9tn/e+V/4yT9z/zd9Wf1f/+Ov/0dd/7lf/gvP/sH/9Tf9I//BP/Mv+F3+hV/rr/hXf/VH/+m7ZvfX/Ot+8n/+yf/ky5/86lf/Nb//m3+u+u3+6Z/8db/68/+2X/uX/m//2V/6Hx4/e/Gb/uP/2O7rv/AH//Fv8rf8Sf9gdvnoT/2xv/XTNw/v/ia/+7vfYufwb9uf/75/0PQv+wf/gn//7t/4V/2C7/y5//Y/8eK/+d1/v3/9r/rqt/2jf7//+b99+qfv/n5/2w/+qD/kW3/c98r/8fd4/k+1f9gf+of9+X/2n/cr/6tf8hf+yj/hP7r4T//Lf+j3/E23foPf/2/6bf71f+LX+c1erX/8P/it/tb//tf7id+aPK+9X/df+oP+6P/hb/vs8U/8ce/+nf/hN1pPdv/8/+vP+jU/+ey3+m727PM/49HLv+WPPPlnf6c/8E/+v37d/3H/b/8l6R/e/Am/4y/89X63F8u/7J/9I3+jv69aPv8n/vnf7Bf+zK/+13/J7/h3Uoz+e/yDL//8/+1X/W+//7/8g/9odv8/+LN/v9/0//5Vz/7Rf+qf/+m/6Z/+8b9k97/9o37VrzH7h/74v/HNL/srv/yff60/qvqtsx/Uv2f9R/8av9c/+jv+wcnh7/Pb/e9/6z/z5ifPf5df6/qX/aJ/5Y//nS/+0ZNf8Gv92un//Yd95+lv+Hf/vf/M3/y7/97/4T/7z/yx/+PhX/PL/8V/4z/5b68/+iN+i9/6b/z1f8V/9B//F5//fsfP/qj/7fu/4N7f/r//8f/ln7P6z/6MP/bP+T9/2X/0D//7/0zx0Z/2+6x/59G//cn/+gf+7b/Vn/zl44//rr/rt/8T/vYv/7Z/+d/855//sj/jo//m7/y3/8w/b/R//7and//bZPIf/wO/4I/7+6f/zP/1X//X/9ofcvzv/vhv9ne3//Yv/s3/wH/8r/yj/4L/6Df7e//zf/8nt3+fP+xPmf0Gv/7/9vv+1H/+1/ySP/9/+yf+h7/mL/mLf6f/7F/9Rf/Of/9P/Ip/4Iv/+l//3//hv3P9V/5Zb37Vb/T3/We/edP8H7/9v5P88//cv/gPfPXb/uN/5h/5pyf/4W//p/6e6af/3B//N/+3/8bTZ1u/3e/zZ/2+/9U//Rs/+LPvr//s//qn/ob/4L/8Vf/T3/BH/9er6jf53f/1f+dq586/O3n3r/65v3z9f/zUP/Hv/i1/7u+x9S/+2//gf/PX/aZ/39/3B/3EP/q3/vivm/7Fv95P7vytv/UvPGr/5YP6t/r+qvhj/sKtP/7f+xs+/yP++L/uf/39//p/Zvr6t/t3/6e/O/m7/ug/4P/4lU9/l8//+D9/69nDf+fLT/6dP+zf/db3/sM/4FXxW/53P/nPP/7sXxn/in/qP/nF6/Y/+c5f8l/+E7/RH/i3/cN/zbf/jH/ql/xuv98f/kfm+e/20T/yTx38X//CP/6X/Zd/zd/wu3/1R977t/69+ef/5Z/wi9/89J//u/5rf9ov2/roP/od/o+/dPEf/l9/wUerv+N//b3n068+/9P++jujP+pn/rR/+V/8Xf+DP3D5B330L/yzT/+RFy//sH/lH/sd/4uf+Iuufu/tX/f13/onff+j49/4b334+0x/t//gH/jjHz/7o9/8KffqP+Lzf+Lf/m//jt/rT/grv/Nv/u0/0Z78I3/h+cX//L/+ev/7X/BLT4sXv1X7K//pH/+7t948+Id+3b/03/6n/5z/7G/6X/+eX/nb/oV/4L/4j/3E7/grfp3r//aX/l5/61/wy//kf+2/Wfyp/8vfVv4rf+PDP/LR3/yd//mjX/run/iL5n/W9Jf89//Hb/mn/fur3+v3+Tv+/j/wx9e/3r9wee8v+Ht/y/wv//af8JeU9f/6B2//Fv/wH/XRH/j9v/Lv/o32/rJHr6f/1Zvv/cw/t/0Tf9Kj//aP+wN+k3939Wd8q/nN67/2//pV/+b/+D9P3vy6f+if9Gv+/v/x1p/+D//P//Yf+6/Wf97RX/8v/au/17/2a/3hP/NLfr2fefjr3nn+6/ztv9Phr/jz/qC/8bf63f+Wf+FPHG3/qt/tHxz99Vt/zH+V/KGzyfZ/efD3/X0Psx98/ODv+/N/8//pj9/9X7/45Mf/5F/77/ztP/ob/rv7/9HOH/uL7v7y3/6P+VP+7r/mf/oP/5F/9Xf6w5Zf/eDb//l2/uBP+uVf/Zkfv/nuvdd/ycPPf/9/4bv/xS/6l/7x3+uv/yve/Kf/+NZ3Hv4Nv/fer/yTv33wH/xnF8//nf/uTz1e/mntP/TxXzn7S/+nX+P0z/wL5n/0+sd/57/vF//+v96//Je8+HUP81X2H/+Tyz/hH8//sp8+fvDb3N/+sd/hd/y15r/pX/G//Hl/8L//J/5j+//OD/61f/Ff/8N/nb/o3/7Tf+dP/pCfOfjnf43f/Hf5j1/+9f/Zv/hn/tnL32v5u/wX/93f/ef/aa/v/AG//Mf+pv/0nx7/0j/sN/rTXv1hf95/8dE/M/34j0j/kH/iv/y1/9Z/7Vf8Zf/Dv/jTv8/q//prf6d/8Sf+jV/5d/+W/+a//mtM/pVf8Wv82O/zu3z7X/vz1k9+r1/5u/3R//kf/Mt/9dk/+i/8R//pH/unv/0H/ol/6x/4zxe/zuMf/M+/4Hf+F/60P/l/+0X/9d5v+3/+13/b+i/9T7//6/zWv8WD/R//S/+TP/lv/tf+kumnv+3v9leVj//8X/Bb/8a/5Nd68Qv+8L/v9H/9dX7qvz/885u/vp4lv/nO4Z/69/0Jf8H4dPar/oM/6Hf77A//A57/Zf/szsN/7zf+d3/B3/+7/Tlf/boHzZ8++3X/4N/6L/iPLv6Fv/Yf+ZP+hV/8T7/6Rxa/zn/9t/1BX/yLv/g/+Vv/t9/+Tzn46//mf/ST3/G3/xP+11/xx09+o9m/evKtf/O//zMWf94f+Yflb/7Zf+MX/OH/3V/w3bt/8s/82v/iu3/jd/jJ1zv7v/6f8L/+b//3v/B3/p7/7st/8cd/vf/+b/6r/5vi0f/5L/+3/9Zvf+e/3Lr4hb//5M/7J2btT/2C3+7f/13/oV//b/kzHr/+q36nTxe/5+/3q/Z/p5Pf7Z+u/qU/5k//bf7kn/y7f91f91989duu//df58c/+lb5X1784sff+kP+1dGv/Xf/Vj/4/f+eP/dv/Wt+77/hX/j27/m//bL/5G/9h/7Yv/rX+y1/j3/hH6v/lf/91/iv/5M/6uN/5U/6vX+d3+9/+Nf+/N/n5Uf/3l/2d/36v/N/+5v97f/Mv/tH/Q+/fPabfvKX/5b3X2z9z5/8H3/hf/b6j/73dn6zh3/yf/1P/VP/zF//b/77f8ujv/X/fvNy94u/54/+137V//X6j/s9/9Sf+OJX/1G/zu/32/4b/8R/+fbX/J1//V/n1/21f61f84/5Pf7s/+v6t/gH/5bf73959Jf+7d/7W17/Cd/5bX+rf/YvfPZj6y/+iV/55D/+I/73f73+zf7JP/rjP2b5Z5f//eeHf8K/8hf9Wf/cx3/9f/mv/6nX/+6f8vfNt/6Y/+Mf+XX/u/zv+fxP/r3+pN/2v/4v/qlf4zd58jv/xP/84o/+Hd7u/D6/6s/9ZX/jp2+Lv/I//Cv/gb/x9/t89vf+R//Jn7ue/59/5bNf9fb/+k3+1j/jV975a6//99/k7//Fd//pn/jxv/M/+nv+x/u/3ff/sH979ac+/ROa//iPPfzP/8F/7e/+N3/mJ3/7n/htr/+EvT/17h/6T//ub//mv/svevzPLud/3r9978Wv91s++2f/uD/8f3rwT/3T/8ryb/ub/ra/9Xf6j378v7zzrb9p9sfs/HW/5H98ef0PjH6N//Nv+4P/sM9/ydmf95O/4R/4N/8Tp//1P/Y7/MP/5L/2Tz/79Lf+L/+bf+OP+7X/gl/zH3r2T/9n//A/9X/+9/9a8o/9zLvf/Kv/6h/a/R/+1t/66I/+1//iv+k//huWv03+N/x5f9df9wc/++v/mH//d/gjdpK/5jf6j/6OP+uP/q/+/D/5N/l3l7/dp//QL/97/84/5e//G/6G5tu/xu8/+ZP/9fJ/+vX/vX/vL1vWf/Wv8Z/t/EMfNf/G7/63/xs/ff///F2fb//W28k/8rfu/Rm/y//wF//Uf/u7b734M//nv/Pqb9j+JX/Of/zrPfxFv8EfO7n80/6QX/uX/j3/7m/2nx/9z7/zf/4v/7K/8g/9k9e/ye/7q/7k+f/6j5/+yX/I67J699//i//j6Bf+D0e/yZf/wL/968/+qD/vr/sV/8HvOvlPvv9r/S+Pzn/RRz/+J/6+//kfUJz97g8e/Bq/2dGvPv6n/uw/4a/74x/8xK/3+Md/i//gX0/2/ozf9z/9J376z/sTF//1u2//Cae/5SfPfvo/+9d+5s/8t1d/2X/3P/11/+f87/yd/65f9Vvu7D799E/9jf+B69/gv/7d/pW/7OxXzv+av+PL09Ef+T/+X79e8xv/PtPf5B87/Vf+g//0d/vDfuu//y/7nf+cv+V/+9t+l7/43/j03/77f8Hv9mz/07/7D/7yn/ydf8M/s/ib/pu/5O/+mf/okz/mj5n8U//RH/cH/Qs/k/2+/+NP/2d/xeoX/Fg6/iO//1d/73t//9/4u/7vf9u/8dv9hj/xM+8++j2qP+Zbv9Ovd/Dv/ZVP/94/9vgX/OP/8HLrD/zHfve//A/4T/73f++//Ht/7B+584f9l9/5y3//P/2f+xu//x//Xn/jzurdf/27//K/6j//o//aH/un/rK/afa7/Yrf/W//B67/4Os//e//7Nk//gf/QX/hu3L+X/+u/8E/9ev8Bn/67/Dv/U+/8tf9136n8k/6vfK/8t+/u/v6r3x4Nvron/wr/+J/9S/+u/75P+Pt6s/89lf/7e7/+Rv8K3/Sf/qP/O//yz/yS/+y7/wB/80/+it/xW//S/+H//X8t/h3/unf/l8dPfydfqN////+L/7Vx//Z7J/5NX+Hf3f1J/3g1/83//1//0/6i//rv+8f/5/+7t/rb/4P/qT/5n/4bR78H//Af/17/J2/zb/xv/7bf9mf828+/NY/+I+ku//o1k8dfffX/pcf/9V/+d+881v8ocm/8tHJ3743/q/+ufRP/c1+3a/+xl/9j/5T7/7RX/u3/o1+2Z+/0/7i3/g//a3/o//606b9t37Pf2Pxr4z/0L/2f/0LX/whv+C/+ms+Oz7+B//en/gH/tW/+o/87X7Jr/y3P/kNvv+bffQ/fXT3H/ipf/iL5//z6v/6ZXd/89/9o39863jxm/9ab/7Wf/CP/St/4vKv/ugP+/Mf/MV/6g/++q/+gs//11/+/T/wX88n7b/8p1/f+82P/4c/7PvXj4/+tb/oP/sTfq2tP+lv+tf+sPlPnn3yN/xHx79k65f9z//h7nf/hH/xl33/7/xP/4o/+5Of+ZkH/+avfvdv/spf/YP/9X/4V/+Nv/T3/Ef+un/z3/vffuIf/X3qz3/b/+A3e/WX/gt/5y/7Xcp/+Isv/7ff8zet/qPsz/89fu+PDn7Bf35y/rusX/4J/8OvbP+Cu3/G//3X/Ja/xR/7h+4s/9n/4H/M/7o/+Q//M79zOJ38x7/h+d/2+/3Cv+3Vb/Db//v/7q/1n/x+/9Xv/sV/9Gn7237//E/76E/7J3/J//y3ff/3+Lv++T/5Z/752Z/y+C/8c3/6r/kloz/uj/v1nv9Ns/S3+mf+vj/s3/09/9u/4cd/r798/Lt9/C//bv/B9MFf/of85U8e/K3/5f/yf/+x/8bhb/Wn7vySP+Qv/Pf/oeOnf+O3v/Nv/OYvPnr7E/9N/ovO/+bxH/3uW3/0t/6RH/tzfsd/5re9ePHff/un/8+3/9j1d369f/Sf2fu1fvHv/jv8g9Xf9FtUP/M7/9hf8Nfu/ZqffPInnj/+Nf68v/x//Cte/rl79e/6+/7rf9D/+ef/V3d+6p/+Jf/Bb/RP/kWT/+k3/SO/+8/9O7/3z/zb0+Nf56//DX/lZ/9M3fx1/9Sf++J3+s9Pf4c/67f6ax7+e3/dr/hX/6Lf/G/75b/r3/bHfutX/DPNP/R7/bu/8t/53f/5P/Jfuv5DDv7+F9er/+jP+y/+saPf7jf7sx4f/Kv1y79o/p8+/lP/kf/2P/v2X3L63/5Nf/X9v/qf+XOy4nd78mf/hX/8v/inf/svuvNH/yHH//h/9bu+/vX/sJ/+L/6sdx/92h//Ln/J7/c//++Tv/bZD/7u0631j7/7+J/5G//98vjzv/kvufiPXv3zv9/5f3T+237x6/7EX/xH/iG/3qv/8A/+m3/Fn/sf/cG/9f/6tz76t3/P/+F73//z9/6Pv+XH/t6/5w//S37fL/+Vv/nH/qWt//Uv/+6f8E/+5//Zr/gt/sU/4Wf+3bf1v/gnHv6+v/hf+iVv/vl70//1d/vb6ov/+0/+F37J3/n7/4a/5Pf6W37Vb/hP/J7/0P/1Bz35px//33/N6T/26z/ae/WLLv78N7/6/zr8I/+EX/lfZX/qv386+q9/1T/9l/7Zf+mv/Ov/7P/hB5/82v/06u//zX7nv/PXSn/h5//+y7/2W7/DX/1P3/+/s//g9/t1f9U/8lf9VT/zV/55v8VffVz/i3/w7/H3/pI//Rf91n/MH/3dX/Fr7/zPf86v++vv/61/7R/2d/0N/8ev99W/e/3jv+2f//v+T3/u9x/8z6PdP+Cv/Af+/j/lN/59/rl/94/+wT9y+lv/q9+9/Jtf/f5/8x/yB/0Nn/+Xf+M//PrP+bf/qd/2t/pn6t/m9A/5sT/+8Df7id/n4S/7Wz/O/u4ni+0/+zf9Y+qX//Rv9tv9Rf/41n/4bz77/J9++cf/vnv/6j/0f/9O5R/3d/3Gv+m/8r//qf/2X/jjf+2v+Rv9pn/bv/YTf+/v+m/9RX/CX5P95b/57zD/9a9e//a//Nf8I/+13+Xsbv3b/3X/66vf9j9989e//TX+l//kD937jX7Z71t9+/of/st+Rf6P/Eav/qL12d/6p/3f/8rFX/tr/p1Hf86f/Uf8M7/b9Hf4r3+bf+Bv+sm/42/5Xf7Ij/+Nf+Bf+nX+qfVHD9cHT3+b3+yf+vX+vb//j/i7f60/9Hf4D/6P//7ve/6tP/q/+OOL//tPO/iZ/+uf+i3/vL/6r/o7/5xf8Ef+L//R9d/48H/8jf6kn/noL/5Xf+d/7e948av+hD/h0z/61/5987/sd/pdDqov/p7mP6l/n//sP/hXD//Z37r8Z7718r/+O8t//A/7z/+63/9v+I8+f7r9H+9Pm/vzf+af/K3/q8N//sm//hv8T7/X3/3b/Hp/8rOv/vI//B97/Xv/8b/TP/8/fvJ3/EV/4Ed/3B/0R/6Gn/91D/6S3f/oT/g3/q/f4df+9E/7J/f/2P/oL93bbv/4f3I1P/ut//1f/1f/Tfef/ZaTw0e//u/7m/z79371b/2b/wG/38/8bX/C9//83/4v/A3/zj/i9/p7/qfv/E3/4v/9q//v//HLv/nPPJn+iX/JX/MHv/zb3/7Er/xtjv6if+fv+Onf5i/6s379i//zv1p8/usnf/bv/ac3//rv+d1f46/7vf78f+biN/2Dfp0/6132m/yq//j00V/7h/z7f83/+t1f9sf+q3/af/Bnf/Y3/lW/dfurfuzX/d1/6T//5Md+4//q3r/4V/+W3/1Xf4cn03/y9//txn/SVfHr/W9//Z/5a/3M9X/64pf+6f/jn1H/xt/7Jb/N7/5P/E//yvh3+oN+k39v73/99f7V//4P+zuufu+T7/++/8ajPzT7k/7sf6H6436j8z/3/NNf/W//rb/53/U3/Av/2287/wX7v8n/Xl3/i/9SenX/V/52f9if/92zvd/3j/uHH/6O//5v9/v8Ou3f/p/+TX/nr/vb/tf/9v4f/+f9xv/1f/hrpf9kNfpbTv6b3+Yv+0de3V0+/LdHv+j//mP2Pvm3/qm//p/85M7v+u/+1x99+mf+pX/mn/Kfvyn/3fZv/M6r/+U7v/9f//v/Pv/Z7/iH/Tp/wvf/4r/uH7z8L/6cX7R/8vC3+dv++s//q/lv/XdPf+m/+Bv9y//b7/zX/Ge/3vO/6HDn7/pHf48/74/8Xd/850//+F/3L/j7Hvw5/+Hf84f9xH/9a/7r/0jze3xxll+sln/Sv/fpf/LfPfgD/53fdfIb/7e/6K//y09+v3/yV/4ff8Lf85f/hr989Nf+zb/xs7P/9Lf98f/xq7/w5Pf6qV/xZ/8Jf+Qf9dv+4b/4l/7qf/ZP+fP+27/19/9XP/+n/7X/7O/4rf60j3/RH/Wn/vm/z6/6hc1/ePcX/vG/5u/w6jf+tf/sP/mv+2v/6eRvffDj/9in9Z/yt/8pf9Xv1v5FW3/ub/oL/4zfJL/7E7/Bx7/icvELfuZ//uv+3v/rd/31f9Vf8Vf+HleX6W+c/gd/0uXf9ff8Fb/40X+x96Ks//N/5Ad/4Lf+xf/w/p/8J/9ff/Y//BccPU1+4X/wn/+ef/Vv/8/+O/f+iK1//c726vnv/W++/u//zX/rl/+7f/kfUP2Tf9Ov/7s8/53+t7/vn9r+8/+U//p3OvuFv3hr+ff/V3/v3/qn/pp/9a979Me/+nV+1e4/+1cl01/6u/73/+z509/wf/zPf8Pf89k/8vjb//lf/uf/Fvu//uN//A/9Hf6ZP/H3+Rv+zovvffpj29/68/6hv/2f/uOfPbj3e/+Jf/Sf+C/80X/m3/s3/Ya/5n/z6/wJv+xffvCX/iff/0+e/J+/7u/xn/23/8u3//X2P977S7Z+k3/6u18kf+Ff+Hs9+wv/pj/q4e/6j/23v/AX/wZ//Z/29z39Q/+l/+6v+eWz3+eX/On/5K/3t/z9//dv8+LvfPef/QV/0P1/5V/4j/7jf/XPqn7Hi2//0r+6+D//6D/oT/yj/vW/7h/83/6Rv/Ht4b/w7/2F/+Fv81/+Rf/kH5j9Bb/p4R/+S5d/69/54tP//bf6h3Z/4nf7/k//Vf/Ff/1X/l2/1b//uz3c+d1/t7/y//6H/ppf9Vf/on/vX/2x8T/8q/+8v/V/rv7Mv/FX/jP/5E88/fGjv//v/0tf/s+LZz+z86t+p7/sO7//qv4P/vy/6LN/7Xd89NU/89e/+a//2v/6j/2f/vF//p/8j6o/4O/+D/+Q3/LvWv6dv+G37vwl//mXj/6R//6f/W/+qD/7r/zPvvW//yP/5v9y+kf9h3/pf/VH/8F/y1/6m/6tP/m7/n6/3n/wa/+uvyD983/Rn/1n5+9+z4+KL3/Tf+7f+wt+xfpP+kNO/5NHv9mf8d/8rr/2v/xn/8+f/Oaf/zM7/9B/k/4fd3/pb/rib/ld/o/d/zT/5ct//uIn/8q/+K/93n/1xxd/3/9R/skf//hf9Tv9wr/xs7/86i/43l/3f/5Nv+jX+i9/02bvV//Ub/4rXv8Lv+tv8z/8Xr//n/77/Bd/1a9q/6ji1386e/HbfPR7/u2/7Ff/qr9v8a//Qb/x9n//e/3Wf//Hf+7/eHHe/v3r3+Y3+A/+0gfP3/0lf9ybv+L3+Id/ye9b/KVP3o3+2L/m/JPfqf6N/oqnP3X2+/3zX37v6JM/6l+5ev5Xfv4X/BYvftvTf+5vfVX8er/23/qH/RPrX+v09/2//rR/97/57a7+yV/5f9//ff/+v/Ff+ts/+mf+rj/6n6j/x9/gD/8HXvwef9c/8q/+Nn/Hn/Dd/Wz61y/+g/lf9Dv/AX/Dr370m/01/+5f96v/mz/jN9j//ed/xqvv/bp/2O/+z33xC3/qt/6Hfs/f+9/7PU5+9e/8Lz39a//DX/vx//Tk2a/4V4/+sV/r96r+5It//M+Z/cL/+x//HQ//oX/89/nz/rR/5eVv8I//Z3/9X/9H/HsPfre/7dOf+Rtnf/tv/IuvP3nwD/3SX/F3/y5/4R/9i/6tf/af/Cf++z/hv/6F/9v54dP/61//48d/8G/63/7hf//vW/1+/0zzV937n7737/4b/+X/+H//tr/Wn/fbHv4Nv+W3fvp7v2b+3/zjv+TXvfMvPl7f+e53/qq/6a/94lv1b/H5H3z1h/wuf+8f8Rf+2X/U3d/4//x1/8Q/+5d+6+F/+Lf8pX/tP/Y3/mV/3z8z/5nZf/1b/DmX6z/49/rzf/xfevX93+xX/hP/4P/S/Jr/yyd/9N/4u93/PX/Vr/UL/6W/K/9t/p0/+Yt/7R/6jX7F//0rf7u/9W989Js9+Wv/0l/zX/ot/72/4a9+8K/+k//TP/M3/rF/79E//Jv95P6f/xv/Nsv/9lf/Pf/oH/43/e3/14/9en/vu3//r/23T//py1/zn/z3H/2T/8RvuvNPzn/Hfyz7vf+Lf2rvj//tf6d/6jf5O/+Df+aT3/9PPZ//5N5v8Nv94X/ub/vL/9W/6rf4e3/TX/aD3+Sf+P3+9N/p4/av+Wv/41/1f/2u59PtP+L3mvxjf8Q/90//cb/Jr/EX/iG/3dG3f9Pf/T/4h/7Dr/6KX/gP/cP/99/xj/+qP+w3+I3/t+v/9fcc/Tt/88u/4qOt3+z//G2/da/45J/4g3/J7/ob/vW/6a/3x/4tv85/dPcnX/3hf9wf9mP/+tXOF3/8r0p/r1/j7z/9m/+Yk5/6I/6C+5/+Df/Bf/Ev/DPLv/BfyH79s9e/69/y+/w9777d/ot//ot/7Tf98/73P+93/6nf8OCTP+rjP+Vfuvflr/79/oW/6b/6N3+Xr/7xf/wf/T+af/Pvv/c7/Ff/+d/7H/7d43//9/oHLv+u/+Wv/TNPti7+/e8f/OAfvfOH/Ovfe/iP/NTV31H9sb/Wf/9X/6f/99Zftvdj//v/9jv8Db/X7/V3fO/w//ijfof/9Tt/x87rP+jtv/P7b6//6N/k+nf5Pf+Cv/HP+b/+ol/n8z/9P/pzf8X/8FPb59/5j179Hr/o6l/M/6w//R//56//1P3D1S96tve7/+Wnf8tnf+Nf8Oz3//2Kj37z/+1f+NP/5ON/9dGv9zt9+Sf+Db/hb/x//kZ/y2/31/3+v/DXTv+YX/KX/um/RvX9P+TXf/HP/3t/5//yr/+z/8of+fv9+n/2r/rX/9efOvrd/+g/7q/+T37R5//JP/YvfvyTv+qv/M2/8/jP+ff/l/+5/C/Pv/eb/QV/1T/7G03+mYeP/4J/+Nm/O/7H/6df5y/837/9i/7Kv/1P+u0f/06/43/5z/9ef8ef+it+xez75U+sv//l3/C//6G/3R/+W//7/+xf9fzkH//3ful/9ff+Z1+evf4T/6btt3/97/v7/4Z/2B9+f//e/b/j7/zjfserj7fu/FH/Xf7xn1P8Vr/Nb/2n/bl/zsP/5g//5f/df/rf/ff/0//8Z/z2f/yf/Df8iX/3v/Yb/u2/y9Pf6zu/8+/0O+4/+PSL51/+en/wX9f+X7/ZH/PLvvvRH/Lb7/wf/+f/9Xfs/nm/5e/yG/9Nv+Nf9X/9hem/sP3PfvTb/m7/zh/7B+/W+/9H8ze8+CN//D/5zf+r/Hf5DZrf8df/pb/L5Pe7+PN/g//sz/81s9/k9/49f4ff/Q//T95+e/xH/lP/xd/6F/7x/9w/8N0/8+wv+Vv+zRcnf+zLH/97fsE/8A//97/26e/29/7hv92vU/3S3+qPmf9Do3/wzYMvDtK/8rf9Xf/KX+uP+8t+wR/0Fx783t/7G/6tX/GX/vhf++f+Vmd/wz/0B/26v07+z/2q3/rvLf/uX9z+MUe/9e/zx/93Xz7+D//bz6cf//nVL/7pf/0fWPzC3y75k85+g3/nX/7Nftt/cv/+//zPHjz8937ij/jj0n/zr/hN/u1f8guq/+LdX5z8q3/dL/hbftF/+70/+Lf4je7+D//Y7/Y3/MI/5z/7Y/+Ff/i//p9+q/1//A/66/+xB7/pL/81/tr/6Bf85/v/xY/9hr/sPzl4+sl//Sv/9T/2avaH/2m/5Z/4L/yXf9Gv+fv88d//J79b/czZn/C3f/TnPvsj/q5/8/Wf+vg//i8+/pN+4h+489v/b3/Vo9/7H/3l//z/8S/97aOnf9CDP/9fbv+3z453f+df/Z/8gb/u7/nX/Lr//W/RfvQv/p6zP/If/+P+z+IfOfuf/8n9X/Kn/I5/7u/4yW/yB/5lf9Qf9vf+Rr/N7m/3u/ydf9QfufwH/p7v/rF/4i/9y39m+Sv/yj/+7h/8vb/73/5FD8t5dn5R/p+/6Z/33734LX/H3+762//7716d3Pu7/6G/+O/66/6IX/Of/pf+lzd/29/1m/w5f9md/+R//Yv/4D+g/CV/wc7/+jN/2i/K/8jln/PHvW3/vl/9x/zLD7a++p/+yl/1Hxe//ue/1x/51//UL/ve7Pf/8X/v19j/y//4f/zvX/47H/2Lv9XhP/ZH/77bf/w/+J//VcV454//VX/M//1b/tlPfvPXj3+t5N/48ZP/4Z/7q3+t3/T/+Mf/tPyP/VtnJ+u//z+a/ifr//r7f8r++vf5X548v/8r/tA/4E/5m/+Z/33/T/+N/s5/+F/6p0bfevqH/rp/9e9+vfdf/fr/5K/zb927+K3/1avzf+Zi8k9e/qJ/JCv/9fYX/xu/17N/899+8Wv9G//wH/7H/R1/2z/2F/9D/+ff9/f8odPJ71P+2b/ub/Lf/Irf6n/9x36PP+Thb/hn/S07f/Yf/Zv97X/j3/Wb/DF/7B/3p//Jf9Kf++f9hc/+4R/84T/x7/8Zv93+n/vn/Yu//h+w+zv8hX/cH/3PfbL6l/6V1//m/d1P/8Lf+c/+bf+wP+Lv/EV/3dUf8A/9rr/ZP/Q//5t//uKP/Oijv+jX+vP+83/8//7u3/kv/cTnv8sP/uzf/a/9XdYvfuaX/Mn/9I/9aX/Zd/+Of/1P/Mnf7Wf+uP/hX/3D/oqv/pCt3+Av+7P/qD/74Z/0Gz76dX/Vn/ar/6fvl3/O8q/9c3/Zv/aL/tE/+xf+3r/WL/tV/+If/vn/Pj77RXe//b/9Ry8+PvnX/pa//rPf9Q/7sbP/ZvlnXP6T1Z/6yT/73/yTD37yX/sPf8GP/WVX/8K//PKP/Xd+94/+s7/mr/33/sj23/71/4vVf/T5v/jv/Oe/37/y3/86/+PvdvDf/p5/yZ98b/G3/x5/w5/wL+z+ufd+4/393zD5v4u/9f6f+Md+8pv9Gk//5HtX/8fll3/c7/8f/UZ/6skv+asv/qr/4s5+/b/+xwe//E/4tx/9e7/30fgf/Rf+2X/rz/93Xr/aO/lrfvk/8sf/8ePRj+fvfpM/+u/7j377V/Wf9MmD2ePPf+vf6nf5bX7zP/Zv+wP3839o9a8v/61/9T/+M/7g9g/5s//nu4/mO4vkqz/6f/ml//Cf8Af+Bf/CH/3P/U1/26d//B/+1/32P93803ef/7N/2cu//f4v+f3+gV/74Ke+++/8m//ExV/z2b/8d/01//M/tGx+2z/yd/tjr/6Au//o01/vL/7dHv6f//s/+2e3v8s/9Rc//xsfvF7+s//a7/1P/8m/w+/2x/+j/8Rv+vde/5p/5m/w3/zPv9Pv//1H7+rX/827J8/+6Oqnv/gff3z91/8Vv+P/9m/+3f/VR3/Ek4vf4Xf+Pf7ar55c/CN/1p/95/8Bf8q73/x3+0f+jL/in/hff4N/rfmn/tP/8j/9A//Mv+S3WH/0v7T/0q/3Z/1n1z+4/uwnv/vyo/Xf2rz9Q//s/3Tyx7/+Pf7Gf3/y9/1Z/8O3ml/yJ/2+f85P/SU/8df9QX/53/mX/vl//e//uz/7b3/Dv/Ov//jf/a/PP/olf+Vv8+6XPPrT/+g/4Z/+rT//R5/977/qj/xD/qD2yz/wf/wvfumf8uh/+F+f/0V/27/+u37vF/83/+h//T/9c//xf/erjk//wH/x7/grf6u/4Q/79C//hX/mL/zt/rVf/It+5p+4OLj/X/51v9PfUf2i3/z5J//nvb/93/hr/5W//y/8N69/r/nof3306/wvb/70V3/+t7/77/z7v8vH/+Zf9xtN/sX/+nf81r/1u/ymf8e/+pv8/X/7v5r8On/fi3/61/yr/rDTf+s3/t3f/oO/1W/2O/yf//riH/pt/oI/9vf4536rH/ySp3/Jb/Pn/sxvOfvtyl/5/S//i7/lD3nyf/w1L/65P+6X/tLf/L//m3793+Pf/pv+qV/373z5j9f/1h/13/zUb/iP/+vf3imK3/K3+Gv2f8n/Wf2i3+/P/HN+l8u3D37Bf/CX/8q/63myf/TX/LN/0d9Q/cff+lvv/o9/3u+X/yd/2x/6L1yc/AF/0q/7t//Of9Pv/NVnn/xDn/2ZF9/+s//5v3T7V1a/wZ/2qvnPv3Nn/e7//NW/1R/8r/4ev+Vv/8/8jd/57K/6056O/op//Xf/0/7N8z/hT/vnfpt///d6/tvVv/e/8pt/f/8//Gv+gX/p//5vX/xH/9C//Pv8WX/aD/7vw9Hv/uK/+Rf+kEf/1W+19+/8wr/s7r/0z/wr/9svefsv3Pm7Pv9v/sG/+nf5Lf+Z0WUz+pt/yeQP+d/+oj/p3/uP/uG/6LM/9t/7n8f/xsGv+4t/1fK3/+N+p/29V3/1P3r4W/wJv/3HP57+oj/475v/MX/bb/43/Y6/72+7v/3f/o/tw/3/+ex3/OzX/sX/6P/6G/5h/9S3/+V//Tf+NX6Dwz/k08Wv+6/9Xb/H4W/xz/wO/9Enf8b/9Vv+Hv/aP/bv/Oe//+/8t8z/4d97sf13/cyf+7v+A3/yw9/m1z78pf/Un1L8UX/e7/jf/PT3Fv/k3/+v/mX/2e/+1e9w9z/4lf/t9z/6Xf+WX/W//eV/Xrrz0dGfkf8j/8dfsP3n/a5bf+ef+3f/Wv/dv/RH/WWvkj/lV/8Nv+w3nP1Wv8nit/3f/tmf+b3/9e+9/l/+vr/7f63/yt/jl+7+i//C3/md/+4//vf/hT/ji7/+/O/4Kz//bf/Z56/+s//s2S/4N37/3/mf/13+l8f/yeGv92v9BaN/+k88/S1+4b/6+T/5K/7hX/ZP//3/23/94Pf+B/+E9Bf85n/U7u/xD/xj9Re/7vnf/Z//e7/3b//v/Sf/5B/y5/z6//gv+qN+3f/q1/kDPvsdfuf/+Pf45X/cuxe/7aO/+6v/7Nd/8g/8GYe//S/8Pev/4rf7zt2v3v0+f/AX09Xp7/x69Lt9fPz5o/9+Plt+cf3b/Iu/11fJv/SP/0l/1C+7+Kf/vL/vX/qDZ3/q7/dPt//Fn/If/L4/8Z/90l/v6etf/e6//C/+xz/oD/pjH/3f/8PLP3frL/td9v+uX+PvKX7do/1/8d/a/5f+gn/kn/sjf/vHv/K//8u/+2/8Lr/P+l/+3h/xu/++v++f9xv9uce/81/w+/+jf/H8b/yX/5m7ya/+v/7G3/b//M9/wz/7iz/6+//HF4e/3/JfffsTf8jv/+V/9eBy9Pkfn5/+p7/Rn/BL/+Ff+M/9zW/X/83Rv/G7/j6f/+P/zd/42/3Js+/91r/oj3p3eefP+0v+zj/r9e8++Qf+nf/pr/u3f6c/++7f+duu/u1/svxbfst/8Bf8rae/4t/893/s96//6D/0j//nf+w3+G/++vX/+Hd/+ff9oX/w51/8w7/jr/13/K4/9a///v/4v/HJ9/7n+7/2o+Nf+Fn6D//av/H/8Df8pf/I33T8/X/pv7j4U7//vX/8e//Ln5b+wvmPnb189zf/gX/Sr/PP/Zp3/pX/8U/6G3/wl/1n3/sj/puTf/Ynfr0/71/9Z/7BL//b6//179g7/1t/+q/8dX+NX/PqVx88/Df+zvbX/9v/zr/td/1jfsO/7F989zsXzS/7/A//w1/+47/P7/zH3P1Xzn/xt/7lP++f/Yv/2l/86/6Nn/+td/+e89l/+/h3+QUXZ//4r/djf+av/lP+3u/8Hn/Hn/Or/qa/6sHk4pe8+UN+9dOf+duu/r4/92/73f7OX+O//D3+jZ/6j37Fkz/s23/Gv/sb/h7J//kHpL/xX5z9m6/+q5/817ae/Hq/3f/0D/1t//df+9v+if/+X/KvJ7/Lb/j7/89/8Z/yp/5507/nb/n7xr/0l/1fWw/v/4m/7V+38yf+kl/zX/u79v6g3+5PXf6Sf+fX/93+pf/t6S/7jf/+P/Uv/kf3v9f+fb9e+9Xv83/9C3/UH3X42V/6J46u//6T3/c3/+P+/Z/43X7y7p/9t/5Jb/7s5tf7sX/8P3n+m/4vf/F//Xvt/6mjnd/sV2z/jX/nx3/Ib/Q3/5Y/9cVv/Dv/kR/9lf/LT/3mP/kbvZz9Tz9d/lb/wx/0+n/5V8/+j//r83/2n/nFP/En/Frbv+/i3a/6Q//+s3t/29/8kz/+3/3R//iflv7Tv9Pv/cft/HV/yD/xa/3lSfsb/nb/1Xd+9994/3f4y3+H3+mL5tHf97vlP/mX/wl/4m/zV/4lf+lv+bu/m6x+j7/0b/pzTx48/rF/+Z89/e9/j1///xh//q/8M/Pf+uV691ce/D6/8N/8H9/+Cf/y3/0v/gl/1J/1h/7Un7375/4df+Sf9ejhX3r05pN//c7h7C//j/7hf/WP/bt+nd/8d/7eb/CH/NRfcvnr/GcXf99v/3v/Oz9o3n7x6/welzv/zH/yg/80+6k//q/669ury+/+uXX1L/3Nl3/O//qvvP7H/8D/4/E/cfW//He/9l/79D/9tX+n1d/2h/6ff8G/8y/8Id/6Z/+K//zX/jNf/Bknv9P/9Pv/K9v/avK/X/5Z/+Q/N/plv/WTB7/z53/f7j/x349/4nff/79+uz/hz/+xe//WdfHH/NJf+sdf/ZL/4gfz19/7mS+3f+YP/Wt+0d/xBz/5U/+u0cHflfyj/8Hv/Vf/rX/NJ//Iu8/f/fLv/iBZ3/sXfv9/6y+7+P3/mv/qk9/t//i/i3/v4tf66N/7V/6iB3/C9l/w3V/31/pz/oO/Lvvx//Rf+yf+hLf/+s6/+/f/Nb/q0e/4C/6l33PV/PL7f+wv/rf+m48/2/mbX/y6/+znf031R6zT/+PZt3/Jz/xVf/ivd/bu737y2fRf+je++A//6T9q/9u/1qutf/P49zhaHf5df/If9Uf/Mb/2y9/29b/3D3++91P/03/19/0pf++/+T/8Gf/g3/Nv/eo/6C/6hTs//fv+Iavfbf9Xvv6Jo5/52+79kv8y+5t/0Xzx8ovJ89/qf/nNT37Xf/9P+j3/sS/+5fLT3/Qn/9H/6C+a/sd/0r/6zy3r//jf/z9/g8lf9fanf+nv9cV3drN//x/+r//+ez/9G3/8X/wX//0v+Ne+/e6jf/svuNz7p5//qX/Mn/0Tv89H/8jf/1v8Rb/PX3rx65X/+B/xu/6Te//2v/Af/FZ/0pvf9E/5K3/x//xr/UN/7D/9p/3Tv/wP/er3/Et++9/yj/zN7v70n/tP/E1H37n7j//mv9f/9qv+vOu/5wf3/pd/6/f+/C/+Sz5t//W//A989J3/6Ks/9rf8B8Yvf7eHv8cf85/8Z//in/1X/UUff/4HJ//m8z/m9/4X/o+L2a/1W/9VB//Lv/33/O7tH/C3//N/xd84/bP+j3/u9/sr/qQ/6++98w89/+P+1r9/+q//sb/q+7/3v/in/ct/4uHrX/Qvf3r0H5f/wu/4f/3jf2316xz9iy//1fU/8+f9jr/VvX/kV/1+v/K3/53/5b/rV373//jTf+xf/8d+i1f/6V/4R/8Zf+3f83f/Nemf+hf83//gH/Uzv2D6f/4a/8w/88f+3k/+8dPf7L/918r5o//4l/4fs1/z9z/7Nb/3m+b5ZPFr/lm/xt/Y/vnf/luP/6/f6u/60/+i7/yNf8o/+0/8EXf+wrcf/zN/xOg7//kf+/Sf+f2nP/b3/g2zn/lfXvyqf+FP2P27/8Df9pf+ZX/0n/ML/oT/7K//2//VX7f56+b/5B/wfz/5V//t3yz9L/+gz//7v/Pf+l1+4ouXr5e/8OO7L5I/4Hf7z59/5xf99V9Mf5tn//Af9cf+dv/It/+WP+uv/81+nav/7umf/N/9zX/lP//H/fhf+i/en/2uP/l3/8X/8f9w8ev+33eOfvA3/faf/NL84U/8DUd/yB/89/w2/+af+vHFy//9N/8Hi//xd/hd/qTf8bf7u/+nX/0HNL81RTff/73/zF/xv/+9v/J/+ZP/p//73/hD/8S/6Y/9w37rP+ZPPPkP/+U/7tXfN/2/fukf9kf/Ab/1//Cv/C3Jf/rP/aOr//03v/f09Dd8/lO/5vI/+W//23/7L/lt0t/pq/97/Wf82G9y8ODZP/4f/qq//Kdf/fJf48/9u4/+kt2f/I/+qt/+F/65f9nV7/SbrH+HX/3L/tA7v8M//4f/C//cb/XyD/mj/7vd/+Q//Wt/z//xn/wnXv9J/8iP3Vss/6P/+J/7v/+3e4d/dfPR7/N7/yv/6M6dv+53aZO/9vP//Q/+pcu/+G/+h/+0/+w//yOOdv/gf+DswZ/6y/6tf/zv/w12/rPDP/+f+F3+wj/2D/kL3yxf/hX72//GH/PjX/5Fv9P/9U/9s//A7/7kV/148x//vv/6P/ft3+lf/7UO/6F/7vec/y3/23de3P2Jf+F3+XN+2X/xL/9h//yf+2fv5//A7/VTf8jf9Pf9Ob/97//i3/sD/7t/6Zf/tv/H//I3nv9Jf9x/8mcd/re/zy//l3/F7/Yvbf/yv+r1X/iP/Nm//Mce/gm/94vf6c7L19/9d//wP+f//IP+6N/16cUf8Pr3/Re+9Ts9W/wOv+sf+Lu++3XefPnP/EZ/09/8y/7WX+e//iM+f/jn/Nm/4Pc8/t+uz9/e3//3vv2n/A8Xjz4e/Un3/vCr3+Yvq36Lv/vP+NP/tb/sz/qz/60/4B/+m/+8P/QPWf+Hf+0f8Yf/Yd/7o37V1epv/hP/uF/2v/+9v/HDH3/3P/2Vf+nf9uv+Wb/G8W/zh7/+w/6c68Pf8Af5b/JHvZj/7h//Hf/jb/vb/LZ/wD/61/0hp79+/hv9wb9stTr53f+t7X/ijzz+l//z3+Rf+73bX+NX/x1/x+Uf9J9c/kf3/+vf9fFf/29NXv9Dv/f0X/mTln/df/Vf/62/1q/9P2398r/ob/8zts+S5Oyvq/79P/af+dP/k3/8+Pc7e/LFf5J963f+N/71f+Qn/7hfZ/X3/D3/5J/6ezzc+QO///1//uBf/Ef+hr/28erX2H/e/vl/83/7e/z0H3L5D/4f/8l/dvc3/N/+mV/n9z79Pb9z+T/8NcVv8iv/yL/vX6z+j1/9l/x+f89/d/Rn3f+7v/oX/9h/8uH/+S9874/5R//b//DX/xd/n+k/+Lv8gl/wO/zjv/Cv/ef+h79++/np5OX/8m/+PX/ry9/gD/6f/5y/4Ff+SX/OP3/0J/6hf9kv+bH/4bcb/17/+NW//av/zV//b/0H/5HqN/31/73F3/mXzeu/pPqb/+rsH/zr30z+nr/hNyn/s//qV9b/xN/4k6+++wtft3/v3/ObH/zxf3rym//Pv9Vv9/v8W//u7/3wV33+8T/2j//l/8g/9Bf9w8//6r/+T9kt/sf7/+yLf+3f/Jmf/ulfOfsVz//P/2P77/hbfuU/c3f6R//Gf/Z/+x//x7/Fu9/uv/8N8+/9j7/Z3/i//dpPf4df/ov+0P9u7y/9J3/Fb/x7ffv3P/6j/77f5l84/8/+4f/yH/kn/8Vnp3/MX/73/Mz/8Kf/Oc9O/oHqj94//Mvv/G1/4//y1/52f95f+8u+9d//Vb/T+m/8+Pf8Pf/i3/Hf+CN//f/lf/mbf/n//sf+m//Gn/2b/ov/8r/xv/yKP+3v/PNfzH/8/G//i/+v/+pP/3T2510/PZl++k/8769+r8M/8nf75/7oH3v3u13u/i9/0B/xf/5r/9Rf89f+GX/K7/GH/tF/xl/yB/xXv89/8b/8ih/7j3/8l//W/+D4N/mPfqPPDj75b0Z/9Ue7f/Kf2/7Rf8L0b/vr/5r/5pf/PfUv+LN+q+Tod/7b//Q/7Xf/rX+HX/O3/C//ml/467/8S/6ev/bf+Gv/qd9y96/7V3/nX/If/DcHf/u/efBHHPyS37L5W36jn/yP/obz3+ji/Hf+G/P/+qM/6Ls/+fv8uv/SP7H+5dlf9A/+y6//5r99/5c8/0fn3/3pN8nlv/Kvv7n7RbL6x3/DL/+BX+P5b/iXf/HgH/0tDv/DP2D+G/9xf+Lf9p//kf/Q8WX2H/zj//wvf/ef/MSvev2X/KvPfubvfPHnXL/5vR79G7/dn/LH/Orf5tf9O/7R3+36//j+7/tn/qH/5MN//HfPfvN/6/Pf7B//+G/4I6b/0l9/8OP/Qf3P/hm/8y/4gxZ/39/dvnnz7sHv83v/Pv/uv/vbzX+TT3+fH1z8Fn/D2yd/9H91+D//az/9u/z2z5Lf699Y1f/1v/iXrv/ifz/947/1a6T/+bf+9z/xrzv8b/7rv2Py6/xa/9Lf+O//Zke/3/bO3/Az/8aT7/wNV/Pf8qPfPftr/5r1gweXv8e91foP/Af+zr/1zZ/y7g/86vD66j/659a/8b9w+d0//g+/+uj3/sV/9D/68I/8D37jf6X4+36fb63/hr/kf/lHnr5+9dXv/b2fOv41fo/f4//4n37Z3/KX/iG/82V5/TO/5H/6n+vf9a/9a/+Sv/RP+9t/4vf7q5/8vtu/5rN/458e/8mv/+Bf/8Xv94d/5/t/0NlP/Mb/1l/1d33r9/43/6pf/Ss+/Z8+e/x/79z7ZXsPfv8/qfmp3/Vbf8Jv+Wf/nr+k/K//6T/0V/ydv/3/8Sf+hf/N37+8/s/+07/oX2n+8Y//zN/rk1/v9y3/mn/7L/pj/+u/+be9+Mvnf/6v/U+/+bV+7eXv9T/8zOxX/O7/6Z/wN3/vX1/+C7/T7/JL/pPf+d1v+c+N/4O/eOc//u5v+i+0/81f9Xf/m3/Kn/I7/HW/3n/y5/zCv6r+TX6fP/V3+DX/5MVPnv3n/9M/8Rv94//MX/vr/lG/0W/6G/wpf9af/Zv8br96dH//9//zL/+5f+kf3h41v+c/n37x9/41v9ev+5v/q//93/jH/n5/0L/4n239Hn/F7/D4v/wL/oj/9Z8+/0+f/oO/72/w6lf/H3/Pd3/Znf/r9/3Dfubf+JP+1D/pt/+zn/8rB3/Xv/grfu39b/3TzdXL3+JP/eP/sl/0N/2in/zb6+aP+XMu/73f5P/6re78kX/l3/Kv/Q1/8m/2X/+Kn3z6t//u3338l/99v/tP/m/Lvzh/lfwOf+Of8rf+DT9z+Is/++o//Fcn/8vf/dmf+sn6r/pX/5Hq+o/b/wv/il/r7/hnfo+/9Nt/y+/0C3/lX/jr/mH/5d/1O/5N/+C///293d/iu1/+ur/wt/h9/6rf4Fv/0m/0G/+Rv8urf+mP/BP+l9kv/1X/1t/0d/y6f8WvffjXJY+++6sWh3/LP/+X/Q3/87Pdv2rx+/2G/+K/+Bv9KX/VH/5//XN/zT88+R9O/6DP/p1//I/7i/62f/hv/Mf+lD/6/uFf8O/8Ln/jr/j2L52tH/31/8t/9S9+9Pv+q3/u7vHv/Mf/Rr/RP/7RX/nor/7rrq9/h39m684/9+f8tb/qL/4b/oG/bvu//Wv/qk/+67949Wf9SXv//b/2x3z1p//tf8sf+zft/kF//X/237dXf+q//0/8NY/f/B2LZ3/I//7o//znZ1ef/cb/yui//k/+j9/+x/+y//of/U1//T9j70/7L//t/+5v/zP/nj/nX5pk/+r93/yPTf/t7/zif+QPrf+J2e//D/+C/Nf4S9783r/h4i/791/83z/xNzz7M2ZXv/CfGi3u/WN/1m/2/O/5nX6DP+gf/cee/u+/+b959j//Dv/k/978xr/fX/7ij/h7H/05/873f53j3/Nf/hP/vT/2vzv5h37XP+6PnPzb//x/+Z89+/v/yj//3/h7//3//T/7zf+93+DqT/hvfnr02T/y9z74s//j3+g/bKfLu3/bn3b8Y9/+9b51+G//Aduje7/gv/n8b/nj57//7vYf+8f8vV8+/9f/1D/l7/2Xft93//If8O30L/tr/5L/5o/+8z/+rb919Xf/fb/5P3f2Oy7/oT/xf3r08I94+GNf/OLDP2r/d/wb/62/+/948fAP/03v/v2/8Hd+/Xx38p0H8//iT/mND/6xV3/lH/Eb/pW/3+z/+N3+5D/xt0j3/6Of/Ju++ov+qP/i9/+j/vn6d/ul/+V/8Cf+i//I/1T/2B//p//6/8Kf9Rv8oX/u3/HVH/Pxr3307md+42/f/aX/yt/24A//VTt/0L/5rdN/d+/ob1j/eX/D3b/3r/9r/sbZr/F7/5d/+/0f/LG/5Pf8H/+033G2+OQf/Omn//hPLv6nf+/X+L/+mLu7h7/vX/Dl9H/4Xf/1P+TX+bv/ir/yr/qz/t2/5M/85/73f/rTB7/w47+o+fP/mD/s8l/+J9O3n+3d+av+yi9+xa/XfPJb1n/Nn/vX/T7f3/9FP/Zb/VZ/45+2+lsvf+Pf5W/8T3+N3+GX/y3/0l//+e/yC/7yX9o8+dP/z//jz/oNfv1f8kf9xG/1l/8Rf+4f8y/+fb/x3/Dk9/jnVlu/2Wf/8X/0h/wzv+Wf8oM/5lf+M7/RP/V3/82/3m/zF/7Rf9xHn/5J//2v/Q/O/6L/7J//X/7cl3//H/zP/qo/+P/663/lH/Sv/br/8Fb2Vx//nv/H3/m3/X0/+MV/xm/xn//Zv8k/svf4T0ne/F+XP7j/M3/g+A//I9Z/wV/79/wuf+kf/yf+Pv/rv//on0v/tr/+N//v/7vqf/unVn/+5w//z1/zHz39y/7Fv+Pv/7N+1dNf8sf/l//t//63/we/9p/zM8VvtPt/f+t///c/Sf7y/+qP+Cf+gX/w+e/2j37xR/yWf/Z/8Nv+Zr/mP/rP/13/zP/6x/3xf+V/9+f8a9d3fs1f4zf4jf/bP/1P+z8O/sQ/9cf+q3L+r//Bf9Gv8fBf2/ojVp89/Pf/1+8cnvxTf9fvNfvD/+u/7pd963f7r/+Lf/Lpv/0P/Evvihe/ePZ//v3jT//rb/3d9+t/YPVP/3U73/5v9nZ+l//2b3rxT/0+f9Dxv/dr/VrFb/EPfX/7k9/s//4//pDz/+zP+zO/9Q/u/H3/2L/4y7b+69/kL3vyd5/8c3/L/D+8f/kX/jE/9oN/6PRP+oN/77/r3222/vTv/rn/9W/zH/3E0f3f6Tf5U/+93/Qf+60+/6fu/SnP/uN/4NP/+B/5Hf7dvz3936e/wy/7E3+b3yb/p/62f+x/+i9Gf/l6/95f8Zd8/sf+eX/Sp//E2X/yZ/57p7/9H/B3/Yn/6vHqX/tnvvhz/+tHZ3/gL7v8Sz7+d17/rr/ld3b+uP89+fZe8rv9Efkf+tn1n7j1e/8D/+m/9+/9gm/9uv/o8jf/J7L03/0fsj/k9Lf/XX+Df6z4R0e/+e/762d/0R/xJ/8pz3733+07v/Dv/vLF1X/xT/2zv/B3nfwnW//Hr/k//wu/8j9+8uv/+vfu/2nJH/T3/ZVvfscX/+H/9tVXf+Nf+Gf9dr/zpwf/7o/99v/Qv/Uv/8bPf7e/9dFnv/Ef97v8Lc/+5L/rxR//i//sX/F/zH77b+38nr/259mv979/67//my/+uX/mVfv4f/2x/+z5H/nv/bv/wu/zm/4Ov8n/9e989Gt/+e/9pv/xn/wv/Kfz3/Qf+fyf/Vf/sB/85b/HvbtX//Y/9lP/zb+W/eF/73/yJ/w6d3/5X/Fr/Cd/9a/9a/zn/8Sfl/xZ/96v92v9I7/w//y9/vXf9NVP/lV/4582++9//7/qNz38S+q/6+LTf/L3+++u1r9o0vxuu//Xvzj/yU+vf4df/PFf9O5PS64Pv/rPR//5v//jf9P27/y//36/4a/8zt/9W9371tYf9Wf/5//e7/q3PPlX/tx/4W/7o//jT/7B3+7P+3N/ly//0N/5T/r+H/Vr/sF/5D/79C/9M39qlf47f8Mf+q/80j/nd3n2K/+3r/6rP+WP+Dv//H/zd/p9/th//4/9Zf/3wz/jz3j3n/7Jv/BP+3ef7PwdlGD9Q/+gf+6//Vs/+ff/xN/p7Ps/9Z8/+du/f/Ib/cyfVv6X/0yTffS3/a/rv/jk39r/pQfb//GDf+O3/E/+wl/3p/+25y/Pft1/8e/7u65/t585/eMOXv7Er/df//d/zu/9Z/32Z7/X7/zRH/03/nVPfodfvvMX/1l/6f/w+7z55b90+def/p73/q4/81f/Of/K7/p7/pl/9SfFf/vuV/31X/7YH/dn/x//xv/2i37fv3q6/5N/5f/wB//g//ps57f7n3+n9M/6bX6f3/rJV//aP3r50fcOjr79X/3Dv/p/+11/8tf9Zw7/+d/nyW/X/NF/6P/8L/0Jf/B/9md99t/+gb/03Zd/2n+Y/W2/z3/+5Zf/yLf/of/w7/x1f2Z69H/9Bf/yP/rd/+v7v/+fV/16v+Df+L9+49/81/z3/qHX/+ybf+nZb/FL/9X/5Fv/7R/w55z9Bv/TbztNH/yB3/mVv+Nv/lv8+7/1n1L8Wf/iy9P7f9xf9Hf88j/q//xFf/bf+Jc1/84f81//er/sD//pP+X1v/53/HF/yu/Y/Md/7/P/4b/9o/6qk3f//j/6+fn9P/Fv++v/peM/rPjFe7/9H/vp3/En/NZ/7l/2F139yV/+Gv/3//1//PP/xe/+z+9/9af+6eUf9Bv+aX/k4t3fd+cv/r2f/tr/1F/yv//Lf8L04nf77Ff8+6t/4i/5F4///D/wN/1H/9B/7Mmf/Sf+Znf/2dHrv/Z3+w/+gD/pX/gj/sa/5/zPqn/R7/B7/Lb/95/1J//yX/sf+MN/jd/ij/kTTv+733ryl/zuv/Hf/uN/252/8x/9rf+R/X/+3/4v/pT/43/5Q2dVffXiX/kn/qm/9a/4he1P/tG/x/F/+E8Wny9/g3958Vf/fX/si7/x//jjfuwX/YM7f80Pxr/Pn/3v/5//0/f+z3/nv/ydf8s3X/2SX+tPW9/9E/7g07/+X/iDv7Pzm/82v/lv8JfM/p6/6+qf/mf/k//1l/1JO7/DT/0V/+7J77b/5Pf/7//Bf+I3+kv+jn/qW6vF//S7/W6/W/LPzv663+gf/4lfcfC3/8IHf8I/9adP/tvj9l//0/6BX/l7/4Nf/HH/xZ/+S/6EX/Bb/BF/3N/1K37Fz/zYb/hrVH/tV9e/9O/+7f/g3/arf/43/3XWz/7h//VP/dv/779p/Z+8+8vvff7H/pP/9NNf9av+u/2/8p/99u7jf+XvWP1t/+Xf8L+/vvNr/cF/ya/3Z977N3/j/+V3+5va/P5nB9d7P1b8S0//1V/579Vf/fR//O+2/96f/ede/8yz7/7gj/ifv/gzfq0fO/hj/vB/5Fd8/pdd/JPzv+/v/u9e/46/2a/8p/6bd3/4//T81/3Pf8vf7k/+/NX/8U/93v/l7/+9b/9T/+T5n/Jv/jH/x7tHf9zfdv8//jt3/o2/9e/9zf+0Pyz5U/7Q3+NP/ROe/r6/32/+jx3svvzuf/FP/mN/8N/yd/zbv+AP+9d/69/xb/zH/+b/9B/96d/qd/qXnjy795/9t9/b+du+/aeUv+fWy7/sW//BP1f+i//T/T/8d/z0N/kDft3/4V/9v776P/7u3+vdbz37R/7q3+Xf/DWT/2b7P/ltf+Ff/Lv8Jr/6z/lPftXRf/7p7v/59/6F//Lv/env/1+2f9inv+CP+m3/j3/9W7/VX/v7/W+/47/x9/9mv8Zf8avr0X/yu/zXf9uv+F3+jX/7l//qb/8rD37d07d/5m/yP/x+f+2T+3/b6lv/zj/9R/7x2Zd/7u/x6/z0+L/6zf/4X//3/h+S3/9f/bEnv9tvtfN//VUXv+W/8nv/mb/X9x+8+P0eP/hv/tLL7/31y7//D/w7f93/7a/8q//Cf+pf/Lf/kb9179/5bee//p/6/d/83q/7n/xZ//Bv+OAf+B//5b/tt/4lv++//3f9hf/e3/3n/b1/7bc+3voNfqfDz3/l//Lv/d5/1p/1n/23/+Sf8clx+fv/MV99/3f8P373L4o/9O/+H/7Av/83+bN+6vf+g/7T32L2t/zrv+Hf8Le/+Xf+new3PP3lye/2F/z2v+vvMf5F//Hf9Vc9+8f/sf/1P/mPv3f0h/z98+3p9B948u/9O79i9lv+tr/v7/PJm7/xy3/vx/7y7/+Jf9iv+DX+2r9g/hf9uz/5x//Yv/Fb/0VP3v15v/Zf9dv/zO/3z/0L//TFn/bL/tXf+1/J/q7/4Lf8df6a3+Bf/tbv9mv/xf/W52/+8f/j9774N363X/eX/im/9a/+bX7bf+xvvPiDfoM//X/91k/8Cb/L8e/wR/62f8/Ov/Lpn37nH/21v/8//sN/3Lf/9F+7+c//u7/pf/tX/60//h/5t/69h3/Qt37fP/FP/GPybPKX/mn/1//2Z//m//vOb3P6yR/2m/8uf97D3+xv/Ws/+6u/92f/069+/3/vP/2H/4bXv9v0J3638//kf/wjPv7d//nsf/4N/7Vf48/6nX/l4dt/7f+ukj//d7//V/52f9f//o89/i1+x4Pf95/88//iv/I/+U0/+1c/Sv/EX/pf/9//x59cff6f/SVf/PvFX3b0J/7Uw8Wv8+0/6zf6zf7Cn/i/d/+3P/Sv/HX+ln/8n6T0+pvf6q/544/P//JfY/tX/tt//Itf/DP/+z//9/5T+e/+z//B//Hf9K/9TdVvXV/+j/O/4T/4s/73r373X/hv/zp/2nTrP/tv/o4/9E05+Zv/0r/xN1r9Ln/e3/Xv/PK/4N9/8kf9Pn/C3//5+R/xi7/zzza/6s2/X/79k937n//Tf/m/9e/9l3/6m9/71/+d7979tf7P3/bX+7f+hN/838l+1d/5R/0u//kf9rv9Fv/yxV+1/ff/Rmf/wt/yb979g/7EX+vP/OnfYvS3/an/QPN7/+5/xR/7123/zPdf/aV/8L+4+E+3/6S/6M/9fc+v/6K/9zf99I/4Axd/79N/9sHrf2nyL//kv/i7/oH/0b/8b//rf8Jv+vjX/AV/xT/+R333d/+FH//qH//fftE/+m+V/8sv/xV/1X/1P/6lL/+uX/mP/aKtk9/927/tn/v03/39/6eLf+032/p3/55/7ovf8k/9k/69w9/3j//j/7h/6u/5J/7h/+gHv/qfnf17zT/74uV//0v+jH/nD/3Wb//gT/vr/vDy+H/6E//VP+v3+Rt+wX/9N58tfvLT//hv/K3/m399+i/+8XeXv98f/g/+3Z998ddcvvzs3/zOH/Lv/5X/5F/zn/x5D3/xP/6v/yF/z19y+Wf+63//3/vib9z9G/71P+gP/uh3/jV/xb/7z/zzf/9f8pf+2//kf/CHpv/wr/8H/ml/3i978ew3+xfv/w0n/+xv+Ov9U//Y3/k3/93Fr3z8L/748z/rr//iL/4d/8Vf+if+Tfu/z3f/tj/yb/jVv+ZH1er3+Dv+vX/2t/5H/5qn5Z/16/4ff2Hya/0Hv+7veb/9mf/mr/1t/p5/7jf40/6Vv/ntt/77kz/iW7/03/mP/tzf6S/+/X6/f+T/+KfO/q/6r/yrf+//8C//q3b/h3/l7V/x1/8f26//uX/y4y/+5N/qJ3+TX/Pf+K2a3/Hv/kP+i/LP/xd+jfH/8Zf+2f/Wv/vvfPXms3/v3/mj/7L/NPnp4r/7C/7Qf+a/+Vd//+//5f/yb3vwDz9efPbb/hZb//Uf9k/8Ub/Of/wH/AZ/2X9+L/+d9v+z//P3+V3/xh+r/ve/JR//A//Id3/FP/InHP9h/+Hv8Mf8R3/od/+s46e/c/EnfPVf/vdX/+v8L3j96/5N/9Af9Qf/Bf/LP/Xv/ZG/9Z/3n/xn/8CP/YF/81/wezf/13/2f/xtf+Uf8fv/vV/8kr/391xU736f50/+4n9t9c/+KZ/8+v/bwdYf/m/81f/0939w8Bv+vb/L23u/2Zf1vzb5/E/83f6l3+AX/9m/ye/7W/+zZ//jX/vH/EN/8H9R/x7/xE9+/jMP/sf/6Z//id/81/7H/qF/7B//c558+U/8vX/tP/yb/0+/9E/+vX+b3+J3/jW+/fv8U1d/yd/w3/yBn/1pf/Cv92T8cvZv/NX/8j/7L/6Wf/749/s9foP/dPJL/4x/84//736Tv/bwLzz9zX+H6v/+M/+lX/f3XPzPT//2X/vx//2n3f0ft36/px//7b/fP/RTf+f27/K//LL/7eHDB3/b7/V7/s9/2R/2R/5hf+S/uN77d/+GP/cPfvh//zY//a/9j6t/+/7f9ufdf/XFH/r3/ue/6h8ofqvt3++f+7P+uj/mX/k9j+/9wr/lN/2D/rz/+8/7z3+3n/wv/vA/6g/7w5P/8nf/G3/957/L3/nm9Z90+vrh7/G7/Xqf/3Z/yNFJ9Rv8T7/x//Z3/if/fP69f/n//utnv/6f9Pv+zD/6O/8nP3i69Wv/iX/o9/75v/XX/Tv+6l/7V/zL3/ul//VP/cMv/pu/Y+/X+Rf/xMN/6p/5F/677b/31zj8r/7hf/c//5t+398wm/7Un/t3t7/6V/wT/+g/872vXv76f+Cv//bH/+3iL/ivf+X/9b9d/eZ/6r//7/47//a/+Uf99X/37/23/47/0B/4X/zRf8c//iv/uz/+L9n79f7Pn/zf/qK/7W//Hb7d/s7/yZ929i/8Df/5z/zb/8Df8zv/5v/oFz918N/8l3/pb/E/fPsv+PX+oe/84H/4Q/+Xn3nxN/yF+3/YH/Nv/s2/4ju/9O/9Qw4u/pw/9fdb7f3X/9n/8s/8H//4P3jvP/htDv60P+j/+jv/j3/yN7n+Df6r//IX/qV/3V/59/0jf9fzv/Yf+bf/3H/7n/v41/kNnv2X/0D+9/yNv1b7n/8GR3/nv/Jvbj1+8uf/0f/DV/f+7l/9W/2Ff/tf+Zf95f/jf/G/PfwD/+A/6q/8i/79X7L7F/7dv+/6f3n4X/z3f++/e+ef/pP/0X/1+vf/D/+Cv/fl3/47/NeTf/83/Yv/2d1/8Ohf/N8f/uGv/4c/+V+uf8vd13/C9w4//tv+uX/gF/2pf9p/1/ydZ3/7d/6lf+75L8j+11+0Pv7y4vr4bPJf/h1/z3f/mb//T/lHj/Jv/413fsnjP+D//sv+8L/vN738/m/ze/9Bv+e//9P/3C+488mf+I/8FdMX//mL//SPOk3/ypPrv6/8qx/8gu8e/it//1/2Jz7Z/+nf6Xu/zz/1L/xh//SL47/qO3/rH7f7b//q7/0eO//Vb/o7Zb/Xv7P+rbP0f3r6h/6u//rfcfBr/59/1u//Y2//tMsvf4t/Iv8jf++f/gv/woe/5r/0m/9Z/+Lf/Mv+kD/rn/2r/5Hf8M5v+S/MF//xnzX+G/Z/r7/qD797/b0/8I+ffu/d7/n91//RH/dnHP/Lv8kf+5/+GX/E7/0P/Sf/+n/56Z+xc/L3/sH//e/zFxz/Xb/3v/dTT/75j1/8Rvv/5J/x5a//O//47O/+lX/xb/CHXvzn/8I/+0/90//0H/Wn/cV/xa/7t/1B3/01/rDfa/Q3Lv+tX+en/pF/L/n1Rr/Ok3/szT/7X+yW/9Tn//LLf/cv+X3/7992mv8Bv/if/Mcv/8brP/F3+sN/179l/O0/8Tf9fX/n363535/+Zr/j0//58dE//Z8c/4//02f/1tU/d/Tp1j/66/7Um1/0z/yq7/yuP/E7/uZ/5O/935z8C3/qX//n/dr/9O/w35Tf2a1ePf7d/uU/9Y999X/9Fv/Vp3/b7/aT/8MfUP4tv+8//+8d/AH/2F/9i/+9P/+nf+Hf/Fs3f8w/ML74l/+PP/K3Of2f/+I/6R/6+37d3/MP/Eu+//iP/Etf/fV/03/2L61++vfMfuZv/o3/5t/04vl3/tSPf6v2n/u3Hj+ffvH7/1mj32Xv9Ns/+Qf9g3/s7/LH/dm/zb/27/xWo9/s0a/4D3/xL9v/G//b/+b//rcnf+q3//rv/E9/d/Yrfq9//h/7c/78673/+4//b//iv/HzX/Fb/uo/5l+//mt/xd/wz/zgn3v8f/xfv+qrv+io/sV/3l9773/8i//q3/sn/8z//W+599s//Z9+r9/uT/pL/og//B/715I/9U/5Hf/rX+f/+g3/wn/+4j/59t9w9If/q7/tb//4Fyyajxa/z2/7m/9W/8ov+ZP/uPYf/Ut+xd/79/5H//M//sf/F3/Xvz36K97+E//J4u+o/uX/5r89+Od+6V/0a/1Pi7/xH/xl/9v9v/63+nd/y7/xP/xLdv/nP/AXv/wX/qPd/+1P/H3/noN/5bc6333z+/++f9Nf8M/8/lsv/ovf6l/+H/+5f/kP/Hf+kT/pwX/wH/3dv+0v/veXr/d/sy/+qX/hnzz9Rf/IL//WH/XL/vY/9o/5fZKv/oR/7V/+vf6E/yz/xZ/+D3/0f/mr/pU/+E/4Derf8w/6p/7H18XfevZb/UF/7/d/xx/863/IOvut7vwz3/pz9v6mv+F/+ns+Tf6o3+P3/Bv+wP/t2eNv/aG/Xfpr/4Ld3/yP/wceff473f23/u7v/J0//VM//i88/Ut/+h/7G/7xgz/lV37v3/6FX/7Z737Jn/qv/La/19//Yz9++i//77//24/+4n/rH//Hfu0f++9/63/56B//U/+u32f3P/y1/uP0L2n+yd/j//w1/rK/9L/+Z3//v/5f+9bbP/3R6e/xG/zbv8ef9nv+A//N311tf/aDP/6f/fR/+Ff+/r/7r/l7f89/95/+n//QP+/PfPzJ26u9q3/v1/rj/ud/8B/49R8//A0e/Mt/4m/za/12Z4/+gevf8d2/+Vv8IWf/3e9w9dU/+9n//q/+V7/yX/j8T/rf/rnVX/BH/tcX56vf8S/+g/6Bf2D2S/793/Xf/ktf/4Nf/Zl/xu/yD/0Ff/Hfsf07/Eb/0V/6r33+D/y7P370l/0Rf9Gdv+TtX7H1D//Ev/307/r2r/GPb/9d/82LX/1rPP8d/+Xf9nf6Y3/dX/Uf/Gf/5q/9O/9Wf9Ru8r//Lr/sv/+zfvrjZPfT3eyP++1+xfo3+ujP+T3+8bev/+vf9+W/2eZ/1K+9+6ef/mG/9z/00b3rv+i/+D+Pv//g//43/tY//xf9Nb/5j/0Ff/c/98/8X7/PX/jX/unJH/FL/pB/dfFf/y7/4O/9Zz5qm/b+vd/iVx5866+r/vrk/l/yy/N33/qfq185/v3+1r/3T/+f9j//9O98+zP/69/xL/2zf/Af/qdv/6M/853f/Tf833/tP/e3/VW/5a/4Pav/9n//7kd//+/2j/1uD9e/auu//0Pmv++v/9/+pX/qb/kb/EG/++rv/Qd+jd83Ofl9/uOD8/H8T/+X/svf4l/5G36t3+nv+F2//fHOPzb5y/9hGukf+mt+8Wv8pW/2fs9f6zc6y6/+qv/g3/3Vv/NP//b/5f4/8mf9s//Af/m3/7F//e/+t5z/I9/7rf+Vb/8Tv/l3s//kT/rsv/nt/vY/6af+l//mb/5b/tLf9S/723/sz/kN/6zf8o//pU+bT/+SF3s/8Vv9t7/n3/Nf/NJ/8id/z9XJ3332v7b/dPu3/YkPPv9fv3V299f8j/+4//BPPXn0rde/zn/3Z/6j2f96+Nnv8rf9vV/8wdM/+n+581f8kcU/8keN/v7f/Ld5+bf9o7/of7n/9/zTf/Yfcf53/E6/+T/2uv1T9h//htP/8ov/4Jf8fn/V3/no//57f8Xpv/XZb/vo1/8N/5q/9v/+5/+5v/DJ//H53/TXnvzlf96/9Lf/H2++++v8vv/0wxdf/lUvf/HWf/jn/jd/4D/wB/9Zv+zf/+N/8E/+xPqX/1Z/1D/8O/w5k6fJ7/NX/cb/4x/6d/8u/+N/9Nk/9bfe+W0P/v7/Kfnzl9t/wf/2z/wJv95/dfzf/5r/8K/xt//fv94f+Ot//JOf/8W7f9V/+Av+s3/kN9pf/B3/Yf4v/Gu/7W/+D3z55/ySv/T3+bt/4l/6236b/2jvH/zl3/t1/vCf/nX/tz/h8dGf94f/7//9m9/+X/r9/ts/+dmj7L//v37Zb/pf/0//wp/w9/+Ff/Av+ve+9df8Jge/83/8D/5O3/l9ftFf+teO/sKf+tW/2ef/ya88/wW/2z/y/b/58J/833/bb/0av8Yf/3f8RZ/8DnX2/S+3/8p/4S/6y3/hP/mn/9VX/9zqv/pvfpdf+Tf/lt9++ef8db/hv/MX/zG//2/3x3/3Hx39Ab/Jv/k7/dR/8af+u//tyf/1x387/Xv/79/mb/iz/pCv/od/8j/5d/7nv+Hlv/2n/4d/+r8y/U3/2n/+3zn4DX/97x8lP7X4Q//Wv/7TR7/3b/Gn/mu07ndw/Fs9/qX/0a/77338O/+Cf+WvSaa/wd5v8M/9gfW//b9896f+8L/t7/lj/91/9rdp//e/5jf9Z//v3/wX/lb//p8x/pd/nT/rj/7bf6qc/c6/5q/7X/yav/Nnf82//B8/+C//jtGv/Xv8A3/8l7/8L/1tfvXB//ELd/7Ti//iX7z7Z/yGv/Fv8it/yx//k3+bv/BP+PP+kr/gz/qzf8+vjia//uyP/Lf+/d/jF/z9f+Tv8X/9az/1J/+Vf+z3/qh/5T/+V49/w7/1F/3OH/0Bv+Lf/P3/+fXDn/gr/4Y/5H/613/H/+1v/h/+uv/wH/09n2//Vz/4Lf+LP+UP+j3/uY//vSf/+2/1a/0z/8hf/G//N3/sv/KP//v/7O/xR/7M/3H5y/6on/gf/uB/+hf9z//jT/1ti7/mq7/wv/jvX/8R/81P/Ad/8K/46T/iX/ptv/9X/S9/9H/w1/yiX/+T/+L42X/1V/w3//R/+L/+xu0/+Rf/+F/yi/7uP/Lf/Pd/we/wTz5/+5f/jv/e7/4X/PH/7LMf+4t/8U9u/2P/4udH/8PfU/+Df9aLX+O3u/fr/du/xt//J/wD/+Kf8Mf9bh//1dUv+M1e/lu/6T/wVyzqv/av+ed+7d/3O6//2Ob3/N//zV//tzg6/s9/5Z/zT/6rz+7+Nf/qPzJ5+5/+lf/67/jgYO/1b/ZP/LW/zef/49/2p/3g3c/84X/F60/+5e/+j//V33rvfyn+8d97/Rv+K//nbzb/S/Lv/Pr/+V/zX8//xO/8g3/3z/yj/87WP3Lwd/2d//W3Jn/k3/HX/Fmr//O//OP+1R/8Or/vn/Ov/kb/0p/0i3/dv/fjX/f7v9fs4d/2l/wGf+N/99Uf8id//K/8MVs/Ufy32af/0ad/9+//q/7XvaPf6R85/Tf+3v/1f/o3/5Hf+uzv/pf+pn/zj/jzX/2TO//AyV/7tzb/7Py3+Dt+42//Q3/Qn/Of/Wmnf8Bv/Jv+9O/2j/xVf9THf9pf8m9+5w/6M3/p7/IH/KH/xx//3X/38//z9F/4Tb/zn/6SB//XP7P3q052fvlv8PhX/sTv9fYv+OTwD/z49/qn/8wv7/0Xv+sv/ME/9xv8ho8++Wsmf9I/Uv2i//RPqv/piz/qt/uj/8n/41f/b5M/8Xf+8qz4e3+r7/7Wd/f+2l/7X//8p3/xX//8d/lbzv6wf+vf/Y/+zv/18e/2S5//Zuu/ut4q/rPf+Lf/Jb/w//69f/If+Wt+8Cds/Ue/we//z/9D/1n25O959o/9gb/rr/nr/KLip3/b6V/x/b2/7Bf+Sf/axcUf8Lf+XX/3b/qn/+3/afrP/fP/+G959hv/vn/uH/B7P/3eX/13f/l3/7qL//vvfPznvPhd/5Pf4Z/6W/6Mf7L4rX7yz/hDft/v/Ir/9PN/6A/4ePw3bv+Ov8dHP/M7/EPf+4v/5y8X/8r/8nv+Lv/H69/mT/7ffvI3+OgP/5v+iNPf7vf8C7791V/2R/yGj/6P/+gf/L/+87/r1/yXFn/7r/y9/4z/7bf+X//k9l/7Zb/8y8u/OT//k7N/9OxPf/ifHX/yX/17/9qr3/432v5nP/oV/+Pv+RsX//If8m/+43/Bv/Mb5lt/5S/4yb/zl3/nZ/7wX/XJr/UX/ycn937zyeI3uvf7ffffO/6z/ob/7J/68x78gj/oP/qn/9P/8s0f9y//Zfcu/6urX+Nf+z3Hv/4v/G//tO/+is/+xz/rzz78aPSPv/iffum//E/+h3/A3/AP/zf/7S9d/fb/0f/8T/yDf++/PPkX/7pfuvwvv/2b/y2v/61f585v8gv/kD/oL3n411z8yr/sFz34j377//zBL/3oL7/3h/99f9g/8AtHv3e2+Bd3H43/jj/88Ce++K3G//3v9u996xf+W3/X1f/5T/xmH+3977/3f/k/rf/zv/0P/Kn/+n9sf/d//l/7D/6Zvd/kW7/5v/GH/8M/9d/P/s7781/1jzxP/rU/5/fbfvt3fPXH/s5/+u/0P/3qX/Z3VX////5H/jd3vvMX/feT12f/xH86/SVf/OUf//if9yf+CX/8k5/a/w/+gH/rv9l7vf7T/+nf6Q/+e//Vv+1f/PN2/4qD/+rP+bP+1t//4K+686+e/Qu/8z/0vX/jy3//j/yp3/SX/1p/1f3/8/B3/HP/gL/kL/ry3/rt/tFf80/8n/+ev/pbv3n6i3/93/XOn/Irf8Pf7+/8Py//4cd/3PFf81uOXvz5J7/Bvb/0n9z7j//IP+hv+93/mT/w9a/1T975Te7/vr/bv/V/f7dZ/Z2f/hF/+6//E3/TX/Mn/fP/5r/9N/0n//0/8Af+hXs/+It/v7/o95/+k3/h7/f3PXnzN/5z/8fO7/an/cvNT/1bX/7rB7/R3/wn7/5Pf/1fQHHL6K+884f+dse/a/6H/OP/yn/zyRcPln/xX/w/vfi7/pHf/39Y/t7TX3r9H/6L/81/+vv8ot/n2d9//ev+s3/3//z3/ctvf+l/898nP/hstFj+Cb/5t/+jP+a/+C8/+3t++o//le0//iet7v/Bb5//Db/2b//X/apv//6/8k//db77e/7nv/FHyz/gV/3Zl7/PT/81v/HRP/Cb/bV/+p/x6/xOv/Nv8es++4//qLO/+e5/cffvfPvk6I/6v/6Xf+x3uf8vfOc/+lv+6P/zv/o/f9kv/+t/p9/8F39698/+B/757V/+5/9e//o/Of/T/tjv/Q6fzHb+rtE/+ut89cv/nP/7zZ/32/8Zf/7//bv+Mff/lz/t//qnfr3/8Xf+W/+E/I+6//C//hP+hMX+b/T7/Bf/6bP/80/9A373f/e3/Av/lT/pwTod/YZ/0n/4e53/Dn/Db3z5U5O/7ff5G/6av/Pv+G//+N/pz/wf/qg//4/9j/7n+e91dn32bv3l3rcO/uuffPHtf/Wf+fse/RW/5dl/8evP/tnf5Neus99w/m//Rv/NP/g7/EF/0u/zOxd3/sn/9I/+tf/h/+Lbf9pf+pf/Ff/l1b/1K/6i36n8637fP+W3ffZX/U47v/qX/Xkf/aW/1T/7W/6Hf/R/9kt+v8vyH/5T/sb1z9R/1S/+4n96/T+8fvxr/x+/33/y3/66f8Lei1/9C37Lw+nf/tPbv97/8A//Ef/r//Yv//Z/1x//P/yTj/6H33aU/AZ/6H/4u/6S3/OP+ZP+p3//F/yer37XH/zzf+29v+Pv+BP+hV/nZ36N3d9uZ77/+J/5Xbb+xd/+kz/mL/zX/qs/9a+4/xud/PX/zB/0yavDv/k/+iN/j9Fv+l/8d7/tr/4r/v7sz/79/rbf8ndv/8B/4b/e+lt+q1/6X/wef/G/8Sf/o3/M3/yv/xV/wi+8+t/+vV/2J/41/9W/9av+19n/3nx/5+L3Lea/45/yG/9Gf8If9p0/5t6f/4f/Ff/J+B/7J791/Vn1F2z/2v/zv5X/qb/Gb3/61b/65q/a+kv+hv/08NPHn/1a17/Wn/u3TP7H9NkfuL67/df9Tb/yt/j7/rvqlx38Rn/Yf/Pn/es/9cf+x3/h//B7/36/4jf6LX6r6S/939P/6E/4O/+S3/Vv+qP+rf/we9M/4Mf/uX/3s/1f/tf+F7/sl/yNf9Kv++/8IaP//e//hX/D3/IbfPdP+iv+w9/6//zn/sz//k/5L/6nP+u3/wP+h1/3j/0t/urf7s999zfe+a3++H/o09/m7/1Tfoc/7g96+Qt/8Pv/zV/8h9/7vX7/68O/5w/8l3/P3+/bo9/tr9r+5Lf/9j9/tfW33vlv//I/6uSf3/mf/tff/6/73f/N/+gv+ov+mC9/2cG/9of9IQ9/r/ruH/d3/lt//j/w+xZ/7e//l//hn/77ny9+h3/zT/+N/rX/9J/8+/6H3+R3+T0u/936f/zfftkv++dP/4p/8x/7sX/+l/9fv/ov+01/wR/W/IG/xT9653erii/+gL/yl/x7l//97/Cb7v52/+Vf8q/+Ecfnf8av92v9u7/P1e/+6/zYJ+v9j3+jv/G3+pf+oT90evXb/GH//fLv/SfevP43/5V/9K/58b/sn//L/u+//Ff/IQ93/5DTf+cf+OW/+Lf4yd/5V/+y3/Zf+9f+/j/2T/2b/tS/8+V/8gt+47/gt/yrfp3f4tf87X7r77bPf9Nk66P//G89+anvzh79Hr/Fn/sH/6O/7/L8v/2Zf+w3f/aX/rt/Vdn+W3/Kz/wRf/cv+Tf+ul/r9/67Jnt/4H/963/77/qffvmf9Mnd3/Ev/pv/6Z88/k9+5o/4L4q/+Lf6Bb/5H/l//Vr/5n/47+3+u//x3/Xn/OOH/+Of/rf8cb/5f/B7/Td/zb3/8Y/5h/6zf+7X/mP+hYPf+9EvOPnDf/Uvvf6/ftmfufhVf9a/v5z+Af/OP/bHFP/lr/9b/gl/5u/1C4//0t/sd/tjf+ef+C3n//y//Gv/df/i3/hffPxfbn3yg1/52340/ZX/3F/z91Z/6W/xh/x1v9veF7/Xb/adu3/QP/wflb/kp39s72/+M47+tfxf/uL0z7j7+/06v/7ffSetf5u/6df7vb/7F/zp9/6Q3/E3+l3/0F81/kfe/J3/1PWf8m/8Xr/fb3/6e/6Rv/yX/LbrxT/4q06mv+tvevF/ff7b/0F/xN//j6+P/qJf/7f65eWf90c0/8cf/0f8p//Wb/fw3/tbfrfqT/rsd/z3P//F//1n/+WLP+pf+LPf1b/6f/o1ql/2P/2ue3/Hb/ov/U9/48vFb/bb/eu/3vZP/q9/4U//gX/3n/CfLrb+xwe/6p/8I5K/69/42/6mP/Q3/ZOu/tAv/9hf5zfZ+tX/wu/+/X/yz/73fulf+utMf78/+C/+z7/8T/6b41d/8r/9v/+l6Xf/57/zT/zp3/TJb/6DxZu/6f/6zp/9l8x/nV/z7/rJ+wd/4+/4Yx8/+zf+u1/xU7/qv/31/4r1m++fHvynv82/+0f/97/Tv5n9sj/6f/xr/+hf9Ec8+nP/retf/EuzycX/9ef8mZ//Idl/+Xv+L//H/3b/f/87rv/QP+M/nPyGv/Dlb/VvZf/uv/J7/+5/5Je/3z/xrb9r/D++fPVn/86/x1/x9/2jf9jVwR/3L1S/aflP/9p/6Z+9+/Ef8+v9b7/vT+wlr/d+13/hj/0b/+6//PWPXf7Zj+78jf/RnY+u/7Zf8/yP+XX/6/G/9wfS2uPv9jf917/vX/PLfr3f4s33F3/0/E/6te7+1F/za/7Mwz/wd/6//t1/4ov/cfob/NRn//PB7/b9P+yf//TP/a1/m/+Ouvvr/pH//K/7W//l+rf/9Y8++rX+r//rP90/+Y/+7f/11d/0t/7Xf8jV3/WX/RX/3b/4T1z+l3/Sn/Ob/8I/+nf88//z3zNN3/4bX/0hf+5f8lOPX57/t3/4n/PPffqLfslP/DY/+fIfy2f5q9d/6J9Fqwl/3H/4vZ94/bv+m3/d0Z/8B7/84k/+M36tv/rPLf6L/3G1++bP/1te/th/8Hscf2f3D/mj9n/zP+OP+gv/pOqrf/Dv+wf+q+/+Xv/69u/5k3/kH/QX/ol//B/1By0v/67/8F/8O371b/UH/hW/5i/+q/6X//Hv+pf+hO++mfzv/9n//rv8HT/4V/61f/xP+Vf/oN/4wZs/7myU/06/1W/wa/5OP/X3/V1/37/2u/79/8B/8n//mv/0H/3gD/xN/qBf81/825PV//0ffPGPVb/r3za5+Bvu/LH7fzh5tn/A21//L/gXf8fv/8wv/79+h+l/9N2nf//q6G/6He/8tv/Kd/7Tv/743/wtvvq3/r4/5jf6E/+kv+Af+ddO/8a/6rf473eOl7/wTy7+w9/4v/+fftnv/Xt+8Qf+8v/mb/7H/sl/7M/9g//pX/lnrGe/+res/8p/9K/7z//b/+Qf/68/+q/a3+ynsz/l110+nv7MP/2//0Pt68m73+qX/J7/8Vd/1+Vv/RO/x//0Bx396t/yH5r+Wb/V8vn/+Tv8ob/7H/m3/LZbf+dPfP7r/uBfefNr/pG/5B/M/4m/qPnN/vvJX/ngj63+qn/8X/5d7v4bv9mf9c/9xC/9Lf+5/+Lv/HX+lX/t9xk/+FN+7X/h7/8l//jkv/6b/sE/b/bJn/zv/a3vfoff7m/65Pz6d/wH/t3/8rPfY/UXHfyGv8UPfo9Hf/wf92v97v/SP/v6Fz34q/7Vy1/nd/kzf/PpX/MP/de/w3eT//Lf/Yf/m7/2f/0/fuNy+U8f/d8X/8Z/9m/+rb/WP/0X/MQveFP+Jr/3n/tPvv67/5e/6Jf+1J/0k3/dr/mnbv/nf8uPX/15T/7ef+Yf/49+xz/oj/jff8e/4S/+Fb/1r/dTF7/i/C/7mT/wz/yPX/62n/7nF9U/8Z/+H3s7v9OvefAvv/41/uG/6nf59X+9k+Xv8Vv+HX/cH/7HPP3dfofmT/xHf9Hj6f/8V738Y37jxen/9Bv9yv/1b/wvf+kf/Nf+z7/9r/N7/26vln9w+esu/tX/8Xt/1O/4P/4R/0px58//rf/0f/av/o3/6L/ub0//6fP//l/8R7979h//2X/277f3V/5x/+C/80f8Oz/4k/7k6u/45//5v+7X/r2/9U/+bn//3/rr/9d/yD/y5ZOH8+V/nP6uP/7t//bsr/r2x3/6xV//tx79Wf/Cv/xn/N17eT75y//ub/1hv8UvPP9Tf9W3/ojf/H/9Tf/If+M3+V/+yv/mv/4d/50/6vf8c//gMvut/+rf/Vfu/rY/9e/+R81P/vn/yG/99/6P/+POV9/6R9I/7H/76/6If/JfLV99/Je//u3u/jP/y4//G0+/dfQH/Sv/5d/0x/3V/8f/8oc/+wt/5vf5q//F3/FXzf63P+7697v/6/7UR3/Ay1/+u/yN//Mvmvzhv+D3+VN/719w7+Wf+Hd//w/8Y/79vzT5z//QP/Y3/Ev+94u//Le987dkv+mr9H+8+5v+y//T2R/7P5yNfvm//1dU/81P/Zl/6N/4F/y9/+jv+zt85+/4n36tf2Hrt//N/vf/8OX/Mv3ur/Vn/vvf+R/+8z/jf//Vf+3f/WO/02f/0MVf8nv9UX/Kr/UH/Vefv/2P//x/9zf4Vvrb/9eTf/bP+EP+j8Wf8fnkl/6rv8fD/zL53X7dP/Uf+JN+01//r/59Hv8nX/5pv+zwP/mH1//b22f/8B/0f/3Gv9Ef/uJv/Rf+gH/tv/h1v/2P/N7/zn/3+/7fr/b+yPm/OKrbJ//Fb/MHfvFr/XX/5+8y313/Rr/Vr/GLP3v9f/9nf/Bf/qD4i36d3/zP/qO2/5o/5ceu/ps/75/6h178Wv/BH/YXvvuZ/+4f/O0P7v0pv9m/+r/e/+3+66PH/8HZ/Jf/iX/H4tc5/hWzo//+J7/61j/3P/6tX3zy+G/5q/7y9Nf/0//ux7/G//q3/9F/9B/+D330e//tdz77+36bP/8f+fX+w+//Fr/jf/+v/td/9L/w2db/+fe8+w//sr/+u/9Q8pf/Z3/iP/dH/mV/x1/9Y3/QHz9+Nv2zfu1/6U94dPjwH/urtx//8n/wj/iD/6C/9+/5n9vP/ov/5lf9ub/ir/iPRn/zL/iF/83v9Kf+I//zL/xD/o1P/uTVP/HH/JW/+1/9cPL6t/xjT/6iv+On/6XTf/JXf/LZr/xHf53f7V/5R/+oP+bwt/lrf9/f5k/9va/+sl/5D/1Of9vxf/1n/1kv/4jm8Bec/vrjP+f87q/5h/3hv+pf+0/+7b/2r/nn679+6+Uf8OXPfPvx0W/+Gz17+mf9idv/wV/7y37df/A3/lv+wsvf+r/45N978Nmf9Cf/sj/nr/tbX/8fv9NP/5v/xR/yJ/93f3j1L5bf+b3+iz/hz/8P3n3ye3/v9/q9fvyj9V/yl/zSX/aHfvp3fPFPzB/+7f/G/p/xj/w2/9Pdo0/Lo//1v1/9k//aX/PlH/YH/9N/2Hd+q0/+9G8/+7f+tt/51y5+m7+4/LX/qD/6j/ij/5jf+s/4B3Z/4R/wr/1Tf/7f9+jHfpdfcvevb37b/+03/vv/jL/md35+58nq//qPf79/7z/5VX/Dr3j847/1X/nnfPJ/TO7/Vv/Ut//QP27rF/2Rf/Kv+fLT7/5pf+udP+Fv/+d+t7/3r/p7/ut//y/9B/7NT/+Cv+j5f/fiW7/LX5Dc+91+8V/9L/zq/+T4r/nkj/hl//nuH/c/Pv+v/9tP/oG//dlPjh78Q7/833v2v7y4+0d/8fuUv9tv/lv9q//eP/v3/3V/45/9h/2Kf/vv+09+8O999DMXf+A/8qv/3T/qd3lx779++vzsn/oD/+z1f/jvfPb9X/xLXz39bX6v//2//C3/gX81+5v/r3r6D7796o/97f/lq9/73/7Nfsu/9+/8H//vf/x32f2tXn1Wf/f/+jX+uP/1//57/7S//m/4E369/3P++/8Bv/0f/Vv/p8e/w7/6v/3ZP/EP/Vqj3/R/3P0t/tt3i9/vW7/5n/Lg5D/5/X+rZw++dbpX/p//+J+x8wu//d/+/T/5e062/sI3r/+G/GL1m/xr/9cv2T79jX7DP+hfvv7T/42f+WPmv/fRn/vrr/6Z61/xf/0V/+r//Wt+8p/+1O/xz/wlOx/d/x3/zD+jevPvPv/Nf/2/6ge/y/pX/ytHf+If/l/8A3/VR+N/7YuTP+Nf/Mu/9Z9v/ZF/w3/Z/qJ/8V/79bO//nd99bv+b3/a4cv/7Tf6Hf/k/+5/vP69/+l/71/63X7fg9/zf/hzP/sn//7f/g/5zsHeg//qj/59f+z0z376923/0b/t//189i//sv/mL/37f4f/+Q/4d6//vr/p5O/7nf+Kv/dv+Ht+nV/45C/9v37i9/6Jv/Gv/QP+rj/mJ/eS3+3//pm/53fafv7n/Of/4x/+r/+Lf9gv+z//iz/krzv60//Sw7/l9/rj/pnX53/GV/P/+qf/41/037/5ff7If/H+X/bgH336j/89r/d+5U89+/3+pd/h4e/ZvPj3kx/7N8s/+839u3/F//j8t/xX/+b/+/lP/jm/7n//yz/9h3/nP/Hv/ju//e/9Oqf/zvHJL/+zk3/hf/11/5ez3+0/+j1+8LccPnzwC36t4vrX+29/m//sL//tH//zl//gn/3Xphd/8W/9R/75j2f/xl+S/QF/5O/+2/+pv+c/+K+8+F2+91/9hZP//r/+336D3/MP+oX/2bd/q9/13t/0+/5m/+23/rbq1/kFr3/Tf3T1m/8L/+l//Su+/LX/+t/mD/2sTP+8f7L4px82/95/8xf8yf/wP/avr/6UX/Qv/n6/8m/6tf/XX/s3an+Lb//pv/fv9ov/1fPv/43/xr/1J/zkv7n8g36N57/+7/3jv/W//UcUf+f6H/zss9/tj/97/rb/6ff+Nf+T/+SX/qJf55/81Re//c4vvvzu//E//rd/32/7F/2mv9Phf/uH/jPv/p0ne3/FP/7mP/9N7337n/6D/un05G/6067+/l/68W/8v//CX/g7/Ru/5R/z5z7+s/6m77z8t/6IP2z/X7z3S/6Tsz/q9/tHX33nL/+nv/w1/sw/9k+e/Lb//b+4+s1/y9/qHzv6l/64v+BX/32/5R969S/9B3/qX/Nv7Xzx/e/94//t3/jr/ka/9j/yx/72//tv8V//z7/kJ/+tX+P3/9Zf9Qf+Jd/5C77/B/9W/8BnD/6r0W/wj/+nf/xv9J8+/f6v9Rv9b//ZX/ZP3fuH/5Gtf+rv/Fd+/Ld8+dnWZ+2zrfHp9i/5bb//j/3Jv86v+zv/keU//Dtt/ZIn//Tf/Pf9rv/XL/5zr3+3P/Z/+XN+4z/+z0w//Z3+iV/2+b/5F/0d+b/x/PHf9pN/13+5n/zK/E+q//p/qv5vv/enlv/t+a/zF03/kt/sX/21f42/6Q/+/m87/uQ/mf6DH1/8Gn/vL//sn/s//ur7f8Yf9WN/093/8I//Qx4s/8nf+tf893b+gd/7vzz8m//Bf7X4F5/W//1v9OyfPvsD/7Ltv+l669//945/6z//4Z/wH//z/8Bf/zf9st/3j/5v/7Bf6y/90/75v+KP+Df/xP/01//v/+pvffdVO/3rf+/ffuu//Pf/gr9955d9/uIP/fN/h+3x6vd/tfjf/sjf7Xf5fX/5z/w2v84Xv+K3+mv+xb/onzv7Fb/d4k/5O47+kJ/+v/7GfzX/E/7Vn/ns9/wlv+q/P3r0rT/0H/zb/oK//cu//LN/9j/9u/+1/3379S/8b/+S3+sX/f0vJr/XfzH+o6q/7vf5Df6E//G//qz6lb/T+p/4H3/X/+wf++//qf/kX/lLPn726e/xl/+uf/3bP+Dqs3/td/sv/uOt/+53+es//8//lb/tfzv/8a9+5S/97/+W2egPevVXfPbVv/zsT/+Tvyjn/84/PPldvvr9Tv6o//LB//BnffG3Vd/9l3/tX///+F3z3/Ti3/yjT36Nv2b8q/+5v+9vrP76n1n+mY//wv+tOvjWk9/0u//sr3H0nb/if3r9V/x3D8e/7ewP+vv+pl/4+vJP/O/+0h//+774+/+Fb/8Fo7f/5+9Y/Oe/6W+w9++t/5E/5Cz5I/78P/0/+fNP//Tv/qK/4z/8Tf+B0z/9F97f+09nf/t/8X//Tf/9r/03/bd/9d/62/7Xv9Wf/Wf897/ye1nyV/+hf+wf/Cf9sv/8+V/1P/yS36r9XX7rX/M3+N9+7I/5z/6Y7+z8Xdkv/zN/7b/97/vb/pafeP1v/PJ/8Df4L3+nX/4X/rKLf/7TX/S//6J/5+2v+pV/+h/723/807/1T/yz/8Tv9lv9pv/bgz/yn33y3/42f8Zvc/B/L/63v+u3/Gt/5aPno9/75E/6id/ob/6r/4x/9s/4zh/3C37hP/sHvP0Dir//N578ZY//mz96+qc2v/Sv2f/nf+wv+Wv/7b/h9J989u9+dvQb/sT+g7/qD//pvzv/RX/Ar/xF/+4/8Rf/mX/5X/73jrd+8k/8Zf9V/pf9JrtX/9NH6XT/7/zd/u3/68/7v67/+L/6z/lnfs2/6T/+iX/mL/vr/qhPk7/qv75+du/P/zd/q/LXmV38bp8//p9/pz9s+7f6Zy9/7//0v/3Ff+jkL/+nf6N/5s+e/Om/95Nn/9eL3+z/+ssP/oF/6s/4g1/9Nckv+M3/lh/72/6m5R/55/2J/+d/+pP7f+Tf/Oi3+ft/24/Of8vf6+G/9Hv+Fr/BP1b/Gb/Jv/WT/3v9Tz78s/+nX/N/Tc/+q1+++zv8mv/zb/5X/FG/4+/yu/6O/8H3/9n/+7/9bZ//YX/Uo3/ht8/Ofrs/48f/y+K3+et/z7/+3/ktf4+//uS3+IX/8T/2J/2CP+Yf+Jv+8L/ut8k//S1Pfsnf9Ef95b/XP/2r/9w/5df9D/6Jv/3f/T9+zd/8N/tj/57/9ZNf9nf+/r/TX/lP/3t/2ZPd3+efnv+ff9tvfXw4efNb/75/9T/91/wbf8vFH/vPnfyev0uR/Lv/dFX+0f/EP/8fP/pHml/ry3/y7/zO9J/5V1d/4q/8a6dbv+zv/EV/187i6g/6fPEX/yPPvvjnft9/5A/653/rf/Sv+sd+s9/sL/iTf727/+Pv+tE/NPp1/qSfOvjD/p6zv+0P/QNe/qW/3uO/4dv/+C/4S//hX7D/q+b/3a/5N/2Tf9o/2Xz3VxTPr/61f/bX/aP/sf/yn/zznv2z/+xv+E/9nX/SP/MTJ3/Xr3zz6/xPP/g7nr/+NWbrP/0f+JW/37PPf/e/86/473+XP/Pwn/rL/sT/+9f5J/+mv+A/+Cv/r389z3/j+h9N/szqH1z+Xb/Gv/Y7/rd//e/4B/6vv9Zv9+Wv/7v+Ba//uD/iD1md/tpP9v+OP+qfOPrPf8vyz/gtf93f+vd78O/8rp/8Mf/Fn/kn/Faf/Qa/wb/4N/23b/+SP+m3+Ee+2/xm/82v8Rv87b/e3o/91Sd/zW/1G2y9+PU++eOPRp/szn/Xv/zP/t3/sF/j8vf9V7ZXf9v/9hs+/O8f/Jtf/X6/5V/5v3z2a/8Lf9cf+q/8x3/o8p/5N//kX/Bb/6HL6p/+T1//jv/p+jc9/Ff/h3/xV/7bZz/9R/7n/8Ff+Pk/9u/+Nl/9Ub/r/7j3P3z2f/1pf3713/2x/+7n//h/t/366O0f/W8+/RfOTn/RF//GP/gHP3786/yN/+w/8Je8/BW/y9/8B7/7pX/S3/7nLP7KX/IP/mv/1R9f/Qv/zl/2/Ms/trr75b/w4t2/ULz7XX6b73z3X/r1D3/627/w2fOXf/9vWX//Z/6l//tv+gd/zc/OiqN/9R//Rz779h+29St+vT/iB3/zn/7ms9/4v/nj//vf9s6f+sf9UVt/4980Ol/9DtPJn/zn/lG/92+79/f/OX/+7/9T/95v+pOX//sf8qt/jf/qD/87/6i/5Z/+0778Nf7Yv/MX/vq/0+/8vx/812f/e/tv/y1/3N/3p6z+x8ef/Sv/9dl/8bf9u//Zr/4NvvMf/eqd7/yWf9+/8/vv7uz+r//an/8vXRf/3P/15/2Jv+DX+9P/gb99/z9Z/77pX/HH/vf/0a/+L/7t/+6r/+x/+7d+5R/wB/4Pf/7O7/g7/kt/yZ//x/3z/+Mf8g+//Hf//f9s9Qef/rV/y+/3N/5Pf+e//Kf9Qf/8v1D9Dh//qXd/p//7j/lr/+DHf9Rv+of8p3/or/36z/zlP/X3/IY/9ft+8Rf++69+g6vf6c/55OPz//EvW/1Gxc6f8rf90dPfff/d5O/8rb63/HOe/dbf++3/vXs/uf7qt/zHfuKv+zWevP7Ok1/z1/g1fw08vxH9/3JvvDO+v/Ng7wE++XV/jZb+/Q2SX+PX+PFf+mv8Gj9DP3+734B+f93WxfKiQYs/7bf4NX6N5/Tzx796/Wv8R/T7b4bfP//q7Cn9/J/o7/bXpb+flNXk1wifX+vX+DWS7/7pf8mdH/sF9Mf//mve+zV+m1+DsXhC//9N9P/fUpx+T/r/b0z//3Xo/+mvIe3wf4Lxa/yYfo6/qatf49ej//+29P/fXH/iGxndr/dr/AG/xif07/mvsaZ//3L+/a/lf/8B/vc/4H9/41/zd/w1f71f49Nf85Nf47f4Nb73a+7RJ9mvWdEnf9yv+afQv38z//v387f/GH/7z/6a/xp98l/8mnj3/+R/f6dfC5/c4X93+N9D/veLXwtv/aJfa4/+vfy18O7P/Fpo/wfzv3/Hr/UP/lq/za/xz/5a//Kv9ev9Gr/1r/27/9q/3q/xx//a+Pxv+7Xx7t//a//j9Mm/x5/8b/xv+uv8g9Tyya+D3+e/TvXr/Hq/xt/Ev//Dv86/Qr//J/z7f8f//spfBxB+s1+XceN/t35djPH+r1v9Or/Jr/Hk13356/4mv8Y5/fvr/Rq/9Nf9I+nff+zXxRh/h18PLe/+euj3r+Df/8lfD3T7L/nfX/fXB8zfif99yP/+3vzvL+J//xj+9y/nf/+hXx/Q/jX+9z/hT/7vX3/N0/VdOzu/JnHNP/Nr/Ou/xm9Pv/1a9N9v9msUv/avQX/9Or/Gb8gtm1/7B7/2b0+z+xv/Gr8Z/fVH0F/Xv8avD46gv/5M/u7X1+/+Ev7ux/S7v5q/w1+/LkMBzN/k1/itf43fkv76m+iv61/jN/01fkf+61f9uuYvtPwtfz20NH+V+tdHDHP268hfW8Sw//mv8bvQv/8N//s/8r+/6Nf+XQjeL/21d3/N3/LX+EN+7fu/5m/5a/4Fv/ZD+v0Hv/Znv+Zv/mv8Bb/28a+5+2t89ms+pX9/6a+Nf3/wa3+b2vxNv/bvRf9+9mve/7Vegr1/jT/5t/tHqe9f89f4i/ivP+K3++W/xi+kv/4u+Y7ef0iU2f9d8def8Rsc/5rfpr/+IP3r9/o1X9Ff/5j89Wv8fr/Wn0tUe/rj8tef8mv9m7/Gb/BrfPt3l79+rV/71/41f+zX+OW/UP76PX/t3/3X/A1/jT/tY9f7b/xr/E5bpveP6K/Rlv/d0+Cvf47/wojx12/3Lfnr6Nf583/N3/jX+KNG8tdXv87fhr+25a/Zr/Nv0l//2Fj++gN/nf8Nf92Vv/74X+e3+rUI5o789Vf/OmP8tSt//eDXfkh//W/8159K/f2d+OtT09+/Tn/9Vgfy16/6df97fKd//QW/9m/4a//Gv8Zv8Ej++qW/9sf0169xaN57Tn/9Zo/Ne1N895n89Tf92mv669c5Mu/9GfTX/6F/ffZr/j147/c0Pfzb9Nf/pn999ev81+jvifnu/0LLE9PfL/h1fuNfY/+paXlIf/12pwbmK/rrd3omf/3g157TX7/V56b3P5T+2vq2/PWH/Np/Mf318sxg/bfSX/PvGKz/kV8H+vLX/DX+918DWvL/pn9/7V/j1/k18clXv2b887/818K/v+mvjc9/i18bv7/m37/7a//mv8afTjB3fw3wQcH//sG/xn/7a1b072/6a13/Gn/1r/Hs1/oTf42/+df4fX6tP+PX+Jd/jT/q1/rnfo3/+Nf4336t//3X+K+p5W//a/7Xv8anv3b6a/6av+a/8WtPf80f+zX/i197/mv+5r/mL/81lvT7b/TrtPT57/NrTX/N3/7XBMzf/tcc/zp/CknE/V/nz/41/+Bf4/f5df75X/POr3n96/xPtI7/R/w6v9mv9W//Gn/ar3Pn19rn3n/Rr2n+/SN+rWv694/7tX6fX/Py1/3o19j/Nf6CX/ev/rV+7Nf8K3/d9Nfc/TX/xl/3z/4193+Nv+vX/ZsJx3/h1/2X6N//lP4l/H/d/5J+/z9/3V/31z77NZJf76Nf+/jX2Pr1nv3af/Gv+emv92eQBnj86/1xpD9Of72/gf79zq/3r/3a//avMf31/tNf+8d+zebX+99+7Tu/5i/+9X6bX+cX/Zp/0K/36a/zd/8af9Sv95v9Wse/xp9C//6iX+PP//X+nF/nr/41p7/eX0///q2/3t/76/zNhNU/++v83YznP0z//m+/zj/N//7L/O+/zf/+x/zvf83//s/876+if3d+3V/z18LvP8b//ua/FiCMidq/7a87/jX+U/733/01f2f699f+tUr691f/mr8//fvLfs379O+/+mv+n7/O+Nf4W/nfv/bX/Lfp37/01/yX6N9/9tf8Dejbf5Tf/Xvp91/n1/izfm1Yyl+LNeCvT/P8E2THE/oJtv4Nf41tYv0vfo3f+9f4S8ge/oa/5pe/5ptf8xf/mn/5r/n3/Zr/ya/56/5av/Ov9eTX+kd+rX/v1/rffq3f5tfe/bW/+2v/9K/9B/3af/Gv/U/92r/hr/PJr3P663zv17n8df64X+fXYms7/bVHv+avSb382tTPr0P/nv4al7/Gn/hr/jO/5r/6a17+Wie/9p/ya/+KX/vN7wUs/rsXwOHPewX7/u+8gtX/df4gfP7rMffKAwv/a+nveH5N9gW6n/02kc8+6X2W/Bp7/PM3CD475p/A9cfom4T+/Q3p529E//+NteWP/xp/L1D6NX53/bmrP+/pz/v68wH9/DX55z/Ifx/q34f692fa7vfQn8f680TbnWi7U/37lP7+tfjnP8qff67tz/TnF9ruC33vS/38J+jnzq/x07/G41/jDycO+mNINv7eX+Plr/EPkaf2j5OH9T/9Gi9+jf/11/j01/itfs1Hv0b1az39NX7pr/W7/Rp/5q/1jP7/7V/jzyfP5A8nXvhLf63fk37+moThr0Xy/2vTCH8dwv7XJQr8er/G70pz9rsSZf5wotTvSvT6jOj1jxO9PiN6LWgOf1eyj384WfHfnryw35W8HeiPv/vX+K3o29+a/v/b0Ge/7a/xEGi+eLM7npUlfv4ai2Za1WUx+TVeXzdtvhh/t1jOqqtm/KyqF41+aL57WmdX5ID+Gl8U07pqqvN2/JNFs87KJ1lTTH+Nx19Us3WZH/0aZ8v23t6v8Wq9bItF/u28XOW1gTTWT8cn1WJVlHn9Oq8vi2ne0EtFW2Rl8YP8uK6z619D/tXmz4q8nH07W87K/Nc4mWf1rzGeTtuq/jUWWTnP13W+fvdrnC2yi2KZ17/Gl5Ofzqftr3GZ1bv4Zw//3KMX0H598YNd/HPv11jV1U8vs0X+a5ydLteLvM4mZf4H7BosT6qyJCBFtWzGn+cElYYnzvev8R//IX/Vr3GRt7//d6pl1vwajf3tMivXOWNB/9KoeCyA2h25/Q7gf43f/831qteECJjX1crS5vf/Im/n1exseV79Gq+ICtXi13hStIts9WscN02+mJTXFkJ+roj/Ggz487zFz2d1tVDyaR/4VD85W15Wb/MvCA5R7wlNPw3zWZlRnIE/6DOvd/mV5tu89mucLi+Lulou8mX7a5y+K9pf4z/6y/6I/+gv+2v+o7/sr/qP/vI/6D/6y/6Q/+gv+yt+jdc0q78G0ZRm4Ml1m/8aT9bn5+irrKZvT6rVNb3zZ/xHf/kf+x/9ZX/ef/SX/QP/0V/2l/1Hf/kf+Wt89fn825Plk2X23bb8fd6+26WOphVQM0N9k79rf42v2qJs4vzYZzF0JWz1H/1lf9d/9JcTan8TdflrvNz9NX6v3V/jVd5U63qaf5EtaQprR1D5uAEplbX+o7/sL/mP/rK/RfD8j/6yv5vG+Wu8291hlqKvmauEJ06XxDP06oy45m/9j/+Qv4h+/OX0/7+J/v93ykd/66/xk+Abniv+AN/9ZfLrXyU/8Ndf/2uc6cz+Gl9UJCiVxe/NvM4zJsspmObXOF6tnlaLrFgyk56s65omRj/BWMrL/PSSPpK5r3+NbDb7/c0Y9Xvl9CfropwJxHw5+zXeVFYA/tJf44usbuZE52vCSomCsRCJhEEa+vPvA5w8s8rj7Mtf47t10WKcfynG/6Y6ri8m8tdfxtg+KS5Oifuy5VfLguZaW/5VAd70DumK08tili+n+bMMYm25/3U+XVMX5Em4pidltcxZDs9O1k1bLY5bGsdk3eYv6wpg6l/j7GnRrKpGGxHXZKwOfo2nBUtSVl//AXvE+QvqSYf0lCYja/PuAJnl6rxpIH/e719gMNIJCYzi3kV6/LIqi+k1q5QzKF2i5tOszZg0L8BUJ9WypXlsfq/8+tf4/a3kU7PTdwSjpckJPiTmu7YfvIC0gAUBzaKAP1g4mdJ/qT96UobU3zRrfw1hsV/jdZnnK6NQml/jeUWfYcKzZXGeN61hImDKwgJJbwTwX/RrvNaxvAIkzDykEL1/t5i1c/7teb68oF/pzZfFu7yEhiMELvMabP2mEqPyu/6uO/T/Xfr/3q8h8s1q9FVeZu/4t8ZOr9F0PKS2mBQlEdl9ayjzpmjLvP/x07yZ1sUKIPtfEl7nxcW6zoa+ph6Xkb6I42braRt7Y3VdFxfzyFdv6myWL7L6rfuK4JOeKyY+3p+vi1n/5Wek/36SrG+A5uv1ihnzrJxljRMHuDcPfg38l/0aU8rW5PTvNvkf98nbuke/7dNns19jh37L6LsJ/X+b/n5An+/R7/v0e04tdsi/2SFQ3/+f/oi/46fS733xZ/z9//hv/Hfde/nb/hq/wd/5g9/3J3/7/f/oj/4N/qbf4/f/A3/zfz159Ov/Gr/Wr/lb/Ma/+W+OqOfX+vV+k187/TV+zV8v/bV/zd/kN/lNfsNf/9f5rX+L3/nX/LV/g9/gd/4N6Nvf5Nf/9X+d34l+/7V/rd/5N6E0AP3z6/9av8Fv8Ov+Gr/mr/k7/ya/+a//Y7/Tb/G7/xa/8W9x57fY/i128cKvk/yav8X9X+/X+DV/i+Pf/PTX+p1/3d8w/XV/p9/kNz/7Lb74nX7n3wlffYZ/jn+99Nf6nfABwfgNfr1fgzv97X793/w3+A1+g9/pN/idfvPv/wa/wW+e/Vq/1m/xGwPc7/xr44XfHf88/PUS+vC3+I0Tyk/Ql/ie+vmdf93f4uFv/uv/RviTkPy1GNHf+Tf4danp4jf5tZNf8zf5DX4Nfum3+I1pvL/zr/s7/7q/yW/w6/+6v9PvJJj+Wr/Jb0KY/Jq/CWGV/pq/02/y61HTh7/Jb/Lr/AY0xl/71/vNf6tf+9ej8f96v/nvRD9/7V/r1/u1fu1f77f4jX+tX4/++s1Hv86v/2v+zr/2b/Lr/9hv8UvQHeENcDSY34kSKr/FH/SH/7oE9Hf67X49CgF/iz/oj/4tf/3fjMb1O/1O3Aw9U9tf63f+tenb3+IP+uN/bSL7b/Lr/xq/zm9CHye/ya//G/wGv8Uf9CcLuN/51yaECdav/Wv/xvj4N+ZPaWS/1i/4NX7d9Nf4nX+Ln/i16f/Jb/Zr4scv+DV+g9/gN/71f+w3MG1+g9/g16eZ/J1/3d/gN/iNfrNf89f7NX/Br4FfqYNf/9fnJtSGuv0NfoNf49f+DX6z3zz7DX6D35A+Z7x+bYzi1/gtFiDE4tf+9WikWyDfZ7/Tb/EH/dmjX/+3/y3+oD//t/iD/uLf4g/6y38n+uCv/p2A62/xB/31+Pk3M36/M8NAB5ipP+gP/01+/d/6t/iD/nYi8q+f/Nr05+/0m1CISlglhNtv8Qf96b/5H/QP/1q/boLf+N+/m//9x399It1vSckkavpr/ZbkZP961Bcl2H/d3+Q3JiR/iz/on1baAM3PgOZnv7Y3rN+ACI9x/ma/5q/7G4AmNP5fHzylYyO6UQ+gGf2g73/t3/DX//V+g9/8+2A4gpj+Gr/593+MvvvNv/8LiDC/Ob1I2P/zvyZmhrv8tX7Br0nxI3Fq8pv9Wr/Ob/ILfo1f8Gv+ekQ50/NvwHz8GwCbX+83UCZEw98JDX/tXw89MUMLGr/zb3FM83Ys03f8C36NX+/XdohSm9/w1/i1f4vPwKyE529Mg5E/CK1fD1NleIEw/p1/E2D8O/8mgEAUI+7+DalPNCXsCONfC5z4m/xOv9Fv9mv/usQFv4CG8BswgkoQ4pLfwHDJbyBc8uv9emYA2sOvyz38ugZHHS5NM3PP939t8yl/9hv8xr/Zr/XrU0+/ATr6tX899wKYkuBQJ7/er4eZ/M0zMB7eIQFkHqRh/uYZJu3Xg2ohVH79X+PXZralWWYkf41fh3/8BiSqBPzX1BD1FyCP+ubX+m2+W2erF9Xy9N00Z6tBVpPCqF8TjX+ThGLy6cdkJEmX/Zq/xo89z9JXWdGQj8CJTuIkiq3thykpZMqt03u/1p1f89f43fbvnzzY2/t0Z/tg78nB9v6zndPtJ/f397d3T44PHu4ePLi3+5Riut/o1/w1fv37tIKwM6ZA+9dhoL/Gr/F3/Qe/hn3+Bfyeur/95x+y7X7/k6p+WpZfwFvkwDDPOVDE83//7r9G+nvGAfzoiTzIrtO6za/xa/xB3c8xPTuRz/F8m/7/e/9HNKG/tvvmN/q19+nfn/w1Xv8avz/9e/prvKLfzijn8IL+PqN/n9HveP7+X+d//L/MioxkX+Tn76FwsF7jZ2XwIB36axLU7NeoCU7xa5Rkxc9+jSVZ8oq//934rTf0bUafNvR9RmtTBX27VAh/069Tcg7zNX1e0zcUeUQgfZvb7Nj/9smD2KHPR5wDO6E2C/ovp/btr4EFrufUT0ojzQhSo73te21XjA/5tfQT7/0ag++Qibb4PKX/N+TXAM9VMI7pr/Exf4d1tx0SbffOT9L/a/rGtb1PucEd/f+ebX/GuKPtkjAoPcxeEP12qe2MPoUs/Z6Uq/k1CVvyv7klRrSisQCri19jzjj0x5LS56Aw1ud+zeB9mR34Xwuex7dMQXkOGLcvFXahuJmxLQdxHDHdXtJ7FX22Jvq0Aa19eu1zH2HbLtW6NBO8jqlFw3hPqNdrGmPsvU/1PV5++H/z8y/Juul/dHRTwx89/398/h8A");
					InitializeComponent();
					num = ((int)num2 * -1005313328) ^ -594293247;
					continue;
				case 0u:
					num = (int)(num2 * 929052149) ^ -1246414387;
					continue;
				default:
					return;
				case 3u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string string_ = default(string);
		while (true)
		{
			int num = -1747271498;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE13B440Du) % 9u)
				{
				case 7u:
					PreVentFlicker();
					string_ = Form1.smethod_6(Form1.smethod_5(Form1.smethod_4()));
					num = (int)((num2 * 204961241) ^ 0x22502C54);
					continue;
				case 6u:
					num = (int)(num2 * 1364683812) ^ -1252967177;
					continue;
				case 5u:
					Form1.smethod_2((Form)(object)this, bool_0: true);
					num = (int)((num2 * 826106784) ^ 0x57E94C92);
					continue;
				case 4u:
					string_ = Form1.smethod_8(string_, 6, checked(Form1.smethod_7(string_) - 6));
					provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
					datafile = Form1.smethod_9(string_, "\\Database.accdb");
					Form1.smethod_10(myconnection, Form1.smethod_9(provider, datafile));
					num = ((int)num2 * -1566948175) ^ 0x13D0076;
					continue;
				case 2u:
					Form1.smethod_3((Form)(object)this, (AutoSizeMode)0);
					num = (int)(num2 * 1029295801) ^ -796521196;
					continue;
				case 1u:
					login_type = "";
					num = ((int)num2 * -681793948) ^ 0x6D95D9ED;
					continue;
				case 0u:
					num = ((int)num2 * -1619318247) ^ 0x3CD2CCA4;
					continue;
				case 8u:
					break;
				default:
					username = "";
					return;
				}
				break;
			}
		}
	}

	private void loginBtn_Click(object sender, EventArgs e)
	{
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected I4, but got Unknown
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected I4, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Incompatible stack heights: 0 vs 1
		//IL_055c: Incompatible stack heights: 0 vs 1
		//IL_0563: Incompatible stack heights: 0 vs 1
		Form1.smethod_11(myconnection);
		try
		{
			string string_ = Form1.smethod_13(new string[5]
			{
				"Select [Designation] From [Staff] Where [Username] = '",
				Form1.smethod_12(UsernameTxt),
				"' And [Password] = '",
				Form1.smethod_12(PasswordTxt),
				"';"
			});
			OleDbCommand val = Form1.smethod_14();
			int num9 = default(int);
			bool flag3 = default(bool);
			bool flag = default(bool);
			OleDbDataReader oleDbDataReader_ = default(OleDbDataReader);
			bool flag2 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			while (true)
			{
				int num = 334387685;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x57973EAFu) % 38u)
					{
					case 37u:
						num9 = 1;
						num = (int)((num2 * 1436312105) ^ 0x18828D4C);
						continue;
					case 36u:
						num9 = 0;
						num = ((int)num2 * -648876307) ^ 0x3EE42E39;
						continue;
					case 34u:
						flag3 = num9 == 1;
						num = 520559868;
						continue;
					case 33u:
						num = ((int)num2 * -427145698) ^ -736796439;
						continue;
					case 32u:
						flag = Form1.smethod_26(ShowPasswd);
						num = ((int)num2 * -1113616928) ^ 0x2DA27BE2;
						continue;
					case 31u:
						num = (int)((num2 * 1559762150) ^ 0x6420AA97);
						continue;
					case 30u:
						val = Form1.smethod_15(string_, myconnection);
						oleDbDataReader_ = Form1.smethod_16(val);
						num = ((int)num2 * -939341921) ^ -1564536606;
						continue;
					case 29u:
						num = 2087582378;
						continue;
					case 28u:
					{
						int num10;
						int num11;
						if (flag2)
						{
							num10 = 178771102;
							num11 = 178771102;
						}
						else
						{
							num10 = 1469455939;
							num11 = 1469455939;
						}
						num = num10 ^ (int)(num2 * 1808486387);
						continue;
					}
					case 27u:
						num = 174374727;
						continue;
					case 26u:
						num = ((int)num2 * -1459686307) ^ -938848886;
						continue;
					case 25u:
						flag4 = Form1.smethod_18(login_type, "Admin", bool_0: false) == 0;
						num = 1832309099;
						continue;
					case 24u:
					{
						int num14;
						int num15;
						if (flag4)
						{
							num14 = 1854096683;
							num15 = 1854096683;
						}
						else
						{
							num14 = 215324810;
							num15 = 215324810;
						}
						num = num14 ^ ((int)num2 * -644266397);
						continue;
					}
					case 23u:
					{
						int num12;
						int num13;
						if (flag)
						{
							num12 = 1000826749;
							num13 = 1000826749;
						}
						else
						{
							num12 = 2102638753;
							num13 = 2102638753;
						}
						num = num12 ^ (int)(num2 * 512810059);
						continue;
					}
					case 22u:
					{
						int num7;
						int num8;
						if (flag5)
						{
							num7 = 485634998;
							num8 = 485634998;
						}
						else
						{
							num7 = 549239370;
							num8 = 549239370;
						}
						num = num7 ^ (int)(num2 * 1017601557);
						continue;
					}
					case 21u:
						flag5 = Form1.smethod_18(login_type, Calculate_Login_Type(Form1.smethod_20(Form1.smethod_19(oleDbDataReader_, 0))), bool_0: false) == 0;
						num = 604252919;
						continue;
					case 20u:
						Form1.smethod_30("Incorrect Credentials");
						num = ((int)num2 * -1086398054) ^ 0x33558F9F;
						continue;
					case 19u:
						num = 2070238335;
						continue;
					case 18u:
						Form1.smethod_30("Incorrect Credentials");
						num = ((int)num2 * -252600850) ^ -826139289;
						continue;
					case 17u:
					{
						int num5;
						int num6;
						if (flag3)
						{
							num5 = -1599983;
							num6 = -1599983;
						}
						else
						{
							num5 = -595654968;
							num6 = -595654968;
						}
						num = num5 ^ (int)(num2 * 1016544353);
						continue;
					}
					case 16u:
						num = (int)((num2 * 1320112151) ^ 0x15628998);
						continue;
					case 15u:
						Form1.smethod_32(myconnection);
						num = (int)((num2 * 921133254) ^ 0x5E07C38F);
						continue;
					case 14u:
						Form1.smethod_24(StaffRadioBtn, bool_0: false);
						Form1.smethod_25((Control)(object)this);
						num = ((int)num2 * -533541448) ^ -1404026618;
						continue;
					case 13u:
						username = Form1.smethod_22(Form1.smethod_12(UsernameTxt));
						Form1.smethod_23((TextBoxBase)(object)UsernameTxt);
						num = (int)(num2 * 1907466535) ^ -1097055607;
						continue;
					case 12u:
						num = (int)(num2 * 378057198) ^ -1017859664;
						continue;
					case 11u:
						num = (int)(num2 * 978367313) ^ -911944450;
						continue;
					case 10u:
						num = 457219775;
						continue;
					case 9u:
						Form1.smethod_29((Control)(object)MyProject.Forms.Form2);
						num = 1029580419;
						continue;
					case 8u:
						flag2 = Form1.smethod_21(oleDbDataReader_);
						num = 1210597005;
						continue;
					case 7u:
					{
						int num3;
						int num4;
						if (Form1.smethod_17(oleDbDataReader_) & (Form1.smethod_18(login_type, "", bool_0: false) != 0))
						{
							num3 = -844553750;
							num4 = -844553750;
						}
						else
						{
							num3 = -300708427;
							num4 = -300708427;
						}
						num = num3 ^ ((int)num2 * -737413279);
						continue;
					}
					case 6u:
						num = 1013718495;
						continue;
					case 5u:
						num = ((int)num2 * -654669386) ^ -29852816;
						continue;
					case 4u:
						Form1.smethod_31((Component)(object)val);
						num = 1225096266;
						continue;
					case 3u:
						Form1.smethod_27(ShowPasswd, bool_0: false);
						Form1.smethod_28(PasswordTxt, bool_0: true);
						num = ((int)num2 * -246854257) ^ -855549215;
						continue;
					case 2u:
						Form1.smethod_29((Control)(object)MyProject.Forms.Form3);
						num = (int)(num2 * 1749954958) ^ -33416795;
						continue;
					case 1u:
						Form1.smethod_23((TextBoxBase)(object)PasswordTxt);
						Form1.smethod_24(AdminRadioBtn, bool_0: false);
						num = ((int)num2 * -124529922) ^ -1920524436;
						continue;
					default:
						return;
					case 0u:
						break;
					case 35u:
						return;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Form1.smethod_33(exception_);
			while (true)
			{
				_ = 1990446749;
				while (true)
				{
					_003F val2 = /*Error near IL_0507: Stack underflow*/^ 0x57973EAF;
					uint num2 = (uint)(int)val2;
					switch (val2 % 4)
					{
					default:
						return;
					case 2:
						Form1.smethod_32(myconnection);
						Form1.smethod_30("Incorrect Credentials");
						_ = ((int)num2 * -1950908239) ^ 0x27E0A884;
						continue;
					case 1:
						Form1.smethod_34();
						_ = ((int)num2 * -2015333596) ^ 0x6E928CF8;
						continue;
					case 0:
						break;
					case 3:
						return;
					}
					break;
				}
			}
		}
	}

	private void ExitBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 749210428;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x389B0623u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				Form1.smethod_35((Form)(object)this);
				num = ((int)num2 * -843910975) ^ 0x1F673A82;
			}
		}
	}

	private void ShowPasswd_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 2018489931;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A4B8185u) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1066950254) ^ -1741784980;
					continue;
				case 8u:
					num = (int)((num2 * 906584676) ^ 0x3B3F78B1);
					continue;
				case 6u:
					flag = Form1.smethod_36(PasswordTxt);
					num = ((int)num2 * -1996441256) ^ -948563062;
					continue;
				case 5u:
					num = (int)(num2 * 1285495381) ^ -407173282;
					continue;
				case 4u:
					num = ((int)num2 * -1088315122) ^ 0x62E1F76F;
					continue;
				case 3u:
					Form1.smethod_28(PasswordTxt, bool_0: true);
					num = 1323994010;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 991806990;
						num4 = 991806990;
					}
					else
					{
						num3 = 1372614945;
						num4 = 1372614945;
					}
					num = num3 ^ (int)(num2 * 630439575);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1074716368) ^ 0x74CA4C6C);
					continue;
				case 0u:
					Form1.smethod_28(PasswordTxt, bool_0: false);
					num = (int)((num2 * 328534150) ^ 0x6614DA44);
					continue;
				default:
					return;
				case 7u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private string Calculate_Login_Type(string designation)
	{
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 605710703;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x20A12CB0u) % 8u)
				{
				case 7u:
					flag = Form1.smethod_18(Form1.smethod_37(designation), "admin", bool_0: false) == 0;
					num = ((int)num2 * -926936344) ^ 0x29300FBD;
					continue;
				case 6u:
					result = "Admin";
					num = (int)((num2 * 1424457676) ^ 0x7C6FAC41);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 202749651;
						num4 = 202749651;
					}
					else
					{
						num3 = 1104343177;
						num4 = 1104343177;
					}
					num = num3 ^ ((int)num2 * -955363687);
					continue;
				}
				case 4u:
					num = 353294667;
					continue;
				case 3u:
					result = "Staff";
					num = ((int)num2 * -1807176394) ^ -1546983038;
					continue;
				case 0u:
					num = ((int)num2 * -928225401) ^ -605991255;
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void AdminRadioBtn_CheckedChanged(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -666591237;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA123009u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				login_type = "Admin";
				num = (int)(num2 * 987547816) ^ -505758715;
			}
		}
	}

	private void StaffRadioBtn_CheckedChanged(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -277560153;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE95F8788u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				login_type = "Staff";
				num = (int)(num2 * 2019445296) ^ -1876893049;
			}
		}
	}

	private void PreVentFlicker()
	{
		while (true)
		{
			int num = -528016442;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4F2779Bu) % 8u)
				{
				case 7u:
					num = ((int)num2 * -1560526679) ^ -1941044204;
					continue;
				case 5u:
					((Control)this).SetStyle((ControlStyles)131072, true);
					num = ((int)num2 * -870892917) ^ -1758489168;
					continue;
				case 4u:
					((Control)this).SetStyle((ControlStyles)2, true);
					num = ((int)num2 * -820569642) ^ 0x5F539A89;
					continue;
				case 3u:
					((Control)this).UpdateStyles();
					num = ((int)num2 * -1862933815) ^ -1857328913;
					continue;
				case 2u:
					num = (int)((num2 * 1970149693) ^ 0x6679340);
					continue;
				case 1u:
					((Control)this).SetStyle((ControlStyles)8192, true);
					num = ((int)num2 * -1690387448) ^ -1492065008;
					continue;
				default:
					return;
				case 6u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public bool Name_Validation(string name)
	{
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected I4, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected I4, but got Unknown
		//IL_050a: Incompatible stack heights: 0 vs 1
		//IL_0521: Incompatible stack heights: 0 vs 1
		//IL_0528: Incompatible stack heights: 0 vs 1
		bool result = default(bool);
		try
		{
			int num3 = default(int);
			bool flag2 = default(bool);
			bool flag = default(bool);
			int num11 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num = 512086655;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4FCD720u) % 40u)
					{
					case 38u:
					{
						int num18;
						if ((Form1.smethod_39(name, num4) >= 'a') & (Form1.smethod_39(name, num4) <= 'z'))
						{
							num = 1400894162;
							num18 = 1400894162;
						}
						else
						{
							num = 812711860;
							num18 = 812711860;
						}
						continue;
					}
					case 37u:
						result = false;
						num = ((int)num2 * -481771359) ^ 0x32F32A6F;
						continue;
					case 36u:
						result = false;
						num = (int)((num2 * 625495144) ^ 0x376212A9);
						continue;
					case 35u:
					{
						int num14;
						if ((Form1.smethod_18(Form1.smethod_40(Form1.smethod_39(name, num4)), "a", bool_0: false) >= 0) & (Form1.smethod_39(name, num4) <= 'z'))
						{
							num = 1985033838;
							num14 = 1985033838;
						}
						else
						{
							num = 1082609469;
							num14 = 1082609469;
						}
						continue;
					}
					case 34u:
						num3 = 2;
						num = ((int)num2 * -60859698) ^ 0x1447A24C;
						continue;
					case 33u:
						num = 1252185037;
						continue;
					case 32u:
						num3 = 2;
						num = (int)((num2 * 1933304999) ^ 0x3C0CBBC9);
						continue;
					case 31u:
						num = (int)((num2 * 140418134) ^ 0x6A526147);
						continue;
					case 30u:
						num3 = 0;
						num = 1753684586;
						continue;
					case 29u:
					{
						int num17;
						if (Form1.smethod_39(name, num4) != ' ')
						{
							num = 113172139;
							num17 = 113172139;
						}
						else
						{
							num = 2005367826;
							num17 = 2005367826;
						}
						continue;
					}
					case 28u:
						num3 = 1;
						num = (int)(num2 * 1295150351) ^ -365900285;
						continue;
					case 27u:
						result = false;
						num = ((int)num2 * -2139558429) ^ 0x2FCDE837;
						continue;
					case 26u:
					{
						int num9;
						int num10;
						if (flag2)
						{
							num9 = 1897605442;
							num10 = 1897605442;
						}
						else
						{
							num9 = 224246403;
							num10 = 224246403;
						}
						num = num9 ^ (int)(num2 * 916441013);
						continue;
					}
					case 25u:
						result = false;
						num = ((int)num2 * -889483723) ^ 0x12272CCE;
						continue;
					case 24u:
						num = ((int)num2 * -304680707) ^ -2052692559;
						continue;
					case 23u:
					{
						int num20;
						int num21;
						if (!flag)
						{
							num20 = 1833971068;
							num21 = 1833971068;
						}
						else
						{
							num20 = 160070792;
							num21 = 160070792;
						}
						num = num20 ^ (int)(num2 * 434262620);
						continue;
					}
					case 22u:
						num = 1153473320;
						continue;
					case 21u:
						num = (int)((num2 * 413827104) ^ 0x55E7310B);
						continue;
					case 20u:
						flag2 = Form1.smethod_39(name, num4) == ' ';
						num = 341004426;
						continue;
					case 19u:
					{
						int num19;
						if (Form1.smethod_39(name, num4) != '.')
						{
							num = 83121245;
							num19 = 83121245;
						}
						else
						{
							num = 1682140060;
							num19 = 1682140060;
						}
						continue;
					}
					case 16u:
					{
						int num16;
						if (num3 != 1)
						{
							num = 1346620651;
							num16 = 1346620651;
						}
						else
						{
							num = 1056620182;
							num16 = 1056620182;
						}
						continue;
					}
					case 15u:
					{
						int num15;
						if (num4 <= num11)
						{
							num = 906348404;
							num15 = 906348404;
						}
						else
						{
							num = 605110359;
							num15 = 605110359;
						}
						continue;
					}
					case 13u:
						num = ((int)num2 * -2002385670) ^ 0x1171A19B;
						continue;
					case 12u:
					{
						int num12;
						int num13;
						if (!((Form1.smethod_39(name, num4) >= 'a') & (Form1.smethod_39(name, num4) <= 'z')) & !((Form1.smethod_39(name, num4) == '.') | (Form1.smethod_39(name, num4) == ' ')))
						{
							num12 = -1731813556;
							num13 = -1731813556;
						}
						else
						{
							num12 = -1396677;
							num13 = -1396677;
						}
						num = num12 ^ ((int)num2 * -2032800082);
						continue;
					}
					case 11u:
						num = 149103337;
						continue;
					case 10u:
						num = ((int)num2 * -1656229823) ^ -443982557;
						continue;
					case 9u:
						num4 = checked(num4 + 1);
						num = 867393135;
						continue;
					case 8u:
						num3 = 0;
						num4 = 0;
						num11 = checked(Form1.smethod_7(name) - 1);
						num4 = 0;
						num = (int)((num2 * 846117237) ^ 0x1A43D9C7);
						continue;
					case 7u:
					{
						int num7;
						int num8;
						if (Form1.smethod_18(Form1.smethod_38(name), Form1.smethod_37(name), bool_0: false) == 0)
						{
							num7 = 1825126543;
							num8 = 1825126543;
						}
						else
						{
							num7 = 1177519242;
							num8 = 1177519242;
						}
						num = num7 ^ ((int)num2 * -632672420);
						continue;
					}
					case 6u:
					{
						int num5;
						int num6;
						if (!(!((Form1.smethod_39(name, num4) >= 'a') & (Form1.smethod_39(name, num4) <= 'z')) & (Form1.smethod_39(name, num4) != ' ')))
						{
							num5 = -2038479360;
							num6 = -2038479360;
						}
						else
						{
							num5 = -597049257;
							num6 = -597049257;
						}
						num = num5 ^ (int)(num2 * 1665876709);
						continue;
					}
					case 4u:
						flag = num3 == 0;
						num = 655979239;
						continue;
					case 2u:
						num3 = 0;
						num = ((int)num2 * -1953502190) ^ -74419676;
						continue;
					case 1u:
						num = (int)((num2 * 158362401) ^ 0x5309B448);
						continue;
					case 0u:
						num = ((int)num2 * -1375307708) ^ 0x54603FEB;
						continue;
					case 5u:
						break;
					default:
						result = true;
						return result;
					case 3u:
						return result;
					case 14u:
						return result;
					case 17u:
						return result;
					case 18u:
						return result;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Form1.smethod_33(exception_);
			while (true)
			{
				_ = 1623831307;
				while (true)
				{
					_003F val = /*Error near IL_04e0: Stack underflow*/^ 0x4FCD720;
					uint num2 = (uint)(int)val;
					switch (val % 4)
					{
					case 3:
						_ = (num2 * 2107356639) ^ 0xF58F1AE5u;
						continue;
					case 0:
						result = false;
						Form1.smethod_34();
						_ = (num2 * 51114448) ^ 0xEDA64455u;
						continue;
					case 2:
						break;
					default:
						return result;
					case 1:
						return result;
					}
					break;
				}
			}
		}
	}

	public bool age_validator(string age)
	{
		try
		{
			int num8 = default(int);
			bool result = default(bool);
			int num10 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -581833764;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE09D7E1Du) % 20u)
					{
					case 19u:
						num = -439295752;
						continue;
					case 18u:
					{
						int num9;
						if (!((Form1.smethod_39(age, num8) >= '0') & (Form1.smethod_39(age, num8) <= '9')))
						{
							num = -643333109;
							num9 = -643333109;
						}
						else
						{
							num = -1064113773;
							num9 = -1064113773;
						}
						continue;
					}
					case 17u:
						num8 = 0;
						num = (int)((num2 * 2045692477) ^ 0x92F1A45);
						continue;
					case 16u:
						result = true;
						num = (int)((num2 * 2104772491) ^ 0x3999C2B5);
						continue;
					case 14u:
						num = -1615743047;
						continue;
					case 13u:
						result = false;
						num = (int)(num2 * 1989917822) ^ -443838000;
						continue;
					case 12u:
					{
						int num5 = Form1.smethod_41(age);
						int num6;
						int num7;
						if (num5 <= 150)
						{
							num6 = 237389463;
							num7 = 237389463;
						}
						else
						{
							num6 = 1935073633;
							num7 = 1935073633;
						}
						num = num6 ^ (int)(num2 * 1878083649);
						continue;
					}
					case 10u:
						num8 = checked(num8 + 1);
						num = -684239166;
						continue;
					case 9u:
					{
						int num12;
						int num13;
						if (Form1.smethod_18(Form1.smethod_38(age), Form1.smethod_37(age), bool_0: false) == 0)
						{
							num12 = 493301925;
							num13 = 493301925;
						}
						else
						{
							num12 = 887787894;
							num13 = 887787894;
						}
						num = num12 ^ ((int)num2 * -390363134);
						continue;
					}
					case 7u:
						num = (int)((num2 * 373337190) ^ 0x3E0D8B8);
						continue;
					case 6u:
						num10 = checked(Form1.smethod_7(age) - 1);
						num8 = 0;
						num = -103226670;
						continue;
					case 5u:
						flag = (Form1.smethod_7(age) > 3) | (Form1.smethod_7(age) == 0);
						num = (int)((num2 * 522050378) ^ 0x42504496);
						continue;
					case 3u:
					{
						int num11;
						if (num8 <= num10)
						{
							num = -492811717;
							num11 = -492811717;
						}
						else
						{
							num = -498419759;
							num11 = -498419759;
						}
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1328041489;
							num4 = -1328041489;
						}
						else
						{
							num3 = -1506448077;
							num4 = -1506448077;
						}
						num = num3 ^ ((int)num2 * -1347299);
						continue;
					}
					case 8u:
						break;
					case 0u:
						return false;
					case 2u:
						return false;
					case 15u:
						return false;
					default:
						return result;
					case 4u:
						return result;
					case 11u:
						return result;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Form1.smethod_33(exception_);
			bool result = false;
			Form1.smethod_34();
			return result;
		}
	}

	public bool Gender_Validator(string gender)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -776915504;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD550444Bu) % 7u)
				{
				case 5u:
					result = true;
					num = (int)((num2 * 398983846) ^ 0x30F22719);
					continue;
				case 4u:
					flag = (Form1.smethod_18(gender, "male", bool_0: false) == 0) | (Form1.smethod_18(gender, "female", bool_0: false) == 0) | (Form1.smethod_18(gender, "others", bool_0: false) == 0);
					num = (int)((num2 * 1205729465) ^ 0x335CF0B0);
					continue;
				case 2u:
					num = ((int)num2 * -1150061754) ^ 0x369E527D;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 2097692180;
						num4 = 2097692180;
					}
					else
					{
						num3 = 1371513509;
						num4 = 1371513509;
					}
					num = num3 ^ ((int)num2 * -51322875);
					continue;
				}
				case 0u:
					result = false;
					num = -2063206407;
					continue;
				case 6u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public bool Mobile_Validator(string mobile)
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected I4, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected I4, but got Unknown
		//IL_0179: Incompatible stack heights: 0 vs 1
		//IL_018e: Incompatible stack heights: 0 vs 1
		//IL_0195: Incompatible stack heights: 0 vs 1
		try
		{
			int num = 0;
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num2 = -1763023866;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x8B5A64C1u) % 12u)
					{
					case 11u:
						flag = Form1.smethod_7(mobile) != 10;
						num2 = (int)((num3 * 952096639) ^ 0x36CD317C);
						continue;
					case 10u:
						num = 0;
						num2 = -219748758;
						continue;
					case 9u:
					{
						int num6;
						int num7;
						if (!flag2)
						{
							num6 = 1357721390;
							num7 = 1357721390;
						}
						else
						{
							num6 = 1511636011;
							num7 = 1511636011;
						}
						num2 = num6 ^ (int)(num3 * 806825432);
						continue;
					}
					case 8u:
					{
						num = checked(num + 1);
						int num8;
						int num9;
						if (num <= 9)
						{
							num8 = 1058995498;
							num9 = 1058995498;
						}
						else
						{
							num8 = 1289097175;
							num9 = 1289097175;
						}
						num2 = num8 ^ ((int)num3 * -518081200);
						continue;
					}
					case 7u:
						flag2 = !((Form1.smethod_39(mobile, num) >= '0') & (Form1.smethod_39(mobile, num) <= '9'));
						num2 = -236467132;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1145073044;
							num5 = -1145073044;
						}
						else
						{
							num4 = -1696996293;
							num5 = -1696996293;
						}
						num2 = num4 ^ ((int)num3 * -1396359504);
						continue;
					}
					case 3u:
						num2 = -233036251;
						continue;
					case 2u:
						result = false;
						num2 = ((int)num3 * -243795702) ^ -1645696332;
						continue;
					case 0u:
						break;
					case 1u:
						return false;
					default:
						return true;
					case 5u:
						return result;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Form1.smethod_33(exception_);
			while (true)
			{
				IL_0190:
				_ = -1466404886;
				while (true)
				{
					_003F val = /*Error near IL_014f: Stack underflow*/^ -1957010239;
					uint num3 = (uint)(int)val;
					switch (val % 4)
					{
					default:
						goto end_IL_0149;
					case 3:
						_ = ((int)num3 * -706975903) ^ 0x52639AD6;
						continue;
					case 0:
						Form1.smethod_34();
						_ = (num3 * 553342641) ^ 0xC3DB2EA0u;
						continue;
					case 2:
						break;
					case 1:
						goto end_IL_0149;
					}
					goto IL_0190;
					continue;
					end_IL_0149:
					break;
				}
				break;
			}
		}
		return false;
	}

	public bool Decimal_Validator(string deci)
	{
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected I4, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected I4, but got Unknown
		//IL_0289: Incompatible stack heights: 0 vs 1
		//IL_0290: Incompatible stack heights: 0 vs 1
		bool result = default(bool);
		try
		{
			bool flag = default(bool);
			int num9 = default(int);
			int num3 = default(int);
			bool flag2 = default(bool);
			int num4 = default(int);
			while (true)
			{
				int num = -305558334;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x82E47300u) % 21u)
					{
					case 19u:
					{
						int num7;
						int num8;
						if (flag)
						{
							num7 = 1005711257;
							num8 = 1005711257;
						}
						else
						{
							num7 = 853820886;
							num8 = 853820886;
						}
						num = num7 ^ ((int)num2 * -574414566);
						continue;
					}
					case 18u:
						num = ((int)num2 * -1107198225) ^ -801229787;
						continue;
					case 17u:
						num9 = checked(Form1.smethod_7(deci) - 1);
						num = -1333856737;
						continue;
					case 14u:
					{
						int num14;
						if (num3 <= num9)
						{
							num = -278755826;
							num14 = -278755826;
						}
						else
						{
							num = -1837075709;
							num14 = -1837075709;
						}
						continue;
					}
					case 13u:
						flag2 = !((Form1.smethod_39(deci, num3) >= '0') & (Form1.smethod_39(deci, num3) <= '9')) & (Form1.smethod_39(deci, num3) != '.');
						num = -1429320130;
						continue;
					case 12u:
					{
						int num10;
						int num11;
						if (num4 < 2)
						{
							num10 = 482867744;
							num11 = 482867744;
						}
						else
						{
							num10 = 859802182;
							num11 = 859802182;
						}
						num = num10 ^ (int)(num2 * 655709334);
						continue;
					}
					case 11u:
						num3 = 0;
						num = (int)((num2 * 1639954334) ^ 0x64137766);
						continue;
					case 10u:
					{
						int num12;
						int num13;
						if (!flag2)
						{
							num12 = -1315941850;
							num13 = -1315941850;
						}
						else
						{
							num12 = -1354753476;
							num13 = -1354753476;
						}
						num = num12 ^ (int)(num2 * 1248333103);
						continue;
					}
					case 9u:
						num4 = checked(num4 + 1);
						num = ((int)num2 * -1506953402) ^ -1388813911;
						continue;
					case 8u:
					{
						num4 = 0;
						int num5;
						int num6;
						if (!((Form1.smethod_18(Form1.smethod_37(deci), Form1.smethod_38(deci), bool_0: false) != 0) | (Form1.smethod_7(deci) == 0)))
						{
							num5 = -842155804;
							num6 = -842155804;
						}
						else
						{
							num5 = -190375487;
							num6 = -190375487;
						}
						num = num5 ^ (int)(num2 * 1775433206);
						continue;
					}
					case 7u:
						num = -1054307796;
						continue;
					case 6u:
						num = -1278705274;
						continue;
					case 4u:
						num = -1578545094;
						continue;
					case 3u:
						num3 = checked(num3 + 1);
						num = (int)((num2 * 458126070) ^ 0x51D03D11);
						continue;
					case 1u:
						result = false;
						num = ((int)num2 * -300775864) ^ 0x7C9B1D6B;
						continue;
					case 0u:
						flag = Form1.smethod_39(deci, num3) == '.';
						num = ((int)num2 * -1394323235) ^ 0x4C3DBEDA;
						continue;
					case 5u:
						break;
					default:
						result = true;
						return result;
					case 15u:
						result = false;
						return result;
					case 16u:
						result = false;
						return result;
					case 20u:
						return result;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Form1.smethod_33(exception_);
			while (true)
			{
				_ = -1285312177;
				while (true)
				{
					_003F val = /*Error near IL_025c: Stack underflow*/^ -2098957568;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = false;
						Form1.smethod_34();
						_ = (num2 * 1082494318) ^ 0x32B3D7D5;
						continue;
					case 0:
						break;
					default:
						return result;
					case 2:
						return result;
					}
					break;
				}
			}
		}
	}

	public bool Number_Validator(string num)
	{
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected I4, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected I4, but got Unknown
		//IL_01e6: Incompatible stack heights: 0 vs 1
		//IL_01ed: Incompatible stack heights: 0 vs 1
		bool result = default(bool);
		try
		{
			int num4 = default(int);
			int num7 = default(int);
			bool flag2 = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num2 = 1751771874;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x14CD2903u) % 16u)
					{
					case 13u:
					{
						int num8;
						if (num4 > num7)
						{
							num2 = 2055776439;
							num8 = 2055776439;
						}
						else
						{
							num2 = 35242520;
							num8 = 35242520;
						}
						continue;
					}
					case 12u:
						num2 = ((int)num3 * -584382680) ^ -1360829410;
						continue;
					case 11u:
						flag2 = (Form1.smethod_39(num, num4) >= '0') & (Form1.smethod_39(num, num4) < '9');
						num2 = 265088353;
						continue;
					case 10u:
						num7 = checked(Form1.smethod_7(num) - 1);
						num2 = (int)(num3 * 751701899) ^ -1372556243;
						continue;
					case 9u:
					{
						int num9;
						int num10;
						if (flag)
						{
							num9 = -1768688547;
							num10 = -1768688547;
						}
						else
						{
							num9 = -1464482180;
							num10 = -1464482180;
						}
						num2 = num9 ^ ((int)num3 * -929251032);
						continue;
					}
					case 7u:
						num2 = 2146747849;
						continue;
					case 6u:
						result = false;
						num2 = (int)((num3 * 312473262) ^ 0x43182DB8);
						continue;
					case 5u:
						num4 = checked(num4 + 1);
						num2 = 1510951550;
						continue;
					case 3u:
						num2 = ((int)num3 * -1037145050) ^ 0x3C573D14;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (!flag2)
						{
							num5 = 1565505311;
							num6 = 1565505311;
						}
						else
						{
							num5 = 414513972;
							num6 = 414513972;
						}
						num2 = num5 ^ (int)(num3 * 288951626);
						continue;
					}
					case 1u:
						flag = (Form1.smethod_18(Form1.smethod_37(num), Form1.smethod_38(num), bool_0: false) != 0) | (Form1.smethod_7(num) == 0);
						num2 = ((int)num3 * -2000995061) ^ 0x30F29021;
						continue;
					case 0u:
						num4 = 0;
						num2 = (int)(num3 * 1767393739) ^ -752752801;
						continue;
					case 14u:
						break;
					default:
						result = true;
						return result;
					case 8u:
						result = false;
						return result;
					case 15u:
						return result;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Form1.smethod_33(exception_);
			while (true)
			{
				IL_01e8:
				_ = 1175694664;
				while (true)
				{
					_003F val = /*Error near IL_01c0: Stack underflow*/^ 0x14CD2903;
					uint num3 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						_ = ((int)num3 * -852922265) ^ -253710652;
						continue;
					case 2:
						break;
					default:
						Form1.smethod_34();
						goto end_IL_01ba;
					}
					goto IL_01e8;
					continue;
					end_IL_01ba:
					break;
				}
				break;
			}
		}
		while (true)
		{
			int num11 = 120701686;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num11 ^ 0x14CD2903u) % 4u)
				{
				case 3u:
					num11 = ((int)num3 * -88171811) ^ 0x60FB5E0;
					continue;
				case 1u:
					result = false;
					num11 = (int)(num3 * 1612472722) ^ -1938120638;
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private ScreenSize AutoSuitableScreen()
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		ScreenSize screenSize = default(ScreenSize);
		Size size = default(Size);
		bool flag3 = default(bool);
		ScreenSize result = default(ScreenSize);
		Rectangle rectangle = default(Rectangle);
		while (true)
		{
			int num = -1419787712;
			while (true)
			{
				uint num2;
				int num4;
				int num3;
				switch ((num2 = (uint)num ^ 0xC2519455u) % 21u)
				{
				case 18u:
					num = (int)(num2 * 1178569907) ^ -350875950;
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 233238250;
						num8 = 233238250;
					}
					else
					{
						num7 = 1795558323;
						num8 = 1795558323;
					}
					num = num7 ^ ((int)num2 * -1691684131);
					continue;
				}
				case 16u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = 425017125;
						num10 = 425017125;
					}
					else
					{
						num9 = 1230167616;
						num10 = 1230167616;
					}
					num = num9 ^ (int)(num2 * 1688321292);
					continue;
				}
				case 15u:
					screenSize = ScreenSize.Extra;
					num = (int)(num2 * 1755753269) ^ -1104648196;
					continue;
				case 14u:
					num4 = (checked(size.Width * size.Height <= largeSize.Width * largeSize.Height) ? 1 : 0);
					goto IL_00ab;
				case 13u:
					num = (int)(num2 * 665815263) ^ -1812425442;
					continue;
				case 12u:
				{
					int num5;
					int num6;
					if (flag3)
					{
						num5 = 65299124;
						num6 = 65299124;
					}
					else
					{
						num5 = 833373007;
						num6 = 833373007;
					}
					num = num5 ^ ((int)num2 * -449746497);
					continue;
				}
				case 11u:
					num = -800571694;
					continue;
				case 10u:
					if (checked(middleSize.Width * middleSize.Height < size.Width * size.Height))
					{
						num = -1243523005;
						continue;
					}
					num4 = 0;
					goto IL_00ab;
				case 9u:
					screenSize = ScreenSize.Middle;
					num = ((int)num2 * -426643272) ^ 0x3A37F0DC;
					continue;
				case 8u:
					if (checked(smallSize.Width * smallSize.Height < size.Width * size.Height))
					{
						num = -53737640;
						continue;
					}
					num3 = 0;
					goto IL_017d;
				case 7u:
					screenSize = ScreenSize.Small;
					num = (int)(num2 * 2122975651) ^ -1804054645;
					continue;
				case 6u:
					num = (int)((num2 * 1003160264) ^ 0x3295B2B9);
					continue;
				case 5u:
					num = ((int)num2 * -1113142008) ^ 0x6D7374E9;
					continue;
				case 4u:
					num3 = (checked(size.Width * size.Height <= middleSize.Width * middleSize.Height) ? 1 : 0);
					goto IL_017d;
				case 3u:
					result = screenSize;
					num = -660218260;
					continue;
				case 2u:
					screenSize = ScreenSize.Large;
					num = (int)((num2 * 423430382) ^ 0x6C28C5F3);
					continue;
				case 1u:
					screenSize = default(ScreenSize);
					rectangle = Form1.smethod_43(Form1.smethod_42());
					num = (int)(num2 * 622745121) ^ -1187611470;
					continue;
				case 0u:
					size = rectangle.Size;
					flag = checked(size.Width * size.Height <= smallSize.Width * smallSize.Height);
					num = (int)((num2 * 584102440) ^ 0x32CE4F03);
					continue;
				case 19u:
					break;
				default:
					{
						return result;
					}
					IL_017d:
					flag2 = (byte)num3 != 0;
					num = -1946239227;
					continue;
					IL_00ab:
					flag3 = (byte)num4 != 0;
					num = -1388521591;
					continue;
				}
				break;
			}
		}
	}

	private void AutoLayout(ScreenSize size)
	{
		ScreenSize screenSize = default(ScreenSize);
		while (true)
		{
			int num = 226091670;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4BFC175Au) % 18u)
				{
				case 17u:
					num = ((int)num2 * -1148121948) ^ 0x47E26621;
					continue;
				case 16u:
					screenSize = size;
					num = (int)((num2 * 1224585810) ^ 0x2B95B0BD);
					continue;
				case 15u:
					AutoSizeForm(largeSize);
					num = ((int)num2 * -253160686) ^ 0x25C98493;
					continue;
				case 14u:
					AutoSizeForm(smallSize);
					num = (int)(num2 * 1810943353) ^ -1832286374;
					continue;
				case 13u:
					num = 215196426;
					continue;
				case 12u:
					AutoSizeForm(middleSize);
					num = ((int)num2 * -1692189223) ^ -1887622325;
					continue;
				case 10u:
					num = ((int)num2 * -1568914388) ^ 0x3F544E5D;
					continue;
				case 9u:
					goto IL_00a2;
				case 8u:
					num = ((int)num2 * -604918223) ^ -356644075;
					continue;
				case 6u:
					num = (int)(num2 * 496915227) ^ -746730590;
					continue;
				case 5u:
					switch (screenSize)
					{
					case ScreenSize.Middle:
						break;
					case ScreenSize.Extra:
						goto IL_00a2;
					default:
						goto IL_00f5;
					case ScreenSize.Small:
						goto IL_0104;
					case ScreenSize.Large:
						goto IL_010b;
					}
					goto case 13u;
				case 3u:
					goto IL_0104;
				case 0u:
					goto IL_010b;
				case 4u:
					num = ((int)num2 * -1709745310) ^ -149965927;
					continue;
				case 2u:
					num = (int)(num2 * 1697563365) ^ -578288325;
					continue;
				case 1u:
					num = ((int)num2 * -1185687556) ^ 0x28A87C9E;
					continue;
				default:
					return;
				case 11u:
					break;
				case 7u:
					return;
					IL_010b:
					num = 395266835;
					continue;
					IL_0104:
					num = 1545814480;
					continue;
					IL_00f5:
					num = ((int)num2 * -896709358) ^ -1087758954;
					continue;
					IL_00a2:
					AutoSizeForm(Form1.smethod_43(Form1.smethod_42()).Size);
					num = 1394484788;
					continue;
				}
				break;
			}
		}
	}

	private void AutoSizeForm(Size size)
	{
		int width = size.Width;
		int height = default(int);
		while (true)
		{
			int num = 371230638;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D038347u) % 4u)
				{
				case 2u:
					Form1.smethod_46((Control)(object)GroupBox1, checked(new Point((int)Form1.smethod_44((double)width / 2.0), (int)Form1.smethod_44((double)height / 5.0))));
					num = ((int)num2 * -2096578370) ^ 0x72884B34;
					continue;
				case 1u:
					height = size.Height;
					Form1.smethod_45((Form)(object)this, checked(new Size((int)Form1.smethod_44((double)width / 4.0), (int)Form1.smethod_44((double)height / 2.0))));
					num = ((int)num2 * -352451441) ^ 0x5CBDBFAA;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1963689071;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x67793BE4u) % 8u)
					{
					case 7u:
						num = ((int)num2 * -387529515) ^ -1408959598;
						continue;
					case 5u:
						num = ((int)num2 * -1438409439) ^ 0x1E4D28D7;
						continue;
					case 3u:
						if (disposing)
						{
							num = ((int)num2 * -1745260271) ^ 0x70802B6F;
							continue;
						}
						num3 = 0;
						goto IL_0038;
					case 2u:
						Form1.smethod_47((IDisposable)components);
						num = ((int)num2 * -817438287) ^ -1990545615;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 44444690;
							num5 = 44444690;
						}
						else
						{
							num4 = 172399382;
							num5 = 172399382;
						}
						num = num4 ^ (int)(num2 * 1171404864);
						continue;
					}
					case 0u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_0038;
					default:
						return;
					case 4u:
						break;
					case 6u:
						return;
						IL_0038:
						flag = (byte)num3 != 0;
						num = 1281778525;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -2114201167;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF4A90BAu) % 149u)
				{
				case 148u:
					num = (int)(num2 * 1532958969) ^ -318395635;
					continue;
				case 147u:
					Form1.smethod_85(Label2, "Password :");
					num = (int)(num2 * 1501192604) ^ -564707383;
					continue;
				case 146u:
					Form1.smethod_28(PasswordTxt, bool_0: true);
					num = (int)(num2 * 1860278104) ^ -24636983;
					continue;
				case 145u:
					num = ((int)num2 * -639246025) ^ 0x15CF0D60;
					continue;
				case 144u:
					num = ((int)num2 * -1169569456) ^ 0x48F22C57;
					continue;
				case 143u:
					num = ((int)num2 * -1866573866) ^ -444670414;
					continue;
				case 142u:
					Form1.smethod_74((ButtonBase)(object)ShowPasswd, bool_0: true);
					num = ((int)num2 * -1005414084) ^ 0x185A6B6E;
					continue;
				case 141u:
					num = ((int)num2 * -987481930) ^ 0x406A3358;
					continue;
				case 140u:
					Form1.smethod_46((Control)(object)ExitBtn, new Point(461, 248));
					num = ((int)num2 * -1516208063) ^ -1789921410;
					continue;
				case 139u:
					Form1.smethod_62(Form1.smethod_61((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)((num2 * 1787671003) ^ 0x791F9209);
					continue;
				case 138u:
					Form1.smethod_62(Form1.smethod_61((Control)(object)GroupBox1), (Control)(object)StaffRadioBtn);
					num = ((int)num2 * -250355415) ^ 0x66D83A31;
					continue;
				case 137u:
					Form1.smethod_77(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1844330556) ^ 0x282507BA;
					continue;
				case 136u:
					Form1.smethod_78(PictureBox1, 6);
					Form1.smethod_79(PictureBox1, bool_0: false);
					Form1.smethod_81((ButtonBase)(object)ExitBtn, Form1.smethod_80());
					num = (int)((num2 * 1975655370) ^ 0x178817AD);
					continue;
				case 135u:
					GroupBox1 = Form1.smethod_48();
					num = (int)(num2 * 451569971) ^ -430456552;
					continue;
				case 134u:
					Form1.smethod_58((Control)(object)GroupBox1, (AnchorStyles)0);
					num = ((int)num2 * -1404048606) ^ -959921052;
					continue;
				case 133u:
					Form1.smethod_68((Control)(object)ExitBtn, new Size(75, 32));
					num = ((int)num2 * -2069089320) ^ -1891722269;
					continue;
				case 132u:
					num = ((int)num2 * -968359512) ^ 0x5C9F6D73;
					continue;
				case 131u:
					Form1.smethod_75(AdminRadioBtn, bool_0: true);
					num = ((int)num2 * -271470683) ^ 0x19661EF3;
					continue;
				case 130u:
					Form1.smethod_62(Form1.smethod_61((Control)(object)GroupBox1), (Control)(object)Label1);
					Form1.smethod_62(Form1.smethod_61((Control)(object)GroupBox1), (Control)(object)PasswordTxt);
					Form1.smethod_62(Form1.smethod_61((Control)(object)GroupBox1), (Control)(object)UsernameTxt);
					num = (int)(num2 * 434134066) ^ -1212581646;
					continue;
				case 129u:
					Form1.smethod_67((Control)(object)GroupBox1, new Padding(5));
					Form1.smethod_68((Control)(object)GroupBox1, new Size(604, 318));
					num = ((int)num2 * -1312860301) ^ 0x69A941C9;
					continue;
				case 128u:
					num = ((int)num2 * -774753587) ^ 0x5DB611D6;
					continue;
				case 127u:
					num = (int)((num2 * 919052187) ^ 0x3F8E6D35);
					continue;
				case 126u:
					num = (int)((num2 * 1688541856) ^ 0x7BE293CE);
					continue;
				case 125u:
					Form1.smethod_62(Form1.smethod_90((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -446205798) ^ 0xF41B206;
					continue;
				case 124u:
					num = ((int)num2 * -837379771) ^ -1536805960;
					continue;
				case 123u:
					Form1.smethod_94((Form)(object)this, "Form1");
					num = (int)(num2 * 1636279492) ^ -2077008748;
					continue;
				case 122u:
					num = (int)((num2 * 1408355008) ^ 0xE2AF43C);
					continue;
				case 121u:
					num = (int)((num2 * 33255569) ^ 0x1E8700F);
					continue;
				case 120u:
					num = (int)(num2 * 837129469) ^ -1787224890;
					continue;
				case 119u:
					Form1.smethod_72((ButtonBase)(object)AdminRadioBtn, bool_0: true);
					num = ((int)num2 * -1853440067) ^ 0x2FA8E3D9;
					continue;
				case 118u:
					Form1.smethod_64((Control)(object)ShowPasswd, Form1.smethod_63("MS Reference Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					Form1.smethod_46((Control)(object)ShowPasswd, new Point(431, 192));
					num = ((int)num2 * -518045794) ^ -783703996;
					continue;
				case 117u:
					Form1.smethod_62(Form1.smethod_61((Control)(object)GroupBox1), (Control)(object)PictureBox1);
					num = ((int)num2 * -1072904089) ^ -560513055;
					continue;
				case 116u:
					Form1.smethod_69((Control)(object)AdminRadioBtn, 8);
					num = (int)((num2 * 10785645) ^ 0x52CC10E3);
					continue;
				case 115u:
					Form1.smethod_99((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1512098380) ^ -245461191;
					continue;
				case 114u:
					num = (int)(num2 * 566237466) ^ -2010437136;
					continue;
				case 113u:
					num = (int)((num2 * 1669860126) ^ 0x63C258CA);
					continue;
				case 112u:
					Form1.smethod_69((Control)(object)ExitBtn, 5);
					num = ((int)num2 * -1771183742) ^ -509952482;
					continue;
				case 111u:
					Form1.smethod_46((Control)(object)GroupBox1, new Point(793, 102));
					num = ((int)num2 * -508383167) ^ -558665667;
					continue;
				case 110u:
					Form1.smethod_57((Control)(object)this);
					num = (int)(num2 * 1185246645) ^ -1664012519;
					continue;
				case 109u:
					num = (int)(num2 * 1824163119) ^ -723729914;
					continue;
				case 108u:
					Form1.smethod_66((Control)(object)ShowPasswd, "ShowPasswd");
					num = ((int)num2 * -204633566) ^ 0x133E5702;
					continue;
				case 107u:
					Form1.smethod_68((Control)(object)AdminRadioBtn, new Size(78, 22));
					num = (int)(num2 * 480244751) ^ -966312871;
					continue;
				case 106u:
					Form1.smethod_46((Control)(object)Label2, new Point(234, 139));
					num = ((int)num2 * -330116780) ^ -86284616;
					continue;
				case 105u:
					Form1.smethod_73((ButtonBase)(object)AdminRadioBtn, "Admin");
					num = ((int)num2 * -964724683) ^ -1551738001;
					continue;
				case 104u:
					num = ((int)num2 * -769600194) ^ -1997745889;
					continue;
				case 103u:
					Form1.smethod_46((Control)(object)Label1, new Point(234, 83));
					num = (int)(num2 * 318793463) ^ -2080243874;
					continue;
				case 102u:
					Form1.smethod_55((Control)(object)GroupBox1);
					num = ((int)num2 * -1495129920) ^ 0x454E58ED;
					continue;
				case 101u:
					Form1.smethod_72((ButtonBase)(object)StaffRadioBtn, bool_0: true);
					Form1.smethod_64((Control)(object)StaffRadioBtn, Form1.smethod_63("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form1.smethod_46((Control)(object)StaffRadioBtn, new Point(29, 260));
					num = (int)(num2 * 1191577092) ^ -529905145;
					continue;
				case 100u:
					num = ((int)num2 * -181800081) ^ 0x47F50CEE;
					continue;
				case 99u:
					num = (int)((num2 * 1080287826) ^ 0x621171AD);
					continue;
				case 98u:
					Form1.smethod_60((Control)(object)this, (ImageLayout)3);
					num = ((int)num2 * -1301527999) ^ -468376824;
					continue;
				case 97u:
					num = (int)((num2 * 427383780) ^ 0x7FAF690A);
					continue;
				case 96u:
					num = ((int)num2 * -154169452) ^ 0x5FBCBDD1;
					continue;
				case 95u:
					num = (int)(num2 * 1890096451) ^ -957562848;
					continue;
				case 94u:
					loginBtn = Form1.smethod_52();
					num = ((int)num2 * -1824185580) ^ 0x3878AB93;
					continue;
				case 93u:
					Form1.smethod_64((Control)(object)Label1, Form1.smethod_63("MS Reference Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 867093572) ^ -1503626139;
					continue;
				case 92u:
					AdminRadioBtn = Form1.smethod_50();
					num = (int)((num2 * 1740865496) ^ 0x7C01F040);
					continue;
				case 91u:
					Form1.smethod_68((Control)(object)ShowPasswd, new Size(150, 23));
					num = ((int)num2 * -488280356) ^ 0x7D32B351;
					continue;
				case 90u:
					Form1.smethod_69((Control)(object)GroupBox1, 0);
					Form1.smethod_70(GroupBox1, bool_0: false);
					num = (int)((num2 * 917958401) ^ 0x3DCF96FD);
					continue;
				case 89u:
					num = ((int)num2 * -1765986811) ^ 0x6364287B;
					continue;
				case 88u:
					Form1.smethod_87((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)(num2 * 1735030448) ^ -321379165;
					continue;
				case 87u:
					Form1.smethod_69((Control)(object)Label1, 2);
					Form1.smethod_85(Label1, "Username :");
					num = ((int)num2 * -899945479) ^ 0x788EFBFE;
					continue;
				case 86u:
					num = (int)(num2 * 1294769614) ^ -79264426;
					continue;
				case 85u:
					num = (int)((num2 * 7741129) ^ 0xE462FD);
					continue;
				case 84u:
					Form1.smethod_66((Control)(object)StaffRadioBtn, "StaffRadioBtn");
					num = (int)(num2 * 252315743) ^ -31644618;
					continue;
				case 83u:
					num = (int)(num2 * 235996531) ^ -690366694;
					continue;
				case 82u:
					Form1.smethod_88((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1863933896) ^ 0x6E88D458;
					continue;
				case 81u:
					PasswordTxt = Form1.smethod_54();
					num = ((int)num2 * -339932004) ^ -1607090525;
					continue;
				case 80u:
					Form1.smethod_46((Control)(object)loginBtn, new Point(353, 248));
					num = ((int)num2 * -2031752116) ^ 0x6236ED53;
					continue;
				case 79u:
					Form1.smethod_96((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -1387886472) ^ 0x5A4B7502;
					continue;
				case 78u:
					Form1.smethod_65((Control)(object)GroupBox1, new Padding(5));
					num = (int)((num2 * 1995153391) ^ 0x41CA21C1);
					continue;
				case 77u:
					num = ((int)num2 * -207777790) ^ 0x62AF1C69;
					continue;
				case 76u:
					ShowPasswd = Form1.smethod_49();
					num = (int)((num2 * 1190445524) ^ 0x6AEAFF08);
					continue;
				case 75u:
					Form1.smethod_68((Control)(object)Label1, new Size(116, 29));
					num = (int)((num2 * 1754928621) ^ 0x735441D7);
					continue;
				case 74u:
					Form1.smethod_64((Control)(object)loginBtn, Form1.smethod_63("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 859433138) ^ 0xA722BCB);
					continue;
				case 73u:
					Form1.smethod_46((Control)(object)AdminRadioBtn, new Point(119, 258));
					num = (int)((num2 * 1957247419) ^ 0x302E986F);
					continue;
				case 72u:
					Form1.smethod_64((Control)(object)UsernameTxt, Form1.smethod_63("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1375305537) ^ -1713027236;
					continue;
				case 71u:
					Form1.smethod_64((Control)(object)GroupBox1, Form1.smethod_63("MS Reference Sans Serif", 13.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1259050253) ^ 0x176F4869;
					continue;
				case 70u:
					Form1.smethod_68((Control)(object)UsernameTxt, new Size(216, 28));
					Form1.smethod_69((Control)(object)UsernameTxt, 0);
					num = (int)((num2 * 1448026021) ^ 0x71A10975);
					continue;
				case 69u:
					Form1.smethod_73((ButtonBase)(object)StaffRadioBtn, "Staff");
					num = ((int)num2 * -1090559934) ^ 0x3B76E935;
					continue;
				case 68u:
					num = ((int)num2 * -1437034171) ^ 0x2C84AAA1;
					continue;
				case 67u:
					Form1.smethod_89((Form)(object)this, new Size(1262, 721));
					num = (int)((num2 * 401295850) ^ 0x267391F4);
					continue;
				case 66u:
					Form1.smethod_64((Control)(object)AdminRadioBtn, Form1.smethod_63("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1531577831) ^ 0x370EEE4C);
					continue;
				case 65u:
					UsernameTxt = Form1.smethod_54();
					num = (int)((num2 * 1578766725) ^ 0x14B6EE4A);
					continue;
				case 64u:
					Form1.smethod_68((Control)(object)Label2, new Size(116, 29));
					Form1.smethod_69((Control)(object)Label2, 3);
					num = (int)((num2 * 249552460) ^ 0x53E7C155);
					continue;
				case 63u:
					num = ((int)num2 * -1982836100) ^ 0x1B33B0B6;
					continue;
				case 62u:
					Form1.smethod_71(GroupBox1, "Login");
					Form1.smethod_72((ButtonBase)(object)ShowPasswd, bool_0: true);
					num = (int)((num2 * 545783321) ^ 0x65623B30);
					continue;
				case 61u:
					num = (int)((num2 * 1221080816) ^ 0x6922B3D5);
					continue;
				case 60u:
					Form1.smethod_68((Control)(object)PasswordTxt, new Size(216, 28));
					num = ((int)num2 * -1234167885) ^ 0x49870B10;
					continue;
				case 59u:
					num = ((int)num2 * -1665298241) ^ 0x2D861803;
					continue;
				case 58u:
					Form1.smethod_74((ButtonBase)(object)ExitBtn, bool_0: false);
					num = ((int)num2 * -1267208327) ^ 0x1C1763E2;
					continue;
				case 57u:
					Form1.smethod_66((Control)(object)PictureBox1, "PictureBox1");
					Form1.smethod_68((Control)(object)PictureBox1, new Size(197, 203));
					num = ((int)num2 * -208983719) ^ -600292243;
					continue;
				case 56u:
					Form1.smethod_66((Control)(object)Label1, "Label1");
					num = ((int)num2 * -203403872) ^ -247316521;
					continue;
				case 55u:
					Label2 = Form1.smethod_53();
					num = ((int)num2 * -584183502) ^ -1498937982;
					continue;
				case 54u:
					num = ((int)num2 * -1040846811) ^ 0x1300F97D;
					continue;
				case 53u:
					num = (int)((num2 * 1586120236) ^ 0x6200CD5C);
					continue;
				case 52u:
					Form1.smethod_56((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -329691176) ^ -1346453432;
					continue;
				case 51u:
					Form1.smethod_91((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1965121933) ^ 0x71AA0643;
					continue;
				case 50u:
					Form1.smethod_86(Label1, (ContentAlignment)32);
					num = ((int)num2 * -948545502) ^ 0x75CDA5A7;
					continue;
				case 48u:
					num = (int)((num2 * 1704131545) ^ 0x51F1A813);
					continue;
				case 47u:
					Form1.smethod_74((ButtonBase)(object)StaffRadioBtn, bool_0: true);
					Form1.smethod_76(PictureBox1, (Image)(object)Resources.imageedit_1_6564123496);
					num = ((int)num2 * -1940195412) ^ -504622986;
					continue;
				case 46u:
					Form1.smethod_98((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -666153729) ^ 0x12647E71;
					continue;
				case 45u:
					Form1.smethod_69((Control)(object)PasswordTxt, 1);
					num = (int)(num2 * 1235076714) ^ -1643134412;
					continue;
				case 44u:
					ExitBtn = Form1.smethod_52();
					num = (int)((num2 * 1731327142) ^ 0xECFBEAF);
					continue;
				case 43u:
					num = (int)(num2 * 1007067579) ^ -1429379866;
					continue;
				case 42u:
					num = (int)((num2 * 488791100) ^ 0x4820D7E);
					continue;
				case 41u:
					num = ((int)num2 * -878088040) ^ 0x509DEBFF;
					continue;
				case 40u:
					Form1.smethod_81((ButtonBase)(object)loginBtn, Form1.smethod_82());
					num = ((int)num2 * -741365173) ^ 0x10A16927;
					continue;
				case 39u:
					num = ((int)num2 * -1177788967) ^ -1193842412;
					continue;
				case 38u:
					StaffRadioBtn = Form1.smethod_50();
					num = ((int)num2 * -719021036) ^ 0x74401406;
					continue;
				case 37u:
					Form1.smethod_74((ButtonBase)(object)AdminRadioBtn, bool_0: true);
					num = (int)(num2 * 505939720) ^ -544777361;
					continue;
				case 36u:
					Form1.smethod_68((Control)(object)StaffRadioBtn, new Size(68, 22));
					num = (int)((num2 * 170042704) ^ 0x2DD6A046);
					continue;
				case 35u:
					PictureBox1 = Form1.smethod_51();
					num = (int)(num2 * 1434828786) ^ -380444082;
					continue;
				case 34u:
					Form1.smethod_95((Form)(object)this, (FormWindowState)2);
					num = (int)(num2 * 1810713690) ^ -79732600;
					continue;
				case 33u:
					Form1.smethod_69((Control)(object)StaffRadioBtn, 7);
					num = ((int)num2 * -1061995861) ^ -1878837516;
					continue;
				case 32u:
					num = ((int)num2 * -1960249783) ^ -762655740;
					continue;
				case 31u:
					Form1.smethod_66((Control)(object)Label2, "Label2");
					num = (int)((num2 * 71796290) ^ 0x7FB85E4A);
					continue;
				case 29u:
					Form1.smethod_86(Label2, (ContentAlignment)32);
					num = ((int)num2 * -677230879) ^ 0x5E0977B9;
					continue;
				case 28u:
					num = ((int)num2 * -1673699622) ^ -2085904377;
					continue;
				case 27u:
					Form1.smethod_66((Control)(object)GroupBox1, "GroupBox1");
					num = (int)(num2 * 1459378973) ^ -427124048;
					continue;
				case 26u:
					Form1.smethod_62(Form1.smethod_61((Control)(object)GroupBox1), (Control)(object)loginBtn);
					num = (int)(num2 * 113351510) ^ -1469496919;
					continue;
				case 25u:
					Form1.smethod_66((Control)(object)loginBtn, "loginBtn");
					num = (int)((num2 * 1929230151) ^ 0x17109B32);
					continue;
				case 24u:
					Form1.smethod_84((Control)(object)loginBtn, Form1.smethod_83());
					num = ((int)num2 * -587264231) ^ 0x56A3B351;
					continue;
				case 23u:
					Form1.smethod_66((Control)(object)ExitBtn, "ExitBtn");
					num = (int)(num2 * 760898615) ^ -1989127394;
					continue;
				case 22u:
					Form1.smethod_66((Control)(object)AdminRadioBtn, "AdminRadioBtn");
					num = (int)(num2 * 265068724) ^ -721465661;
					continue;
				case 21u:
					Form1.smethod_62(Form1.smethod_61((Control)(object)GroupBox1), (Control)(object)ExitBtn);
					num = ((int)num2 * -1334576323) ^ -1174471046;
					continue;
				case 20u:
					Form1.smethod_64((Control)(object)Label2, Form1.smethod_63("MS Reference Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1742804844) ^ 0x5B52C047;
					continue;
				case 19u:
					Form1.smethod_73((ButtonBase)(object)ShowPasswd, "Show Password");
					num = ((int)num2 * -608135867) ^ 0x526FA49;
					continue;
				case 18u:
					Form1.smethod_59((Control)(object)GroupBox1, Color.AliceBlue);
					num = ((int)num2 * -2007969019) ^ -590034547;
					continue;
				case 17u:
					num = ((int)num2 * -1372748751) ^ -99733213;
					continue;
				case 16u:
					Form1.smethod_92((Form)(object)this, bool_0: false);
					Form1.smethod_93((Control)(object)this, "Form1");
					num = (int)((num2 * 1135255711) ^ 0x522212AA);
					continue;
				case 15u:
					Form1.smethod_46((Control)(object)UsernameTxt, new Point(376, 77));
					Form1.smethod_66((Control)(object)UsernameTxt, "UsernameTxt");
					num = (int)((num2 * 1538185989) ^ 0x46F68996);
					continue;
				case 14u:
					Form1.smethod_64((Control)(object)ExitBtn, Form1.smethod_63("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 936070279) ^ -747977080;
					continue;
				case 13u:
					Form1.smethod_66((Control)(object)PasswordTxt, "PasswordTxt");
					num = ((int)num2 * -305340954) ^ -669008127;
					continue;
				case 12u:
					num = (int)(num2 * 1316652124) ^ -2058003548;
					continue;
				case 11u:
					Form1.smethod_74((ButtonBase)(object)loginBtn, bool_0: false);
					num = ((int)num2 * -50557750) ^ 0x3B8004D4;
					continue;
				case 10u:
					Form1.smethod_64((Control)(object)PasswordTxt, Form1.smethod_63("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					Form1.smethod_46((Control)(object)PasswordTxt, new Point(376, 133));
					num = (int)((num2 * 2084893543) ^ 0x6C218059);
					continue;
				case 9u:
					Label1 = Form1.smethod_53();
					num = (int)(num2 * 756751259) ^ -817810876;
					continue;
				case 8u:
					Form1.smethod_73((ButtonBase)(object)loginBtn, "Login");
					num = ((int)num2 * -142233123) ^ -1578804737;
					continue;
				case 7u:
					Form1.smethod_69((Control)(object)ShowPasswd, 16);
					num = ((int)num2 * -1057755100) ^ -272583037;
					continue;
				case 6u:
					Form1.smethod_75(StaffRadioBtn, bool_0: true);
					num = ((int)num2 * -1442825966) ^ 0x71ABF933;
					continue;
				case 5u:
					Form1.smethod_46((Control)(object)PictureBox1, new Point(0, 51));
					num = ((int)num2 * -2066702422) ^ 0x3FA064DB;
					continue;
				case 4u:
					Form1.smethod_73((ButtonBase)(object)ExitBtn, "Exit");
					num = (int)(num2 * 1333020310) ^ -1595295908;
					continue;
				case 3u:
					Form1.smethod_68((Control)(object)loginBtn, new Size(75, 32));
					num = (int)((num2 * 1224871284) ^ 0x6C2843FE);
					continue;
				case 2u:
					Form1.smethod_97((Control)(object)GroupBox1);
					num = ((int)num2 * -443204870) ^ -206355791;
					continue;
				case 1u:
					Form1.smethod_69((Control)(object)loginBtn, 4);
					num = ((int)num2 * -204458039) ^ 0x7B8BE263;
					continue;
				case 0u:
					Form1.smethod_60((Control)(object)GroupBox1, (ImageLayout)0);
					Form1.smethod_62(Form1.smethod_61((Control)(object)GroupBox1), (Control)(object)ShowPasswd);
					Form1.smethod_62(Form1.smethod_61((Control)(object)GroupBox1), (Control)(object)AdminRadioBtn);
					num = ((int)num2 * -1555623040) ^ -389725091;
					continue;
				default:
					return;
				case 30u:
					break;
				case 49u:
					return;
				}
				break;
			}
		}
	}

	static void smethod_0(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static OleDbConnection smethod_1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbConnection();
	}

	static void smethod_2(Form form_0, bool bool_0)
	{
		form_0.set_AutoSize(bool_0);
	}

	static void smethod_3(Form form_0, AutoSizeMode autoSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_AutoSizeMode(autoSizeMode_0);
	}

	static Assembly smethod_4()
	{
		return Assembly.GetExecutingAssembly();
	}

	static string smethod_5(Assembly assembly_0)
	{
		return assembly_0.CodeBase;
	}

	static string smethod_6(string string_0)
	{
		return Path.GetDirectoryName(string_0);
	}

	static int smethod_7(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_8(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, int_1);
	}

	static string smethod_9(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_10(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static void smethod_11(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static string smethod_12(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_13(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static OleDbCommand smethod_14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static OleDbCommand smethod_15(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbDataReader smethod_16(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteReader();
	}

	static bool smethod_17(OleDbDataReader oleDbDataReader_0)
	{
		return oleDbDataReader_0.get_HasRows();
	}

	static int smethod_18(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static object smethod_19(OleDbDataReader oleDbDataReader_0, int int_0)
	{
		return oleDbDataReader_0.get_Item(int_0);
	}

	static string smethod_20(object object_0)
	{
		return object_0.ToString();
	}

	static bool smethod_21(OleDbDataReader oleDbDataReader_0)
	{
		return oleDbDataReader_0.Read();
	}

	static string smethod_22(string string_0)
	{
		return string_0.ToString();
	}

	static void smethod_23(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static void smethod_24(RadioButton radioButton_0, bool bool_0)
	{
		radioButton_0.set_Checked(bool_0);
	}

	static void smethod_25(Control control_0)
	{
		control_0.Hide();
	}

	static bool smethod_26(CheckBox checkBox_0)
	{
		return checkBox_0.get_Checked();
	}

	static void smethod_27(CheckBox checkBox_0, bool bool_0)
	{
		checkBox_0.set_Checked(bool_0);
	}

	static void smethod_28(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_UseSystemPasswordChar(bool_0);
	}

	static void smethod_29(Control control_0)
	{
		control_0.Show();
	}

	static DialogResult smethod_30(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static void smethod_31(Component component_0)
	{
		component_0.Dispose();
	}

	static void smethod_32(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_33(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_34()
	{
		ProjectData.ClearProjectError();
	}

	static void smethod_35(Form form_0)
	{
		form_0.Close();
	}

	static bool smethod_36(TextBox textBox_0)
	{
		return textBox_0.get_UseSystemPasswordChar();
	}

	static string smethod_37(string string_0)
	{
		return string_0.ToLower();
	}

	static string smethod_38(string string_0)
	{
		return string_0.ToUpper();
	}

	static char smethod_39(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static string smethod_40(char char_0)
	{
		return Conversions.ToString(char_0);
	}

	static short smethod_41(string string_0)
	{
		return Convert.ToInt16(string_0);
	}

	static Screen smethod_42()
	{
		return Screen.get_PrimaryScreen();
	}

	static Rectangle smethod_43(Screen screen_0)
	{
		return screen_0.get_WorkingArea();
	}

	static double smethod_44(double double_0)
	{
		return Math.Round(double_0);
	}

	static void smethod_45(Form form_0, Size size_0)
	{
		form_0.set_Size(size_0);
	}

	static void smethod_46(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_47(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static GroupBox smethod_48()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static CheckBox smethod_49()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new CheckBox();
	}

	static RadioButton smethod_50()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new RadioButton();
	}

	static PictureBox smethod_51()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Button smethod_52()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static Label smethod_53()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static TextBox smethod_54()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static void smethod_55(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_56(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_57(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_58(Control control_0, AnchorStyles anchorStyles_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Anchor(anchorStyles_0);
	}

	static void smethod_59(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_60(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static ControlCollection smethod_61(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_62(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static Font smethod_63(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_64(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_65(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_66(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_67(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Padding(padding_0);
	}

	static void smethod_68(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_69(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_70(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_71(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_72(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_AutoSize(bool_0);
	}

	static void smethod_73(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_74(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_75(RadioButton radioButton_0, bool bool_0)
	{
		radioButton_0.set_TabStop(bool_0);
	}

	static void smethod_76(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_77(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_78(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_79(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static Color smethod_80()
	{
		return SystemColors.ButtonHighlight;
	}

	static void smethod_81(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static Color smethod_82()
	{
		return SystemColors.ControlLightLight;
	}

	static Color smethod_83()
	{
		return SystemColors.ControlText;
	}

	static void smethod_84(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_85(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_86(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_87(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_88(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_89(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_90(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_91(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_92(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_93(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_94(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_95(Form form_0, FormWindowState formWindowState_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_WindowState(formWindowState_0);
	}

	static void smethod_96(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_97(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_98(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_99(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_100(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_101(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_102(RadioButton radioButton_0, EventHandler eventHandler_0)
	{
		radioButton_0.remove_CheckedChanged(eventHandler_0);
	}

	static void smethod_103(RadioButton radioButton_0, EventHandler eventHandler_0)
	{
		radioButton_0.add_CheckedChanged(eventHandler_0);
	}

	static void smethod_104(CheckBox checkBox_0, EventHandler eventHandler_0)
	{
		checkBox_0.remove_CheckedChanged(eventHandler_0);
	}

	static void smethod_105(CheckBox checkBox_0, EventHandler eventHandler_0)
	{
		checkBox_0.add_CheckedChanged(eventHandler_0);
	}
}
