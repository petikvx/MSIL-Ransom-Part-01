using System;
using System.Diagnostics;
using System.Threading;

internal static class Class0
{
	internal sealed class Class1 : Interface4<int>, Interface1<int>, Interface0, Interface2, Interface3
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		public int int_4;

		[DebuggerHidden]
		public Class1(int int_5)
		{
			int_0 = int_5;
			int_2 = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		void Interface2.imethod_0()
		{
		}

		private bool imethod_2()
		{
			switch (int_0)
			{
			default:
				return false;
			case 0:
				int_0 = -1;
				int_1 = 1395980637;
				int_0 = 1;
				return true;
			case 1:
				int_0 = -1;
				int_1 = -112083546;
				int_0 = 2;
				return true;
			case 2:
				int_0 = -1;
				int_1 = int_3 ^ -1780847285;
				int_0 = 3;
				return true;
			case 3:
				int_0 = -1;
				int_1 = -1027425236;
				int_0 = 4;
				return true;
			case 4:
				int_0 = -1;
				int_1 = int_3 ^ -2026041324;
				int_0 = 5;
				return true;
			case 5:
				int_0 = -1;
				int_1 = -186117228;
				int_0 = 6;
				return true;
			case 6:
				int_0 = -1;
				int_1 = 1391806242;
				int_0 = 7;
				return true;
			case 7:
				int_0 = -1;
				return false;
			}
		}

		bool Interface3.imethod_2()
		{
			//ILSpy generated this explicit interface implementation from .override directive in imethod_2
			return this.imethod_2();
		}

		[DebuggerHidden]
		int Interface4<int>.imethod_3()
		{
			return int_1;
		}

		[DebuggerHidden]
		void Interface3.imethod_1()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		object Interface3.imethod_0()
		{
			return int_1;
		}

		[DebuggerHidden]
		Interface4<int> Interface1<int>.imethod_1()
		{
			Class1 @class;
			if (int_0 == -2 && int_2 == Thread.CurrentThread.ManagedThreadId)
			{
				int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class1(0);
			}
			@class.int_3 = int_4;
			return @class;
		}

		[DebuggerHidden]
		Interface3 Interface0.imethod_0()
		{
			return ((Interface1<int>)this).imethod_1();
		}
	}
}
