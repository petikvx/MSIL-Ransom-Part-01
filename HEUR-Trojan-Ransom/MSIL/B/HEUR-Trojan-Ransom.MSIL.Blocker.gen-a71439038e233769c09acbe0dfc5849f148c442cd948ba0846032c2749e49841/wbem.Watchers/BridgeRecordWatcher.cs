using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Ckytkvxxwmxrnwi.Bridges;

namespace wbem.Watchers;

public sealed class BridgeRecordWatcher : Form
{
	private IContainer map = null;

	private ListView _System;

	private static BridgeRecordWatcher InitParams;

	public BridgeRecordWatcher()
	{
		int num = 2;
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_4041a133a42b40928c0a2b76d8800ae4 == 0)
		{
			goto IL_001a;
		}
		goto IL_0031;
		IL_0031:
		switch (num)
		{
		case 3:
			break;
		default:
			return;
		}
		goto IL_001a;
		IL_001a:
		CalcDispatcher();
		num = 0;
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_0b7687d61da04188aec99bd69e269ccd != 0)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0031;
	}

	private void AwakeDispatcher(object sender, EventArgs e)
	{
		Ckytkvxxwmxrnwi.Bridges.Importer<string> importer = new Ckytkvxxwmxrnwi.Bridges.Importer<string>();
		importer.StopDispatcher("Clean Code");
	}

	protected override void Dispose(bool isv)
	{
		bool flag = isv && map != null;
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_7f3369fcf947428e979cc59d474e486a == 0)
		{
			switch (0)
			{
			case 2:
				goto IL_0045;
			case 5:
			case 6:
				goto IL_0050;
			case 1:
			case 3:
				return;
			}
		}
		if (flag)
		{
			goto IL_0045;
		}
		goto IL_0050;
		IL_0050:
		TestParams(this, isv);
		return;
		IL_0045:
		CompareParams(map);
		goto IL_0050;
	}

	private void CalcDispatcher()
	{
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		int num = 2;
		while (true)
		{
			_System = new ListView();
			int num2 = 8;
			if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_f6172064568f46208a012767db60071b == 0)
			{
				goto IL_00ac;
			}
			goto IL_010f;
			IL_010f:
			while (true)
			{
				switch (num2)
				{
				case 14:
					_System.set_HideSelection(false);
					PrintParams(_System, new Point(0, 0));
					goto case 3;
				case 3:
					PatchParams(_System, "listView1");
					((Control)_System).set_Size(new Size(824, 451));
					PopParams(_System, 1);
					goto case 4;
				case 4:
					_System.set_UseCompatibleStateImageBehavior(false);
					goto case 10;
				case 10:
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
					goto default;
				default:
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					((Form)this).set_ClientSize(new Size(824, 451));
					num2 = 13;
					if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_e8d4f466afeb4b2ca513a2b713c6a7fb != 0)
					{
						continue;
					}
					goto IL_00ac;
				case 13:
					((Control)this).get_Controls().Add((Control)(object)_System);
					num2 = 12;
					if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_7f3369fcf947428e979cc59d474e486a != 0)
					{
						continue;
					}
					goto IL_00ac;
				case 12:
					DefineParams(this, "Form1");
					num2 = 7;
					if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_0b170bb8d66641e887585bec843e55d8 == 0)
					{
						continue;
					}
					goto IL_00ac;
				case 6:
				case 11:
					DeleteParams(_System, (DockStyle)5);
					num2 = 14;
					if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_7f3369fcf947428e979cc59d474e486a != 0)
					{
						continue;
					}
					goto IL_00ac;
				case 1:
				case 8:
					((Control)this).SuspendLayout();
					goto case 6;
				case 2:
					break;
				case 7:
					CreateParams(this, "Form1");
					((Form)this).add_Load((EventHandler)AwakeDispatcher);
					NewParams(this, bool_0: false);
					return;
				case 5:
					return;
				}
				break;
			}
			continue;
			IL_00ac:
			num2 = num;
			goto IL_010f;
		}
	}

	internal static bool PostParams()
	{
		return InitParams == null;
	}

	internal static BridgeRecordWatcher RegisterParams()
	{
		return InitParams;
	}

	internal static void CompareParams(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static void TestParams(object object_0, bool bool_0)
	{
		((Form)object_0).Dispose(bool_0);
	}

	internal static void DeleteParams(object object_0, DockStyle dockStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Dock(dockStyle_0);
	}

	internal static void PrintParams(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static void PatchParams(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void PopParams(object object_0, int int_0)
	{
		((Control)object_0).set_TabIndex(int_0);
	}

	internal static void DefineParams(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void CreateParams(object object_0, object object_1)
	{
		((Control)object_0).set_Text((string)object_1);
	}

	internal static void NewParams(object object_0, bool bool_0)
	{
		((Control)object_0).ResumeLayout(bool_0);
	}
}
