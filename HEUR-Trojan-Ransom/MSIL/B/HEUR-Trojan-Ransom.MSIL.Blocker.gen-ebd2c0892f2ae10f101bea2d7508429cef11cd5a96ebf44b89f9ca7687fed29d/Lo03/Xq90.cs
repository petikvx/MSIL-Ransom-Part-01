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
using Bm4r;
using Cr4;
using Ds3;
using Kc9;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Sd9;
using Ti18;
using Yf06;
using Yn19;
using Yn6o;
using c9S;
using i1QX;
using k2CM;
using k3R;
using q9Z2;

namespace Lo03;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Xq90
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class b0JZ
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k2GS m_frmBilling;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cy1 m_frmBillingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c7G m_frmMain;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s5C m_frmProcessingCost;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ty3 m_frmProcessingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sd5 m_frmProductDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o1W m_frmPurchaseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q1J3 m_frmSalesDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q1C3 m_frmSupplierDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Es6d m_frmTransportDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cr17 m_frmWarehouseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f1D8 m_Login;

		public k2GS frmBilling
		{
			[DebuggerHidden]
			get
			{
				m_frmBilling = o5Z7(m_frmBilling);
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
					o1P4(ref m_frmBilling);
				}
			}
		}

		public Cy1 frmBillingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmBillingDetail = o5Z7(m_frmBillingDetail);
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
					o1P4(ref m_frmBillingDetail);
				}
			}
		}

		public c7G frmMain
		{
			[DebuggerHidden]
			get
			{
				m_frmMain = o5Z7(m_frmMain);
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
					o1P4(ref m_frmMain);
				}
			}
		}

		public s5C frmProcessingCost
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingCost = o5Z7(m_frmProcessingCost);
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
					o1P4(ref m_frmProcessingCost);
				}
			}
		}

		public Ty3 frmProcessingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingDetail = o5Z7(m_frmProcessingDetail);
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
					o1P4(ref m_frmProcessingDetail);
					o1W.char_0[371] = (char)((o1W.char_0[371] - s5C.int_0[362]) & 'O');
				}
			}
		}

		public Sd5 frmProductDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProductDetail = o5Z7(m_frmProductDetail);
				return m_frmProductDetail;
			}
			[DebuggerHidden]
			set
			{
				bool num = value == m_frmProductDetail;
				s5C.int_0[370] = (s5C.int_0[370] ^ o1W.char_0[537]) & 0xB9;
				if (!num)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					o1P4(ref m_frmProductDetail);
				}
			}
		}

		public o1W frmPurchaseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmPurchaseDetail = o5Z7(m_frmPurchaseDetail);
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
					o1P4(ref m_frmPurchaseDetail);
				}
			}
		}

		public q1J3 frmSalesDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSalesDetail = o5Z7(m_frmSalesDetail);
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
					o1P4(ref m_frmSalesDetail);
				}
			}
		}

		public q1C3 frmSupplierDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSupplierDetail = o5Z7(m_frmSupplierDetail);
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
					o1P4(ref m_frmSupplierDetail);
				}
			}
		}

		public Es6d frmTransportDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmTransportDetail = o5Z7(m_frmTransportDetail);
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
					o1P4(ref m_frmTransportDetail);
				}
			}
		}

		public Cr17 frmWarehouseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmWarehouseDetail = o5Z7(m_frmWarehouseDetail);
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
					o1P4(ref m_frmWarehouseDetail);
				}
			}
		}

		public f1D8 Login
		{
			[DebuggerHidden]
			get
			{
				m_Login = o5Z7(m_Login);
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
					o1P4(ref m_Login);
				}
			}
		}

		[DebuggerHidden]
		private static z5S6 o5Z7<z5S6>(z5S6 Xt2a) where z5S6 : Form, new()
		{
			if (Xt2a == null || ((Control)Xt2a).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(z5S6)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(z5S6), null);
				TargetInvocationException ex = default(TargetInvocationException);
				try
				{
					return new z5S6();
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					TargetInvocationException obj2 = obj as TargetInvocationException;
					s5C.int_0[273] = (s5C.int_0[273] ^ s5C.int_0[237]) & 0xAD;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
					if (obj2 == null)
					{
						result = 0;
					}
					else
					{
						ProjectData.SetProjectError((Exception)obj2);
						ex = obj2;
						result = ((ex.InnerException != null) ? 1 : 0);
					}
					return (byte)result != 0;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(z5S6));
				}
			}
			return Xt2a;
		}

		[DebuggerHidden]
		private void o1P4<Td39>(ref Td39 Qj81) where Td39 : Form
		{
			((Component)Qj81).Dispose();
			Qj81 = default(Td39);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public b0JZ()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Yg2o(object Hr7p)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Hr7p));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Wo21()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Ak0z()
		{
			return typeof(b0JZ);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string g9SA()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class o9X7
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Mr8a(object e2M7)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(e2M7));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Jg2y()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type Ba09()
		{
			return typeof(o9X7);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Zp34()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static q5AF Ts32<q5AF>(q5AF z1A4) where q5AF : new()
		{
			if (z1A4 == null)
			{
				return new q5AF();
			}
			return z1A4;
		}

		[DebuggerHidden]
		private void q7D9<Ks4b>(ref Ks4b q5CK)
		{
			q5CK = default(Ks4b);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public o9X7()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Lq47<i3Z0> where i3Z0 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static i3Z0 m_ThreadStaticValue;

		internal i3Z0 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new i3Z0();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Lq47()
		{
		}
	}

	private static readonly Lq47<Ea3q> m_ComputerObjectProvider = new Lq47<Ea3q>();

	private static readonly Lq47<g6EQ> m_AppObjectProvider = new Lq47<g6EQ>();

	private static readonly Lq47<User> m_UserObjectProvider = new Lq47<User>();

	private static Lq47<b0JZ> m_MyFormsObjectProvider = new Lq47<b0JZ>();

	private static readonly Lq47<o9X7> m_MyWebServicesObjectProvider = new Lq47<o9X7>();

	[HelpKeyword("My.Computer")]
	internal static Ea3q Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static g6EQ Application
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
	internal static b0JZ Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static o9X7 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
