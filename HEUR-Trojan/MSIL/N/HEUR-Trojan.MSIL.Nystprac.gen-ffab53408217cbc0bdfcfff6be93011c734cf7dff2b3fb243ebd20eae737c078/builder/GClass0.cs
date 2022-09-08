#define DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace builder;

public class GClass0 : Panel
{
	private static List<WeakReference> list_0;

	private Timer timer_0;

	private Timer timer_1;

	private IContainer icontainer_0;

	private Bitmap bitmap_0;

	private short[,,] short_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private bool bool_0;

	private int int_3;

	private int int_4;

	private byte[] byte_0;

	private BitmapData bitmapData_0;

	private int int_5;

	private bool bool_1;

	public Bitmap ImageBitmap
	{
		get
		{
			return bitmap_0;
		}
		set
		{
			bitmap_0 = value;
			if (Information.IsNothing((object)bitmap_0))
			{
				timer_0.Stop();
				timer_1.Stop();
				return;
			}
			timer_0.Start();
			bool_1 = false;
			int_3 = ((Image)bitmap_0).get_Height();
			int_4 = ((Image)bitmap_0).get_Width();
			int_0 = int_4 >> int_5;
			int_1 = int_3 >> int_5;
			checked
			{
				short_0 = new short[int_0 - 1 + 1, int_1 - 1 + 1, 2];
				byte_0 = new byte[int_4 * int_3 * 4 - 1 + 1];
				Bitmap obj = bitmap_0;
				Rectangle rectangle = new Rectangle(0, 0, int_4, int_3);
				bitmapData_0 = obj.LockBits(rectangle, (ImageLockMode)3, (PixelFormat)2498570);
				Marshal.Copy(bitmapData_0.get_Scan0(), byte_0, 0, int_4 * int_3 * 4);
			}
		}
	}

	public int Scale
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
		}
	}

	[DebuggerNonUserCode]
	static GClass0()
	{
		Class14.hYiyYvszsKHjE();
		list_0 = new List<WeakReference>();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	private void method_0()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		((Control)this).add_Paint(new PaintEventHandler(WaterEffectControl_Paint));
		((Control)this).add_MouseMove(new MouseEventHandler(GClass0_MouseMove));
	}

	public GClass0()
	{
		Class14.hYiyYvszsKHjE();
		((Panel)this)._002Ector();
		smethod_0(this);
		int_2 = 0;
		method_0();
		timer_0.set_Enabled(true);
		timer_0.set_Interval(100);
		timer_1.set_Interval(1000);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)65536, true);
		((Control)this).set_BackColor(Color.Transparent);
		bool_0 = false;
		int_5 = 1;
	}

	public GClass0(Bitmap bmp)
	{
		Class14.hYiyYvszsKHjE();
		this._002Ector();
		ImageBitmap = bmp;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_0)
		{
			((Control)this).Invalidate();
			method_1();
		}
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		bool_1 = !bool_1;
	}

	public void WaterEffectControl_Paint(object sender, PaintEventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		Bitmap val = default(Bitmap);
		BitmapData val2 = default(BitmapData);
		byte[] array = default(byte[]);
		int num5 = default(int);
		int num6 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		int num14 = default(int);
		int num15 = default(int);
		byte b = default(byte);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					Bitmap obj;
					Rectangle rectangle;
					int num7;
					int num11;
					int num8;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						if (Information.IsNothing((object)bitmap_0))
						{
							goto end_IL_0001;
						}
						goto IL_0015;
					case 1378:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0001_2;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 3:
							case 4:
								goto IL_0015;
							case 5:
								goto IL_001a;
							case 6:
								goto IL_0023;
							case 7:
								goto IL_0037;
							case 8:
								goto IL_0044;
							case 9:
								goto IL_006c;
							case 10:
								goto IL_0088;
							case 11:
								goto IL_00a8;
							case 12:
								goto IL_00c3;
							case 13:
								goto IL_00de;
							case 14:
								goto IL_00ee;
							case 15:
								goto IL_00fe;
							case 16:
								goto IL_010e;
							case 19:
								goto IL_0119;
							case 22:
								goto IL_0124;
							case 23:
							case 24:
								goto IL_0131;
							case 25:
								goto IL_0145;
							case 26:
							case 27:
								goto IL_0152;
							case 28:
								goto IL_018a;
							case 29:
								goto IL_01c2;
							case 30:
								goto IL_01d8;
							case 31:
								goto IL_01ee;
							case 32:
							case 33:
								goto IL_01fd;
							case 34:
								goto IL_0213;
							case 35:
							case 36:
								goto IL_0222;
							case 37:
								goto IL_022e;
							case 38:
							case 39:
								goto IL_0236;
							case 40:
								goto IL_0242;
							case 41:
							case 42:
								goto IL_024a;
							case 43:
								goto IL_0257;
							case 44:
							case 45:
								goto IL_025d;
							case 46:
								goto IL_026b;
							case 47:
								goto IL_0275;
							case 48:
							case 49:
								goto IL_027b;
							case 50:
								goto IL_0289;
							case 51:
							case 52:
								goto IL_0293;
							case 53:
								goto IL_02bd;
							case 54:
								goto IL_02eb;
							case 55:
								goto IL_0319;
							case 56:
							case 57:
								goto IL_032e;
							case 17:
							case 18:
								goto IL_033a;
							case 58:
								goto IL_034c;
							case 60:
							case 61:
								goto IL_0361;
							case 20:
							case 21:
								goto IL_036d;
							case 59:
							case 62:
								goto IL_0389;
							case 63:
								goto IL_03a9;
							case 64:
							case 65:
								goto IL_03b5;
							case 66:
								goto IL_03e5;
							case 67:
								goto IL_03fa;
							case 68:
							case 69:
								goto IL_0416;
							case 70:
								goto end_IL_0001_3;
							default:
								goto end_IL_0001_2;
							case 2:
							case 71:
								goto end_IL_0001;
							}
							goto default;
						}
						IL_03e5:
						num = 66;
						if (Information.Err().get_Number() != 0)
						{
							goto IL_03fa;
						}
						goto IL_0416;
						IL_03b5:
						num = 65;
						e.get_Graphics().DrawImage((Image)(object)val, 0, 0, ((Control)this).get_ClientRectangle().Width, ((Control)this).get_ClientRectangle().Height);
						goto IL_03e5;
						IL_0015:
						num = 4;
						val = null;
						goto IL_001a;
						IL_001a:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0023;
						IL_0023:
						num = 6;
						val = (Bitmap)((Image)bitmap_0).Clone();
						goto IL_0037;
						IL_0037:
						num = 7;
						if (bool_0)
						{
							goto IL_0044;
						}
						goto IL_03b5;
						IL_0044:
						num = 8;
						obj = val;
						rectangle = new Rectangle(0, 0, int_4, int_3);
						val2 = obj.LockBits(rectangle, (ImageLockMode)3, (PixelFormat)2498570);
						goto IL_006c;
						IL_006c:
						num = 9;
						array = new byte[int_4 * int_3 * 4 - 1 + 1];
						goto IL_0088;
						IL_0088:
						num = 10;
						Marshal.Copy(val2.get_Scan0(), array, 0, int_4 * int_3 * 4);
						goto IL_00a8;
						IL_00a8:
						num = 11;
						num5 = int_4 - 2;
						num6 = 1;
						goto IL_00b7;
						IL_00b7:
						num7 = num6;
						num8 = num5;
						if (num7 <= num8)
						{
							goto IL_00c3;
						}
						goto IL_0389;
						IL_00c3:
						num = 12;
						num9 = int_3 - 2;
						num10 = 1;
						goto IL_00d2;
						IL_00d2:
						num11 = num10;
						num8 = num9;
						if (num11 <= num8)
						{
							goto IL_00de;
						}
						goto IL_034c;
						IL_00de:
						num = 13;
						num12 = num6 >> int_5;
						goto IL_00ee;
						IL_00ee:
						num = 14;
						num13 = num10 >> int_5;
						goto IL_00fe;
						IL_00fe:
						num = 15;
						if (num12 <= 0)
						{
							goto IL_010e;
						}
						goto IL_033a;
						IL_010e:
						num = 16;
						num12 = 1;
						goto IL_033a;
						IL_033a:
						num = 18;
						if (num13 <= 0)
						{
							goto IL_0119;
						}
						goto IL_036d;
						IL_0119:
						num = 19;
						num13 = 1;
						goto IL_036d;
						IL_036d:
						num = 21;
						if (num12 >= int_0 - 1)
						{
							goto IL_0124;
						}
						goto IL_0131;
						IL_0124:
						num = 22;
						num12 = int_0 - 2;
						goto IL_0131;
						IL_0131:
						num = 24;
						if (num13 >= int_1 - 1)
						{
							goto IL_0145;
						}
						goto IL_0152;
						IL_0145:
						num = 25;
						num13 = int_1 - 2;
						goto IL_0152;
						IL_0152:
						num = 27;
						num14 = unchecked((short)(checked((short)unchecked(short_0[checked(num12 - 1), num13, int_2] - short_0[checked(num12 + 1), num13, int_2])) >> 3));
						goto IL_018a;
						IL_018a:
						num = 28;
						num15 = unchecked((short)(checked((short)unchecked(short_0[num12, checked(num13 - 1), int_2] - short_0[num12, checked(num13 + 1), int_2])) >> 3));
						goto IL_01c2;
						IL_01c2:
						num = 29;
						if ((num14 != 0 || num15 != 0) ? true : false)
						{
							goto IL_01d8;
						}
						goto IL_032e;
						IL_0416:
						num = 69;
						if (Information.IsNothing((object)val))
						{
							goto end_IL_0001;
						}
						break;
						IL_03fa:
						num = 67;
						Debug.WriteLine("WaterEffectControl_Paint: " + Information.Err().get_Description());
						goto IL_0416;
						IL_01d8:
						num = 30;
						if (num6 + num14 >= int_4 - 1)
						{
							goto IL_01ee;
						}
						goto IL_01fd;
						IL_01ee:
						num = 31;
						num14 = int_4 - num6 - 1;
						goto IL_01fd;
						IL_01fd:
						num = 33;
						if (num10 + num15 >= int_3 - 1)
						{
							goto IL_0213;
						}
						goto IL_0222;
						IL_0213:
						num = 34;
						num15 = int_3 - num10 - 1;
						goto IL_0222;
						IL_0222:
						num = 36;
						if (num6 + num14 < 0)
						{
							goto IL_022e;
						}
						goto IL_0236;
						IL_022e:
						num = 37;
						num14 = -num6;
						goto IL_0236;
						IL_0236:
						num = 39;
						if (num10 + num15 < 0)
						{
							goto IL_0242;
						}
						goto IL_024a;
						IL_0242:
						num = 40;
						num15 = -num10;
						goto IL_024a;
						IL_024a:
						num = 42;
						if (num14 <= 0)
						{
							goto IL_0257;
						}
						goto IL_025d;
						IL_0257:
						num = 43;
						num14 = 0;
						goto IL_025d;
						IL_025d:
						num = 45;
						b = (byte)(200 - num14);
						goto IL_026b;
						IL_026b:
						num = 46;
						if (b < 0)
						{
							goto IL_0275;
						}
						goto IL_027b;
						IL_0275:
						num = 47;
						b = 0;
						goto IL_027b;
						IL_027b:
						num = 49;
						if (b > byte.MaxValue)
						{
							goto IL_0289;
						}
						goto IL_0293;
						IL_0289:
						num = 50;
						b = 254;
						goto IL_0293;
						IL_0293:
						num = 52;
						array[4 * (num6 + num10 * int_4)] = byte_0[4 * (num6 + num14 + (num10 + num15) * int_4)];
						goto IL_02bd;
						IL_02bd:
						num = 53;
						array[4 * (num6 + num10 * int_4) + 1] = byte_0[4 * (num6 + num14 + (num10 + num15) * int_4) + 1];
						goto IL_02eb;
						IL_02eb:
						num = 54;
						array[4 * (num6 + num10 * int_4) + 2] = byte_0[4 * (num6 + num14 + (num10 + num15) * int_4) + 2];
						goto IL_0319;
						IL_0319:
						num = 55;
						array[4 * (num6 + num10 * int_4) + 3] = b;
						goto IL_032e;
						IL_032e:
						num = 57;
						num10++;
						goto IL_00d2;
						IL_034c:
						num = 58;
						if (Information.Err().get_Number() == 0)
						{
							goto IL_0361;
						}
						goto IL_0389;
						IL_0361:
						num = 61;
						num6++;
						goto IL_00b7;
						IL_0389:
						num = 62;
						Marshal.Copy(array, 0, val2.get_Scan0(), int_4 * int_3 * 4);
						goto IL_03a9;
						IL_03a9:
						num = 63;
						val.UnlockBits(val2);
						goto IL_03b5;
						end_IL_0001_3:
						break;
					}
					num = 70;
					((Image)val).Dispose();
					break;
				}
				end_IL_0001_2:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 1378;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_1()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num6 = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
		int num8 = default(int);
		int num11 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int num9;
					int num12;
					int num10;
					short[,,] array;
					int num13;
					int num14;
					int num15;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						num6 = ((int_2 == 0) ? 1 : 0);
						goto IL_0011;
					case 652:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0001;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0011;
							case 3:
								goto IL_0015;
							case 4:
								goto IL_001d;
							case 5:
							case 6:
								goto IL_0021;
							case 7:
								goto IL_002a;
							case 8:
								goto IL_0046;
							case 9:
								goto IL_0062;
							case 10:
								goto IL_0158;
							case 11:
								goto IL_0173;
							case 12:
								goto IL_01b8;
							case 13:
							case 14:
								goto IL_01bd;
							case 15:
							case 18:
								goto IL_01d2;
							case 20:
							case 21:
								goto IL_01e7;
							case 16:
							case 17:
								goto IL_01f5;
							case 19:
							case 22:
								goto IL_0203;
							case 23:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 24:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_01f5:
						num = 17;
						num5++;
						goto IL_0055;
						IL_01bd:
						num = 14;
						if (Information.Err().get_Number() != 0)
						{
							goto IL_01d2;
						}
						goto IL_01f5;
						IL_01e7:
						num = 21;
						num7++;
						goto IL_0039;
						IL_0203:
						num = 22;
						bool_0 = flag;
						break;
						IL_01d2:
						num = 18;
						if (Information.Err().get_Number() == 0)
						{
							goto IL_01e7;
						}
						goto IL_0203;
						IL_0011:
						num = 2;
						flag = false;
						goto IL_0015;
						IL_0015:
						num = 3;
						if (num6 < 0)
						{
							goto IL_001d;
						}
						goto IL_0021;
						IL_001d:
						num = 4;
						num6 = 1;
						goto IL_0021;
						IL_0021:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_002a;
						IL_002a:
						num = 7;
						num8 = int_0 - 2;
						num7 = 1;
						goto IL_0039;
						IL_0039:
						num9 = num7;
						num10 = num8;
						if (num9 <= num10)
						{
							goto IL_0046;
						}
						goto IL_0203;
						IL_0046:
						num = 8;
						num11 = int_1 - 2;
						num5 = 1;
						goto IL_0055;
						IL_0055:
						num12 = num5;
						num10 = num11;
						if (num12 <= num10)
						{
							goto IL_0062;
						}
						goto IL_01d2;
						IL_0062:
						num = 9;
						short_0[num7, num5, num6] = (short)unchecked((short)(checked((short)unchecked(checked((short)unchecked(checked((short)unchecked(checked((short)unchecked(checked((short)unchecked(checked((short)unchecked(checked((short)unchecked(checked(short_0[num7 - 1, num5 - 1, int_2]) + short_0[num7, checked(num5 - 1), int_2])) + checked(short_0[num7 + 1, num5 - 1, int_2]))) + short_0[checked(num7 - 1), num5, int_2])) + short_0[checked(num7 + 1), num5, int_2])) + checked(short_0[num7 - 1, num5 + 1, int_2]))) + short_0[num7, checked(num5 + 1), int_2])) + checked(short_0[num7 + 1, num5 + 1, int_2]))) >> 2) - short_0[num7, num5, num6]);
						goto IL_0158;
						IL_0158:
						num = 10;
						if (short_0[num7, num5, num6] != 0)
						{
							goto IL_0173;
						}
						goto IL_01bd;
						IL_0173:
						num = 11;
						array = short_0;
						num13 = num7;
						num14 = num5;
						num15 = num6;
						array[num13, num14, num15] = (short)unchecked(array[num13, num14, num15] - (short)(short_0[num7, num5, num6] >> 4));
						goto IL_01b8;
						IL_01b8:
						num = 12;
						flag = true;
						goto IL_01bd;
						end_IL_0001_2:
						break;
					}
					num = 23;
					int_2 = num6;
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 652;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_2(int int_6, int int_7, short short_1)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		double num7 = default(double);
		int num8 = default(int);
		int num10 = default(int);
		int num14 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int num9;
					int num11;
					int num13;
					int num15;
					int num12;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						bool_0 = true;
						goto IL_000a;
					case 287:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								default:
									goto end_IL_0001;
								case 1:
									break;
								case 0:
									goto end_IL_0001;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000a;
							case 3:
								goto IL_000f;
							case 4:
								goto IL_0018;
							case 5:
								goto IL_002d;
							case 6:
								goto IL_0042;
							case 7:
								goto IL_0073;
							case 8:
								goto IL_0084;
							case 9:
								goto IL_008e;
							case 14:
							case 15:
								goto IL_00c7;
							case 16:
								goto IL_00d3;
							case 18:
							case 19:
								goto IL_00e8;
							case 10:
							case 11:
							case 12:
								goto IL_00f4;
							default:
								goto end_IL_0001;
							case 0:
								goto end_IL_0001;
							case 13:
							case 17:
							case 20:
								goto end_IL_0001_2;
							}
							goto default;
						}
						IL_008e:
						num = 9;
						short_0[int_6 + num5, int_7 + num6, int_2] = (short)Math.Round(Math.Cos(num7 * Math.PI / (double)num8) * (double)short_1);
						goto IL_00f4;
						IL_0084:
						num = 8;
						if (num7 < (double)num8)
						{
							goto IL_008e;
						}
						goto IL_00f4;
						IL_000a:
						num = 2;
						num8 = 20;
						goto IL_000f;
						IL_000f:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0018;
						IL_0018:
						num = 4;
						num9 = -num8;
						num10 = num8;
						num5 = num9;
						goto IL_0021;
						IL_0021:
						num11 = num5;
						num12 = num10;
						if (num11 > num12)
						{
							goto end_IL_0001_2;
						}
						goto IL_002d;
						IL_002d:
						num = 5;
						num13 = -num8;
						num14 = num8;
						num6 = num13;
						goto IL_0036;
						IL_0036:
						num15 = num6;
						num12 = num14;
						if (num15 <= num12)
						{
							goto IL_0042;
						}
						goto IL_00d3;
						IL_0042:
						num = 6;
						if ((int_6 + num5 >= 0 && int_6 + num5 < int_0 - 1 && int_7 + num6 >= 0 && int_7 + num6 < int_1 - 1) ? true : false)
						{
							goto IL_0073;
						}
						goto IL_00f4;
						IL_00c7:
						num = 15;
						num6++;
						goto IL_0036;
						IL_00d3:
						num = 16;
						if (Information.Err().get_Number() != 0)
						{
							goto end_IL_0001_2;
						}
						goto IL_00e8;
						IL_00e8:
						num = 19;
						num5++;
						goto IL_0021;
						IL_00f4:
						num = 12;
						if (Information.Err().get_Number() != 0)
						{
							goto end_IL_0001_2;
						}
						goto IL_00c7;
						IL_0073:
						num = 7;
						num7 = Math.Sqrt(num5 * num5 + num6 * num6);
						goto IL_0084;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 287;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void GClass0_MouseMove(object sender, MouseEventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int int_ = default(int);
		int int_2 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 248:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0016;
						case 4:
							goto IL_003e;
						case 5:
							goto IL_0067;
						case 7:
						case 8:
							goto IL_0080;
						case 9:
						case 10:
							goto IL_0090;
						case 11:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
						case 12:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0090:
					num = 10;
					if (timer_1.get_Enabled())
					{
						goto end_IL_0001_3;
					}
					break;
					IL_0080:
					num = 8;
					method_2(int_, int_2, 200);
					goto IL_0090;
					IL_0009:
					num = 2;
					if (!bool_1)
					{
						goto IL_0016;
					}
					goto IL_0090;
					IL_0016:
					num = 3;
					int_ = checked((int)Math.Round((double)e.get_X() / (double)((Control)this).get_ClientRectangle().Width * (double)int_0));
					goto IL_003e;
					IL_003e:
					num = 4;
					int_2 = checked((int)Math.Round((double)e.get_Y() / (double)((Control)this).get_ClientRectangle().Height * (double)int_1));
					goto IL_0067;
					IL_0067:
					num = 5;
					if (Information.Err().get_Number() != 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0080;
					end_IL_0001_2:
					break;
				}
				num = 11;
				timer_1.Start();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 248;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
