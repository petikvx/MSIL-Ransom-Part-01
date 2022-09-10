using System;
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

[HideModuleName]
[StandardModule]
internal sealed class _____________
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ________________<_> where @_ : new()
	{
		[ThreadStatic]
		private static @_ m__;

		internal @_ _
		{
			[DebuggerHidden]
			get
			{
				if (________________<@_>._ == null)
				{
					________________<@_>._ = new @_();
				}
				return ________________<@_>._;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ________________()
		{
		}
	}

	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class ______________
	{
		public _____________________________________________________________ _;

		public ______________________________________________________________________ __;

		[ThreadStatic]
		private static Hashtable ___;

		public _____________________________________________________________ _
		{
			get
			{
				this._ = _____(this._);
				return this._;
			}
			set
			{
				if (value != this._)
				{
					if (value != null)
					{
						throw new ArgumentException(_003CModule_003E.____<string>(1513599099u));
					}
					______(ref this._);
				}
			}
		}

		public ______________________________________________________________________ __
		{
			get
			{
				this.__ = _____(this.__);
				return this.__;
			}
			set
			{
				if (value != this.__)
				{
					if (value != null)
					{
						throw new ArgumentException(_003CModule_003E.____<string>(1513599099u));
					}
					______(ref this.__);
				}
			}
		}

		[DebuggerHidden]
		private static @_ _____<_>(@_ gparam_0) where @_ : Form, new()
		{
			if (gparam_0 != null && !((Control)gparam_0).get_IsDisposed())
			{
				return ((nint)Type.EmptyTypes.LongLength + 0) switch
				{
					_ => gparam_0, 
				};
			}
			if (___ != null)
			{
				if (___.ContainsKey(typeof(@_)))
				{
					throw new InvalidOperationException(Utils.GetResourceString(_003CModule_003E._______<string>(3581975121u), new string[0]));
				}
			}
			else
			{
				___ = new Hashtable();
			}
			___.Add(typeof(@_), null);
			try
			{
				return new @_();
			}
			catch (TargetInvocationException ex) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError((Exception)ex);
				return ex.InnerException != null;
			}).Invoke())
			{
				string resourceString = Utils.GetResourceString(_003CModule_003E.___<string>(4207987928u), new string[1] { ex.InnerException!.Message });
				throw new InvalidOperationException(resourceString, ex.InnerException);
			}
			finally
			{
				___.Remove(typeof(@_));
			}
		}

		[DebuggerHidden]
		private void ______<_>(ref @_ gparam_0) where @_ : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(@_);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ______________()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type _______()
		{
			return typeof(______________);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class _______________
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type _()
		{
			return typeof(_______________);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static @_ __<_>(@_ gparam_0) where @_ : new()
		{
			if (gparam_0 == null)
			{
				return new @_();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		private void ___<_>(ref @_ gparam_0)
		{
			gparam_0 = default(@_);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public _______________()
		{
		}
	}

	private static readonly ________________<____________> m__ = new ________________<____________>();

	private static readonly ________________<___________> m___ = new ________________<___________>();

	private static readonly ________________<User> m____ = new ________________<User>();

	private static ________________<______________> m_____ = new ________________<______________>();

	private static readonly ________________<_______________> m______ = new ________________<_______________>();

	[HelpKeyword("My.Computer")]
	internal static ____________ _
	{
		[DebuggerHidden]
		get
		{
			return _____________.m__._;
		}
	}

	[HelpKeyword("My.Application")]
	internal static ___________ __
	{
		[DebuggerHidden]
		get
		{
			return _____________.m___._;
		}
	}

	[HelpKeyword("My.User")]
	internal static User ___
	{
		[DebuggerHidden]
		get
		{
			return _____________.m____._;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static ______________ ____
	{
		[DebuggerHidden]
		get
		{
			return _____________.m_____._;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static _______________ _____
	{
		[DebuggerHidden]
		get
		{
			return _____________.m______._;
		}
	}
}
