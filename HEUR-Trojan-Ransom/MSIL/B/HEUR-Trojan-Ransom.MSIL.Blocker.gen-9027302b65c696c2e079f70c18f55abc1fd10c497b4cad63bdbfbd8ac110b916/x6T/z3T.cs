using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Bo6;
using Dp4o9T;
using Dt7;
using Ed65Hf;
using Ed9;
using Ei07De;
using Gp;
using Jg8;
using Jm0r4W;
using Jr39Qo;
using Js9;
using Kj87Xi;
using Lk;
using Microsoft.VisualBasic.CompilerServices;
using Rn1;
using Sn7x6Z;
using c1CLx2;
using d0P;
using e2;
using g8GLd9;
using j1H5Ld;
using m2Q;
using n2Z;
using o1KZx9;
using p6MRy9;
using s9;
using t5C8Kg;
using t7S;
using w0XGc7;

namespace x6T;

[DesignerGenerated]
public class z3T : Form
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Rt1
	{
		internal object object_0;

		internal SaveFileDialog saveFileDialog_0;

		internal Timer timer_0;

		internal object object_1;

		internal object object_2;
	}

	private IContainer components;

	[AccessedThroughProperty("btnLogin")]
	private object _btnLogin;

	[AccessedThroughProperty("lblNo")]
	private object _lblNo;

	private Bs.o6 o6_0;

	internal virtual object btnLogin
	{
		get
		{
			return _btnLogin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnLogin = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object BunifuCustomLabel1
	{
		get
		{
			return o6_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			o6_0.object_0 = objectValue;
		}
	}

	internal virtual object txtgetUserName
	{
		get
		{
			return o6_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			o6_0.object_1 = objectValue;
		}
	}

	internal virtual object lblNo
	{
		get
		{
			return _lblNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNo = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return o6_0.pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			o6_0.pictureBox_0 = ((value is PictureBox) ? value : null);
		}
	}

	public z3T()
	{
		x0J();
	}

	protected override void Xm2(bool Dx1)
	{
		try
		{
			if (Dx1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Dx1);
		}
	}

	private void x0J()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected O, but got Unknown
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected O, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected O, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		object obj = new ComponentResourceManager(typeof(z3T));
		PictureBox1 = new PictureBox();
		((ISupportInitialize)btnLogin).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "Font", new object[1] { (object)new Font("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "Location", new object[1]
		{
			new Point(353, 246)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "Name", new object[1] { "btnLogin" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "Size", new object[1]
		{
			new Size(164, 36)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "TabIndex", new object[1] { 17 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "Text", new object[1] { "Get Password" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "ThemeName", new object[1] { "Office2010Black" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "AutoSize", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "BackColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "ForeColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Location", new object[1]
		{
			new Point(12, 200)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Name", new object[1] { "BunifuCustomLabel1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Size", new object[1]
		{
			new Size(83, 20)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "TabIndex", new object[1] { 18 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Text", new object[1] { "Username" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "BackColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "Location", new object[1]
		{
			new Point(149, 190)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "Name", new object[1] { "txtgetUserName" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "Size", new object[1]
		{
			new Size(368, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "TabIndex", new object[1] { 16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtgetUserName, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblNo, (Type)null, "AutoSize", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblNo, (Type)null, "BackColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblNo, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblNo, (Type)null, "ForeColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblNo, (Type)null, "Location", new object[1]
		{
			new Point(12, 251)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblNo, (Type)null, "Name", new object[1] { "lblNo" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblNo, (Type)null, "Size", new object[1]
		{
			new Size(63, 20)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblNo, (Type)null, "TabIndex", new object[1] { 19 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblNo, (Type)null, "Text", new object[1] { "number" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblNo, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		PictureBox1.set_Image((Image)(obj as ComponentResourceManager).GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(13, 13));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(504, 170));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(20);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(529, 304));
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)lblNo);
		((Control)this).get_Controls().Add((Control)btnLogin);
		((Control)this).get_Controls().Add((Control)BunifuCustomLabel1);
		((Control)this).get_Controls().Add((Control)txtgetUserName);
		((Control)this).set_Name("ForgetPassword");
		((Form)this).set_Text("ForgetPassword");
		((ISupportInitialize)btnLogin).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void p2G(object sender, EventArgs e)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(txtgetUserName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			Rf7.Zj9();
			Rf7.cnn.Open();
			try
			{
				Rf7.cmd.set_Connection(Rf7.cnn);
				Rf7.cmd.set_CommandText("select mobno,password from userinfo where username ='" + NewLateBinding.LateGet(txtgetUserName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Rf7.da.set_SelectCommand(Rf7.cmd);
			IXmlSerializable xmlSerializable = new DataTable();
			try
			{
				((DbDataAdapter)(object)Rf7.da).Fill((DataTable)xmlSerializable);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				MessageBox.Show("Invalid Uesrname");
				ProjectData.ClearProjectError();
			}
			object obj = default(object);
			try
			{
				obj = ((DataTable)xmlSerializable).Rows[0];
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				IConvertible convertible = Conversions.ToString((obj as DataRow)["mobno"]);
				NewLateBinding.LateSetComplex(lblNo, (Type)null, "Text", new object[1] { "PASSWORD SENDED ON : +91 " + (convertible as string) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateCall(lblNo, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				try
				{
					IEnumerable<char> enumerable = Conversions.ToString(((DataRow)obj)["password"]);
					IEnumerable enumerable2 = "Your Password Is : " + (enumerable as string);
					IEnumerable<char> enumerable3 = "http://api.textlocal.in/send/?";
					IEnumerable<char> enumerable4 = "sangleshubham9@gmail.com";
					object obj2 = "04b1a77a40a4d43e1d30d8522380fc9b488714ef3fe7170bdc7040aa70a955ef";
					IEnumerable enumerable5 = (enumerable3 as string) + "username=" + (enumerable4 as string) + "&hash=" + (obj2 as string) + "&message=" + (enumerable2 as string) + "&sender=TXTLCL&numbers=91" + (convertible as string) + "&test=0";
					MarshalByRefObject marshalByRefObject = WebRequest.Create((string)enumerable5);
					((WebRequest)marshalByRefObject).Method = "POST";
					Array bytes = Encoding.UTF8.GetBytes(enumerable5 as string);
					((WebRequest)marshalByRefObject).ContentType = "application/x-www-form-urlencoded";
					(marshalByRefObject as WebRequest).ContentLength = ((byte[])bytes).Length;
					IDisposable requestStream = (marshalByRefObject as WebRequest).GetRequestStream();
					((Stream)requestStream).Write((byte[])bytes, 0, (bytes as byte[]).Length);
					((Stream)requestStream).Close();
					MarshalByRefObject response = ((WebRequest)marshalByRefObject).GetResponse();
					requestStream = (response as WebResponse).GetResponseStream();
					object obj3 = new StreamReader(requestStream as Stream);
					IComparable comparable = ((StreamReader)obj3).ReadToEnd();
					Console.WriteLine((string)comparable);
					Console.ReadLine();
					(obj3 as StreamReader).Close();
					((Stream)requestStream).Close();
					(response as WebResponse).Close();
					if (((string)comparable).Length > 0)
					{
						MessageBox.Show((string)comparable);
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					MessageBox.Show("Fail to send sms");
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				MessageBox.Show("No user found");
				NewLateBinding.LateCall(lblNo, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				ProjectData.ClearProjectError();
			}
			Rf7.cnn.Close();
		}
		else
		{
			NewLateBinding.LateCall(txtgetUserName, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	static void Er8()
	{
		//IL_030a: Expected O, but got I4
		//IL_0353: Expected O, but got I4
		//IL_05f1: Expected O, but got I4
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected O, but got I4
		//IL_06b2: Expected O, but got I4
		//IL_06fa: Expected O, but got I4
		//IL_0a85: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yg89Py yg89Py);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i1D i1D);
		while (((a8C)null).PayTMPay != null)
		{
			try
			{
				Yg89Py obj = (Yg89Py)((f3L6Rd)null).PrintDailyRecords;
				yg89Py = null;
				yg89Py = obj;
			}
			catch
			{
				i1D = null;
				_ = (Ez0)((f3L6Rd)i1D.PrintMonthlyRecords).PrintDailyRecords;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a8C a8C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mr7n6D mr7n6D);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Ez0 ez);
			do
			{
				xn05Ce = (Xn05Ce)((i1D)null).PrintMonthlyRecords;
				if ((UIntPtr)((s7K2Ek)xn05Ce.ObjectDetectorScalingMode).ObjectDetectorSearchMode != (UIntPtr)(nuint)0u)
				{
					ez = ez;
					ez = ez;
					continue;
				}
				_ = (z3T)((f3L6Rd)null).PrintDailyRecords;
				xn05Ce = null;
				mr7n6D = mr7n6D;
				_ = (Sy50Xx)((Mr7n6D)mr7n6D.SelectImageGetFrom).SelectImageGetFrom;
			}
			while ((object)yg89Py.DBForFoodManagementConnectionString != null);
		}
		catch
		{
			nuint num;
			checked
			{
				num = unchecked((nuint)(UIntPtr)((Ag9)null).UserInfo) - unchecked((nuint)default(UIntPtr));
				num2 = default(UIntPtr);
			}
			if (num / num2 == 0)
			{
				i1D = i1D;
			}
			else
			{
				a8C = a8C;
				_ = (Sy50Xx)a8C.PayTMPay;
			}
			obj3 = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy0 sy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ty5k0C ty5k0C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x6LFp1 x6LFp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f3L6Rd f3L6Rd);
		try
		{
			f3L6Rd = (f3L6Rd)f3L6Rd.PrintDailyRecords;
			sy = (Sy0)f3L6Rd.PrintDailyRecords;
			sy = sy;
		}
		catch
		{
			while (obj3 != null)
			{
				if ((UIntPtr)((Yg89Py)null).DBForFoodManagementConnectionString == (UIntPtr)(nuint)0u)
				{
					ty5k0C = ty5k0C;
					ty5k0C = null;
				}
				else
				{
					x6LFp = x6LFp;
					x6LFp = x6LFp;
				}
			}
		}
		try
		{
			try
			{
			}
			catch
			{
				while (obj3 != null)
				{
					_ = (e2.y6)mr7n6D.ObjectDetectorSearchMode;
				}
			}
		}
		catch
		{
			m8K m8K = m8K;
			m8K = m8K;
		}
		b4 b = b;
		b = b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rf7 rf);
		if (num2 == 0)
		{
			do
			{
				rf = null;
				rf = rf;
			}
			while (obj3 != null || obj3 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7K2Ek s7K2Ek);
		do
		{
			_ = (x6LFp1)mr7n6D.ObjectDetectorSearchMode;
			s7K2Ek = s7K2Ek;
		}
		while (s7K2Ek.ObjectDetectorScalingMode != null || ((f3L6Rd)null).PrintDailyRecords != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag9 ag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1P6Lz f1P6Lz);
		while (mr7n6D.ObjectDetectorSearchMode != null)
		{
			f1P6Lz = f1P6Lz;
			Ag9 obj8 = (Ag9)f1P6Lz.SuppliedRecord;
			ag = ag;
			ag = obj8;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Se60Di se60Di);
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				se60Di = se60Di;
				se60Di = se60Di;
				_ = (Ty5k0C)((i1D)null).PrintMonthlyRecords;
				_ = (b4)((Xn05Ce)null).ObjectDetectorScalingMode;
				_ = (_003CModule_003E)(object)yg89Py.Fast_food_managementConnectionString;
			}
		}
		_ = (Mm0)s7K2Ek.ObjectDetectorScalingMode;
		_ = (i1D)((Mr7n6D)((Sy0)null).SupplierDailyRecord).SelectImageGetFrom;
		_ = (s9.y6)((Xn05Ce)null).ObjectDetectorScalingMode;
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Wt9q7H wt9q7H);
			do
			{
				Wt9q7H obj9 = (Wt9q7H)((f1P6Lz)null).SupplierDailyRecord;
				wt9q7H = wt9q7H;
				wt9q7H = obj9;
			}
			while (obj3 != null);
		}
		else
		{
			do
			{
				_ = (s4C8Py)((s7K2Ek)(((y0D)null).Width as a8C).PayTMPay).ObjectDetectorScalingMode;
			}
			while (obj3 != null);
		}
		if (num2 != (UIntPtr)(nuint)0u)
		{
			a8C = a8C;
		}
		checked
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy50Xx sy50Xx);
				while (obj3 != null)
				{
					try
					{
						sy50Xx = sy50Xx;
						sy50Xx = null;
					}
					catch
					{
						_ = ((y0D)null).Width is s4C8Py;
					}
				}
			}
			finally
			{
				num2 = default(UIntPtr);
				if (num2 - unchecked((nuint)(UIntPtr)((i1D)null).PrintMonthlyRecords) == 0)
				{
					try
					{
						_ = (Mt2)((Ag9)null).UserInfo;
					}
					finally
					{
						ag = ag;
						goto IL_0398;
					}
				}
				goto IL_0398;
			}
		}
		IL_0998:
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Bs bs);
			do
			{
				bs = bs;
			}
			while (obj3 != null);
		}
		finally
		{
			_ = (_003CModule_003E)((Xn05Ce)((Ag9)null).UserInfo).ObjectDetectorScalingMode;
			goto IL_09c2;
		}
		IL_04e0:
		rf = rf;
		try
		{
			try
			{
				try
				{
					_ = (s4C8Py)((a8C)null).PayTMPay;
				}
				finally
				{
					_ = (s4C8Py)((Xn05Ce)null).ObjectDetectorSearchMode;
					goto end_IL_04e9;
				}
				end_IL_04e9:;
			}
			finally
			{
				if (num2 == 0)
				{
					b = b;
				}
				else
				{
					_ = (s9.y6)f1P6Lz.SupplierDailyRecord;
				}
				goto end_IL_04e8;
			}
			end_IL_04e8:;
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out e2.y6 y);
			while (obj3 != null)
			{
				e2.y6 obj11 = (e2.y6)i1D.PrintMonthlyRecords;
				y = y;
				y = obj11;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mt2 mt);
		if ((UIntPtr)ag.UserInfo == (UIntPtr)(nuint)0u && checked(unchecked((nuint)(UIntPtr)f1P6Lz.SuppliedRecord) - num2 + unchecked((nuint)(UIntPtr)((Sy0)(object)yg89Py.Fast_food_managementConnectionString).SupplierDailyRecord)) == 0)
		{
			mt = mt;
			mt = mt;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		if ((UIntPtr)mr7n6D.SelectImageGetFrom == (UIntPtr)(nuint)0u)
		{
			UIntPtr intPtr = (UIntPtr)mr7n6D.ObjectDetectorSearchMode;
			num2 = default(UIntPtr);
			nuint num3;
			object obj13;
			checked
			{
				num3 = unchecked((nuint)default(UIntPtr)) * num2;
				obj13 = y0D.Width;
			}
			if ((int)checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)intPtr / checked(num3 - ((obj13 is UIntPtr) ? obj13 : null)))) == 0)
			{
				i1D = i1D;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3T z3T2);
		try
		{
			rf = rf;
		}
		finally
		{
			if (num2 == 0)
			{
				ty5k0C = (Ty5k0C)f1P6Lz.SuppliedRecord;
				_ = (Mt2)((Ag9)i1D.PrintMonthlyRecords).UserInfo;
				_ = (Yg89Py)mr7n6D.UserInfo;
				z3T2 = (z3T)((f3L6Rd)null).PrintDailyRecords;
				z3T2 = z3T2;
			}
			goto IL_0666;
		}
		IL_09c2:
		try
		{
			num2 = default(UIntPtr);
			checked
			{
				if (num2 == 0)
				{
					try
					{
						mt = mt;
						f1P6Lz = f1P6Lz;
					}
					catch
					{
						_ = (s7K2Ek)((a8C)i1D.PrintMonthlyRecords).PayTMPay;
					}
				}
				else if (unchecked((nuint)(UIntPtr)f3L6Rd.PrintDailyRecords) + num2 == 0)
				{
					x6LFp = null;
				}
				else
				{
					_ = (_003CModule_003E)xn05Ce.UserInfo;
				}
			}
		}
		catch
		{
			do
			{
				num2 = default(UIntPtr);
				if (checked(num2 + unchecked((nuint)(UIntPtr)xn05Ce.ObjectDetectorScalingMode)) / (nuint)(UIntPtr)((i1D)null).PrintMonthlyRecords == 0)
				{
					_ = (Xn05Ce)xn05Ce.ObjectDetectorSearchMode;
				}
			}
			while (obj3 != null);
		}
		if (num2 == 0)
		{
			if (!(y0D.Width is UIntPtr))
			{
				try
				{
					_ = (Mt2)((i1D)null).PrintMonthlyRecords;
					return;
				}
				finally
				{
					_ = (Mm0)i1D.PrintMonthlyRecords;
					return;
				}
			}
			_ = (Mt2)s7K2Ek.ObjectDetectorScalingMode;
			return;
		}
		try
		{
			do
			{
				_ = (Mr7n6D)((Xn05Ce)null).ObjectDetectorScalingMode;
			}
			while (obj3 != null);
			return;
		}
		catch
		{
			try
			{
				f3L6Rd = (f3L6Rd)ag.UserInfo;
				return;
			}
			finally
			{
				_ = (Ty5k0C)(object)yg89Py.Fast_food_managementConnectionString;
				return;
			}
		}
		IL_0422:
		try
		{
			_ = (Yg89Py)((i1D)ag.UserInfo).PrintMonthlyRecords;
		}
		catch
		{
			do
			{
				ag = ag;
			}
			while (obj3 != null || obj3 != null);
		}
		try
		{
			y0D = y0D;
			y0D = null;
		}
		finally
		{
			while (obj3 != null)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					Wt9q7H wt9q7H = (Wt9q7H)((Ag9)((a8C)mr7n6D.UserInfo).PayTMPay).UserInfo;
					_ = (x6LFp1)f1P6Lz.SuppliedRecord;
					yg89Py = yg89Py;
					_ = (Sy50Xx)((Ag9)xn05Ce.UserInfo).UserInfo;
				}
				else
				{
					ty5k0C = ty5k0C;
				}
			}
			goto IL_04e0;
		}
		IL_0666:
		try
		{
			Hf08Tc hf08Tc = null;
			hf08Tc = hf08Tc;
		}
		catch
		{
			do
			{
				if (num2 == 0)
				{
					_ = (Se60Di)mr7n6D.ObjectDetectorScalingMode;
				}
			}
			while ((((y0D)null).Width as Mr7n6D).UserInfo != null);
		}
		try
		{
			try
			{
				Sy50Xx sy50Xx = ((y0D)null).Width as Sy50Xx;
			}
			finally
			{
				goto end_IL_06aa;
			}
			end_IL_06aa:;
		}
		catch
		{
			rf = null;
		}
		mr7n6D = mr7n6D;
		while (((f1P6Lz)((Sy0)((f3L6Rd)null).PrintDailyRecords).SuppliedRecord).Send_sms_to_customer != null)
		{
			try
			{
				_ = (Mr7n6D)a8C.PayTMPay;
			}
			finally
			{
				try
				{
					x6LFp = x6LFp;
				}
				catch
				{
					_ = y0D.Width is b4;
					_ = (Se60Di)i1D.PrintMonthlyRecords;
					m8K m8K = null;
					_ = (f3L6Rd)((Ag9)((Mr7n6D)mr7n6D.UserInfo).SelectImageGetFrom).UserInfo;
				}
				continue;
			}
		}
		do
		{
			try
			{
				try
				{
					_ = (Rf7)sy.SupplierDailyRecord;
				}
				finally
				{
					s4C8Py s4C8Py = (s4C8Py)f3L6Rd.PrintDailyRecords;
					s4C8Py = s4C8Py;
					goto end_IL_075f;
				}
				end_IL_075f:;
			}
			finally
			{
				_ = (_003CModule_003E)f3L6Rd.PrintDailyRecords;
				continue;
			}
		}
		while (((s7K2Ek)((Mr7n6D)((s7K2Ek)((f3L6Rd)xn05Ce.UserInfo).PrintDailyRecords).ObjectDetectorScalingMode).ObjectDetectorSearchMode).ObjectDetectorScalingMode != null);
		checked
		{
			if (unchecked((nuint)(UIntPtr)((a8C)mr7n6D.ObjectDetectorScalingMode).PayTMPay) * num2 == 0)
			{
				do
				{
					try
					{
						_ = (_003CModule_003E)i1D.PrintMonthlyRecords;
					}
					finally
					{
						_ = (_003CModule_003E)xn05Ce.UserInfo;
						i1D = i1D;
						_ = (Mm0)((Ag9)((f1P6Lz)null).SupplierDailyRecord).UserInfo;
						continue;
					}
				}
				while (obj3 != null);
			}
			_ = (b4)i1D.PrintMonthlyRecords;
			while (obj3 != null)
			{
				if (unchecked((UIntPtr)sy.SupplierDailyRecord == (UIntPtr)(nuint)0u))
				{
					if (num2 == 0)
					{
						z3T2 = z3T2;
						_ = (Rf7)i1D.PrintMonthlyRecords;
						_ = (s7K2Ek)a8C.PayTMPay;
					}
					else
					{
						_ = (Bs)((i1D)((Xn05Ce)null).ObjectDetectorSearchMode).PrintMonthlyRecords;
					}
				}
			}
			do
			{
				_ = (_003CModule_003E)f1P6Lz.Send_sms_to_customer;
			}
			while (obj3 != null || obj3 != null || ((Sy0)f1P6Lz.SupplierDailyRecord).SuppliedRecord != null);
			if (unchecked((nuint)(UIntPtr)xn05Ce.UserInfo) - (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) == 0)
			{
				try
				{
					if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
					{
						_ = (_003CModule_003E)f1P6Lz.SupplierDailyRecord;
					}
				}
				finally
				{
					try
					{
						_ = (Yg89Py)((f3L6Rd)i1D.PrintMonthlyRecords).PrintDailyRecords;
					}
					finally
					{
						f3L6Rd = null;
						goto IL_0998;
					}
				}
			}
		}
		if ((UIntPtr)a8C.PayTMPay == (UIntPtr)(nuint)0u)
		{
			f3L6Rd = f3L6Rd;
		}
		else
		{
			try
			{
				i7Z8Et i7Z8Et = i7Z8Et;
				i7Z8Et = i7Z8Et;
			}
			catch
			{
				se60Di = (Se60Di)s7K2Ek.ObjectDetectorSearchMode;
			}
		}
		goto IL_0998;
		IL_0398:
		_ = (Mr7n6D)a8C.PayTMPay;
		try
		{
			try
			{
				do
				{
					mr7n6D = null;
					ag = ag;
				}
				while (ag.UserInfo != null);
			}
			finally
			{
				while (xn05Ce.ObjectDetectorScalingMode != null)
				{
					_ = (Ty5k0C)((Xn05Ce)null).ObjectDetectorScalingMode;
				}
				goto end_IL_03a7;
			}
			end_IL_03a7:;
		}
		finally
		{
			try
			{
				if (checked(num2 - num2) == 0)
				{
					m8K m8K = null;
				}
			}
			catch
			{
				try
				{
					xn05Ce = null;
				}
				finally
				{
					_ = (s9.y6)((Xn05Ce)((s7K2Ek)null).ObjectDetectorScalingMode).ObjectDetectorScalingMode;
					goto end_IL_03fe;
				}
				end_IL_03fe:;
			}
			goto IL_0422;
		}
	}

	static void n4R()
	{
		//IL_0136: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		//IL_029c: Expected O, but got I4
		//IL_02e6: Expected O, but got I4
		//IL_031f: Expected O, but got I4
		//IL_03de: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		while (true)
		{
			obj = obj;
			if (obj == null)
			{
				break;
			}
			try
			{
				_ = (Wt9q7H)((Sy0)null).SupplierDailyRecord;
			}
			finally
			{
				_ = (x6LFp1)((s7K2Ek)null).ObjectDetectorScalingMode;
				continue;
			}
		}
		Ag9 ag = ag;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i7Z8Et i7Z8Et);
		if ((UIntPtr)ag.UserInfo != (UIntPtr)(nuint)0u)
		{
			xn05Ce = null;
			i7Z8Et obj2 = (i7Z8Et)xn05Ce.UserInfo;
			i7Z8Et = i7Z8Et;
			i7Z8Et = obj2;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x6LFp1 x6LFp);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				i7Z8Et = null;
			}
			finally
			{
				try
				{
					_ = (Yg89Py)xn05Ce.ObjectDetectorSearchMode;
				}
				catch
				{
					x6LFp = x6LFp;
					x6LFp = x6LFp;
				}
				goto IL_0099;
			}
		}
		goto IL_0099;
		IL_020a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i1D i1D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7K2Ek s7K2Ek);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9.y6 y);
		Mr7n6D mr7n6D;
		try
		{
			s9.y6 obj4 = (s9.y6)((f3L6Rd)((f1P6Lz)null).Send_sms_to_customer).PrintDailyRecords;
			y = null;
			y = obj4;
		}
		catch
		{
			if (uIntPtr != 0)
			{
				_ = (Hf08Tc)((Sy0)i1D.PrintMonthlyRecords).UserInfo;
				Rf7 rf = (Rf7)((a8C)((f3L6Rd)s7K2Ek.ObjectDetectorScalingMode).PrintDailyRecords).PayTMPay;
				mr7n6D = (Mr7n6D)s7K2Ek.ObjectDetectorScalingMode;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yg89Py yg89Py);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hf08Tc hf08Tc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy50Xx sy50Xx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1P6Lz f1P6Lz);
		try
		{
			try
			{
				Sy50Xx obj6 = ((y0D)mr7n6D.ObjectDetectorScalingMode).Width as Sy50Xx;
				sy50Xx = sy50Xx;
				sy50Xx = obj6;
			}
			catch
			{
				yg89Py = null;
				_ = (Xn05Ce)(object)yg89Py.DBForFoodManagementConnectionString;
			}
		}
		catch
		{
			try
			{
				y = y;
			}
			finally
			{
				Hf08Tc obj8 = ((y0D)f1P6Lz.Send_sms_to_customer).Width as Hf08Tc;
				hf08Tc = null;
				hf08Tc = obj8;
				goto end_IL_02c7;
			}
			end_IL_02c7:;
		}
		finally
		{
			if ((UIntPtr)((Yg89Py)null).Fast_food_managementConnectionString == (UIntPtr)(nuint)0u)
			{
				xn05Ce = (Xn05Ce)i1D.PrintMonthlyRecords;
				_ = ((y0D)null).Width is f3L6Rd;
				_ = (Mt2)ag.UserInfo;
			}
			goto IL_0335;
		}
		IL_0099:
		UIntPtr num = uIntPtr;
		uIntPtr = default(UIntPtr);
		a8C a8C;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f3L6Rd f3L6Rd);
		checked
		{
			if (unchecked((nuint)num) * uIntPtr == 0)
			{
				do
				{
					Rf7 rf = (Rf7)((i1D)((a8C)null).PayTMPay).PrintMonthlyRecords;
					rf = rf;
					i1D = i1D;
				}
				while (i1D.PrintMonthlyRecords != null);
			}
			_ = (y0D)((a8C)null).PayTMPay;
			f1P6Lz = f1P6Lz;
			Mr7n6D obj10 = (Mr7n6D)f1P6Lz.SupplierDailyRecord;
			mr7n6D = null;
			mr7n6D = obj10;
			a8C = null;
			a8C = a8C;
			b4 b = b;
			b = b;
			try
			{
				if (!(((y0D)null).Width is UIntPtr))
				{
					while (((Mr7n6D)((f1P6Lz)null).SuppliedRecord).ObjectDetectorScalingMode != null)
					{
						f3L6Rd = null;
						_ = (s4C8Py)((Sy0)((Xn05Ce)(((y0D)((i1D)f3L6Rd.PrintDailyRecords).PrintMonthlyRecords).Width as a8C).PayTMPay).UserInfo).SuppliedRecord;
					}
				}
			}
			finally
			{
				try
				{
					uIntPtr = default(UIntPtr);
					nuint num2 = uIntPtr;
					uIntPtr = default(UIntPtr);
					nuint num3 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num2 - unchecked(checked(num3 - uIntPtr) / checked(unchecked((nuint)(UIntPtr)((Yg89Py)null).Fast_food_managementConnectionString) * unchecked((nuint)(UIntPtr)((f1P6Lz)null).SuppliedRecord))) == 0)
					{
						_ = (x6LFp1)(object)Yg89Py.Default;
					}
				}
				catch
				{
					try
					{
						f3L6Rd = f3L6Rd;
					}
					finally
					{
						xn05Ce = xn05Ce;
						goto end_IL_01f1;
					}
					end_IL_01f1:;
				}
				goto IL_020a;
			}
		}
		IL_0685:
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)i1D.PrintMonthlyRecords) == 0)
			{
				try
				{
					Se60Di se60Di = null;
					se60Di = se60Di;
					return;
				}
				finally
				{
					while (obj != null)
					{
						i7Z8Et = i7Z8Et;
					}
					return;
				}
			}
		}
		if ((UIntPtr)f3L6Rd.PrintDailyRecords == (UIntPtr)(nuint)0u)
		{
			try
			{
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = null;
				return;
			}
			finally
			{
				_ = (Ag9)((f1P6Lz)((f3L6Rd)i1D.PrintMonthlyRecords).PrintDailyRecords).SuppliedRecord;
				hf08Tc = (Hf08Tc)xn05Ce.ObjectDetectorSearchMode;
				_ = (z3T)a8C.PayTMPay;
				return;
			}
		}
		try
		{
			_ = (Xn05Ce)((i1D)null).PrintMonthlyRecords;
			return;
		}
		catch
		{
			ag = ag;
			return;
		}
		IL_0335:
		_ = (y0D)f1P6Lz.SuppliedRecord;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy0 sy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ez0 ez);
		while (((a8C)null).PayTMPay != null)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Mm0)f3L6Rd.PrintDailyRecords;
				}
			}
			finally
			{
				while (obj != null)
				{
					sy = sy;
					ez = (Ez0)sy.UserInfo;
					ez = ez;
				}
				continue;
			}
		}
		_ = (s7K2Ek)((i1D)null).PrintMonthlyRecords;
		do
		{
			hf08Tc = hf08Tc;
		}
		while (obj != null);
		if ((UIntPtr)xn05Ce.UserInfo == (UIntPtr)(nuint)0u)
		{
			y0D y0D = y0D;
			Ty5k0C ty5k0C = y0D.Width as Ty5k0C;
			ty5k0C = ty5k0C;
			_ = (Mm0)((Ag9)null).UserInfo;
			z3T obj13 = (z3T)ag.UserInfo;
			z3T z3T2 = z3T2;
			z3T2 = obj13;
			_ = (Wt9q7H)a8C.PayTMPay;
		}
		else
		{
			UIntPtr num4 = (UIntPtr)a8C.PayTMPay;
			UIntPtr num5 = (UIntPtr)((f1P6Lz)((f1P6Lz)null).Send_sms_to_customer).Send_sms_to_customer;
			UIntPtr num6 = (UIntPtr)s7K2Ek.ObjectDetectorSearchMode;
			uIntPtr = default(UIntPtr);
			checked
			{
				nuint num7 = unchecked((nuint)num5) + (unchecked(checked(unchecked((nuint)num6) - uIntPtr) / checked(uIntPtr + unchecked((nuint)(UIntPtr)f3L6Rd.PrintDailyRecords))) + unchecked((nuint)default(UIntPtr)));
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)num4) - (num7 + uIntPtr) + uIntPtr == 0 && unchecked((UIntPtr)f3L6Rd.PrintDailyRecords == (UIntPtr)(nuint)0u))
				{
					Ty5k0C ty5k0C = ty5k0C;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Ez0)f3L6Rd.PrintDailyRecords;
		}
		else
		{
			try
			{
				sy50Xx = (Sy50Xx)((Ag9)((s7K2Ek)(object)yg89Py.DBForFoodManagementConnectionString).ObjectDetectorScalingMode).UserInfo;
			}
			catch
			{
				while (obj != null)
				{
					_ = (_003CModule_003E)f1P6Lz.SupplierDailyRecord;
					_ = (Mt2)s7K2Ek.ObjectDetectorSearchMode;
					_ = (Mt2)sy.SupplierInfo;
					_ = (Ez0)mr7n6D.ObjectDetectorSearchMode;
					_ = (s7K2Ek)mr7n6D.SelectImageGetFrom;
				}
			}
		}
		do
		{
			try
			{
				_ = (Mr7n6D)xn05Ce.ObjectDetectorScalingMode;
			}
			finally
			{
				while (a8C.PayTMPay != null)
				{
					xn05Ce = xn05Ce;
				}
				continue;
			}
		}
		while (((Sy0)((Sy0)null).SuppliedRecord).UserInfo != null);
		sy50Xx = null;
		ez = ez;
		while (obj != null)
		{
			x6LFp = x6LFp;
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			x6LFp = null;
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (i1D)((i1D)i1D.PrintMonthlyRecords).PrintMonthlyRecords;
			}
		}
		else
		{
			Bs bs = bs;
			bs = bs;
		}
		try
		{
			do
			{
				_ = (_003CModule_003E)((i1D)(object)Yg89Py.Default).PrintMonthlyRecords;
				_ = (Rf7)((Mr7n6D)null).SelectImageGetFrom;
				_ = (s9.y6)a8C.PayTMPay;
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				ag = ag;
			}
			catch
			{
				try
				{
					_ = (m8K)((Mr7n6D)null).ObjectDetectorSearchMode;
				}
				catch
				{
					f1P6Lz = f1P6Lz;
					_ = (Ag9)((f3L6Rd)null).PrintDailyRecords;
				}
			}
			goto IL_0685;
		}
	}
}
