using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PointBlank.Launcher;

public class AntiHack : Form
{
	private IContainer _ZxAbWPOeuBqLkbv0v0TsfEpIn4bA;

	public AntiHack()
	{
		_QeLc76eWmkdedtAuJ38IUOaf8ZrA();
	}

	private void _WmEfeZTahXpfCYjOMF6hkXFZ9Tz(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		string text = AntiHack.smethod_2(AntiHack.smethod_1(AntiHack.smethod_0(Registry.CurrentUser, _003CModule_003E.smethod_4<string>(346423978u), bool_0: true), _003CModule_003E.smethod_5<string>(1129496492u), (object)true));
		if (text == null && AntiHack.smethod_3(text, _003CModule_003E.smethod_1<string>(414366168u)) && AntiHack.smethod_4(text) != 24)
		{
			AntiHack.smethod_5(_003CModule_003E.smethod_5<string>(2443387478u));
			AntiHack.smethod_6(1);
		}
		if (AntiHack.smethod_9(AntiHack.smethod_8(AntiHack.smethod_7(), _003CModule_003E.smethod_1<string>(3960113113u))))
		{
			_qWrzrG4SS0PoyPCUvq8Xod6GXNB(_003CModule_003E.smethod_2<string>(3388790755u));
			return;
		}
		AntiHack.smethod_5(_003CModule_003E.smethod_2<string>(2883919925u));
		AntiHack.smethod_6(1);
	}

	private void _qWrzrG4SS0PoyPCUvq8Xod6GXNB(string GuardKey)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		if (AntiHack.smethod_9(_003CModule_003E.smethod_1<string>(3920042151u)))
		{
			AntiHack.smethod_10();
			if (AntiHack.smethod_11(_003CModule_003E.smethod_3<string>(1941520859u)).Length < 1)
			{
				AntiHack.smethod_13(AntiHack.smethod_8(AntiHack.smethod_7(), _003CModule_003E.smethod_1<string>(2673204435u)), GuardKey);
				AntiHack.smethod_14((Form)(object)this);
				AntiHack.smethod_15();
			}
			else
			{
				AntiHack.smethod_12(_003CModule_003E.smethod_3<string>(1887373959u), _003CModule_003E.smethod_3<string>(2541477308u), (MessageBoxButtons)0, (MessageBoxIcon)48);
				AntiHack.smethod_6(1);
			}
		}
		else
		{
			AntiHack.smethod_12(_003CModule_003E.smethod_3<string>(3691583855u), _003CModule_003E.smethod_2<string>(3228802786u), (MessageBoxButtons)0, (MessageBoxIcon)16);
			AntiHack.smethod_6(1);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && _ZxAbWPOeuBqLkbv0v0TsfEpIn4bA != null)
		{
			AntiHack.smethod_16((IDisposable)_ZxAbWPOeuBqLkbv0v0TsfEpIn4bA);
		}
		((Form)this).Dispose(disposing);
	}

	private void _QeLc76eWmkdedtAuJ38IUOaf8ZrA()
	{
		AntiHack.smethod_17((Control)(object)this);
		AntiHack.smethod_18((ContainerControl)(object)this, new SizeF(6f, 13f));
		AntiHack.smethod_19((ContainerControl)(object)this, (AutoScaleMode)1);
		AntiHack.smethod_20((Form)(object)this, new Size(800, 450));
		AntiHack.smethod_21((Control)(object)this, _003CModule_003E.smethod_1<string>(1964055046u));
		AntiHack.smethod_22((Control)(object)this, _003CModule_003E.smethod_3<string>(1625320557u));
		AntiHack.smethod_23((Form)(object)this, (EventHandler)_WmEfeZTahXpfCYjOMF6hkXFZ9Tz);
		AntiHack.smethod_24((Control)(object)this, bool_0: false);
	}

	static RegistryKey smethod_0(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		return registryKey_0.OpenSubKey(string_0, bool_0);
	}

	static object smethod_1(RegistryKey registryKey_0, string string_0, object object_0)
	{
		return registryKey_0.GetValue(string_0, object_0);
	}

	static string smethod_2(object object_0)
	{
		return object_0.ToString();
	}

	static bool smethod_3(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static int smethod_4(string string_0)
	{
		return string_0.Length;
	}

	static DialogResult smethod_5(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static void smethod_6(int int_0)
	{
		Environment.Exit(int_0);
	}

	static string smethod_7()
	{
		return Application.get_StartupPath();
	}

	static string smethod_8(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static bool smethod_9(string string_0)
	{
		return File.Exists(string_0);
	}

	static Process[] smethod_10()
	{
		return Process.GetProcesses();
	}

	static Process[] smethod_11(string string_0)
	{
		return Process.GetProcessesByName(string_0);
	}

	static DialogResult smethod_12(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	static Process smethod_13(string string_0, string string_1)
	{
		return Process.Start(string_0, string_1);
	}

	static void smethod_14(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_15()
	{
		Application.Exit();
	}

	static void smethod_16(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static void smethod_17(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_18(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_19(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_20(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static void smethod_21(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_22(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_23(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_24(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
