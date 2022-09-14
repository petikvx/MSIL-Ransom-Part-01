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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace HOAProject.My;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Availablelotdetailform m_Availablelotdetailform;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public AvailableLotform m_AvailableLotform;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public CustomerPurchaseRecordForm m_CustomerPurchaseRecordForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Customers m_Customers;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Highest_Salesperson_Rating m_Highest_Salesperson_Rating;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lowest_Salesperson_Rating m_Lowest_Salesperson_Rating;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Models m_Models;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Newest_Salesperson_Rating m_Newest_Salesperson_Rating;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public PurchaseLotform m_PurchaseLotform;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Salesperson_DetailForm m_Salesperson_DetailForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Salesperson_Ratings m_Salesperson_Ratings;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Salespersons m_Salespersons;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Subdivisions m_Subdivisions;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public WelcomePage m_WelcomePage;

		public Availablelotdetailform Availablelotdetailform
		{
			[DebuggerHidden]
			get
			{
				m_Availablelotdetailform = Create__Instance__(m_Availablelotdetailform);
				return m_Availablelotdetailform;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Availablelotdetailform)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Availablelotdetailform);
				}
			}
		}

		public AvailableLotform AvailableLotform
		{
			[DebuggerHidden]
			get
			{
				m_AvailableLotform = Create__Instance__(m_AvailableLotform);
				return m_AvailableLotform;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AvailableLotform)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_AvailableLotform);
				}
			}
		}

		public CustomerPurchaseRecordForm CustomerPurchaseRecordForm
		{
			[DebuggerHidden]
			get
			{
				m_CustomerPurchaseRecordForm = Create__Instance__(m_CustomerPurchaseRecordForm);
				return m_CustomerPurchaseRecordForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_CustomerPurchaseRecordForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_CustomerPurchaseRecordForm);
				}
			}
		}

		public Customers Customers
		{
			[DebuggerHidden]
			get
			{
				m_Customers = Create__Instance__(m_Customers);
				return m_Customers;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Customers)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Customers);
				}
			}
		}

		public Highest_Salesperson_Rating Highest_Salesperson_Rating
		{
			[DebuggerHidden]
			get
			{
				m_Highest_Salesperson_Rating = Create__Instance__(m_Highest_Salesperson_Rating);
				return m_Highest_Salesperson_Rating;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Highest_Salesperson_Rating)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Highest_Salesperson_Rating);
				}
			}
		}

		public Lowest_Salesperson_Rating Lowest_Salesperson_Rating
		{
			[DebuggerHidden]
			get
			{
				m_Lowest_Salesperson_Rating = Create__Instance__(m_Lowest_Salesperson_Rating);
				return m_Lowest_Salesperson_Rating;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Lowest_Salesperson_Rating)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Lowest_Salesperson_Rating);
				}
			}
		}

		public Models Models
		{
			[DebuggerHidden]
			get
			{
				m_Models = Create__Instance__(m_Models);
				return m_Models;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Models)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Models);
				}
			}
		}

		public Newest_Salesperson_Rating Newest_Salesperson_Rating
		{
			[DebuggerHidden]
			get
			{
				m_Newest_Salesperson_Rating = Create__Instance__(m_Newest_Salesperson_Rating);
				return m_Newest_Salesperson_Rating;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Newest_Salesperson_Rating)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Newest_Salesperson_Rating);
				}
			}
		}

		public PurchaseLotform PurchaseLotform
		{
			[DebuggerHidden]
			get
			{
				m_PurchaseLotform = Create__Instance__(m_PurchaseLotform);
				return m_PurchaseLotform;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_PurchaseLotform)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_PurchaseLotform);
				}
			}
		}

		public Salesperson_DetailForm Salesperson_DetailForm
		{
			[DebuggerHidden]
			get
			{
				m_Salesperson_DetailForm = Create__Instance__(m_Salesperson_DetailForm);
				return m_Salesperson_DetailForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Salesperson_DetailForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Salesperson_DetailForm);
				}
			}
		}

		public Salesperson_Ratings Salesperson_Ratings
		{
			[DebuggerHidden]
			get
			{
				m_Salesperson_Ratings = Create__Instance__(m_Salesperson_Ratings);
				return m_Salesperson_Ratings;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Salesperson_Ratings)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Salesperson_Ratings);
				}
			}
		}

		public Salespersons Salespersons
		{
			[DebuggerHidden]
			get
			{
				m_Salespersons = Create__Instance__(m_Salespersons);
				return m_Salespersons;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Salespersons)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Salespersons);
				}
			}
		}

		public Subdivisions Subdivisions
		{
			[DebuggerHidden]
			get
			{
				m_Subdivisions = Create__Instance__(m_Subdivisions);
				return m_Subdivisions;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Subdivisions)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Subdivisions);
				}
			}
		}

		public WelcomePage WelcomePage
		{
			[DebuggerHidden]
			get
			{
				m_WelcomePage = Create__Instance__(m_WelcomePage);
				return m_WelcomePage;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_WelcomePage)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_WelcomePage);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || ((Control)Instance).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
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
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			((Component)instance).Dispose();
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
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
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
