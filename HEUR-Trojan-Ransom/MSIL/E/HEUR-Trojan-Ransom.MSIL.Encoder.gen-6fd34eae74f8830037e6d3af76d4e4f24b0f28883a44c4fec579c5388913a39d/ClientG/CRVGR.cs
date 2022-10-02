using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClientG.My;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class CRVGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("VName")]
	private TextBox _VName;

	[AccessedThroughProperty("ValueData")]
	private TextBox _ValueData;

	[AccessedThroughProperty("Create")]
	private Button _Create;

	public string CG;

	public bool D;

	public string P;

	public int Sock;

	public int V;

	internal virtual TextBox VName
	{
		[DebuggerNonUserCode]
		get
		{
			return _VName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_VName = value;
		}
	}

	internal virtual TextBox ValueData
	{
		[DebuggerNonUserCode]
		get
		{
			return _ValueData;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ValueData = value;
		}
	}

	internal virtual Button Create
	{
		[DebuggerNonUserCode]
		get
		{
			return _Create;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Create_Click;
			if (_Create != null)
			{
				((Control)_Create).remove_Click(eventHandler);
			}
			_Create = value;
			if (_Create != null)
			{
				((Control)_Create).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public CRVGR()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CRVGR));
		VName = new TextBox();
		ValueData = new TextBox();
		Create = new Button();
		((Control)this).SuspendLayout();
		((Control)VName).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox vName = VName;
		Point location = new Point(12, 12);
		((Control)vName).set_Location(location);
		((Control)VName).set_Name("VName");
		TextBox vName2 = VName;
		Size size = new Size(335, 21);
		((Control)vName2).set_Size(size);
		((Control)VName).set_TabIndex(0);
		VName.set_Text("Value Name");
		((Control)ValueData).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox valueData = ValueData;
		location = new Point(12, 38);
		((Control)valueData).set_Location(location);
		ValueData.set_Multiline(true);
		((Control)ValueData).set_Name("ValueData");
		TextBox valueData2 = ValueData;
		size = new Size(335, 190);
		((Control)valueData2).set_Size(size);
		((Control)ValueData).set_TabIndex(1);
		ValueData.set_Text("Value Data");
		((Control)Create).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button create = Create;
		location = new Point(41, 234);
		((Control)create).set_Location(location);
		((Control)Create).set_Name("Create");
		Button create2 = Create;
		size = new Size(276, 23);
		((Control)create2).set_Size(size);
		((Control)Create).set_TabIndex(2);
		((ButtonBase)Create).set_Text("Create");
		((ButtonBase)Create).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(359, 263);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Create);
		((Control)this).get_Controls().Add((Control)(object)ValueData);
		((Control)this).get_Controls().Add((Control)(object)VName);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Rve");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Rve");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Create_Click(object sender, EventArgs e)
	{
		if ((VName.get_Text().Length > 0 && ValueData.get_Text().Length > 0) ? true : false)
		{
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "Create Value" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(P) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(VName.get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(ValueData.get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(V.ToString()) + MyProject.Forms.FrmMAINGR.Key + CG.ToString() + MyProject.Forms.FrmMAINGR.Key + D);
			((Form)this).Close();
		}
	}
}
