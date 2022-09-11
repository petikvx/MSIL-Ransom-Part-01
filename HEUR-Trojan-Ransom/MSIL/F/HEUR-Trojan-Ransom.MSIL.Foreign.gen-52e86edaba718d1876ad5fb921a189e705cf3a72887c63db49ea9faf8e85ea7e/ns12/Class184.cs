using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using MySql.Data.MySqlClient;
using ns11;
using ns21;
using ns4;

namespace ns12;

internal abstract class Class184
{
	[CompilerGenerated]
	private sealed class Class186
	{
		public Class188 class188_0;

		public Class184 class184_0;

		internal void method_0(object sender, DoWorkEventArgs e)
		{
			Class187 obj = new Class187
			{
				class186_0 = this,
				bool_0 = false,
				class188_0 = (e.Argument as Class188),
				timer_0 = new Timer((double)class184_0.RetryTime * 1000.0)
			};
			ElapsedEventHandler elapsedEventHandler = delegate
			{
				if (obj.bool_0)
				{
					return;
				}
				try
				{
					obj.bool_0 = true;
					using Class139 @class = new Class139(obj.class186_0.class188_0.ConnectionString);
					@class.Open();
					obj.class188_0.IsAvailable = true;
					obj.timer_0.Stop();
				}
				catch
				{
					MySqlTrace.smethod_3(0, string.Format(Class121.Replication_ConnectionAttemptFailed, obj.class188_0.Name));
				}
				finally
				{
					obj.bool_0 = false;
				}
			};
			obj.timer_0.Elapsed += elapsedEventHandler;
			obj.timer_0.Start();
			elapsedEventHandler(sender, null);
		}
	}

	[CompilerGenerated]
	private sealed class Class187
	{
		public bool bool_0;

		public Class188 class188_0;

		public Timer timer_0;

		public Class186 class186_0;

		internal void method_0(object sender, ElapsedEventArgs e)
		{
			if (bool_0)
			{
				return;
			}
			try
			{
				bool_0 = true;
				using Class139 @class = new Class139(class186_0.class188_0.ConnectionString);
				@class.Open();
				class188_0.IsAvailable = true;
				timer_0.Stop();
			}
			catch
			{
				MySqlTrace.smethod_3(0, string.Format(Class121.Replication_ConnectionAttemptFailed, class188_0.Name));
			}
			finally
			{
				bool_0 = false;
			}
		}
	}

	protected List<Class188> list_0 = new List<Class188>();

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private IList<Class188> ilist_0;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		protected set
		{
			string_0 = value;
		}
	}

	public int RetryTime
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		protected set
		{
			int_0 = value;
		}
	}

	protected IList<Class188> Servers
	{
		[CompilerGenerated]
		get
		{
			return ilist_0;
		}
		[CompilerGenerated]
		private set
		{
			ilist_0 = value;
		}
	}

	public Class184(string string_1, int int_1)
	{
		Servers = list_0;
		Name = string_1;
		RetryTime = int_1;
	}

	protected internal Class188 method_0(string string_1, bool bool_0, string string_2)
	{
		Class188 @class = new Class188(string_1, bool_0, string_2);
		list_0.Add(@class);
		return @class;
	}

	protected internal void method_1(string string_1)
	{
		Class188 @class = method_2(string_1);
		if (@class == null)
		{
			throw new MySqlException(string.Format(Class121.ReplicationServerNotFound, string_1));
		}
		list_0.Remove(@class);
	}

	protected internal Class188 method_2(string string_1)
	{
		foreach (Class188 item in list_0)
		{
			if (string.Compare(string_1, item.Name, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return item;
			}
		}
		return null;
	}

	protected internal abstract Class188 vmethod_0(bool bool_0);

	protected internal virtual Class188 vmethod_1(bool bool_0, MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0)
	{
		return vmethod_0(bool_0);
	}

	protected internal virtual void vmethod_2(Class188 class188_0)
	{
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.DoWork += delegate(object sender, DoWorkEventArgs e)
		{
			bool bool_0 = false;
			Class188 class188_ = e.Argument as Class188;
			Timer timer_0 = new Timer((double)RetryTime * 1000.0);
			ElapsedEventHandler elapsedEventHandler = delegate
			{
				if (bool_0)
				{
					return;
				}
				try
				{
					bool_0 = true;
					using Class139 @class = new Class139(class188_0.ConnectionString);
					@class.Open();
					class188_.IsAvailable = true;
					timer_0.Stop();
				}
				catch
				{
					MySqlTrace.smethod_3(0, string.Format(Class121.Replication_ConnectionAttemptFailed, class188_.Name));
				}
				finally
				{
					bool_0 = false;
				}
			};
			timer_0.Elapsed += elapsedEventHandler;
			timer_0.Start();
			elapsedEventHandler(sender, null);
		};
		backgroundWorker.RunWorkerAsync(class188_0);
	}

	protected internal virtual void vmethod_3(Class188 class188_0, Exception exception_0)
	{
		vmethod_2(class188_0);
	}
}
