using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

public sealed class GClass0<T> : GInterface12<T> where T : GInterface7
{
	private sealed class Class3 : IEnumerable<T>, IEnumerator<T>, IEnumerable, IEnumerator, IDisposable
	{
		public int int_0;

		public T gparam_0;

		public int int_1;

		internal GInterface2 ginterface2_0;

		internal GInterface2 ginterface2_1;

		internal GClass0<T> gclass0_0;

		private T Current
		{
			[DebuggerNonUserCode]
			get
			{
				return gparam_0;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerNonUserCode]
			get
			{
				return gparam_0;
			}
		}

		public Class3(int int_2)
		{
			int_0 = int_2;
			int_1 = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerNonUserCode]
		private void Dispose()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		[CompilerGenerated]
		private bool MoveNext()
		{
			if (int_0 != 0)
			{
				return false;
			}
			int num = -1;
			int_0 = -1;
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerNonUserCode]
		private IEnumerator<T> GetEnumerator()
		{
			Class3 @class;
			if (int_0 == -2 && int_1 == Thread.CurrentThread.ManagedThreadId)
			{
				int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class3(0);
				@class.gclass0_0 = gclass0_0;
			}
			@class.ginterface2_0 = ginterface2_1;
			return @class;
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
			return this.GetEnumerator();
		}

		[DebuggerNonUserCode]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		[DebuggerNonUserCode]
		private void Reset()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Reset
			this.Reset();
		}
	}

	private Random random_0;

	public GClass0()
	{
		random_0 = new Random();
	}

	public IEnumerable<T> imethod_0(GInterface2 ginterface2_0)
	{
		Class3 @class = new Class3(-2);
		@class.gclass0_0 = this;
		@class.ginterface2_1 = ginterface2_0;
		return @class;
	}
}
