using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Co02;
using Mb5q;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Nr2m;
using Nt1m;
using Re2r;
using Rk0g;
using Rp8;
using e8Z;
using y0D5;
using y5P;

namespace Bi7;

[DesignerGenerated]
public sealed class Ht2 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("TableLayoutPanel")]
	internal virtual TableLayoutPanel TableLayoutPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LogoPictureBox")]
	internal virtual PictureBox LogoPictureBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LabelProductName")]
	internal virtual Label LabelProductName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LabelVersion")]
	internal virtual Label LabelVersion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LabelCompanyName")]
	internal virtual Label LabelCompanyName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBoxDescription")]
	internal virtual TextBox TextBoxDescription
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OKButton
	{
		[CompilerGenerated]
		get
		{
			return _OKButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Bn0;
			Button oKButton = _OKButton;
			if (oKButton != null)
			{
				((Control)oKButton).remove_Click(eventHandler);
			}
			_OKButton = value;
			oKButton = _OKButton;
			if (oKButton != null)
			{
				((Control)oKButton).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("LabelCopyright")]
	internal virtual Label LabelCopyright
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Ht2()
	{
		((Form)this).add_Load((EventHandler)Am9);
		z7K();
	}

	[DebuggerNonUserCode]
	protected override void Fd4(bool g3Q)
	{
		try
		{
			if (g3Q && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(g3Q);
		}
	}

	[DebuggerStepThrough]
	private void z7K()
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ht2));
		TableLayoutPanel = new TableLayoutPanel();
		LogoPictureBox = new PictureBox();
		LabelProductName = new Label();
		LabelVersion = new Label();
		LabelCopyright = new Label();
		LabelCompanyName = new Label();
		TextBoxDescription = new TextBox();
		OKButton = new Button();
		((Control)TableLayoutPanel).SuspendLayout();
		((ISupportInitialize)LogoPictureBox).BeginInit();
		((Control)this).SuspendLayout();
		TableLayoutPanel.set_ColumnCount(2);
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 48.96552f));
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 51.03448f));
		TableLayoutPanel.get_Controls().Add((Control)(object)LogoPictureBox, 0, 0);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelProductName, 1, 0);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelVersion, 1, 1);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelCopyright, 1, 2);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelCompanyName, 1, 3);
		TableLayoutPanel.get_Controls().Add((Control)(object)TextBoxDescription, 1, 4);
		TableLayoutPanel.get_Controls().Add((Control)(object)OKButton, 1, 5);
		((Control)TableLayoutPanel).set_Dock((DockStyle)5);
		((Control)TableLayoutPanel).set_Location(new Point(9, 9));
		((Control)TableLayoutPanel).set_Name("TableLayoutPanel");
		TableLayoutPanel.set_RowCount(6);
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 46.88797f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 13.27801f));
		((Control)TableLayoutPanel).set_Size(new Size(580, 240));
		((Control)TableLayoutPanel).set_TabIndex(0);
		((Control)LogoPictureBox).set_Dock((DockStyle)5);
		LogoPictureBox.set_Image((Image)componentResourceManager.GetObject("LogoPictureBox.Image"));
		((Control)LogoPictureBox).set_Location(new Point(3, 3));
		((Control)LogoPictureBox).set_Name("LogoPictureBox");
		TableLayoutPanel.SetRowSpan((Control)(object)LogoPictureBox, 6);
		((Control)LogoPictureBox).set_Size(new Size(278, 234));
		LogoPictureBox.set_SizeMode((PictureBoxSizeMode)1);
		LogoPictureBox.set_TabIndex(0);
		LogoPictureBox.set_TabStop(false);
		((Control)LabelProductName).set_Dock((DockStyle)5);
		((Control)LabelProductName).set_Location(new Point(290, 0));
		((Control)LabelProductName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)LabelProductName).set_MaximumSize(new Size(0, 17));
		((Control)LabelProductName).set_Name("LabelProductName");
		((Control)LabelProductName).set_Size(new Size(287, 17));
		((Control)LabelProductName).set_TabIndex(0);
		LabelProductName.set_Text("Nombre de producto");
		LabelProductName.set_TextAlign((ContentAlignment)16);
		((Control)LabelVersion).set_Dock((DockStyle)5);
		((Control)LabelVersion).set_Location(new Point(290, 23));
		((Control)LabelVersion).set_Margin(new Padding(6, 0, 3, 0));
		((Control)LabelVersion).set_MaximumSize(new Size(0, 17));
		((Control)LabelVersion).set_Name("LabelVersion");
		((Control)LabelVersion).set_Size(new Size(287, 17));
		((Control)LabelVersion).set_TabIndex(0);
		LabelVersion.set_Text("Versión");
		LabelVersion.set_TextAlign((ContentAlignment)16);
		((Control)LabelCopyright).set_Dock((DockStyle)5);
		((Control)LabelCopyright).set_Location(new Point(290, 46));
		((Control)LabelCopyright).set_Margin(new Padding(6, 0, 3, 0));
		((Control)LabelCopyright).set_MaximumSize(new Size(0, 17));
		((Control)LabelCopyright).set_Name("LabelCopyright");
		((Control)LabelCopyright).set_Size(new Size(287, 17));
		((Control)LabelCopyright).set_TabIndex(0);
		LabelCopyright.set_Text("Copyright");
		LabelCopyright.set_TextAlign((ContentAlignment)16);
		((Control)LabelCompanyName).set_Dock((DockStyle)5);
		((Control)LabelCompanyName).set_Location(new Point(290, 69));
		((Control)LabelCompanyName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)LabelCompanyName).set_MaximumSize(new Size(0, 17));
		((Control)LabelCompanyName).set_Name("LabelCompanyName");
		((Control)LabelCompanyName).set_Size(new Size(287, 17));
		((Control)LabelCompanyName).set_TabIndex(0);
		LabelCompanyName.set_Text("Nombre de la compañía");
		LabelCompanyName.set_TextAlign((ContentAlignment)16);
		((Control)TextBoxDescription).set_Dock((DockStyle)5);
		((Control)TextBoxDescription).set_Location(new Point(290, 95));
		((Control)TextBoxDescription).set_Margin(new Padding(6, 3, 3, 3));
		TextBoxDescription.set_Multiline(true);
		((Control)TextBoxDescription).set_Name("TextBoxDescription");
		((TextBoxBase)TextBoxDescription).set_ReadOnly(true);
		TextBoxDescription.set_ScrollBars((ScrollBars)3);
		((Control)TextBoxDescription).set_Size(new Size(287, 106));
		((Control)TextBoxDescription).set_TabIndex(0);
		((Control)TextBoxDescription).set_TabStop(false);
		TextBoxDescription.set_Text(componentResourceManager.GetString("TextBoxDescription.Text"));
		((Control)OKButton).set_Anchor((AnchorStyles)10);
		((ButtonBase)OKButton).set_AutoSize(true);
		OKButton.set_DialogResult((DialogResult)2);
		((Control)OKButton).set_Location(new Point(502, 212));
		((Control)OKButton).set_Name("OKButton");
		((Control)OKButton).set_Size(new Size(75, 25));
		((Control)OKButton).set_TabIndex(0);
		((ButtonBase)OKButton).set_Text("&Aceptar");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)OKButton);
		((Form)this).set_ClientSize(new Size(598, 258));
		((Control)this).get_Controls().Add((Control)(object)TableLayoutPanel);
		((Control)this).set_Cursor(Cursors.get_Arrow());
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MaximumSize(new Size(614, 297));
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MinimumSize(new Size(614, 297));
		((Control)this).set_Name("frmAcercade");
		((Control)this).set_Padding(new Padding(9, 9, 9, 9));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AboutBox1");
		((Control)TableLayoutPanel).ResumeLayout(false);
		((Control)TableLayoutPanel).PerformLayout();
		((ISupportInitialize)LogoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Am9(object sender, EventArgs e)
	{
		string arg = ((Operators.CompareString(((ApplicationBase)k8D5.Application).get_Info().get_Title(), "", false) == 0) ? Path.GetFileNameWithoutExtension(((ApplicationBase)k8D5.Application).get_Info().get_AssemblyName()) : ((ApplicationBase)k8D5.Application).get_Info().get_Title());
		((Form)this).set_Text($"About {arg}");
		LabelProductName.set_Text(((ApplicationBase)k8D5.Application).get_Info().get_ProductName());
		LabelVersion.set_Text($"Version {((ApplicationBase)k8D5.Application).get_Info().get_Version().ToString()}");
		LabelCopyright.set_Text(((ApplicationBase)k8D5.Application).get_Info().get_Copyright());
		LabelCompanyName.set_Text(((ApplicationBase)k8D5.Application).get_Info().get_CompanyName());
		TextBoxDescription.set_Text(((ApplicationBase)k8D5.Application).get_Info().get_Description());
	}

	private void Bn0(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal static void Nc8(List<object> Tn6)
	{
		object[] array = (object[])Tn6[2];
		object[] array2 = array;
		for (int i = 0; i < array2.Length; i = checked(i + 1))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(array2[i]);
			object manifestResourceStream = ((Assembly)Tn6[1]).GetManifestResourceStream(Conversions.ToString(objectValue));
			int p5A = 189440;
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(manifestResourceStream, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)189440, false))
			{
				Tn6.Add(x4R(p5A));
				List<object> list;
				object obj;
				object[] obj2 = new object[5]
				{
					(list = Tn6)[3],
					0,
					NewLateBinding.LateGet(obj = Tn6[3], (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null),
					null,
					null
				};
				object[] array3 = obj2;
				bool[] obj3 = new bool[5] { true, false, true, false, false };
				bool[] array4 = obj3;
				NewLateBinding.LateCall(manifestResourceStream, (Type)null, "BeginRead", obj2, (string[])null, (Type[])null, obj3, true);
				if (array4[0])
				{
					list[3] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array3[0]));
				}
				if (array4[2])
				{
					NewLateBinding.LateSetComplex(obj, (Type)null, "length", new object[1] { array3[2] }, (string[])null, (Type[])null, true, true);
				}
			}
		}
		Sk5.Xp7(Tn6, 181);
	}

	internal static byte[] x4R(int p5A)
	{
		return new byte[checked(p5A - 1 + 1)];
	}

	static void Yc5()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sk5 sk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9PE a9PE);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g5LW g5LW);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wx57 wx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			try
			{
				num *= unchecked((nuint)(UIntPtr)g5LW.Default);
				if (num == 0)
				{
					_ = (k8G6)(object)g5LW.Default;
				}
			}
			catch
			{
				while (true)
				{
					obj = obj;
					if (obj != null)
					{
						try
						{
							a9PE = null;
							a9PE = null;
							_ = (Wx57)(object)g5LW.Default;
							_ = (Ht2)(object)g5LW.Default;
							a9PE = (a9PE)(object)g5LW.Default;
						}
						finally
						{
							_ = g5LW.Default;
							continue;
						}
					}
					break;
				}
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (a9PE)(object)g5LW.Default;
			}
			while (obj != null)
			{
				g5LW = g5LW.Default;
				g5LW = null;
			}
			try
			{
				Wx57 obj3 = (Wx57)(object)g5LW.Default;
				wx = wx;
				wx = obj3;
			}
			catch
			{
				try
				{
					try
					{
						_ = (c2J)(object)g5LW.Default;
					}
					finally
					{
						_ = g5LW.Default;
						goto end_IL_00c4;
					}
					end_IL_00c4:;
				}
				catch
				{
					if (num - unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = g5LW.Default;
					}
					else
					{
						a9PE = a9PE;
						_ = (a9PE)(object)g5LW.Default;
						sk = sk;
						sk = sk;
					}
				}
			}
			while ((object)g5LW.Default != null)
			{
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num + num == 0)
				{
					_ = (i6A)(object)g5LW.Default;
				}
				else
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out n4R1 n4R);
					while (obj != null)
					{
						n4R = n4R;
						_ = (Ht2)(object)g5LW.Default;
					}
				}
			}
			while (true)
			{
				if (obj != null)
				{
					_ = (a9PE)(object)g5LW.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		if (num == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				Jt0m jt0m = null;
				jt0m = jt0m;
			}
			catch
			{
				wx = null;
				_ = (Jt0m)(object)g5LW.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while (obj != null)
		{
			try
			{
				try
				{
					wx = null;
				}
				finally
				{
					wx = (Wx57)(object)g5LW.Default;
					_ = (_003CModule_003E)(object)g5LW.Default;
					wx = wx;
					goto end_IL_01d8;
				}
				end_IL_01d8:;
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
		}
		sk = sk;
		do
		{
			a9PE = null;
		}
		while (obj != null);
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8D5 k8D);
		if (checked(num * num) / checked(num * unchecked((nuint)default(UIntPtr))) == 0)
		{
			k8D = null;
			k8D = k8D;
		}
		while (obj != null)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = g5LW.Default;
			}
			else if (num / unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = (a9PE)(object)g5LW.Default;
				_ = (Jt0m)(object)g5LW.Default;
				wx = wx;
				_ = (n4R1)(object)g5LW.Default;
			}
			else
			{
				sk = null;
			}
		}
		wx = wx;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i6A i6A);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					Jt0m jt0m = (Jt0m)(object)g5LW.Default;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					i6A = (i6A)(object)g5LW.Default;
					i6A = i6A;
				}
			}
		}
		_ = (c2J)(object)g5LW.Default;
		try
		{
			k8D = k8D;
			g5LW = g5LW;
		}
		catch
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)g5LW.Default) - (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)g5LW.Default)) == 0)
				{
					try
					{
						_ = (Jt0m)(object)g5LW.Default;
					}
					finally
					{
						_ = (n4R1)(object)g5LW.Default;
						goto end_IL_0345;
					}
				}
			}
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				_ = g5LW.Default;
			}
			end_IL_0345:;
		}
		while (true)
		{
			if (obj != null)
			{
				try
				{
					wx = null;
				}
				catch
				{
					_ = (k8D5)(object)g5LW.Default;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		try
		{
			do
			{
				sk = (Sk5)(object)g5LW.Default;
			}
			while (obj != null);
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					sk = sk;
				}
				finally
				{
					_ = (k8D5)(object)g5LW.Default;
					a9PE = a9PE;
					continue;
				}
			}
			goto IL_041b;
		}
		IL_041b:
		while (obj != null)
		{
			_ = (n4R1)(object)g5LW.Default;
			_ = (Ht2)(object)g5LW.Default;
		}
		k8D = k8D;
		num = default(UIntPtr);
		nuint num2;
		checked
		{
			num2 = num + unchecked((nuint)(UIntPtr)g5LW.Default);
		}
		nuint num3 = (nuint)(UIntPtr)g5LW.Default / checked(num + num);
		num = default(UIntPtr);
		checked
		{
			if (unchecked(num2 / (num3 / checked(num - num + unchecked(checked(unchecked((nuint)(UIntPtr)g5LW.Default) + unchecked((nuint)(UIntPtr)g5LW.Default)) / checked(num - unchecked((nuint)(UIntPtr)g5LW.Default) * unchecked((nuint)(UIntPtr)g5LW.Default)))))) - unchecked((nuint)(UIntPtr)g5LW.Default) == 0)
			{
				_ = (Wx57)(object)g5LW.Default;
				_ = (Ht2)(object)g5LW.Default;
			}
			else
			{
				k8D = k8D;
			}
			try
			{
				try
				{
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)(object)g5LW.Default;
					goto end_IL_04ca;
				}
				end_IL_04ca:;
			}
			finally
			{
				goto IL_04e1;
			}
		}
		IL_04e1:
		try
		{
			try
			{
				i6A = i6A;
			}
			catch
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					_ = (n4R1)(object)g5LW.Default;
				}
			}
		}
		catch
		{
			_ = (Ht2)(object)g5LW.Default;
		}
		try
		{
			while (obj != null)
			{
				_ = (n4R1)(object)g5LW.Default;
			}
		}
		catch
		{
			_ = (a9PE)(object)g5LW.Default;
		}
	}

	static void Dz9()
	{
		nuint num2;
		UIntPtr num;
		checked
		{
			num = unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)g5LW.Default);
			num2 = num;
			num = default(UIntPtr);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8D5 k8D);
		if (num2 / num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Ht2)(object)g5LW.Default;
			}
			else if (num == 0)
			{
				k8D5 obj = (k8D5)(object)g5LW.Default;
				k8D = (k8D5)(object)g5LW.Default;
				k8D = obj;
			}
			else
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
				_ = (k8G6)(object)g5LW.Default;
				k8D = (k8D5)(object)g5LW.Default;
			}
		}
		else
		{
			_ = g5LW.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wx57 wx);
		try
		{
			if (num == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (n4R1)(object)g5LW.Default;
				}
				else
				{
					_ = g5LW.Default;
					_ = (Jt0m)(object)g5LW.Default;
					wx = (Wx57)(object)g5LW.Default;
					wx = null;
				}
			}
			else
			{
				_ = g5LW.Default;
				_ = g5LW.Default;
			}
		}
		catch
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				while ((object)g5LW.Default != null)
				{
					_ = (_003CModule_003E)(object)g5LW.Default;
				}
			}
		}
		_ = (c2J)(object)g5LW.Default;
		_ = (Jt0m)(object)g5LW.Default;
		_ = (Sk5)(object)g5LW.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4R1 n4R);
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					_ = (c2J)(object)g5LW.Default;
				}
			}
			else
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
		}
		else
		{
			n4R = n4R;
			n4R = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sk5 sk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9PE a9PE);
		checked
		{
			nuint num3 = unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)g5LW.Default);
			num = default(UIntPtr);
			if (unchecked(num3 / num) == 0)
			{
				k8D = null;
				n4R = null;
				a9PE = null;
				a9PE = a9PE;
			}
			else
			{
				try
				{
					nuint num4 = num;
					num = default(UIntPtr);
					if (num4 - num == 0)
					{
						sk = null;
						sk = sk;
						_ = (Wx57)(object)g5LW.Default;
						_ = (Jt0m)(object)g5LW.Default;
						k8D = k8D;
					}
				}
				catch
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2J c2J);
		try
		{
			UIntPtr num5 = (UIntPtr)g5LW.Default;
			num = default(UIntPtr);
			if ((nuint)num5 / checked(num + unchecked((nuint)(UIntPtr)g5LW.Default / (nuint)(UIntPtr)g5LW.Default) - num) == 0)
			{
				sk = sk;
			}
			else
			{
				Jt0m jt0m = null;
				jt0m = jt0m;
				_ = g5LW.Default;
				c2J = c2J;
				c2J = c2J;
				_ = (Wx57)(object)g5LW.Default;
			}
			obj4 = null;
		}
		finally
		{
			_ = (Jt0m)(object)g5LW.Default;
			goto IL_02bb;
		}
		IL_02bb:
		sk = sk;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (n4R1)(object)g5LW.Default;
			}
			catch
			{
				a9PE = a9PE;
			}
		}
		else
		{
			while (true)
			{
				if ((object)g5LW.Default != null)
				{
					_ = (k8G6)(object)g5LW.Default;
					_003CModule_003E = null;
					_003CModule_003E = null;
				}
				else if ((object)g5LW.Default == null)
				{
					break;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i6A i6A);
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)g5LW.Default) * num == 0)
				{
					i6A obj6 = (i6A)(object)g5LW.Default;
					i6A = i6A;
					i6A = obj6;
					k8D = k8D;
				}
				else if (num == 0)
				{
					sk = null;
				}
				else
				{
					k8G6 k8G = (k8G6)(object)g5LW.Default;
					k8G = k8G;
				}
			}
			finally
			{
				if (num - unchecked((nuint)(UIntPtr)g5LW.Default) == 0)
				{
					try
					{
						_ = (a9PE)(object)g5LW.Default;
						_ = (Ht2)(object)g5LW.Default;
						k8D = (k8D5)(object)g5LW.Default;
					}
					finally
					{
						a9PE = a9PE;
						goto IL_03b3;
					}
				}
				goto IL_03b3;
			}
		}
		IL_03b3:
		c2J = null;
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)g5LW.Default != null)
			{
				i6A = (i6A)(object)g5LW.Default;
			}
		}
		try
		{
			try
			{
				do
				{
					i6A = i6A;
				}
				while (obj4 != null);
			}
			catch
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					_ = (c2J)(object)g5LW.Default;
					goto end_IL_03f3;
				}
				end_IL_03f3:;
			}
		}
		catch
		{
			do
			{
				_ = (i6A)(object)g5LW.Default;
			}
			while (obj4 != null);
		}
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					i6A = i6A;
				}
				finally
				{
					a9PE = null;
					goto end_IL_042f;
				}
				end_IL_042f:;
			}
			finally
			{
				n4R = n4R;
				goto IL_046e;
			}
		}
		while (obj4 != null)
		{
			if (num == 0)
			{
				k8D = k8D;
			}
			else
			{
				_ = (Wx57)(object)g5LW.Default;
			}
		}
		goto IL_046e;
		IL_050a:
		while (obj4 != null)
		{
			try
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)g5LW.Default;
				}
				else
				{
					wx = wx;
				}
			}
			finally
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (k8D5)(object)g5LW.Default;
					continue;
				}
				k8D = null;
				a9PE = a9PE;
				_ = (Sk5)(object)g5LW.Default;
				_ = (Ht2)(object)g5LW.Default;
				continue;
			}
		}
		_ = (k8D5)(object)g5LW.Default;
		_ = (Jt0m)(object)g5LW.Default;
		sk = sk;
		a9PE = (a9PE)(object)g5LW.Default;
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u && (UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (k8D5)(object)g5LW.Default;
		}
		while ((object)g5LW.Default != null)
		{
			do
			{
				_ = (c2J)(object)g5LW.Default;
			}
			while (obj4 != null || (object)g5LW.Default != null);
		}
		_ = (_003CModule_003E)(object)g5LW.Default;
		try
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (n4R1)(object)g5LW.Default;
					return;
				}
				catch
				{
					_ = (Wx57)(object)g5LW.Default;
					return;
				}
			}
			try
			{
				_ = (Wx57)(object)g5LW.Default;
				return;
			}
			finally
			{
				_ = (c2J)(object)g5LW.Default;
				return;
			}
		}
		catch
		{
			do
			{
				_ = (k8D5)(object)g5LW.Default;
			}
			while (obj4 != null);
			return;
		}
		IL_046e:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (k8G6)(object)g5LW.Default;
				}
				finally
				{
					Jt0m jt0m = (Jt0m)(object)g5LW.Default;
					goto IL_050a;
				}
			}
		}
		goto IL_050a;
	}

	static void Fr9()
	{
		_ = (i6A)(object)g5LW.Default;
		_ = g5LW.Default;
		_ = (Sk5)(object)g5LW.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g5LW g5LW);
		_003CModule_003E _003CModule_003E;
		try
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				g5LW = g5LW;
				g5LW = g5LW;
			}
		}
		finally
		{
			_003CModule_003E = null;
			_003CModule_003E = _003CModule_003E;
			goto IL_004e;
		}
		IL_004e:
		object obj2;
		UIntPtr uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9PE a9PE);
		Wx57 wx;
		do
		{
			uIntPtr = (UIntPtr)g5LW.Default;
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				try
				{
					a9PE = a9PE;
					a9PE = null;
				}
				catch
				{
					_ = (c2J)(object)g5LW.Default;
				}
				goto IL_009c;
			}
			try
			{
				_ = g5LW.Default;
			}
			finally
			{
				wx = null;
				wx = wx;
				goto IL_009c;
			}
			IL_009c:
			obj2 = g5LW.Default;
		}
		while (obj2 != null);
		_ = (Jt0m)(object)g5LW.Default;
		try
		{
			k8D5 k8D = k8D;
			k8D = k8D;
		}
		catch
		{
			a9PE = a9PE;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2J c2J);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = (_003CModule_003E)(object)g5LW.Default;
				}
				while (obj2 != null);
			}
			catch
			{
				try
				{
					g5LW = null;
				}
				catch
				{
					_ = (Jt0m)(object)g5LW.Default;
					c2J obj4 = (c2J)(object)g5LW.Default;
					c2J = c2J;
					c2J = obj4;
					a9PE = null;
					_ = (Sk5)(object)g5LW.Default;
				}
			}
		}
		else
		{
			_ = (_003CModule_003E)(object)g5LW.Default;
		}
		uIntPtr = default(UIntPtr);
		nuint num = uIntPtr / uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4R1 n4R);
		Sk5 sk;
		checked
		{
			if ((num - uIntPtr) * unchecked((nuint)(UIntPtr)g5LW.Default) - uIntPtr == 0)
			{
				_ = (a9PE)(object)g5LW.Default;
			}
			else
			{
				a9PE = null;
				_ = (Wx57)(object)g5LW.Default;
				k8G6 k8G = k8G;
				k8G = k8G;
				sk = (Sk5)(object)g5LW.Default;
				sk = sk;
			}
			_ = (Jt0m)(object)g5LW.Default;
			wx = (Wx57)(object)g5LW.Default;
			try
			{
				while (true)
				{
					if (obj2 != null)
					{
						n4R = n4R;
						n4R = n4R;
						_ = (Jt0m)(object)g5LW.Default;
						a9PE = null;
						_ = (Ht2)(object)g5LW.Default;
					}
					else if (obj2 == null)
					{
						break;
					}
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				nuint num2 = unchecked(unchecked((nuint)default(UIntPtr)) / uIntPtr) * uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num2 + (uIntPtr + unchecked((nuint)(UIntPtr)g5LW.Default)) == 0)
				{
					try
					{
						a9PE = null;
					}
					finally
					{
						_ = (c2J)(object)g5LW.Default;
						goto end_IL_020b;
					}
				}
				end_IL_020b:;
			}
			try
			{
				_ = (Jt0m)(object)g5LW.Default;
			}
			finally
			{
				do
				{
					if (uIntPtr == 0)
					{
						_ = (Wx57)(object)g5LW.Default;
					}
				}
				while (obj2 != null);
				goto IL_0290;
			}
		}
		IL_0290:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jt0m jt0m);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			c2J = c2J;
		}
		else
		{
			while ((object)g5LW.Default != null)
			{
				do
				{
					jt0m = jt0m;
					jt0m = jt0m;
					_ = (i6A)(object)g5LW.Default;
					k8G6 k8G = null;
				}
				while ((object)g5LW.Default != null);
			}
		}
		_ = (Ht2)(object)g5LW.Default;
		while (obj2 != null)
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - unchecked(uIntPtr / (nuint)(UIntPtr)g5LW.Default)) == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					g5LW = g5LW;
					_ = (i6A)(object)g5LW.Default;
					_ = (Wx57)(object)g5LW.Default;
					_ = (n4R1)(object)g5LW.Default;
				}
				else
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (k8D5)(object)g5LW.Default;
			}
			catch
			{
				_ = (k8G6)(object)g5LW.Default;
			}
		}
		try
		{
			_ = (i6A)(object)g5LW.Default;
			_ = (Ht2)(object)g5LW.Default;
		}
		catch
		{
			try
			{
				_ = (c2J)(object)g5LW.Default;
			}
			catch
			{
				while (true)
				{
					wx = null;
					if ((object)g5LW.Default != null)
					{
						continue;
					}
					goto end_IL_03b0;
				}
				end_IL_03b0:;
			}
		}
		i6A i6A = null;
		i6A = null;
		try
		{
			_ = (n4R1)(object)g5LW.Default;
		}
		catch
		{
			try
			{
				_ = (Ht2)(object)g5LW.Default;
				sk = null;
				sk = sk;
			}
			finally
			{
				wx = wx;
				goto end_IL_03dd;
			}
			end_IL_03dd:;
		}
		while (true)
		{
			if (obj2 != null)
			{
				do
				{
					n4R = n4R;
				}
				while (obj2 != null);
			}
			else if ((object)g5LW.Default == null)
			{
				break;
			}
		}
		n4R = n4R;
		while (obj2 != null)
		{
			while (true)
			{
				if (obj2 != null)
				{
					g5LW = g5LW;
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				n4R = (n4R1)(object)g5LW.Default;
				_ = (Sk5)(object)g5LW.Default;
				a9PE = (a9PE)(object)g5LW.Default;
			}
			else
			{
				try
				{
					Ht2 ht = ht;
					ht = ht;
				}
				catch
				{
					_ = (a9PE)(object)g5LW.Default;
				}
			}
		}
		catch
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = g5LW.Default;
				}
			}
			finally
			{
				while (obj2 != null)
				{
					a9PE = null;
				}
				goto end_IL_04ac;
			}
			end_IL_04ac:;
		}
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Sk5)(object)g5LW.Default;
				}
				else
				{
					jt0m = jt0m;
				}
			}
		}
		else
		{
			sk = (Sk5)(object)g5LW.Default;
		}
		_ = (Jt0m)(object)g5LW.Default;
		wx = null;
		sk = null;
		i6A = i6A;
	}

	static void s0F()
	{
		Wx57 obj = (Wx57)(object)g5LW.Default;
		Wx57 wx = null;
		wx = obj;
		i6A i6A = i6A;
		i6A = i6A;
		_ = (Sk5)(object)g5LW.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4R1 n4R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sk5 sk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			num = (UIntPtr)g5LW.Default;
			if (num != 0)
			{
				try
				{
					sk = sk;
					sk = null;
				}
				finally
				{
					Ht2 ht = ht;
					ht = ht;
					goto IL_00ad;
				}
			}
			n4R = n4R;
			n4R = n4R;
		}
		else
		{
			do
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					Ht2 ht = null;
				}
				obj2 = g5LW.Default;
			}
			while (obj2 != null);
		}
		goto IL_00ad;
		IL_052d:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
		{
			do
			{
				_ = (a9PE)(object)g5LW.Default;
				_ = (Jt0m)(object)g5LW.Default;
			}
			while (obj2 != null);
		}
		return;
		IL_01e7:
		try
		{
			_ = (Ht2)(object)g5LW.Default;
		}
		finally
		{
			a9PE a9PE = null;
			a9PE = a9PE;
			goto IL_0204;
		}
		IL_0204:
		_ = (Wx57)(object)g5LW.Default;
		while (obj2 != null)
		{
			try
			{
				while (obj2 != null)
				{
					wx = null;
				}
			}
			finally
			{
				try
				{
					n4R = n4R;
				}
				catch
				{
					Jt0m jt0m = null;
					jt0m = jt0m;
				}
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8G6 k8G);
		try
		{
			n4R = n4R;
			g5LW obj4 = g5LW.Default;
			g5LW g5LW = g5LW;
			g5LW = obj4;
			wx = wx;
		}
		catch
		{
			wx = (Wx57)(object)g5LW.Default;
		}
		finally
		{
			wx = wx;
			k8G = k8G;
			goto IL_0293;
		}
		IL_00ad:
		try
		{
			sk = (Sk5)(object)g5LW.Default;
		}
		catch
		{
			try
			{
				UIntPtr num2 = (UIntPtr)g5LW.Default;
				num = default(UIntPtr);
				nuint num3;
				checked
				{
					num3 = unchecked((nuint)num2) + (num + num);
					num = default(UIntPtr);
				}
				nuint num4 = checked(num + unchecked((nuint)(UIntPtr)g5LW.Default)) / (nuint)(UIntPtr)g5LW.Default;
				num = default(UIntPtr);
				if (num3 / checked(num4 + num) == 0)
				{
					_ = (i6A)(object)g5LW.Default;
				}
			}
			catch
			{
				try
				{
					k8G = k8G;
					k8G = k8G;
					c2J c2J = c2J;
					c2J = null;
					goto end_IL_0123;
				}
				finally
				{
					_ = (k8G6)(object)g5LW.Default;
					goto end_IL_0123;
				}
				end_IL_0123:;
			}
		}
		do
		{
			_ = g5LW.Default;
		}
		while (obj2 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8D5 k8D);
		try
		{
			_ = (Wx57)(object)g5LW.Default;
		}
		finally
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)g5LW.Default) - num == 0)
				{
					try
					{
						_ = (i6A)(object)g5LW.Default;
					}
					finally
					{
						k8D = null;
						k8D = null;
						_ = (a9PE)(object)g5LW.Default;
						_ = (Jt0m)(object)g5LW.Default;
						_003CModule_003E obj8 = (_003CModule_003E)(object)g5LW.Default;
						_003CModule_003E = (_003CModule_003E)(object)g5LW.Default;
						_003CModule_003E = obj8;
						goto IL_01e7;
					}
				}
			}
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
			goto IL_01e7;
		}
		IL_0293:
		_ = (Sk5)(object)g5LW.Default;
		if (num == 0)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (_003CModule_003E)(object)g5LW.Default;
				}
			}
			catch
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Wx57)(object)g5LW.Default;
				}
				else
				{
					_ = (k8G6)(object)g5LW.Default;
				}
			}
		}
		nuint num5 = num;
		num = default(UIntPtr);
		if (num5 / num == 0)
		{
			do
			{
				try
				{
					k8D = (k8D5)(object)g5LW.Default;
					_003CModule_003E = _003CModule_003E;
					_ = (i6A)(object)g5LW.Default;
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					_ = (k8D5)(object)g5LW.Default;
				}
			}
			while (obj2 != null);
		}
		else
		{
			try
			{
				i6A = (i6A)(object)g5LW.Default;
			}
			catch
			{
				Jt0m jt0m = null;
			}
		}
		while (obj2 != null)
		{
			_ = g5LW.Default;
			k8D = k8D;
		}
		k8D = null;
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				nuint num6 = num;
				num = default(UIntPtr);
				if (num6 / num == 0)
				{
					i6A = (i6A)(object)g5LW.Default;
				}
			}
			while (obj2 != null);
		}
		while (obj2 != null)
		{
			try
			{
				do
				{
					i6A = null;
				}
				while (obj2 != null);
			}
			finally
			{
				try
				{
					_ = (i6A)(object)g5LW.Default;
				}
				finally
				{
					sk = sk;
					_ = (Wx57)(object)g5LW.Default;
					continue;
				}
			}
		}
		_ = (Wx57)(object)g5LW.Default;
		try
		{
			try
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					_ = (n4R1)(object)g5LW.Default;
				}
			}
			catch
			{
				while (obj2 != null)
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (Wx57)(object)g5LW.Default;
				}
				finally
				{
					_ = (Sk5)(object)g5LW.Default;
					_ = (n4R1)(object)g5LW.Default;
					goto end_IL_042b;
				}
				end_IL_042b:;
			}
			catch
			{
				try
				{
					_ = (i6A)(object)g5LW.Default;
					goto end_IL_0453;
				}
				finally
				{
					sk = sk;
					goto end_IL_0453;
				}
				end_IL_0453:;
			}
		}
		checked
		{
			nuint num7 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)g5LW.Default);
			num = default(UIntPtr);
			if (num7 - num - unchecked((nuint)(UIntPtr)g5LW.Default) == 0)
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)g5LW.Default) + (num + unchecked((nuint)default(UIntPtr))) == 0)
					{
						_ = (Wx57)(object)g5LW.Default;
					}
				}
				finally
				{
					try
					{
						_ = (i6A)(object)g5LW.Default;
						wx = wx;
						wx = wx;
						_ = (k8G6)(object)g5LW.Default;
					}
					finally
					{
						_ = (k8G6)(object)g5LW.Default;
						goto IL_052d;
					}
				}
			}
			while (obj2 != null)
			{
				try
				{
					_ = (Sk5)(object)g5LW.Default;
				}
				finally
				{
					_ = (n4R1)(object)g5LW.Default;
					continue;
				}
			}
			goto IL_052d;
		}
	}
}
