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
using Cd1t;
using Ci75;
using Es0;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Mn1k;
using Ri5n;
using Wa6;
using Wj6t;
using Wt27;
using Wz7;
using Xo8;
using Xs5;
using a9D;
using c4ZK;
using e6H;
using j3B;
using q8B;
using s1Y;
using t5D;
using x9E1;

namespace Ba50;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class n4NE
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Ld20
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ng67 m_frmBilling;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o8W m_frmBillingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t1P m_frmMain;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ws0 m_frmProcessingCost;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ma6 m_frmProcessingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z1J m_frmProductDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w5D m_frmPurchaseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ta8 m_frmSalesDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y9T m_frmSupplierDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c0B m_frmTransportDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Br2 m_frmWarehouseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Be5 m_Login;

		public Ng67 frmBilling
		{
			[DebuggerHidden]
			get
			{
				m_frmBilling = Wa5d(m_frmBilling);
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
					t0X2(ref m_frmBilling);
				}
			}
		}

		public o8W frmBillingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmBillingDetail = Wa5d(m_frmBillingDetail);
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
					t0X2(ref m_frmBillingDetail);
				}
			}
		}

		public t1P frmMain
		{
			[DebuggerHidden]
			get
			{
				m_frmMain = Wa5d(m_frmMain);
				return m_frmMain;
			}
			[DebuggerHidden]
			set
			{
				int[] int_ = c0B.int_0;
				int num = 0;
				while (true)
				{
					if (value != m_frmMain)
					{
						num = 2;
						while (true)
						{
							if (value != null)
							{
								switch (int_[536])
								{
								case 19612:
								case 19616:
									break;
								default:
									goto end_IL_0048;
								case 19617:
									throw new ArgumentException("Property can only be set to Nothing");
								case 19618:
									goto end_IL_0050;
								case 19611:
								case 19614:
									goto IL_0070;
								case 19613:
									return;
								}
								continue;
							}
							num = 1;
							goto IL_0070;
							IL_0070:
							t0X2(ref m_frmMain);
							return;
							continue;
							end_IL_0048:
							break;
						}
						continue;
					}
					num = 8;
					break;
					continue;
					end_IL_0050:
					break;
				}
				num = 3;
			}
		}

		public Ws0 frmProcessingCost
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingCost = Wa5d(m_frmProcessingCost);
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
					t0X2(ref m_frmProcessingCost);
					c0B.int_0[230] = (c0B.int_0[230] + c0B.int_0[261]) & 0xD0;
				}
			}
		}

		public Ma6 frmProcessingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingDetail = Wa5d(m_frmProcessingDetail);
				return m_frmProcessingDetail;
			}
			[DebuggerHidden]
			set
			{
				char[] char_ = Ta8.char_0;
				int num = 4;
				while (true)
				{
					if (value != m_frmProcessingDetail)
					{
						num = 0;
						while (true)
						{
							if (value == null)
							{
								switch (char_[210])
								{
								case '瞞':
								case '瞦':
									break;
								default:
									goto end_IL_0048;
								case '瞟':
									t0X2(ref m_frmProcessingDetail);
									return;
								case '瞣':
									goto end_IL_0050;
								case '瞠':
								case '瞤':
									goto IL_0075;
								case '瞡':
								case '瞥':
									return;
								}
								continue;
							}
							num = 6;
							goto IL_0075;
							IL_0075:
							throw new ArgumentException("Property can only be set to Nothing");
							continue;
							end_IL_0048:
							break;
						}
						continue;
					}
					num = 5;
					break;
					continue;
					end_IL_0050:
					break;
				}
				num = 3;
			}
		}

		public z1J frmProductDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProductDetail = Wa5d(m_frmProductDetail);
				return m_frmProductDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmProductDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					t0X2(ref m_frmProductDetail);
				}
			}
		}

		public w5D frmPurchaseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmPurchaseDetail = Wa5d(m_frmPurchaseDetail);
				return m_frmPurchaseDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmPurchaseDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					t0X2(ref m_frmPurchaseDetail);
				}
			}
		}

		public Ta8 frmSalesDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSalesDetail = Wa5d(m_frmSalesDetail);
				return m_frmSalesDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmSalesDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					t0X2(ref m_frmSalesDetail);
				}
			}
		}

		public y9T frmSupplierDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSupplierDetail = Wa5d(m_frmSupplierDetail);
				return m_frmSupplierDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmSupplierDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					t0X2(ref m_frmSupplierDetail);
				}
			}
		}

		public c0B frmTransportDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmTransportDetail = Wa5d(m_frmTransportDetail);
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
					t0X2(ref m_frmTransportDetail);
				}
			}
		}

		public Br2 frmWarehouseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmWarehouseDetail = Wa5d(m_frmWarehouseDetail);
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
					t0X2(ref m_frmWarehouseDetail);
				}
			}
		}

		public Be5 Login
		{
			[DebuggerHidden]
			get
			{
				m_Login = Wa5d(m_Login);
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
					t0X2(ref m_Login);
				}
			}
		}

		[DebuggerHidden]
		private static Lr3z Wa5d<Lr3z>(Lr3z x7R8) where Lr3z : Form, new()
		{
			if (x7R8 == null || ((Control)x7R8).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Lr3z)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Lr3z), null);
				try
				{
					return new Lr3z();
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
					m_FormBeingCreated.Remove(typeof(Lr3z));
				}
			}
			return x7R8;
		}

		[DebuggerHidden]
		private void t0X2<k5CF>(ref k5CF m7JF) where k5CF : Form
		{
			((Component)m7JF).Dispose();
			m7JF = default(k5CF);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ld20()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Ac76(object g5G8)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(g5G8));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Hc68()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type d3X1()
		{
			return typeof(Ld20);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string p2MA()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Qx5e
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool r8L4(object s9C2)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(s9C2));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Zj7k()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type j7RP()
		{
			return typeof(Qx5e);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Ax14()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static c1BS y8WZ<c1BS>(c1BS Bm5k) where c1BS : new()
		{
			if (Bm5k == null)
			{
				return new c1BS();
			}
			return Bm5k;
		}

		[DebuggerHidden]
		private void g1A6<Sd75>(ref Sd75 Cx5p)
		{
			Cx5p = default(Sd75);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qx5e()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Yc95<p4YM> where p4YM : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static p4YM m_ThreadStaticValue;

		internal p4YM GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new p4YM();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Yc95()
		{
		}
	}

	private static readonly Yc95<Tg0e> m_ComputerObjectProvider = new Yc95<Tg0e>();

	private static readonly Yc95<Cd0n> m_AppObjectProvider = new Yc95<Cd0n>();

	private static readonly Yc95<User> m_UserObjectProvider = new Yc95<User>();

	private static Yc95<Ld20> m_MyFormsObjectProvider = new Yc95<Ld20>();

	private static readonly Yc95<Qx5e> m_MyWebServicesObjectProvider = new Yc95<Qx5e>();

	[HelpKeyword("My.Computer")]
	internal static Tg0e Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Cd0n Application
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
	internal static Ld20 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Qx5e WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	static void Pp64()
	{
		nuint uIntPtr = (UIntPtr)j5Y1.Default;
		UIntPtr num = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tg0e tg0e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ws0 ws);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o8W o8W);
		if (checked(unchecked((nuint)num) + uIntPtr - uIntPtr) == 0)
		{
			nuint num2 = uIntPtr;
			nuint num3 = uIntPtr;
			UIntPtr num4 = (UIntPtr)j5Y1.Default;
			uIntPtr = default(UIntPtr);
			if (checked(num2 - unchecked(num3 / ((nuint)num4 / uIntPtr))) / (nuint)(UIntPtr)j5Y1.Default == 0)
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					n4NE n4NE2 = null;
					n4NE2 = n4NE2;
					o8W = null;
					o8W = null;
					_ = (n4NE)(object)j5Y1.Default;
				}
				else
				{
					_ = (w5D)(object)j5Y1.Default;
					_ = (Be5)(object)j5Y1.Default;
					Ws0 obj = (Ws0)(object)j5Y1.Default;
					ws = null;
					ws = obj;
				}
			}
			else
			{
				Tg0e obj2 = (Tg0e)(object)j5Y1.Default;
				tg0e = tg0e;
				tg0e = obj2;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		do
		{
			if (uIntPtr == 0)
			{
				_ = (t1P)(object)j5Y1.Default;
			}
			obj3 = obj3;
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Be5 be);
		do
		{
			be = be;
			be = be;
		}
		while (obj3 != null);
		while ((object)j5Y1.Default != null)
		{
		}
		be = be;
		try
		{
		}
		finally
		{
			try
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Ng67)(object)j5Y1.Default;
				}
				else
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
			}
			catch
			{
				_ = (Ja24)(object)j5Y1.Default;
			}
			goto IL_0156;
		}
		IL_0569:
		while (obj3 != null)
		{
			do
			{
				try
				{
					_ = (n4NE)(object)j5Y1.Default;
				}
				catch
				{
					_ = (Ta8)(object)j5Y1.Default;
					_ = (o8W)(object)j5Y1.Default;
					_ = (Ws0)(object)j5Y1.Default;
					n4NE n4NE2 = null;
				}
			}
			while ((object)j5Y1.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cd0n cd0n);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Br2 br);
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				do
				{
					br = br;
				}
				while ((object)j5Y1.Default != null);
			}
			else
			{
				while (obj3 != null)
				{
					br = br;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					cd0n = cd0n;
					be = (Be5)(object)j5Y1.Default;
					ws = null;
					_ = (y9T)(object)j5Y1.Default;
				}
				finally
				{
					_ = (y9T)(object)j5Y1.Default;
					goto end_IL_059c;
				}
				end_IL_059c:;
			}
			finally
			{
				try
				{
					_ = (t1P)(object)j5Y1.Default;
				}
				catch
				{
					br = null;
				}
				goto end_IL_059b;
			}
			end_IL_059b:;
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (w5D)(object)j5Y1.Default;
			_ = (Ws0)(object)j5Y1.Default;
			goto IL_064b;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ma6 ma);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gw13 gw);
		try
		{
			while (obj3 != null)
			{
				gw = (Gw13)(object)j5Y1.Default;
				cd0n = null;
				_ = (Ma6)(object)j5Y1.Default;
				ws = (Ws0)(object)j5Y1.Default;
			}
		}
		finally
		{
			ma = null;
			goto IL_064b;
		}
		IL_0770:
		do
		{
			_ = (Ng67)(object)j5Y1.Default;
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8NS k8NS);
		do
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u && checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)j5Y1.Default)) == 0)
			{
				_ = (Ma6)(object)j5Y1.Default;
				be = (Be5)(object)j5Y1.Default;
				k8NS = k8NS;
			}
		}
		while (obj3 != null);
		_ = (_003CModule_003E)(object)j5Y1.Default;
		gw = (Gw13)(object)j5Y1.Default;
		_ = (Tg0e)(object)j5Y1.Default;
		return;
		IL_0708:
		uIntPtr = default(UIntPtr);
		if (uIntPtr / checked(uIntPtr + uIntPtr) == 0)
		{
			do
			{
				tg0e = tg0e;
			}
			while ((object)j5Y1.Default != null || obj3 != null);
		}
		if (uIntPtr == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = j5Y1.Default;
			}
			finally
			{
				_ = (c0B)(object)j5Y1.Default;
				goto IL_0770;
			}
		}
		goto IL_0770;
		IL_0156:
		try
		{
			_ = (_003CModule_003E)(object)j5Y1.Default;
			z1J z1J = z1J;
		}
		catch
		{
			do
			{
				try
				{
					_ = (Cd0n)(object)j5Y1.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)j5Y1.Default;
				}
			}
			while (obj3 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y9T y9T);
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (n4NE)(object)j5Y1.Default;
					y9T obj10 = (y9T)(object)j5Y1.Default;
					y9T = y9T;
					y9T = obj10;
					_ = (c0B)(object)j5Y1.Default;
					ma = (Ma6)(object)j5Y1.Default;
					ma = null;
				}
				finally
				{
					br = (Br2)(object)j5Y1.Default;
					br = br;
					_ = (Ws0)(object)j5Y1.Default;
					be = (Be5)(object)j5Y1.Default;
					goto end_IL_01a0;
				}
				end_IL_01a0:;
			}
			catch
			{
				try
				{
					_ = (Tg0e)(object)j5Y1.Default;
					o8W = (o8W)(object)j5Y1.Default;
					_ = (b2H1)j5Y1.Default;
				}
				catch
				{
					_ = j5Y1.Default;
				}
			}
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u && (UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			_ = (n4NE)(object)j5Y1.Default;
		}
		if ((UIntPtr)j5Y1.Default != (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj3 != null)
				{
					_ = j5Y1.Default;
				}
			}
			catch
			{
				ma = ma;
			}
		}
		_ = (z1J)(object)j5Y1.Default;
		try
		{
			_ = (Ng67)(object)j5Y1.Default;
		}
		catch
		{
			try
			{
				do
				{
					be = (Be5)(object)j5Y1.Default;
				}
				while (obj3 != null);
			}
			catch
			{
				try
				{
					_ = (Ng67)(object)j5Y1.Default;
					goto end_IL_02cd;
				}
				catch
				{
					_ = j5Y1.Default;
					_ = j5Y1.Default;
					goto end_IL_02cd;
				}
				end_IL_02cd:;
			}
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (c0B)(object)j5Y1.Default;
				}
				finally
				{
					_ = (y9T)(object)j5Y1.Default;
					continue;
				}
			}
			while (obj3 != null);
		}
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out w5D w5D);
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0 && uIntPtr + unchecked((nuint)(UIntPtr)j5Y1.Default) == 0)
				{
					y9T = y9T;
					_ = (Ng67)(object)j5Y1.Default;
					k8NS obj17 = (k8NS)j5Y1.Default;
					k8NS = k8NS;
					k8NS = obj17;
					w5D = w5D;
					w5D = null;
				}
			}
			while ((object)j5Y1.Default != null);
			gw = gw;
			gw = null;
			w5D = w5D;
		}
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					cd0n = cd0n;
					cd0n = null;
				}
			}
			finally
			{
				ws = ws;
				goto end_IL_03a5;
			}
			end_IL_03a5:;
		}
		catch
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Ng67)(object)j5Y1.Default;
				}
			}
			while (obj3 != null);
		}
		do
		{
			_ = (c0B)(object)j5Y1.Default;
		}
		while (obj3 != null);
		try
		{
			while (obj3 != null)
			{
				do
				{
					_ = (k8NS)j5Y1.Default;
					ma = ma;
				}
				while ((object)j5Y1.Default != null);
			}
		}
		catch
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				k8NS = k8NS;
			}
			else
			{
				do
				{
					cd0n = null;
				}
				while (obj3 != null);
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Ng67)(object)j5Y1.Default;
			}
		}
		catch
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr != (UIntPtr)(nuint)0u)
				{
					_ = (k8NS)j5Y1.Default;
				}
				else
				{
					_ = (Ma6)(object)j5Y1.Default;
				}
			}
			while (obj3 != null);
		}
		_ = (y9T)(object)j5Y1.Default;
		try
		{
			do
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (o8W)(object)j5Y1.Default;
				}
			}
			while ((object)j5Y1.Default != null);
		}
		finally
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					gw = gw;
				}
				else
				{
					_ = (c0B)(object)j5Y1.Default;
				}
			}
			catch
			{
				try
				{
					y9T = (y9T)(object)j5Y1.Default;
				}
				catch
				{
					_ = (Ma6)(object)j5Y1.Default;
				}
			}
			goto IL_0569;
		}
		IL_06ab:
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (z1J)(object)j5Y1.Default;
			}
			else
			{
				try
				{
					_ = (Ja24)(object)j5Y1.Default;
					br = null;
				}
				catch
				{
					o8W = o8W;
				}
			}
			goto IL_0708;
		}
		try
		{
			try
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
			}
			finally
			{
				goto end_IL_06e9;
			}
			end_IL_06e9:;
		}
		finally
		{
			_ = (Ja24)(object)j5Y1.Default;
			goto IL_0708;
		}
		IL_064b:
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj3 != null)
				{
					_ = (Ng67)(object)j5Y1.Default;
				}
			}
			finally
			{
				Ta8 ta = (Ta8)(object)j5Y1.Default;
				ta = ta;
				goto IL_06ab;
			}
		}
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				b2H1 b2H = b2H;
				b2H = b2H;
			}
		}
		finally
		{
			_ = (Ng67)(object)j5Y1.Default;
			goto IL_06ab;
		}
	}

	static void j5DT()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c0B c0B);
		try
		{
			c0B = (c0B)(object)j5Y1.Default;
			c0B = c0B;
		}
		catch
		{
			do
			{
				c0B = c0B;
				obj = obj;
			}
			while (obj != null);
		}
		Cd0n cd0n = cd0n;
		cd0n = cd0n;
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w5D w5D);
		if (uIntPtr == 0)
		{
			nuint num = (nuint)(UIntPtr)j5Y1.Default / checked(uIntPtr + unchecked((nuint)(UIntPtr)j5Y1.Default));
			uIntPtr = default(UIntPtr);
			if (checked(num * uIntPtr) == 0)
			{
				try
				{
					_ = (o8W)(object)j5Y1.Default;
				}
				catch
				{
					_ = (c0B)(object)j5Y1.Default;
				}
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					Ta8 obj4 = (Ta8)(object)j5Y1.Default;
					Ta8 ta = ta;
					ta = obj4;
				}
				finally
				{
					_ = (Ja24)(object)j5Y1.Default;
					goto IL_00eb;
				}
			}
			while ((object)j5Y1.Default != null)
			{
				w5D = null;
				w5D = null;
			}
		}
		goto IL_00eb;
		IL_0320:
		t1P t1P = t1P;
		_ = (t1P)(object)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				Ng67 obj5 = (Ng67)(object)j5Y1.Default;
				ng = ng;
				ng = obj5;
			}
			else if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				c0B = null;
			}
		}
		try
		{
			_ = (Gw13)(object)j5Y1.Default;
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y9T y9T);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z1J z1J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4NE n4NE2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ja24 ja);
		checked
		{
			if (unchecked((nuint)(UIntPtr)j5Y1.Default / uIntPtr) + unchecked((nuint)(UIntPtr)j5Y1.Default) == 0)
			{
				while ((object)j5Y1.Default != null)
				{
					cd0n = cd0n;
					n4NE2 = n4NE2;
				}
			}
			else
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
				ng = ng;
				ja = null;
			}
			if (unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr))) + unchecked((nuint)default(UIntPtr)) == 0)
			{
				do
				{
					try
					{
						_ = (Ma6)(object)j5Y1.Default;
					}
					catch
					{
						_ = (o8W)(object)j5Y1.Default;
					}
				}
				while (obj != null);
			}
			else if (unchecked((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u))
			{
				try
				{
					Br2 br = br;
					br = null;
				}
				catch
				{
					_ = (y9T)(object)j5Y1.Default;
					y9T = y9T;
					_ = (Ma6)(object)j5Y1.Default;
				}
			}
			else if (unchecked((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u))
			{
				_003CModule_003E = _003CModule_003E;
			}
			else
			{
				z1J = z1J;
				z1J = z1J;
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while ((object)j5Y1.Default != null)
				{
					try
					{
						ng = (Ng67)(object)j5Y1.Default;
					}
					catch
					{
						_ = (w5D)(object)j5Y1.Default;
					}
				}
			}
			else
			{
				w5D = w5D;
			}
			try
			{
				t1P = t1P;
			}
			finally
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (_003CModule_003E)(object)j5Y1.Default;
					}
				}
				catch
				{
					n4NE2 = n4NE2;
				}
				goto IL_0509;
			}
		}
		IL_00eb:
		do
		{
			try
			{
				do
				{
					_ = (Br2)(object)j5Y1.Default;
				}
				while ((object)j5Y1.Default != null);
			}
			catch
			{
				do
				{
					_ = (y9T)(object)j5Y1.Default;
				}
				while (obj != null);
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tg0e tg0e);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = j5Y1.Default;
					Ja24 obj12 = (Ja24)(object)j5Y1.Default;
					ja = null;
					ja = obj12;
					Tg0e obj13 = (Tg0e)(object)j5Y1.Default;
					tg0e = tg0e;
					tg0e = obj13;
				}
				finally
				{
					Ma6 ma = ma;
					ma = ma;
					goto end_IL_0122;
				}
			}
			end_IL_0122:;
		}
		catch
		{
			try
			{
				y9T = y9T;
				y9T = y9T;
			}
			finally
			{
				_ = (w5D)(object)j5Y1.Default;
				goto end_IL_017c;
			}
			end_IL_017c:;
		}
		_ = (w5D)(object)j5Y1.Default;
		try
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Ta8)(object)j5Y1.Default;
					n4NE obj15 = (n4NE)(object)j5Y1.Default;
					n4NE2 = n4NE2;
					n4NE2 = obj15;
					_ = (c0B)(object)j5Y1.Default;
				}
				while (obj != null);
			}
			else
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
				}
				catch
				{
					Ws0 obj16 = (Ws0)(object)j5Y1.Default;
					Ws0 ws = ws;
					ws = obj16;
				}
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				do
				{
					_ = (Cd0n)(object)j5Y1.Default;
				}
				while (obj != null);
			}
		}
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				ja = null;
				t1P = t1P;
				t1P = t1P;
				_ = (n4NE)(object)j5Y1.Default;
				_ = (Gw13)(object)j5Y1.Default;
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Ma6 ma = (Ma6)(object)j5Y1.Default;
				}
			}
		}
		do
		{
			tg0e = (Tg0e)(object)j5Y1.Default;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Be5 be);
		if (uIntPtr == 0)
		{
			be = be;
			be = null;
		}
		while ((object)j5Y1.Default != null)
		{
			_ = (Gw13)(object)j5Y1.Default;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Ws0)(object)j5Y1.Default;
					be = be;
				}
				else
				{
					Ma6 ma = (Ma6)(object)j5Y1.Default;
				}
			}
			finally
			{
				while (obj != null)
				{
					_ = (z1J)(object)j5Y1.Default;
				}
				goto IL_0320;
			}
		}
		goto IL_0320;
		IL_0772:
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)j5Y1.Default != null)
			{
				UIntPtr num2 = (UIntPtr)j5Y1.Default;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num2) * uIntPtr == 0)
					{
						Ma6 ma = (Ma6)(object)j5Y1.Default;
					}
				}
			}
		}
		else if (checked(uIntPtr + uIntPtr) == 0)
		{
			if (uIntPtr == 0)
			{
				_ = (n4NE)(object)j5Y1.Default;
				_ = (z1J)(object)j5Y1.Default;
				_ = (w5D)(object)j5Y1.Default;
			}
			else
			{
				w5D = w5D;
			}
		}
		_ = (Ws0)(object)j5Y1.Default;
		b2H1 b2H = default(b2H1);
		if (uIntPtr == 0)
		{
			_ = (Ma6)(object)j5Y1.Default;
			return;
		}
		try
		{
			_ = (Cd0n)(object)j5Y1.Default;
			return;
		}
		catch
		{
			_ = (c0B)(object)j5Y1.Default;
			tg0e = null;
			be = be;
			w5D = w5D;
			return;
		}
		IL_0693:
		if (uIntPtr == 0)
		{
			try
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					be = be;
				}
				else
				{
					tg0e = null;
				}
			}
			catch
			{
				_ = (Br2)(object)j5Y1.Default;
				cd0n = cd0n;
				ng = null;
				_ = (Ws0)(object)j5Y1.Default;
			}
		}
		else
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Gw13)(object)j5Y1.Default;
				}
				else
				{
					_ = (z1J)(object)j5Y1.Default;
				}
			}
			catch
			{
				tg0e = (Tg0e)(object)j5Y1.Default;
			}
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			_ = (k8NS)j5Y1.Default;
		}
		t1P = t1P;
		try
		{
			try
			{
				try
				{
					n4NE2 = (n4NE)(object)j5Y1.Default;
				}
				finally
				{
					z1J = z1J;
					goto end_IL_072e;
				}
				end_IL_072e:;
			}
			finally
			{
				o8W obj22 = (o8W)(object)j5Y1.Default;
				o8W o8W = o8W;
				o8W = obj22;
				goto end_IL_072d;
			}
			end_IL_072d:;
		}
		finally
		{
			_ = (Ws0)(object)j5Y1.Default;
			goto IL_0772;
		}
		IL_0509:
		try
		{
			if (uIntPtr == 0)
			{
				w5D = (w5D)(object)j5Y1.Default;
			}
		}
		catch
		{
			_ = (Tg0e)(object)j5Y1.Default;
			_ = (_003CModule_003E)(object)j5Y1.Default;
			j5Y1 j5Y = j5Y;
			j5Y = j5Y;
		}
		try
		{
			do
			{
				try
				{
					_ = (Be5)(object)j5Y1.Default;
					_ = (Tg0e)(object)j5Y1.Default;
				}
				finally
				{
					_ = (t1P)(object)j5Y1.Default;
					_ = (o8W)(object)j5Y1.Default;
					_ = (o8W)(object)j5Y1.Default;
					_003CModule_003E = (_003CModule_003E)(object)j5Y1.Default;
					continue;
				}
			}
			while (obj != null);
		}
		catch
		{
			tg0e = tg0e;
		}
		try
		{
			if (uIntPtr / ((nuint)(UIntPtr)j5Y1.Default / unchecked((nuint)default(UIntPtr))) == 0)
			{
				_ = (n4NE)(object)j5Y1.Default;
				w5D = (w5D)(object)j5Y1.Default;
				t1P = t1P;
				be = null;
			}
			else
			{
				w5D = (w5D)(object)j5Y1.Default;
				w5D = w5D;
				Ws0 ws = null;
			}
		}
		catch
		{
			n4NE2 = (n4NE)(object)j5Y1.Default;
		}
		while (true)
		{
			if (obj != null)
			{
				_ = (Ja24)(object)j5Y1.Default;
			}
			else if (obj == null)
			{
				break;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				while (obj != null)
				{
					t1P = (t1P)(object)j5Y1.Default;
				}
			}
			finally
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
				ja = ja;
				_ = (Ma6)(object)j5Y1.Default;
				_ = (c0B)(object)j5Y1.Default;
				goto IL_0693;
			}
		}
		t1P = null;
		goto IL_0693;
	}
}
