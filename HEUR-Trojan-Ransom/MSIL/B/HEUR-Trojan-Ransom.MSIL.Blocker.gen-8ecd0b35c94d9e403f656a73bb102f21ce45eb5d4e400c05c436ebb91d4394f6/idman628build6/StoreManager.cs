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

namespace idman628build6;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class StoreManager
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class FormFactory
	{
		[ThreadStatic]
		private static Hashtable versionCollection;

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public FormFactory()
		{
		}

		[DebuggerHidden]
		private static versionCollection DisableDrive<versionCollection>(versionCollection versionCollection) where versionCollection : Form, new()
		{
			if ((versionCollection == null || ((Control)versionCollection).get_IsDisposed()) ? true : false)
			{
				if (FormFactory.versionCollection != null)
				{
					if (FormFactory.versionCollection.ContainsKey(typeof(versionCollection)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					FormFactory.versionCollection = new Hashtable();
				}
				FormFactory.versionCollection.Add(typeof(versionCollection), null);
				try
				{
					return new versionCollection();
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
					FormFactory.versionCollection.Remove(typeof(versionCollection));
				}
			}
			return versionCollection;
		}

		[DebuggerHidden]
		private void DisableDrive<versionCollection>(ref versionCollection versionCollection) where versionCollection : Form
		{
			((Component)versionCollection).Dispose();
			versionCollection = default(versionCollection);
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
		internal Type DisableDrive()
		{
			return typeof(FormFactory);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class SelectionService
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public SelectionService()
		{
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type DisableDrive()
		{
			return typeof(SelectionService);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static versionCollection DisableDrive<versionCollection>(versionCollection versionCollection) where versionCollection : new()
		{
			if (versionCollection == null)
			{
				return new versionCollection();
			}
			return versionCollection;
		}

		[DebuggerHidden]
		private void DisableDrive<versionCollection>(ref versionCollection versionCollection)
		{
			versionCollection = default(versionCollection);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ActivatorResolver<versionCollection> where versionCollection : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static versionCollection versionCollection;

		internal versionCollection DisableDrive
		{
			[DebuggerHidden]
			get
			{
				if (ActivatorResolver<versionCollection>.versionCollection == null)
				{
					ActivatorResolver<versionCollection>.versionCollection = new versionCollection();
				}
				return ActivatorResolver<versionCollection>.versionCollection;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ActivatorResolver()
		{
		}
	}

	private static readonly ActivatorResolver<GroupLayout> versionCollection = new ActivatorResolver<GroupLayout>();

	private static readonly ActivatorResolver<ServerService> versionCollection = new ActivatorResolver<ServerService>();

	private static readonly ActivatorResolver<User> versionCollection = new ActivatorResolver<User>();

	private static ActivatorResolver<FormFactory> versionCollection = new ActivatorResolver<FormFactory>();

	private static readonly ActivatorResolver<SelectionService> versionCollection = new ActivatorResolver<SelectionService>();

	[HelpKeyword("My.Computer")]
	internal static GroupLayout DisableDrive
	{
		[DebuggerHidden]
		get
		{
			return StoreManager.versionCollection.DisableDrive;
		}
	}

	[HelpKeyword("My.Application")]
	internal static ServerService DisableDrive
	{
		[DebuggerHidden]
		get
		{
			return StoreManager.versionCollection.DisableDrive;
		}
	}

	[HelpKeyword("My.User")]
	internal static User DisableDrive
	{
		[DebuggerHidden]
		get
		{
			return StoreManager.versionCollection.DisableDrive;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static FormFactory DisableDrive
	{
		[DebuggerHidden]
		get
		{
			return StoreManager.versionCollection.DisableDrive;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static SelectionService DisableDrive
	{
		[DebuggerHidden]
		get
		{
			return versionCollection.DisableDrive;
		}
	}
}
