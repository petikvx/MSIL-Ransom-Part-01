using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace wbem.Adapter;

public sealed class AuthenticationListAdapter : Form
{
	private IContainer m_Resolver = null;

	private ListView _Wrapper;

	private static AuthenticationListAdapter ConcatParams;

	public AuthenticationListAdapter()
	{
		int num = 0;
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_fc59391cc97e4620b7f6adc650bef318 == 0)
		{
			goto IL_002f;
		}
		goto IL_0037;
		IL_0037:
		switch (num)
		{
		case 2:
			break;
		default:
			goto IL_002f;
		case 1:
		case 3:
			return;
		}
		goto IL_0016;
		IL_002f:
		((Form)this)._002Ector();
		goto IL_0016;
		IL_0016:
		FindDispatcher();
		num = 1;
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_8481cfab94b74a1a93e697169ce0cea6 != 0)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0037;
	}

	protected override void Dispose(bool vinstall)
	{
		int num = 2;
		bool flag = default(bool);
		while (true)
		{
			IL_0093:
			int num2;
			if (!vinstall)
			{
				num2 = 0;
				goto IL_0073;
			}
			int num3 = 1;
			if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_7ab9bbc6588b4754b6dbc46353a9f994 == 0)
			{
				goto IL_0047;
			}
			goto IL_006a;
			IL_006a:
			num2 = ((m_Resolver != null) ? 1 : 0);
			goto IL_0073;
			IL_0043:
			num3 = num;
			goto IL_0047;
			IL_0073:
			flag = (byte)num2 != 0;
			num3 = 6;
			if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_09075e79a1424f8e9dff57b33194cdd6 == 0)
			{
				goto IL_0043;
			}
			goto IL_0047;
			IL_0047:
			while (true)
			{
				switch (num3)
				{
				case 5:
				case 6:
					break;
				default:
					goto IL_002f;
				case 1:
					goto end_IL_0047;
				case 2:
					goto IL_0093;
				case 3:
				case 4:
					return;
				}
				if (!flag)
				{
					goto IL_002f;
				}
				SelectParams(m_Resolver);
				num3 = 0;
				if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_903bf18fc4a64c46a25a654ede57ce0d != 0)
				{
					continue;
				}
				goto IL_0043;
				IL_002f:
				((Form)this).Dispose(vinstall);
				num3 = 3;
				if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_9cfc66b1caa441288b44bd0b9bc9eef4 != 0)
				{
					continue;
				}
				goto IL_0043;
				continue;
				end_IL_0047:
				break;
			}
			goto IL_006a;
		}
	}

	private void FindDispatcher()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_Wrapper = new ListView();
		int num2 = default(int);
		while (true)
		{
			((Control)this).SuspendLayout();
			while (true)
			{
				MoveParams(_Wrapper, (DockStyle)5);
				while (true)
				{
					LogoutParams(_Wrapper, bool_0: false);
					while (true)
					{
						((Control)_Wrapper).set_Location(new Point(0, 0));
						((Control)_Wrapper).set_Name("listView1");
						CustomizeParams(_Wrapper, new Size(800, 450));
						RunParams(_Wrapper, 1);
						int num = 1;
						if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_6e77e7bcef6a43eda5caedcd2c992332 != 0)
						{
							goto IL_0072;
						}
						goto IL_0080;
						IL_0080:
						switch (num)
						{
						case 8:
							break;
						case 1:
							goto IL_004e;
						case 3:
							goto IL_0072;
						case 4:
							continue;
						case 12:
							goto end_IL_00be;
						case 9:
						case 10:
							goto end_IL_011b;
						case 5:
							goto end_IL_0129;
						default:
							ResolveParams(this, "Form2");
							goto case 6;
						case 6:
							ReadParams(this, "Form2");
							goto case 2;
						case 2:
							((Control)this).ResumeLayout(false);
							return;
						case 7:
						case 11:
							return;
						}
						goto IL_0010;
						IL_0072:
						DisableParams(_Wrapper, bool_0: false);
						goto IL_0010;
						IL_0010:
						((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
						InterruptParams(this, (AutoScaleMode)1);
						((Form)this).set_ClientSize(new Size(800, 450));
						num = 1;
						if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_e265c4fd835f48ae81fdf16bb06d89a0 != 0)
						{
							goto IL_004e;
						}
						goto IL_0080;
						IL_004e:
						InstantiateParams(SetParams(this), _Wrapper);
						num = 0;
						if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_3d9a56cac72b40d5b5047767ef8f931a != 0)
						{
							num = num2;
						}
						goto IL_0080;
						continue;
						end_IL_00be:
						break;
					}
					continue;
					end_IL_011b:
					break;
				}
				continue;
				end_IL_0129:
				break;
			}
		}
	}

	internal static bool ResetParams()
	{
		return ConcatParams == null;
	}

	internal static AuthenticationListAdapter VisitParams()
	{
		return ConcatParams;
	}

	internal static void SelectParams(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static void MoveParams(object object_0, DockStyle dockStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Dock(dockStyle_0);
	}

	internal static void LogoutParams(object object_0, bool bool_0)
	{
		((ListView)object_0).set_HideSelection(bool_0);
	}

	internal static void CustomizeParams(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void RunParams(object object_0, int int_0)
	{
		((Control)object_0).set_TabIndex(int_0);
	}

	internal static void DisableParams(object object_0, bool bool_0)
	{
		((ListView)object_0).set_UseCompatibleStateImageBehavior(bool_0);
	}

	internal static void InterruptParams(object object_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)object_0).set_AutoScaleMode(autoScaleMode_0);
	}

	internal static object SetParams(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static void InstantiateParams(object object_0, object object_1)
	{
		((ControlCollection)object_0).Add((Control)object_1);
	}

	internal static void ResolveParams(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void ReadParams(object object_0, object object_1)
	{
		((Control)object_0).set_Text((string)object_1);
	}
}
