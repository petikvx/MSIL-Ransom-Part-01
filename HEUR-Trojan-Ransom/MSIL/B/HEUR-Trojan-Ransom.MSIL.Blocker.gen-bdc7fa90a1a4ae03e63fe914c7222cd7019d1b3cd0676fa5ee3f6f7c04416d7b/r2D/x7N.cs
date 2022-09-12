using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace r2D;

[DesignerGenerated]
public class x7N : Form
{
	private Button _Button2;

	private FileSystemWatcher _FileSystemWatcher1;

	private TextBox _TextBox2;

	private TextBox _TextBox1;

	private Panel _Panel1;

	internal IContainer W;

	internal EventLog y;

	internal ListView m;

	internal Button J;

	internal Button F;

	internal FolderBrowserDialog O;

	internal BindingSource b;

	internal Panel s;

	public x7N()
	{
		q1T();
	}

	protected override void Kj5(bool Jm2)
	{
		try
		{
			if (Jm2 && W != null)
			{
				W.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Jm2);
		}
	}

	private void q1T()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		IContainer container = (W = new Container());
		Ky2(new EventLog());
		Zj6(new FileSystemWatcher());
		Jz3(new FolderBrowserDialog());
		Kd2(new Button());
		b7R(new Button());
		Mz9(new Button());
		Ar4(new ListView());
		Ls2(new BindingSource(W));
		e6F(new Panel());
		j0R(new Panel());
		k6N(new TextBox());
		Rb6(new TextBox());
		((ISupportInitialize)Ko2()).BeginInit();
		((ISupportInitialize)i1K()).BeginInit();
		((ISupportInitialize)Pr0()).BeginInit();
		((Control)this).SuspendLayout();
		Ko2().set_SynchronizingObject((ISynchronizeInvoke)this);
		i1K().EnableRaisingEvents = true;
		i1K().SynchronizingObject = (ISynchronizeInvoke?)this;
		((Control)t4F()).set_Location(new Point(152, 113));
		((Control)t4F()).set_Name("Button1");
		((Control)t4F()).set_Size(new Size(75, 23));
		((Control)t4F()).set_TabIndex(0);
		((ButtonBase)t4F()).set_Text("Button1");
		((ButtonBase)t4F()).set_UseVisualStyleBackColor(true);
		((Control)Bp9()).set_Location(new Point(222, 264));
		((Control)Bp9()).set_Name("Button2");
		((Control)Bp9()).set_Size(new Size(75, 23));
		((Control)Bp9()).set_TabIndex(1);
		((ButtonBase)Bp9()).set_Text("Button2");
		((ButtonBase)Bp9()).set_UseVisualStyleBackColor(true);
		((Control)e3H()).set_Location(new Point(380, 187));
		((Control)e3H()).set_Name("Button3");
		((Control)e3H()).set_Size(new Size(75, 23));
		((Control)e3H()).set_TabIndex(2);
		((ButtonBase)e3H()).set_Text("Button3");
		((ButtonBase)e3H()).set_UseVisualStyleBackColor(true);
		Tg8().set_HideSelection(false);
		((Control)Tg8()).set_Location(new Point(304, 249));
		((Control)Tg8()).set_Name("ListView1");
		((Control)Tg8()).set_Size(new Size(121, 97));
		((Control)Tg8()).set_TabIndex(3);
		Tg8().set_UseCompatibleStateImageBehavior(false);
		((Control)Kg8()).set_Location(new Point(75, 96));
		((Control)Kg8()).set_Name("Panel1");
		((Control)Kg8()).set_Size(new Size(200, 100));
		((Control)Kg8()).set_TabIndex(4);
		((Control)g7S()).set_Location(new Point(549, 141));
		((Control)g7S()).set_Name("Panel2");
		((Control)g7S()).set_Size(new Size(200, 100));
		((Control)g7S()).set_TabIndex(5);
		((Control)f4F()).set_Location(new Point(28, 393));
		((Control)f4F()).set_Name("TextBox1");
		((Control)f4F()).set_Size(new Size(100, 20));
		((Control)f4F()).set_TabIndex(6);
		((Control)Qj1()).set_Location(new Point(90, 301));
		((Control)Qj1()).set_Name("TextBox2");
		((Control)Qj1()).set_Size(new Size(100, 20));
		((Control)Qj1()).set_TabIndex(7);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)Qj1());
		((Control)this).get_Controls().Add((Control)(object)f4F());
		((Control)this).get_Controls().Add((Control)(object)g7S());
		((Control)this).get_Controls().Add((Control)(object)Kg8());
		((Control)this).get_Controls().Add((Control)(object)Tg8());
		((Control)this).get_Controls().Add((Control)(object)e3H());
		((Control)this).get_Controls().Add((Control)(object)Bp9());
		((Control)this).get_Controls().Add((Control)(object)t4F());
		((Control)this).set_Name("Form4");
		((Form)this).set_Text("Form4");
		((ISupportInitialize)Ko2()).EndInit();
		((ISupportInitialize)i1K()).EndInit();
		((ISupportInitialize)Pr0()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual EventLog Ko2()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ky2(EventLog Bo6)
	{
		EventLog val = (y = Bo6);
	}

	[SpecialName]
	internal virtual ListView Tg8()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ar4(ListView Ko7)
	{
		ListView val = (m = Ko7);
	}

	[SpecialName]
	internal virtual Button e3H()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mz9(Button Yo0)
	{
		Button val = (J = Yo0);
	}

	[SpecialName]
	internal virtual Button Bp9()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b7R(Button Jy2)
	{
		_Button2 = Jy2;
	}

	[SpecialName]
	internal virtual Button t4F()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kd2(Button a9E)
	{
		Button val = (F = a9E);
	}

	[SpecialName]
	internal virtual FileSystemWatcher i1K()
	{
		return _FileSystemWatcher1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zj6(FileSystemWatcher An1)
	{
		_FileSystemWatcher1 = An1;
	}

	[SpecialName]
	internal virtual FolderBrowserDialog b5Y()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jz3(FolderBrowserDialog Zt9)
	{
		FolderBrowserDialog val = (O = Zt9);
	}

	[SpecialName]
	internal virtual BindingSource Pr0()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ls2(BindingSource a3Z)
	{
		BindingSource val = (b = a3Z);
	}

	[SpecialName]
	internal virtual TextBox Qj1()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rb6(TextBox z5N)
	{
		_TextBox2 = z5N;
	}

	[SpecialName]
	internal virtual TextBox f4F()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6N(TextBox Xp1)
	{
		_TextBox1 = Xp1;
	}

	[SpecialName]
	internal virtual Panel g7S()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0R(Panel Fp7)
	{
		Panel val = (s = Fp7);
	}

	[SpecialName]
	internal virtual Panel Kg8()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6F(Panel Kq1)
	{
		_Panel1 = Kq1;
	}
}
