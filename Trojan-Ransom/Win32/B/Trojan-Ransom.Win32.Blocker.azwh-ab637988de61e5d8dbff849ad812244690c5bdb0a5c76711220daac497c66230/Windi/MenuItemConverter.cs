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

namespace Windi;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MenuItemConverter
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class PathAttribute
	{
		public DeviceContext logLength;

		[ThreadStatic]
		private static Hashtable currentNames;

		public DeviceContext ResolveDatabase
		{
			[DebuggerNonUserCode]
			get
			{
				logLength = FreeComponent(logLength);
				return logLength;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != logLength)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					RebuildToolbox(ref logLength);
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public PathAttribute()
		{
		}

		[DebuggerHidden]
		private static logLength FreeComponent<logLength>(logLength logLength) where logLength : Form, new()
		{
			if ((logLength == null || ((Control)logLength).get_IsDisposed()) ? true : false)
			{
				if (currentNames != null)
				{
					if (currentNames.ContainsKey(typeof(logLength)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					currentNames = new Hashtable();
				}
				currentNames.Add(typeof(logLength), null);
				try
				{
					return new logLength();
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
					currentNames.Remove(typeof(logLength));
				}
			}
			return logLength;
		}

		[DebuggerHidden]
		private void RebuildToolbox<logLength>(ref logLength logLength) where logLength : Form
		{
			((Component)logLength).Dispose();
			logLength = default(logLength);
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
		internal Type NavigateMethod()
		{
			return typeof(PathAttribute);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class DomainHelper
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public DomainHelper()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type IncreaseStub()
		{
			return typeof(DomainHelper);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static logLength NavigateClient<logLength>(logLength logLength) where logLength : new()
		{
			if (logLength == null)
			{
				return new logLength();
			}
			return logLength;
		}

		[DebuggerHidden]
		private void ResolveDatabase<logLength>(ref logLength logLength)
		{
			logLength = default(logLength);
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class ActivityLayout<logLength> where logLength : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static logLength logLength;

		internal logLength NavigateClient
		{
			[DebuggerHidden]
			get
			{
				if (ActivityLayout<logLength>.logLength == null)
				{
					ActivityLayout<logLength>.logLength = new logLength();
				}
				return ActivityLayout<logLength>.logLength;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ActivityLayout()
		{
		}
	}

	private static readonly ActivityLayout<PcitureSite> logLength = new ActivityLayout<PcitureSite>();

	private static readonly ActivityLayout<PcitureProvider> currentNames = new ActivityLayout<PcitureProvider>();

	private static readonly ActivityLayout<User> currentUri = new ActivityLayout<User>();

	private static ActivityLayout<PathAttribute> filterCollection = new ActivityLayout<PathAttribute>();

	private static readonly ActivityLayout<DomainHelper> messageInitialized = new ActivityLayout<DomainHelper>();

	[HelpKeyword("My.Computer")]
	internal static PcitureSite NavigateMethod
	{
		[DebuggerHidden]
		get
		{
			return logLength.NavigateClient;
		}
	}

	[HelpKeyword("My.Application")]
	internal static PcitureProvider ProcessBuilder
	{
		[DebuggerHidden]
		get
		{
			return currentNames.NavigateClient;
		}
	}

	[HelpKeyword("My.User")]
	internal static User SortActivator
	{
		[DebuggerHidden]
		get
		{
			return currentUri.NavigateClient;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static PathAttribute SearchContext
	{
		[DebuggerHidden]
		get
		{
			return filterCollection.NavigateClient;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static DomainHelper TestPackage
	{
		[DebuggerHidden]
		get
		{
			return messageInitialized.NavigateClient;
		}
	}
}
