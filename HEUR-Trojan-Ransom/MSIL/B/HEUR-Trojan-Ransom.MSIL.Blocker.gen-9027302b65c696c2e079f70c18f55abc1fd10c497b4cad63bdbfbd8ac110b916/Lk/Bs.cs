using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
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
using x6T;

namespace Lk;

[DesignerGenerated]
public class Bs : Form
{
	internal sealed class f9
	{
		internal IContainer icontainer_0;

		internal object object_0;

		internal object object_1;

		internal object object_2;

		internal object object_3;

		internal object object_4;

		internal f9()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct o8
	{
		internal object object_0;
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct o6
	{
		internal object object_0;

		internal object object_1;

		internal PictureBox pictureBox_0;
	}

	[AccessedThroughProperty("browseBarcode")]
	private OpenFileDialog _browseBarcode;

	private s9.y6.Jp jp_0 = new s9.y6.Jp();

	internal virtual object picPatmBarcode
	{
		get
		{
			return jp_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			jp_0.object_0 = objectValue;
		}
	}

	internal virtual OpenFileDialog browseBarcode
	{
		get
		{
			return _browseBarcode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_browseBarcode = value;
		}
	}

	internal virtual object PictureEdit1
	{
		get
		{
			return jp_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			jp_0.object_1 = objectValue;
		}
	}

	internal virtual object SimpleButton2
	{
		get
		{
			return jp_0.object_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			jp_0.object_2 = objectValue;
		}
	}

	public Bs()
	{
		((Form)this).add_Load((EventHandler)Hs);
		f1();
	}

	protected override void Bo(bool c6)
	{
		try
		{
			if (c6 && jp_0.icontainer_0 != null)
			{
				jp_0.icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c6);
		}
	}

	private void f1()
	{
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		object obj = new ComponentResourceManager(typeof(Bs));
		((ISupportInitialize)NewLateBinding.LateGet(picPatmBarcode, (Type)null, "Properties", new object[0], (string[])null, (Type[])null, (bool[])null)).BeginInit();
		((ISupportInitialize)NewLateBinding.LateGet(PictureEdit1, (Type)null, "Properties", new object[0], (string[])null, (Type[])null, (bool[])null)).BeginInit();
		((Control)this).SuspendLayout();
		NewLateBinding.LateSetComplex(picPatmBarcode, (Type)null, "Cursor", new object[1] { Cursors.get_Default() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(picPatmBarcode, (Type)null, "Location", new object[1]
		{
			new Point(0, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(picPatmBarcode, (Type)null, "Name", new object[1] { "picPatmBarcode" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(picPatmBarcode, (Type)null, "Properties", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ZoomAccelerationFactor", new object[1] { 1.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(picPatmBarcode, (Type)null, "Size", new object[1]
		{
			new Size(375, 449)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(picPatmBarcode, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(picPatmBarcode, (Type)null, "ToolTip", new object[1] { "Scan This Barcode By PayTM" }, (string[])null, (Type[])null, false, true);
		((FileDialog)browseBarcode).set_FileName("OpenFileDialog1");
		NewLateBinding.LateSetComplex(PictureEdit1, (Type)null, "Cursor", new object[1] { Cursors.get_Default() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(PictureEdit1, (Type)null, "EditValue", new object[1] { (obj as ComponentResourceManager).GetObject("PictureEdit1.EditValue") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(PictureEdit1, (Type)null, "Location", new object[1]
		{
			new Point(381, 90)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(PictureEdit1, (Type)null, "Name", new object[1] { "PictureEdit1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PictureEdit1, (Type)null, "Properties", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ZoomAccelerationFactor", new object[1] { 1.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(PictureEdit1, (Type)null, "Size", new object[1]
		{
			new Size(351, 235)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(PictureEdit1, (Type)null, "TabIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton2, (Type)null, "Location", new object[1]
		{
			new Point(381, 396)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton2, (Type)null, "Name", new object[1] { "SimpleButton2" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton2, (Type)null, "Size", new object[1]
		{
			new Size(351, 53)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton2, (Type)null, "TabIndex", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton2, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton2, (Type)null, "Text", new object[1] { "Paid" }, (string[])null, (Type[])null, false, true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(733, 449));
		((Control)this).get_Controls().Add((Control)SimpleButton2);
		((Control)this).get_Controls().Add((Control)PictureEdit1);
		((Control)this).get_Controls().Add((Control)picPatmBarcode);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("PayTMPay");
		((Form)this).set_Text("PayTMPay");
		((ISupportInitialize)NewLateBinding.LateGet(picPatmBarcode, (Type)null, "Properties", new object[0], (string[])null, (Type[])null, (bool[])null)).EndInit();
		((ISupportInitialize)NewLateBinding.LateGet(PictureEdit1, (Type)null, "Properties", new object[0], (string[])null, (Type[])null, (bool[])null)).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Hs(object sender, EventArgs e)
	{
		object obj = Application.get_StartupPath() + "\\paytm";
		NewLateBinding.LateSetComplex(picPatmBarcode, (Type)null, "Image", new object[1] { Image.FromFile(obj as string) }, (string[])null, (Type[])null, false, true);
	}

	private void g5(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)Wt9q7H.Forms.MainForm).Show();
	}

	static void j3()
	{
		//IL_0158: Expected O, but got I4
		//IL_02c9: Expected O, but got I4
		//IL_02fd: Expected O, but got I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected O, but got I4
		//IL_0440: Expected O, but got I4
		//IL_04dd: Expected O, but got I4
		//IL_058e: Expected O, but got I4
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got I4
		//IL_0886: Expected O, but got I4
		f3L6Rd obj = (f3L6Rd)((i1D)((a8C)((Sy0)((Ag9)null).UserInfo).SupplierDailyRecord).PayTMPay).PrintMonthlyRecords;
		i1D i1D = i1D;
		f3L6Rd f3L6Rd = (f3L6Rd)((s7K2Ek)i1D.PrintMonthlyRecords).ObjectDetectorScalingMode;
		f3L6Rd = obj;
		object obj2 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yg89Py yg89Py);
		while (true)
		{
			if (((Ag9)(object)((Yg89Py)((Sy0)null).SupplierInfo).Fast_food_managementConnectionString).UserInfo != null)
			{
				yg89Py = yg89Py;
				yg89Py = null;
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy0 sy);
		try
		{
			do
			{
				try
				{
					sy = null;
					_ = (x6LFp1)sy.UserInfo;
				}
				finally
				{
					continue;
				}
			}
			while (obj2 != null);
		}
		catch
		{
			_ = (s4C8Py)((f3L6Rd)null).PrintDailyRecords;
			_ = (Hf08Tc)((f1P6Lz)null).SuppliedRecord;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7K2Ek s7K2Ek);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a8C a8C);
		try
		{
			s7K2Ek = null;
			_ = (Hf08Tc)((Sy0)s7K2Ek.ObjectDetectorSearchMode).SuppliedRecord;
			_ = (Bs)((i1D)null).PrintMonthlyRecords;
			a8C = null;
			a8C = a8C;
		}
		finally
		{
			s9.y6 y = y;
			y = null;
			goto IL_0122;
		}
		IL_02e0:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ez0 ez);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		UIntPtr num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1P6Lz f1P6Lz);
		do
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				y0D = y0D;
				if (!(y0D.Width is UIntPtr))
				{
					ez = (Ez0)((Xn05Ce)null).UserInfo;
				}
			}
		}
		while (f1P6Lz.SuppliedRecord != null);
		try
		{
			try
			{
				object obj4 = y0D.Width;
				object obj5 = ((obj4 is UIntPtr) ? obj4 : null);
				num = default(UIntPtr);
				nuint num2 = num;
				num = default(UIntPtr);
				_003F val = checked(obj5 + num2 * num);
				num = default(UIntPtr);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag9 ag);
				if ((int)checked(val * num) == 0)
				{
					_ = (Mt2)s7K2Ek.ObjectDetectorSearchMode;
					ag = ag;
					_ = (Mt2)((Xn05Ce)ag.UserInfo).ObjectDetectorSearchMode;
				}
				else
				{
					_ = (m8K)((Ag9)ag.UserInfo).UserInfo;
				}
			}
			finally
			{
				_ = (Sy50Xx)((f3L6Rd)null).PrintDailyRecords;
				goto end_IL_02f2;
			}
			end_IL_02f2:;
		}
		catch
		{
		}
		if (num == 0)
		{
			_ = (Ez0)(object)Yg89Py.Default;
			_ = (i1D)((Xn05Ce)null).ObjectDetectorSearchMode;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b4 b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mr7n6D mr7n6D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rf7 rf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mm0 mm);
		checked
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num * num * unchecked((nuint)(UIntPtr)((i1D)sy.SupplierDailyRecord).PrintMonthlyRecords) == 0)
				{
					_ = (Mt2)f3L6Rd.PrintDailyRecords;
				}
				else
				{
					try
					{
						y0D = y0D;
						_ = (Yg89Py)(y0D.Width as f3L6Rd).PrintDailyRecords;
						_ = (Sy0)((Ag9)i1D.PrintMonthlyRecords).UserInfo;
					}
					catch
					{
						_ = y0D.Width is i7Z8Et;
					}
				}
			}
			else
			{
				_ = (Ez0)((i1D)((Sy0)null).SuppliedRecord).PrintMonthlyRecords;
			}
			while (obj2 != null)
			{
				try
				{
					_ = (Mt2)((s7K2Ek)null).ObjectDetectorScalingMode;
				}
				finally
				{
					try
					{
						f1P6Lz = null;
					}
					finally
					{
						b = default(b4);
						continue;
					}
				}
			}
			while (((Xn05Ce)sy.SuppliedRecord).ObjectDetectorScalingMode != null)
			{
				if (num == 0)
				{
					mr7n6D = mr7n6D;
					_ = (Sy0)mr7n6D.ObjectDetectorSearchMode;
					_ = (Ty5k0C)((Mr7n6D)null).SelectImageGetFrom;
					mm = null;
					_ = (y0D)f1P6Lz.SupplierDailyRecord;
				}
				else
				{
					do
					{
						_ = (m8K)((Sy0)(y0D.Width as Mr7n6D).UserInfo).SupplierInfo;
					}
					while (obj2 != null);
				}
			}
			do
			{
				try
				{
					_ = (s9.y6)mr7n6D.UserInfo;
					_ = (z3T)i1D.PrintMonthlyRecords;
					_ = (Sy50Xx)mr7n6D.ObjectDetectorScalingMode;
				}
				catch
				{
					do
					{
						_ = (Mm0)f1P6Lz.SuppliedRecord;
					}
					while (obj2 != null);
				}
			}
			while (obj2 != null);
			if (num == 0)
			{
				rf = null;
				rf = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wt9q7H wt9q7H);
		if ((UIntPtr)i1D.PrintMonthlyRecords == (UIntPtr)(nuint)0u)
		{
			object obj9 = ((y0D)null).Width;
			if ((int)(((obj9 is UIntPtr) ? obj9 : null) / num) == 0)
			{
				_ = (Yg89Py)f3L6Rd.PrintDailyRecords;
			}
		}
		else if ((UIntPtr)((Yg89Py)((f1P6Lz)null).Send_sms_to_customer).Fast_food_managementConnectionString == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Rf7)f3L6Rd.PrintDailyRecords;
				xn05Ce = xn05Ce;
				xn05Ce = null;
				_ = ((y0D)a8C.PayTMPay).Width is Hf08Tc;
				_ = (i1D)((Sy0)(object)yg89Py.Fast_food_managementConnectionString).SupplierInfo;
			}
			while (obj2 != null);
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				wt9q7H = null;
				wt9q7H = wt9q7H;
			}
		}
		mr7n6D = mr7n6D;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hf08Tc hf08Tc);
		do
		{
			try
			{
				hf08Tc = hf08Tc;
				hf08Tc = hf08Tc;
				hf08Tc = null;
			}
			catch
			{
				do
				{
					_ = (y0D)((a8C)null).PayTMPay;
				}
				while (obj2 != null);
			}
		}
		while (obj2 != null);
		try
		{
			if (num == 0)
			{
				do
				{
					_ = (x6LFp1)a8C.PayTMPay;
				}
				while (((Ag9)null).UserInfo != null);
			}
			else
			{
				while (obj2 != null)
				{
					_ = (b4)i1D.PrintMonthlyRecords;
					b = b;
					_ = (e2.y6)xn05Ce.UserInfo;
				}
			}
		}
		finally
		{
			do
			{
				s7K2Ek = s7K2Ek;
				xn05Ce = null;
				rf = rf;
				_ = (i7Z8Et)(object)yg89Py.Fast_food_managementConnectionString;
			}
			while (obj2 != null || ((a8C)((Ag9)null).UserInfo).PayTMPay != null);
			goto IL_070f;
		}
		IL_070f:
		try
		{
			do
			{
				y0D = (y0D)xn05Ce.UserInfo;
			}
			while (obj2 != null);
		}
		catch
		{
			mm = null;
			_ = (Yg89Py)((Ag9)null).UserInfo;
			Se60Di se60Di = (Se60Di)((Mr7n6D)null).ObjectDetectorSearchMode;
			se60Di = se60Di;
		}
		if ((UIntPtr)((i1D)null).PrintMonthlyRecords == (UIntPtr)(nuint)0u && num == 0)
		{
			do
			{
				i1D = i1D;
			}
			while (obj2 != null);
		}
		while (((a8C)null).PayTMPay != null)
		{
			while (obj2 != null)
			{
				try
				{
					_ = (s7K2Ek)((Mr7n6D)f3L6Rd.PrintDailyRecords).UserInfo;
				}
				finally
				{
					a8C = a8C;
					continue;
				}
			}
		}
		while (obj2 != null)
		{
			_ = (Xn05Ce)((a8C)null).PayTMPay;
		}
		_ = (e2.y6)((Mr7n6D)((s7K2Ek)null).ObjectDetectorSearchMode).ObjectDetectorSearchMode;
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) == 0)
			{
				s7K2Ek = null;
			}
			else
			{
				while (obj2 != null)
				{
					try
					{
						ez = ez;
					}
					catch
					{
						_ = (a8C)((f1P6Lz)null).SupplierDailyRecord;
					}
				}
			}
			num = default(UIntPtr);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Ag9)mr7n6D.UserInfo;
					rf = rf;
					_ = (a8C)((f3L6Rd)null).PrintDailyRecords;
					_ = ((y0D)(object)((Yg89Py)((Mr7n6D)s7K2Ek.ObjectDetectorScalingMode).ObjectDetectorSearchMode).DBForFoodManagementConnectionString).Width is Ez0;
				}
				else
				{
					_ = (_003CModule_003E)((Ag9)null).UserInfo;
				}
			}
			catch
			{
				_ = (m8K)((a8C)((i1D)f3L6Rd.PrintDailyRecords).PrintMonthlyRecords).PayTMPay;
			}
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out m8K m8K);
			do
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Mr7n6D)((s7K2Ek)((a8C)s7K2Ek.ObjectDetectorSearchMode).PayTMPay).ObjectDetectorSearchMode;
					s7K2Ek = null;
					_ = (Sy50Xx)mr7n6D.ObjectDetectorScalingMode;
					m8K = m8K;
					m8K = m8K;
				}
			}
			while (sy.SuppliedRecord != null);
		}
		wt9q7H = wt9q7H;
		s4C8Py s4C8Py = (s4C8Py)a8C.PayTMPay;
		s4C8Py = s4C8Py;
		return;
		IL_0122:
		while (s7K2Ek.ObjectDetectorSearchMode != null)
		{
			_ = (a8C)((i1D)null).PrintMonthlyRecords;
		}
		while (((y0D)i1D.PrintMonthlyRecords).Width is object)
		{
			mm = mm;
			mm = mm;
		}
		num = (UIntPtr)i1D.PrintMonthlyRecords;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			mm = (Mm0)((i1D)null).PrintMonthlyRecords;
		}
		else
		{
			s7K2Ek = s7K2Ek;
		}
		if ((UIntPtr)((f1P6Lz)null).Send_sms_to_customer == (UIntPtr)(nuint)0u)
		{
			while (((f1P6Lz)null).Send_sms_to_customer != null)
			{
			}
		}
		e2.y6 y2 = default(e2.y6);
		y2 = default(e2.y6);
		f1P6Lz = f1P6Lz;
		if ((UIntPtr)((Xn05Ce)f1P6Lz.SupplierDailyRecord).ObjectDetectorScalingMode == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)((f1P6Lz)null).Send_sms_to_customer;
					f3L6Rd = f3L6Rd;
					ez = ez;
					ez = ez;
				}
			}
			catch
			{
				try
				{
					_ = (Sy0)a8C.PayTMPay;
				}
				finally
				{
					b = default(b4);
					goto end_IL_0232;
				}
				end_IL_0232:;
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Wt9q7H)((f3L6Rd)((Mr7n6D)sy.SuppliedRecord).SelectImageGetFrom).PrintDailyRecords;
			}
			finally
			{
				_ = (x6LFp1)((s7K2Ek)null).ObjectDetectorScalingMode;
				goto IL_02e0;
			}
		}
		goto IL_02e0;
	}

	static void x6()
	{
		//IL_0229: Expected O, but got I4
		//IL_025f: Expected O, but got I4
		//IL_04de: Expected O, but got I4
		//IL_0584: Expected O, but got I4
		//IL_0596: Expected O, but got I4
		a8C a8C = a8C;
		UIntPtr num = (UIntPtr)a8C.PayTMPay;
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		nuint num2 = uIntPtr;
		Sy0 sy = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag9 ag);
		object obj3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f3L6Rd f3L6Rd);
		f1P6Lz f1P6Lz;
		i1D i1D;
		checked
		{
			if (unchecked((nuint)num) * (num2 + unchecked((nuint)(UIntPtr)sy.SupplierDailyRecord)) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) + uIntPtr == 0)
				{
					try
					{
						xn05Ce = null;
						_ = (Mm0)xn05Ce.UserInfo;
					}
					catch
					{
						ag = null;
						_ = (Ty5k0C)ag.UserInfo;
					}
				}
			}
			_ = (f3L6Rd)ag.UserInfo;
			do
			{
				try
				{
					e2.y6 y = (e2.y6)((a8C)null).PayTMPay;
					y = default(e2.y6);
				}
				catch
				{
					f3L6Rd = null;
					m8K m8K = (m8K)(object)((Yg89Py)f3L6Rd.PrintDailyRecords).DBForFoodManagementConnectionString;
					m8K = m8K;
				}
				finally
				{
					ag = (Ag9)((f1P6Lz)null).Send_sms_to_customer;
					obj3 = null;
					continue;
				}
			}
			while (obj3 != null);
			try
			{
				_ = (s7K2Ek)a8C.PayTMPay;
			}
			finally
			{
				i1D = (i1D)sy.SupplierInfo;
				f1P6Lz = (f1P6Lz)((f1P6Lz)((f1P6Lz)i1D.PrintMonthlyRecords).Send_sms_to_customer).Send_sms_to_customer;
				_ = (Se60Di)f1P6Lz.SuppliedRecord;
				goto IL_0171;
			}
		}
		IL_0430:
		Mm0 mm = mm;
		Ty5k0C ty5k0C = ty5k0C;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mt2 mt);
		checked
		{
			if (unchecked((nuint)(UIntPtr)i1D.PrintMonthlyRecords) - uIntPtr == 0)
			{
				try
				{
					mt = mt;
					mt = mt;
				}
				catch
				{
					_ = (e2.y6)((f1P6Lz)null).SupplierDailyRecord;
					_ = (x6LFp1)xn05Ce.UserInfo;
					_ = (Sy0)f1P6Lz.SupplierDailyRecord;
				}
				finally
				{
					try
					{
						_ = (b4)xn05Ce.UserInfo;
						Mr7n6D mr7n6D = mr7n6D;
						mr7n6D = mr7n6D;
					}
					catch
					{
						f3L6Rd = f3L6Rd;
						ag = ag;
						_ = (s7K2Ek)(((y0D)((Mr7n6D)null).ObjectDetectorSearchMode).Width as f3L6Rd).PrintDailyRecords;
					}
					goto IL_04f1;
				}
			}
			goto IL_04f1;
		}
		IL_0171:
		if (uIntPtr == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Se60Di se60Di);
			while (true)
			{
				if (obj3 != null)
				{
					se60Di = se60Di;
					se60Di = se60Di;
				}
				else if (obj3 == null)
				{
					break;
				}
			}
			goto IL_01c1;
		}
		try
		{
			if (uIntPtr == 0)
			{
				s4C8Py s4C8Py = null;
				s4C8Py = s4C8Py;
			}
		}
		finally
		{
			Hf08Tc hf08Tc = hf08Tc;
			hf08Tc = hf08Tc;
			goto IL_01c1;
		}
		IL_04f1:
		mt = mt;
		z3T z3T;
		if ((UIntPtr)ag.UserInfo == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				mt = mt;
				_ = (f1P6Lz)xn05Ce.ObjectDetectorSearchMode;
				z3T = z3T;
			}
			else
			{
				do
				{
					_ = (a8C)((Ag9)null).UserInfo;
				}
				while (obj3 != null);
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (x6LFp1)((a8C)null).PayTMPay;
		}
		y0D y0D;
		if ((UIntPtr)f3L6Rd.PrintDailyRecords == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Yg89Py yg89Py);
			while (obj3 != null)
			{
				try
				{
					_ = ((y0D)null).Width is Mr7n6D;
				}
				catch
				{
					i1D = y0D.Width as i1D;
					_ = (y0D)(object)((Yg89Py)null).DBForFoodManagementConnectionString;
					yg89Py = yg89Py;
					_ = (Ag9)(object)yg89Py.Fast_food_managementConnectionString;
				}
			}
		}
		else if ((UIntPtr)xn05Ce.ObjectDetectorScalingMode == (UIntPtr)(nuint)0u)
		{
			_ = (m8K)i1D.PrintMonthlyRecords;
		}
		else
		{
			_ = (f3L6Rd)a8C.PayTMPay;
		}
		sy = null;
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				do
				{
					z3T = z3T;
				}
				while (obj3 != null);
			}
		}
		return;
		IL_01c1:
		checked
		{
			if ((unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)xn05Ce.ObjectDetectorScalingMode)) * unchecked((nuint)(UIntPtr)((Sy0)null).SupplierDailyRecord) != 0)
			{
				while (true)
				{
					if (obj3 != null)
					{
						_ = (Sy0)a8C.PayTMPay;
					}
					else if (obj3 == null)
					{
						break;
					}
				}
			}
			mm = null;
			mm = mm;
			y0D = null;
			_ = (Ez0)(y0D.Width as f1P6Lz).SuppliedRecord;
			_ = (z3T)((f1P6Lz)null).SupplierDailyRecord;
			do
			{
				_ = ((y0D)((f1P6Lz)((Xn05Ce)null).UserInfo).SupplierDailyRecord).Width is i1D;
			}
			while (((f3L6Rd)null).PrintDailyRecords != null);
			z3T obj7 = (z3T)f1P6Lz.SupplierDailyRecord;
			z3T = (z3T)a8C.PayTMPay;
			z3T = obj7;
			_ = (x6LFp1)a8C.PayTMPay;
			uIntPtr = default(UIntPtr);
		}
		if (uIntPtr == 0)
		{
			if ((UIntPtr)Yg89Py.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)ag.UserInfo == (UIntPtr)(nuint)0u)
				{
					ag = ag;
				}
				else
				{
					_ = (x6LFp1)sy.UserInfo;
					b4 b = (b4)sy.SupplierDailyRecord;
					b = b;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Yg89Py)a8C.PayTMPay;
					_ = (m8K)((i1D)i1D.PrintMonthlyRecords).PrintMonthlyRecords;
					_ = (Bs)(object)Yg89Py.Default;
					_ = (Sy50Xx)((i1D)a8C.PayTMPay).PrintMonthlyRecords;
				}
			}
		}
		while (obj3 != null)
		{
			_ = (Sy50Xx)sy.SuppliedRecord;
		}
		_ = (y0D)((s7K2Ek)null).ObjectDetectorScalingMode;
		while (obj3 != null)
		{
			_003CModule_003E _003CModule_003E = (_003CModule_003E)f1P6Lz.SuppliedRecord;
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - unchecked((nuint)(UIntPtr)sy.SupplierDailyRecord)) == 0)
			{
				if ((UIntPtr)((f1P6Lz)null).SuppliedRecord == (UIntPtr)(nuint)0u)
				{
					_ = (b4)((Ag9)null).UserInfo;
				}
			}
			else
			{
				try
				{
					_ = (Rf7)xn05Ce.ObjectDetectorSearchMode;
				}
				catch
				{
					b4 b = default(b4);
				}
			}
		}
		finally
		{
			while (obj3 != null)
			{
				do
				{
					ty5k0C = ty5k0C;
					ty5k0C = ty5k0C;
				}
				while (obj3 != null);
			}
			goto IL_0430;
		}
	}
}
