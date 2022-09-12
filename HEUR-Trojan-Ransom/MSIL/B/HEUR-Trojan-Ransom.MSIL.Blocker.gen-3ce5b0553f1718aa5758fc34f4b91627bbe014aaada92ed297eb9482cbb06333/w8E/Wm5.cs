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
using La50;
using Lg1;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Qo03;
using Yi2x;
using Yw2;
using b8ED;
using f0B;
using f2H;
using f2K3;
using m4K5;
using r4B;
using r4Z;
using s6Y;
using w7Y6;

namespace w8E;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Wm5
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class c4Q
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m9B m_frmBilling;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c7R m_frmBillingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o7A m_frmMain;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tb9 m_frmProcessingCost;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m2R m_frmProcessingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c7B m_frmProductDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pg6 m_frmPurchaseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d9N2 m_frmSalesDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qy5m m_frmSupplierDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dw54 m_frmTransportDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m1S6 m_frmWarehouseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g2M8 m_Login;

		public m9B frmBilling
		{
			[DebuggerHidden]
			get
			{
				m_frmBilling = t0C(m_frmBilling);
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
					c3M(ref m_frmBilling);
				}
			}
		}

		public c7R frmBillingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmBillingDetail = t0C(m_frmBillingDetail);
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
					c3M(ref m_frmBillingDetail);
				}
			}
		}

		public o7A frmMain
		{
			[DebuggerHidden]
			get
			{
				m_frmMain = t0C(m_frmMain);
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
					c3M(ref m_frmMain);
				}
			}
		}

		public Tb9 frmProcessingCost
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingCost = t0C(m_frmProcessingCost);
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
					c3M(ref m_frmProcessingCost);
				}
			}
		}

		public m2R frmProcessingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingDetail = t0C(m_frmProcessingDetail);
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
					c3M(ref m_frmProcessingDetail);
				}
			}
		}

		public c7B frmProductDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProductDetail = t0C(m_frmProductDetail);
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
					c3M(ref m_frmProductDetail);
				}
			}
		}

		public Pg6 frmPurchaseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmPurchaseDetail = t0C(m_frmPurchaseDetail);
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
					c3M(ref m_frmPurchaseDetail);
				}
			}
		}

		public d9N2 frmSalesDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSalesDetail = t0C(m_frmSalesDetail);
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
					c3M(ref m_frmSalesDetail);
				}
			}
		}

		public Qy5m frmSupplierDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSupplierDetail = t0C(m_frmSupplierDetail);
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
					c3M(ref m_frmSupplierDetail);
				}
			}
		}

		public Dw54 frmTransportDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmTransportDetail = t0C(m_frmTransportDetail);
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
					c3M(ref m_frmTransportDetail);
				}
			}
		}

		public m1S6 frmWarehouseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmWarehouseDetail = t0C(m_frmWarehouseDetail);
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
					c3M(ref m_frmWarehouseDetail);
				}
			}
		}

		public g2M8 Login
		{
			[DebuggerHidden]
			get
			{
				m_Login = t0C(m_Login);
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
					c3M(ref m_Login);
				}
			}
		}

		[DebuggerHidden]
		private static Qt1 t0C<Qt1>(Qt1 Am0) where Qt1 : Form, new()
		{
			if (Am0 == null || ((Control)Am0).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Qt1)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Qt1), null);
				try
				{
					return new Qt1();
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
					m_FormBeingCreated.Remove(typeof(Qt1));
				}
			}
			return Am0;
		}

		[DebuggerHidden]
		private void c3M<Xy4>(ref Xy4 r6X) where Xy4 : Form
		{
			((Component)r6X).Dispose();
			r6X = default(Xy4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public c4Q()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool De1(object Ef8)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Ef8));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Pm7()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type n1P()
		{
			return typeof(c4Q);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string j3X()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class d9A
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool o6J(object k2X)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(k2X));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Nx1()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type x6T()
		{
			return typeof(d9A);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Gn3()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Df6 k6L<Df6>(Df6 Qy3) where Df6 : new()
		{
			if (Qy3 == null)
			{
				return new Df6();
			}
			return Qy3;
		}

		[DebuggerHidden]
		private void Lp7<i9D>(ref i9D Az1)
		{
			Az1 = default(i9D);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public d9A()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class i1M<Hg2> where Hg2 : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Hg2 m_ThreadStaticValue;

		internal Hg2 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Hg2();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public i1M()
		{
		}
	}

	private static readonly i1M<x2K9> m_ComputerObjectProvider = new i1M<x2K9>();

	private static readonly i1M<Ap93> m_AppObjectProvider = new i1M<Ap93>();

	private static readonly i1M<User> m_UserObjectProvider = new i1M<User>();

	private static i1M<c4Q> m_MyFormsObjectProvider = new i1M<c4Q>();

	private static readonly i1M<d9A> m_MyWebServicesObjectProvider = new i1M<d9A>();

	[HelpKeyword("My.Computer")]
	internal static x2K9 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Ap93 Application
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
	internal static c4Q Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static d9A WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
