using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace wbem.Records;

public sealed class InterpreterProccesorRecord : Form
{
	private IContainer m_Record = null;

	private ListView m_Facade;

	internal static InterpreterProccesorRecord CallParams;

	public InterpreterProccesorRecord()
	{
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_aedbac609e9e4164a9b13f5f565d8b87 == 0)
		{
			switch (0)
			{
			default:
				return;
			case 1:
				break;
			case 2:
				goto IL_0033;
			case 0:
			case 3:
				return;
			}
		}
		((Form)this)._002Ector();
		goto IL_0033;
		IL_0033:
		CloneDispatcher();
	}

	protected override void Dispose(bool iskey)
	{
		int num = 8;
		bool flag = default(bool);
		while (true)
		{
			IL_0086:
			int num2;
			if (!iskey)
			{
				num2 = 7;
				if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_92478394bb9c41d3bd2f207ed01d6329 != 0)
				{
					goto IL_0023;
				}
				goto IL_002f;
			}
			goto IL_006c;
			IL_0023:
			num2 = num;
			goto IL_002f;
			IL_006c:
			int num3 = ((m_Record != null) ? 1 : 0);
			goto IL_005b;
			IL_005b:
			flag = (byte)num3 != 0;
			num2 = 1;
			if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_e265c4fd835f48ae81fdf16bb06d89a0 == 0)
			{
				goto IL_0023;
			}
			goto IL_002f;
			IL_002f:
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 6:
					break;
				case 1:
				case 4:
					if (flag)
					{
						break;
					}
					num = 2;
					goto case 2;
				case 7:
					goto end_IL_002f;
				default:
					goto IL_006c;
				case 8:
					goto IL_0086;
				case 2:
				case 5:
					IncludeParams(this, iskey);
					return;
				}
				m_Record.Dispose();
				num2 = 5;
				if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_9e634a12d2fd4981a9276d3d5702cbf6 == 0)
				{
					continue;
				}
				goto IL_0023;
				continue;
				end_IL_002f:
				break;
			}
			num3 = 0;
			goto IL_005b;
		}
	}

	private void CloneDispatcher()
	{
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		int num = 9;
		while (true)
		{
			m_Facade = new ListView();
			int num2 = 1;
			if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_23dafc5344be4bbf820b3ea3b2287c82 != 0)
			{
				goto IL_00b4;
			}
			goto IL_0143;
			IL_0143:
			while (true)
			{
				switch (num2)
				{
				default:
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					PushParams(this, new Size(800, 450));
					QueryParams(CheckParams(this), m_Facade);
					ListParams(this, "Form3");
					((Control)this).set_Text("Form3");
					PublishParams(this, bool_0: false);
					num2 = 0;
					if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_09075e79a1424f8e9dff57b33194cdd6 == 0)
					{
						continue;
					}
					return;
				case 12:
					m_Facade.set_UseCompatibleStateImageBehavior(false);
					goto case 7;
				case 7:
					AwakeParams(this, new SizeF(6f, 13f));
					goto default;
				case 11:
					((Control)m_Facade).set_Location(new Point(0, 0));
					num2 = 4;
					if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_7ab9bbc6588b4754b6dbc46353a9f994 != 0)
					{
						continue;
					}
					goto IL_00b4;
				case 10:
					((Control)m_Facade).set_Dock((DockStyle)5);
					num2 = 2;
					if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_b955f4dec0fe4b4ca0ef1af1eaa51526 == 0)
					{
						continue;
					}
					goto case 3;
				case 3:
					m_Facade.set_HideSelection(false);
					goto case 11;
				case 1:
				case 8:
					((Control)this).SuspendLayout();
					goto case 10;
				case 6:
					((Control)m_Facade).set_Size(new Size(800, 450));
					ReflectParams(m_Facade, 0);
					num2 = 12;
					if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_21e4ef83ec8b4a109ae4873ffe19ee8e != 0)
					{
						continue;
					}
					goto IL_00b4;
				case 4:
					ChangeParams(m_Facade, "listView1");
					num2 = 6;
					if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_f8bcafac74c141b8bcd80b4356e3abd9 == 0)
					{
						continue;
					}
					goto default;
				case 9:
					break;
				case 2:
				case 5:
					return;
				}
				break;
			}
			continue;
			IL_00b4:
			num2 = num;
			goto IL_0143;
		}
	}

	internal static bool ConnectParams()
	{
		return CallParams == null;
	}

	internal static InterpreterProccesorRecord StartParams()
	{
		return CallParams;
	}

	internal static void IncludeParams(object object_0, bool bool_0)
	{
		((Form)object_0).Dispose(bool_0);
	}

	internal static void ChangeParams(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void ReflectParams(object object_0, int int_0)
	{
		((Control)object_0).set_TabIndex(int_0);
	}

	internal static void PushParams(object object_0, Size size_0)
	{
		((Form)object_0).set_ClientSize(size_0);
	}

	internal static object CheckParams(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static void QueryParams(object object_0, object object_1)
	{
		((ControlCollection)object_0).Add((Control)object_1);
	}

	internal static void ListParams(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void PublishParams(object object_0, bool bool_0)
	{
		((Control)object_0).ResumeLayout(bool_0);
	}

	internal static void AwakeParams(object object_0, SizeF sizeF_0)
	{
		((ContainerControl)object_0).set_AutoScaleDimensions(sizeF_0);
	}
}
