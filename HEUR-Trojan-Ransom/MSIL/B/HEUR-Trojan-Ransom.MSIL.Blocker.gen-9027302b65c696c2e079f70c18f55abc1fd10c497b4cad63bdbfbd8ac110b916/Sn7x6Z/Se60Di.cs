using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using g8GLd9;
using n2Z;
using t7S;

namespace Sn7x6Z;

[DesignerGenerated]
public class Se60Di : Form
{
	internal sealed class q0R9Kb
	{
		internal PictureBox pictureBox_0;

		internal ImageList imageList_0;

		internal PictureBox pictureBox_1;

		internal object object_0;

		internal object object_1;

		internal Panel panel_0;

		internal object object_2;

		internal object object_3;

		internal object object_4;

		internal q0R9Kb()
		{
		}
	}

	private IContainer components;

	[AccessedThroughProperty("txtproname")]
	private object _txtproname;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("btnclose")]
	private object _btnclose;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	private m8K.j5W j5W_0 = new m8K.j5W();

	internal virtual object txtproname
	{
		get
		{
			return _txtproname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtproname = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual object btnaddproduct
	{
		get
		{
			return j5W_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			j5W_0.object_0 = objectValue;
		}
	}

	internal virtual object btnclose
	{
		get
		{
			return _btnclose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnclose = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object txtPrice
	{
		get
		{
			return j5W_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			j5W_0.object_1 = objectValue;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return j5W_0.label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			j5W_0.label_0 = ((value is Label) ? value : null);
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	public Se60Di()
	{
		Hp82Am();
	}

	protected override void s0R1Dq(bool Cs7x4W)
	{
		try
		{
			if (Cs7x4W && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Cs7x4W);
		}
	}

	private void Hp82Am()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		new ComponentResourceManager(typeof(Se60Di));
		txtproname = RuntimeHelpers.GetObjectValue(new object());
		Label2 = new Label();
		btnaddproduct = RuntimeHelpers.GetObjectValue(new object());
		btnclose = RuntimeHelpers.GetObjectValue(new object());
		txtPrice = RuntimeHelpers.GetObjectValue(new object());
		Label1 = new Label();
		Label3 = new Label();
		((Control)this).SuspendLayout();
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)Label2).set_Location(new Point(12, 23));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(110, 20));
		((Control)Label2).set_TabIndex(41);
		Label2.set_Text("Product Name");
	}

	private void Si89Yj(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Invalid comparison between Unknown and I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtproname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Enter Any Item Name");
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Enter price");
		}
		else
		{
			try
			{
				Rf7.p7N();
				object rs = Rf7.rs;
				object[] obj = new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INSERT INTO product values('", NewLateBinding.LateGet(txtproname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ,'"), NewLateBinding.LateGet(txtPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"),
					Rf7.cn
				};
				object obj2 = obj;
				bool[] obj3 = new bool[2] { false, true };
				object obj4 = obj3;
				NewLateBinding.LateCall(rs, (Type)null, "Open", obj, (string[])null, (Type[])null, obj3, true);
				if ((obj4 as bool[])[1])
				{
					Rf7.cn = RuntimeHelpers.GetObjectValue(((object[])obj2)[1]);
				}
				object obj5;
				NewLateBinding.LateCall(Wt9q7H.Forms.MainForm.drpdwnProductList, (Type)null, "AddItem", (object[])(obj2 = new object[1] { NewLateBinding.LateGet(obj5 = txtproname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj4 = new bool[1] { true }), true);
				if (((bool[])obj4)[0])
				{
					NewLateBinding.LateSetComplex(obj5, (Type)null, "Text", new object[1] { (obj2 as object[])[0] }, (string[])null, (Type[])null, true, true);
				}
				NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				if ((int)MessageBox.Show("Successful, Would you like to add anther product", "succsful", (MessageBoxButtons)4) != 6)
				{
					((Control)this).Hide();
					NewLateBinding.LateSetComplex(txtproname, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(txtPrice, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateCall(txtproname, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MessageBox.Show("This product is already available");
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Rf7.cnn.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void Ec38Xg(object sender, EventArgs e)
	{
		((Control)this).Hide();
		NewLateBinding.LateSetComplex(txtproname, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(txtproname, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		try
		{
			Rf7.cnn.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Xn9z7E(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.get_KeyChar()) != 8 && ((Strings.Asc(e.get_KeyChar()) < 48) | (Strings.Asc(e.get_KeyChar()) > 57)))
		{
			e.set_Handled(true);
		}
	}

	internal static int k7H9Jw()
	{
		while (true)
		{
			try
			{
				Component component = new WebClient();
				try
				{
					IDisposable disposable = (component as WebClient).OpenRead("https://www.google.com");
					try
					{
						return 100;
					}
					finally
					{
						if ((Stream)disposable != null)
						{
							((IDisposable)(disposable as Stream)).Dispose();
						}
					}
				}
				finally
				{
					if (component is WebClient)
					{
						((IDisposable)(WebClient)component).Dispose();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
