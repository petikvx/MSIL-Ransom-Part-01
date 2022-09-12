using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;

namespace LivePortfolio.My;

[HideModuleName]
[StandardModule]
internal sealed class MyWpfExtension
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Window", "Create__Instance__", "Dispose__Instance__", "My.MyWpfExtenstionModule.Windows")]
	internal sealed class MyWindows
	{
		[ThreadStatic]
		private static Hashtable s_WindowBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public AssetsWindow m_AssetsWindow;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bartleby m_Bartleby;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public DividendsWindow m_DividendsWindow;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public MainWindow m_MainWindow;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public PortFolioWindow m_PortFolioWindow;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public RefreshDataDialogue m_RefreshDataDialogue;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public SettingsWindow m_SettingsWindow;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public TransactionsWindow m_TransactionsWindow;

		public AssetsWindow AssetsWindow
		{
			[DebuggerHidden]
			get
			{
				m_AssetsWindow = Create__Instance__(m_AssetsWindow);
				return m_AssetsWindow;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AssetsWindow)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_AssetsWindow);
				}
			}
		}

		public Bartleby Bartleby
		{
			[DebuggerHidden]
			get
			{
				m_Bartleby = Create__Instance__(m_Bartleby);
				return m_Bartleby;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Bartleby)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Bartleby);
				}
			}
		}

		public DividendsWindow DividendsWindow
		{
			[DebuggerHidden]
			get
			{
				m_DividendsWindow = Create__Instance__(m_DividendsWindow);
				return m_DividendsWindow;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_DividendsWindow)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_DividendsWindow);
				}
			}
		}

		public MainWindow MainWindow
		{
			[DebuggerHidden]
			get
			{
				m_MainWindow = Create__Instance__(m_MainWindow);
				return m_MainWindow;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_MainWindow)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_MainWindow);
				}
			}
		}

		public PortFolioWindow PortFolioWindow
		{
			[DebuggerHidden]
			get
			{
				m_PortFolioWindow = Create__Instance__(m_PortFolioWindow);
				return m_PortFolioWindow;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_PortFolioWindow)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_PortFolioWindow);
				}
			}
		}

		public RefreshDataDialogue RefreshDataDialogue
		{
			[DebuggerHidden]
			get
			{
				m_RefreshDataDialogue = Create__Instance__(m_RefreshDataDialogue);
				return m_RefreshDataDialogue;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_RefreshDataDialogue)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_RefreshDataDialogue);
				}
			}
		}

		public SettingsWindow SettingsWindow
		{
			[DebuggerHidden]
			get
			{
				m_SettingsWindow = Create__Instance__(m_SettingsWindow);
				return m_SettingsWindow;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_SettingsWindow)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_SettingsWindow);
				}
			}
		}

		public TransactionsWindow TransactionsWindow
		{
			[DebuggerHidden]
			get
			{
				m_TransactionsWindow = Create__Instance__(m_TransactionsWindow);
				return m_TransactionsWindow;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_TransactionsWindow)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_TransactionsWindow);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Window, new()
		{
			if (Instance == null)
			{
				if (s_WindowBeingCreated != null)
				{
					if (s_WindowBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException("The window cannot be accessed via My.Windows from the Window constructor.");
					}
				}
				else
				{
					s_WindowBeingCreated = new Hashtable();
				}
				s_WindowBeingCreated.Add(typeof(T), null);
				return new T();
			}
			return Instance;
		}

		[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Window
		{
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWindows()
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

		[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyWindows);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	private static MyProject.ThreadSafeObjectProvider<Computer> s_Computer = new MyProject.ThreadSafeObjectProvider<Computer>();

	private static MyProject.ThreadSafeObjectProvider<User> s_User = new MyProject.ThreadSafeObjectProvider<User>();

	private static MyProject.ThreadSafeObjectProvider<MyWindows> s_Windows = new MyProject.ThreadSafeObjectProvider<MyWindows>();

	private static MyProject.ThreadSafeObjectProvider<Log> s_Log = new MyProject.ThreadSafeObjectProvider<Log>();

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal static Application Application => (Application)(object)Application.get_Current();

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal static Computer Computer => s_Computer.GetInstance;

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal static User User => s_User.GetInstance;

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal static Log Log => s_Log.GetInstance;

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal static MyWindows Windows
	{
		[DebuggerHidden]
		get
		{
			return s_Windows.GetInstance;
		}
	}
}
