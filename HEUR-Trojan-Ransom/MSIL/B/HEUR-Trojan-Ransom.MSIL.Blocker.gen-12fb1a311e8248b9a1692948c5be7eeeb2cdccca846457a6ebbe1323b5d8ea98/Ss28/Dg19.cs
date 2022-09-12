using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bz5f;
using Ca2z;
using Gj16;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Xs4;
using Yz5;
using a3S0;
using a7A;
using c9P;
using d3TQ;
using d7WN;
using d8L;
using e5M3;
using g8J;
using j6N2;
using k7R;
using q4PZ;
using s6N8;
using w0WN;
using x5PX;

namespace Ss28;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Dg19
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Ts1n
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f5R4 m_frmBilling;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zn1b m_frmBillingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hi84 m_frmMain;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sf06 m_frmProcessingCost;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x4N6 m_frmProcessingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k4C9 m_frmProductDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gn76 m_frmPurchaseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g9Z m_frmSalesDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a9X m_frmSupplierDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w0A m_frmTransportDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w1H m_frmWarehouseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p9B m_Login;

		public f5R4 frmBilling
		{
			[DebuggerHidden]
			get
			{
				m_frmBilling = Dm70(m_frmBilling);
				return m_frmBilling;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmBilling)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Hs75(ref m_frmBilling);
				}
			}
		}

		public Zn1b frmBillingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmBillingDetail = Dm70(m_frmBillingDetail);
				return m_frmBillingDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmBillingDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Hs75(ref m_frmBillingDetail);
				}
			}
		}

		public Hi84 frmMain
		{
			[DebuggerHidden]
			get
			{
				m_frmMain = Dm70(m_frmMain);
				return m_frmMain;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmMain)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Hs75(ref m_frmMain);
					Hi84.char_0[580] = (char)((Hi84.char_0[580] | Hi84.char_0[591]) & 'c');
				}
			}
		}

		public Sf06 frmProcessingCost
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingCost = Dm70(m_frmProcessingCost);
				return m_frmProcessingCost;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmProcessingCost)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Hs75(ref m_frmProcessingCost);
					Hi84.char_0[586] = (char)(Hi84.char_0[586] & Hi84.char_0[226] & 'Õ');
				}
			}
		}

		public x4N6 frmProcessingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingDetail = Dm70(m_frmProcessingDetail);
				return m_frmProcessingDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmProcessingDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Hs75(ref m_frmProcessingDetail);
				}
			}
		}

		public k4C9 frmProductDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProductDetail = Dm70(m_frmProductDetail);
				return m_frmProductDetail;
			}
			[DebuggerHidden]
			set
			{
				bool num = value == m_frmProductDetail;
				Tf67.byte_0[83] = (byte)((Tf67.byte_0[83] | Tf67.byte_0[120]) & 0x4E);
				if (!num)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Hs75(ref m_frmProductDetail);
				}
			}
		}

		public Gn76 frmPurchaseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmPurchaseDetail = Dm70(m_frmPurchaseDetail);
				return m_frmPurchaseDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmPurchaseDetail)
				{
					bool num = value != null;
					Hi84.char_0[357] = (char)((Hi84.char_0[357] ^ Hi84.char_0[96]) & '\u0016');
					if (num)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Hs75(ref m_frmPurchaseDetail);
				}
			}
		}

		public g9Z frmSalesDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSalesDetail = Dm70(m_frmSalesDetail);
				return m_frmSalesDetail;
			}
			[DebuggerHidden]
			set
			{
				bool num = value == m_frmSalesDetail;
				Hi84.char_0[446] = (char)(Hi84.char_0[446] & Hi84.char_0[20] & '\u0002');
				if (!num)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Hs75(ref m_frmSalesDetail);
				}
			}
		}

		public a9X frmSupplierDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSupplierDetail = Dm70(m_frmSupplierDetail);
				return m_frmSupplierDetail;
			}
			[DebuggerHidden]
			set
			{
				bool num = value == m_frmSupplierDetail;
				Tf67.byte_0[14] = (byte)(Tf67.byte_0[14] & Tf67.byte_0[136] & 0x2B);
				if (!num)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Hs75(ref m_frmSupplierDetail);
				}
			}
		}

		public w0A frmTransportDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmTransportDetail = Dm70(m_frmTransportDetail);
				return m_frmTransportDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmTransportDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Hs75(ref m_frmTransportDetail);
				}
			}
		}

		public w1H frmWarehouseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmWarehouseDetail = Dm70(m_frmWarehouseDetail);
				return m_frmWarehouseDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmWarehouseDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Hs75(ref m_frmWarehouseDetail);
				}
			}
		}

		public p9B Login
		{
			[DebuggerHidden]
			get
			{
				m_Login = Dm70(m_Login);
				return m_Login;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Login)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Hs75(ref m_Login);
				}
			}
		}

		[DebuggerHidden]
		private static y8AN Dm70<y8AN>(y8AN Cf0y) where y8AN : Form, new()
		{
			y8AN val;
			if (Cf0y == null || ((Control)Cf0y).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(y8AN)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(y8AN), null);
				try
				{
					val = new y8AN();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError((Exception)ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(y8AN));
				}
			}
			else
			{
				val = Cf0y;
			}
			y8AN result = val;
			Hi84.char_0[120] = (char)((Hi84.char_0[120] - Hi84.char_0[394]) & '\f');
			return result;
		}

		[DebuggerHidden]
		private void Hs75<Qz30>(ref Qz30 b8HR) where Qz30 : Form
		{
			((Component)b8HR).Dispose();
			b8HR = default(Qz30);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Ts1n()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool o1YF(object Ca4c)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Ca4c));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Jn81()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Jj9y()
		{
			return typeof(Ts1n);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string i3W5()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Kb81
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool t4KJ(object j2L5)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(j2L5));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Hz4p()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type n7PH()
		{
			return typeof(Kb81);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string b7BK()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static y5K7 Ai60<y5K7>(y5K7 i5DR) where y5K7 : new()
		{
			bool num = i5DR == null;
			Hi84.char_0[357] = (char)((Hi84.char_0[357] + Tf67.byte_0[92]) & '\n');
			if (num)
			{
				return new y5K7();
			}
			return i5DR;
		}

		[DebuggerHidden]
		private void Ao48<Fx5r>(ref Fx5r Kg85)
		{
			Kg85 = default(Fx5r);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kb81()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class n0WP<y8GJ> where y8GJ : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static y8GJ m_ThreadStaticValue;

		internal y8GJ GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new y8GJ();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public n0WP()
		{
		}
	}

	private static readonly n0WP<i5NX> m_ComputerObjectProvider = new n0WP<i5NX>();

	private static readonly n0WP<Pg2c> m_AppObjectProvider = new n0WP<Pg2c>();

	private static readonly n0WP<User> m_UserObjectProvider = new n0WP<User>();

	private static n0WP<Ts1n> m_MyFormsObjectProvider = new n0WP<Ts1n>();

	private static readonly n0WP<Kb81> m_MyWebServicesObjectProvider = new n0WP<Kb81>();

	[HelpKeyword("My.Computer")]
	internal static i5NX Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Pg2c Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Ts1n Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Kb81 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	static void r0GD()
	{
		nuint uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gn76 gn);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				Dg19 obj = (Dg19)(object)o0E3.Default;
				Dg19 dg = dg;
				dg = obj;
			}
			catch
			{
				gn = null;
				gn = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		while ((object)o0E3.Default != null)
		{
			while (true)
			{
				obj3 = o0E3.Default;
				if (obj3 == null)
				{
					break;
				}
				while ((object)o0E3.Default != null)
				{
					_ = (Et0)o0E3.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1H w1H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x4N6 x4N);
		try
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					w1H = w1H;
					w1H = w1H;
				}
				else
				{
					_ = (w0A)(object)o0E3.Default;
					_ = (w8W)o0E3.Default;
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					x4N = (x4N6)(object)o0E3.Default;
					x4N = x4N;
				}
				goto end_IL_0074;
			}
			end_IL_0074:;
		}
		finally
		{
			UIntPtr num = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(unchecked((nuint)num) - uIntPtr) == 0)
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
			}
			else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (f5R4)(object)o0E3.Default;
			}
			goto IL_0116;
		}
		IL_0231:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f5R4 f5R);
		try
		{
			do
			{
				if (uIntPtr == 0)
				{
					f5R4 obj4 = (f5R4)(object)o0E3.Default;
					f5R = f5R;
					f5R = obj4;
				}
			}
			while ((object)o0E3.Default != null);
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out p9B p9B);
			while ((object)o0E3.Default != null)
			{
				nuint num2 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num2 / uIntPtr == 0)
				{
					p9B = p9B;
					p9B = p9B;
				}
			}
		}
		Hi84 hi = (Hi84)(object)o0E3.Default;
		k0WR k0WR = k0WR;
		_ = (Et0)o0E3.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (k0WR)(object)o0E3.Default;
			_ = (Tf67)(object)o0E3.Default;
			_ = (a9X)(object)o0E3.Default;
			Dg19 dg = (Dg19)(object)o0E3.Default;
		}
		_003CModule_003E _003CModule_003E = null;
		_003CModule_003E = _003CModule_003E;
		_ = (Dg19)(object)o0E3.Default;
		_ = (Sf06)(object)o0E3.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				w1H = null;
				a9X obj6 = (a9X)(object)o0E3.Default;
				a9X a9X = a9X;
				a9X = obj6;
			}
			finally
			{
				_ = (Et0)o0E3.Default;
				goto IL_0378;
			}
		}
		if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
		{
		}
		goto IL_0378;
		IL_0378:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			w1H = w1H;
		}
		try
		{
			do
			{
				_ = (a9X)(object)o0E3.Default;
				i5NX i5NX = null;
				i5NX = i5NX;
				_ = (_003CModule_003E)(object)o0E3.Default;
			}
			while (obj3 != null);
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Gn76)(object)o0E3.Default;
				k4C9 obj7 = (k4C9)(object)o0E3.Default;
				k4C9 k4C = k4C;
				k4C = obj7;
			}
		}
		_ = (a9X)(object)o0E3.Default;
		while ((object)o0E3.Default != null)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					w1H = null;
				}
				else
				{
					_ = (Sf06)(object)o0E3.Default;
				}
			}
			catch
			{
				_ = o0E3.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o0E3 o0E);
		while (obj3 != null)
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					p9B p9B = (p9B)(object)o0E3.Default;
				}
				finally
				{
					_ = (Pg2c)(object)o0E3.Default;
					k0WR = (k0WR)(object)o0E3.Default;
					continue;
				}
			}
			do
			{
				o0E = o0E;
				o0E = null;
			}
			while ((object)o0E3.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		while (obj3 != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					k4C9 k4C = (k4C9)(object)o0E3.Default;
				}
				continue;
			}
			try
			{
				zn1b = zn1b;
				_ = (w8W)o0E3.Default;
			}
			catch
			{
				_ = (Et0)o0E3.Default;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			Dg19 dg = (Dg19)(object)o0E3.Default;
			goto IL_0531;
		}
		try
		{
			do
			{
				k0WR = k0WR;
			}
			while (obj3 != null);
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr * uIntPtr) == 0)
			{
				_ = (w1H)(object)o0E3.Default;
			}
			goto IL_0531;
		}
		IL_0531:
		if (uIntPtr == 0)
		{
			try
			{
				while (obj3 != null)
				{
					_ = (Hi84)(object)o0E3.Default;
				}
			}
			catch
			{
				w8W w8W = default(w8W);
			}
		}
		else if (uIntPtr == 0)
		{
			try
			{
				o0E = o0E;
			}
			catch
			{
				f5R = f5R;
				x4N = x4N;
				x4N = null;
			}
		}
		else
		{
			try
			{
				gn = gn;
			}
			catch
			{
				_ = (Gn76)(object)o0E3.Default;
			}
		}
		try
		{
			_ = (Pg2c)(object)o0E3.Default;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				x4N = null;
			}
			goto IL_05d0;
		}
		IL_0116:
		try
		{
			_ = (Sf06)(object)o0E3.Default;
		}
		catch
		{
			_ = (i5NX)(object)o0E3.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tf67 tf);
		do
		{
			try
			{
				Tf67 obj15 = (Tf67)(object)o0E3.Default;
				tf = tf;
				tf = obj15;
			}
			finally
			{
				_ = (Gn76)(object)o0E3.Default;
				continue;
			}
		}
		while (obj3 != null);
		Pg2c pg2c = pg2c;
		pg2c = pg2c;
		checked
		{
			if (uIntPtr - unchecked((nuint)default(UIntPtr)) == 0)
			{
				while ((object)o0E3.Default != null)
				{
					do
					{
						_ = (Pg2c)(object)o0E3.Default;
					}
					while (obj3 != null);
				}
			}
			else
			{
				do
				{
					try
					{
						pg2c = pg2c;
					}
					catch
					{
						Zn1b obj16 = (Zn1b)(object)o0E3.Default;
						zn1b = zn1b;
						zn1b = obj16;
					}
				}
				while (obj3 != null);
			}
			try
			{
				while (obj3 != null)
				{
					pg2c = null;
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					w0A w0A = (w0A)(object)o0E3.Default;
					w0A = w0A;
					k0WR = null;
					k0WR = k0WR;
					g9Z g9Z = g9Z;
					g9Z = g9Z;
					_ = (Hi84)(object)o0E3.Default;
				}
				goto IL_0231;
			}
		}
		IL_05d0:
		hi = hi;
		while (obj3 != null)
		{
			do
			{
				if ((UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
					continue;
				}
				_ = (k4C9)(object)o0E3.Default;
				tf = (Tf67)(object)o0E3.Default;
				_ = (Gn76)(object)o0E3.Default;
			}
			while (obj3 != null);
		}
		if (checked(uIntPtr * uIntPtr) == 0)
		{
			_ = (i5NX)(object)o0E3.Default;
			g9Z g9Z = (g9Z)(object)o0E3.Default;
			o0E = o0E;
		}
	}

	static void n4G6()
	{
		k0WR k0WR = null;
		k0WR = k0WR;
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg2c pg2c);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			Tf67 tf = tf;
			tf = tf;
		}
		else
		{
			while ((object)o0E3.Default != null)
			{
				try
				{
					pg2c = null;
					pg2c = pg2c;
				}
				catch
				{
					_ = (Hi84)(object)o0E3.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf06 sf);
		try
		{
			try
			{
				_ = (k0WR)(object)o0E3.Default;
			}
			catch
			{
				_ = (p9B)(object)o0E3.Default;
			}
		}
		catch
		{
			try
			{
				_ = (p9B)(object)o0E3.Default;
				i5NX i5NX = i5NX;
				i5NX = i5NX;
			}
			finally
			{
				sf = null;
				sf = sf;
				goto end_IL_0076;
			}
			end_IL_0076:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9B p9B);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (a9X)(object)o0E3.Default;
				_ = (k0WR)(object)o0E3.Default;
				p9B = (p9B)(object)o0E3.Default;
				p9B = p9B;
			}
			catch
			{
				p9B = p9B;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gn76 gn);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			k4C9 k4C = k4C;
			k4C = k4C;
			w0A w0A = w0A;
			w0A = w0A;
			gn = gn;
			gn = null;
			_ = (w8W)o0E3.Default;
		}
		object obj5 = null;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					gn = (Gn76)(object)o0E3.Default;
					a9X a9X = null;
					a9X = a9X;
					_ = o0E3.Default;
				}
				catch
				{
					sf = sf;
				}
			}
		}
		else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (w0A)(object)o0E3.Default;
			}
			while ((object)o0E3.Default != null);
		}
		do
		{
			if ((UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
			{
				_ = (Gn76)(object)o0E3.Default;
				_ = (_003CModule_003E)(object)o0E3.Default;
				continue;
			}
			try
			{
				_ = (Et0)o0E3.Default;
			}
			catch
			{
				f5R4 f5R = null;
				f5R = f5R;
			}
		}
		while (obj5 != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			f5R4 f5R = (f5R4)(object)o0E3.Default;
		}
		else if (uIntPtr == 0)
		{
			nuint num = uIntPtr;
			uIntPtr = default(UIntPtr);
			nuint num2 = unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)default(UIntPtr)) + uIntPtr));
			nuint num3 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num * (num2 * (num3 * uIntPtr))) == 0)
			{
				_ = (Sf06)(object)o0E3.Default;
			}
			else
			{
				_ = (a9X)(object)o0E3.Default;
				_ = (x4N6)(object)o0E3.Default;
				_ = (i5NX)(object)o0E3.Default;
				_ = (w0A)(object)o0E3.Default;
			}
		}
		_ = (Et0)o0E3.Default;
		_ = (Hi84)(object)o0E3.Default;
		try
		{
			try
			{
				_ = (i5NX)(object)o0E3.Default;
			}
			finally
			{
				p9B = p9B;
				goto end_IL_02b3;
			}
			end_IL_02b3:;
		}
		finally
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (f5R4)(object)o0E3.Default;
			}
			goto IL_030a;
		}
		IL_0693:
		while ((object)o0E3.Default != null)
		{
			try
			{
				if ((nuint)(UIntPtr)o0E3.Default / uIntPtr == 0)
				{
					k0WR = (k0WR)(object)o0E3.Default;
					k4C9 k4C = null;
					_ = (x4N6)(object)o0E3.Default;
				}
			}
			catch
			{
				_ = (a9X)(object)o0E3.Default;
			}
		}
		sf = sf;
		_ = (Gn76)(object)o0E3.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Et0)o0E3.Default;
			Et0 et = (Et0)o0E3.Default;
			pg2c = pg2c;
			k0WR = k0WR;
		}
		else
		{
			i5NX i5NX = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g9Z g9Z);
		try
		{
			try
			{
				_ = (Tf67)(object)o0E3.Default;
			}
			catch
			{
				g9Z = g9Z;
			}
			finally
			{
				_ = (Sf06)(object)o0E3.Default;
				goto end_IL_06f3;
			}
			end_IL_06f3:;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				g9Z = g9Z;
			}
			else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				Zn1b zn1b = zn1b;
				sf = (Sf06)(object)o0E3.Default;
			}
			goto IL_075c;
		}
		IL_030a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o0E3 o0E);
		checked
		{
			while (obj5 != null)
			{
				if (uIntPtr - unchecked((nuint)(UIntPtr)o0E3.Default) != 0)
				{
					while (obj5 != null)
					{
						_ = (x4N6)(object)o0E3.Default;
					}
				}
			}
			while ((object)o0E3.Default != null)
			{
				_ = o0E3.Default;
			}
			if (uIntPtr == 0)
			{
				try
				{
					_ = (w8W)o0E3.Default;
				}
				catch
				{
					_ = (k0WR)(object)o0E3.Default;
				}
				finally
				{
					do
					{
						_ = (w1H)(object)o0E3.Default;
					}
					while (obj5 != null);
					goto IL_038a;
				}
			}
			do
			{
				o0E = null;
				o0E = o0E;
				_ = (x4N6)(object)o0E3.Default;
				f5R4 f5R = null;
			}
			while ((object)o0E3.Default != null);
			goto IL_038a;
		}
		IL_075c:
		pg2c = (Pg2c)(object)o0E3.Default;
		_ = (_003CModule_003E)(object)o0E3.Default;
		g9Z = null;
		_ = (w1H)(object)o0E3.Default;
		if (uIntPtr != (UIntPtr)(nuint)0u)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1H w1H);
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				o0E = o0E;
			}
			return;
		}
		catch
		{
			while (obj5 != null)
			{
				w1H = w1H;
			}
			return;
		}
		IL_038a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x4N6 x4N);
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Sf06)(object)o0E3.Default;
					Dg19 dg = dg;
					dg = dg;
				}
			}
			finally
			{
				_ = (p9B)(object)o0E3.Default;
				goto end_IL_038b;
			}
			end_IL_038b:;
		}
		catch
		{
			x4N = x4N;
			x4N = null;
			_ = (Dg19)(object)o0E3.Default;
			_ = (_003CModule_003E)(object)o0E3.Default;
			_ = (Et0)o0E3.Default;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				i5NX i5NX = null;
				x4N = null;
				p9B = p9B;
			}
			else
			{
				do
				{
					_ = (Tf67)(object)o0E3.Default;
				}
				while (obj5 != null);
			}
		}
		else
		{
			try
			{
				_ = o0E3.Default;
			}
			catch
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Pg2c)(object)o0E3.Default;
				}
				else
				{
					g9Z = g9Z;
					g9Z = null;
				}
			}
		}
		checked
		{
			w8W w8W;
			if (uIntPtr == unchecked((UIntPtr)(nuint)0u))
			{
				do
				{
					nuint num4 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)o0E3.Default);
					uIntPtr = default(UIntPtr);
					if (num4 + unchecked(uIntPtr / uIntPtr) == 0)
					{
						_ = (Tf67)(object)o0E3.Default;
					}
				}
				while (obj5 != null);
			}
			else
			{
				do
				{
					try
					{
						w8W = (w8W)o0E3.Default;
						w8W = w8W;
					}
					catch
					{
						sf = sf;
					}
				}
				while (obj5 != null);
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0 && uIntPtr - uIntPtr == 0)
			{
				x4N = x4N;
			}
			if (unchecked((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u))
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = o0E3.Default;
					gn = gn;
					g9Z = (g9Z)(object)o0E3.Default;
					_ = (Et0)o0E3.Default;
				}
				else
				{
					nuint num5 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num5 + uIntPtr == 0)
					{
						_ = (w8W)o0E3.Default;
					}
				}
			}
			try
			{
				do
				{
					Et0 et = default(Et0);
					gn = null;
				}
				while (obj5 != null || obj5 != null);
			}
			catch
			{
				if (uIntPtr == 0 && uIntPtr * unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
				{
					w0A w0A = (w0A)(object)o0E3.Default;
				}
			}
			if (uIntPtr == 0)
			{
				try
				{
					_ = (w8W)o0E3.Default;
					_ = (k0WR)(object)o0E3.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
			}
			_ = (a9X)(object)o0E3.Default;
			w1H = w1H;
			w1H = w1H;
			w8W = (w8W)o0E3.Default;
			_ = (Et0)o0E3.Default;
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					g9Z = null;
				}
				finally
				{
					_ = (w1H)(object)o0E3.Default;
					goto IL_0693;
				}
			}
			goto IL_0693;
		}
	}

	static void x7B2()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hi84 hi);
		UIntPtr uIntPtr;
		do
		{
			uIntPtr = (UIntPtr)o0E3.Default;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) + uIntPtr != 0)
				{
					hi = hi;
					hi = null;
					_ = (Et0)o0E3.Default;
				}
				else if (unchecked((nuint)(UIntPtr)o0E3.Default) - unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
				{
					_ = (w8W)o0E3.Default;
				}
			}
		}
		while ((object)o0E3.Default != null);
		_ = (x4N6)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9X a9X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5NX i5NX);
		try
		{
			_ = (a9X)(object)o0E3.Default;
		}
		catch
		{
			try
			{
				_ = (Pg2c)(object)o0E3.Default;
				_ = (Pg2c)(object)o0E3.Default;
			}
			finally
			{
				try
				{
					a9X = a9X;
					a9X = a9X;
				}
				catch
				{
					_ = (Tf67)(object)o0E3.Default;
					i5NX = (i5NX)(object)o0E3.Default;
					i5NX = null;
				}
				goto end_IL_008f;
			}
			end_IL_008f:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tf67 tf);
		try
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				tf = tf;
				tf = tf;
			}
		}
		catch
		{
			do
			{
				_ = (a9X)(object)o0E3.Default;
				obj3 = obj3;
			}
			while (obj3 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g9Z g9Z);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf06 sf);
		if (uIntPtr == 0)
		{
			try
			{
				sf = null;
				sf = null;
			}
			catch
			{
				_ = (a9X)(object)o0E3.Default;
			}
			finally
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (i5NX)(object)o0E3.Default;
					_ = (_003CModule_003E)(object)o0E3.Default;
					k4C9 k4C = k4C;
					k4C = null;
					g9Z obj6 = (g9Z)(object)o0E3.Default;
					g9Z = (g9Z)(object)o0E3.Default;
					g9Z = obj6;
				}
				else
				{
					zn1b = (Zn1b)(object)o0E3.Default;
					zn1b = zn1b;
				}
				goto IL_01a6;
			}
		}
		goto IL_01a6;
		IL_058d:
		p9B p9B = p9B;
		p9B = null;
		try
		{
			_ = (k0WR)(object)o0E3.Default;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (k0WR)(object)o0E3.Default;
				}
				catch
				{
					i5NX = null;
				}
			}
			else
			{
				tf = tf;
			}
			goto IL_05cc;
		}
		IL_04f5:
		while (obj3 != null)
		{
			i5NX = i5NX;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8W w8W);
		try
		{
			x4N6 x4N = (x4N6)(object)o0E3.Default;
			g9Z = (g9Z)(object)o0E3.Default;
			w8W = w8W;
			w8W = w8W;
			_ = (p9B)(object)o0E3.Default;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					zn1b = zn1b;
					hi = null;
					a9X = a9X;
					i5NX = (i5NX)(object)o0E3.Default;
				}
			}
			else
			{
				try
				{
					_ = (Et0)o0E3.Default;
				}
				catch
				{
					_ = (Hi84)(object)o0E3.Default;
				}
			}
			goto IL_058d;
		}
		IL_0310:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out x4N6 x4N);
				try
				{
					x4N = x4N;
					x4N = x4N;
				}
				catch
				{
					i5NX = null;
					x4N = x4N;
					_ = (Gn76)(object)o0E3.Default;
				}
			}
			else
			{
				do
				{
					_ = (Hi84)(object)o0E3.Default;
					_ = (k4C9)(object)o0E3.Default;
					_ = (Hi84)(object)o0E3.Default;
					o0E3 o0E = null;
					o0E = o0E;
				}
				while (obj3 != null);
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w0A w0A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gn76 gn);
		checked
		{
			if (uIntPtr * (uIntPtr - uIntPtr) == 0)
			{
				try
				{
					if (uIntPtr * unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (Tf67)(object)o0E3.Default;
					}
				}
				finally
				{
					try
					{
						w0A = w0A;
					}
					catch
					{
						gn = (Gn76)(object)o0E3.Default;
						gn = gn;
					}
					goto IL_03ef;
				}
			}
			goto IL_03ef;
		}
		IL_05cc:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k0WR k0WR);
		checked
		{
			if (uIntPtr + unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
			{
				nuint num = uIntPtr * unchecked((nuint)(UIntPtr)o0E3.Default);
				uIntPtr = default(UIntPtr);
				if (unchecked(num / uIntPtr) * unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
				{
					_ = (x4N6)(object)o0E3.Default;
					_ = (a9X)(object)o0E3.Default;
					_ = (Pg2c)(object)o0E3.Default;
				}
				else
				{
					k0WR = (k0WR)(object)o0E3.Default;
				}
			}
			else
			{
				k0WR = k0WR;
			}
			try
			{
				f5R4 f5R = f5R;
				f5R = f5R;
				zn1b = null;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					do
					{
						sf = (Sf06)(object)o0E3.Default;
					}
					while ((object)o0E3.Default != null);
				}
				else
				{
					while (obj3 != null)
					{
						hi = hi;
					}
				}
			}
			tf = (Tf67)(object)o0E3.Default;
			Pg2c pg2c = pg2c;
			pg2c = pg2c;
			hi = null;
			while (obj3 != null)
			{
				try
				{
				}
				finally
				{
					_ = (Pg2c)(object)o0E3.Default;
					continue;
				}
			}
			try
			{
			}
			catch
			{
				w8W = w8W;
				_ = (k4C9)(object)o0E3.Default;
				gn = (Gn76)(object)o0E3.Default;
				k0WR = k0WR;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && (UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				g9Z = g9Z;
			}
			catch
			{
				p9B = (p9B)(object)o0E3.Default;
			}
		}
		k0WR = k0WR;
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
			while ((object)o0E3.Default != null)
			{
				do
				{
					_ = (p9B)(object)o0E3.Default;
				}
				while (obj3 != null);
			}
		}
		try
		{
			try
			{
				_ = (Dg19)(object)o0E3.Default;
			}
			finally
			{
				gn = gn;
				goto end_IL_0773;
			}
			end_IL_0773:;
		}
		catch
		{
			try
			{
				do
				{
					g9Z = (g9Z)(object)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
			}
			catch
			{
				try
				{
					_ = (w8W)o0E3.Default;
					goto end_IL_07ab;
				}
				finally
				{
					_ = (p9B)(object)o0E3.Default;
					goto end_IL_07ab;
				}
				end_IL_07ab:;
			}
		}
		_ = (i5NX)(object)o0E3.Default;
		return;
		IL_01a6:
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Pg2c)(object)o0E3.Default;
				_ = (a9X)(object)o0E3.Default;
			}
			else
			{
				try
				{
					_ = (p9B)(object)o0E3.Default;
				}
				catch
				{
					_ = (Tf67)(object)o0E3.Default;
					sf = sf;
					_ = (i5NX)(object)o0E3.Default;
				}
			}
		}
		_ = (Gn76)(object)o0E3.Default;
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			while (obj3 != null)
			{
				_ = (w1H)(object)o0E3.Default;
				_ = (w1H)(object)o0E3.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
		do
		{
			Et0 obj17 = (Et0)o0E3.Default;
			et = et;
			et = obj17;
		}
		while (obj3 != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			UIntPtr num2 = (UIntPtr)o0E3.Default;
			uIntPtr = default(UIntPtr);
			if ((nuint)num2 / uIntPtr == 0)
			{
				_ = (p9B)(object)o0E3.Default;
				_ = (x4N6)(object)o0E3.Default;
			}
			else
			{
				while (obj3 != null)
				{
					k4C9 k4C = null;
				}
			}
		}
		if (uIntPtr == 0)
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					_ = (w0A)(object)o0E3.Default;
				}
			}
			goto IL_0310;
		}
		try
		{
			_ = (k0WR)(object)o0E3.Default;
		}
		catch
		{
			w0A = w0A;
			w0A = w0A;
		}
		finally
		{
			try
			{
				_ = (Dg19)(object)o0E3.Default;
			}
			catch
			{
				sf = (Sf06)(object)o0E3.Default;
			}
			goto IL_0310;
		}
		IL_03ef:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (g9Z)(object)o0E3.Default;
				}
				catch
				{
					a9X = (a9X)(object)o0E3.Default;
					o0E3 o0E = null;
					zn1b = (Zn1b)(object)o0E3.Default;
				}
			}
			while ((object)o0E3.Default != null);
		}
		_ = (k0WR)(object)o0E3.Default;
		_ = (Dg19)(object)o0E3.Default;
		UIntPtr num3 = (UIntPtr)o0E3.Default;
		UIntPtr num4 = uIntPtr;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num3) * (unchecked((nuint)num4) * uIntPtr) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					try
					{
						_ = (g9Z)(object)o0E3.Default;
					}
					finally
					{
						k0WR = k0WR;
						k0WR = k0WR;
						goto IL_04f5;
					}
				}
				goto IL_04f5;
			}
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
				else
				{
					_ = (Dg19)(object)o0E3.Default;
				}
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (x4N6)(object)o0E3.Default;
				}
				else
				{
					_ = (Hi84)(object)o0E3.Default;
				}
				goto IL_04f5;
			}
		}
	}
}
