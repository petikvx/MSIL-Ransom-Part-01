using System;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns6;
using ns7;
using ns8;

namespace ns4;

internal sealed class Class41 : IDisposable
{
	private sealed class Class42 : NativeWindow, IDisposable
	{
		public struct Struct10
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;

			public short short_0;
		}

		private Delegate4 delegate4_0;

		public Class42()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			((NativeWindow)this).CreateHandle(new CreateParams());
		}

		void IDisposable.Dispose()
		{
			((NativeWindow)this).DestroyHandle();
			GC.SuppressFinalize(this);
		}

		[SpecialName]
		public void method_0(Delegate4 delegate4_1)
		{
			Delegate4 @delegate = delegate4_0;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value = (Delegate4)Delegate.Combine(delegate2, delegate4_1);
				@delegate = Interlocked.CompareExchange(ref delegate4_0, value, delegate2);
			}
			while ((object)@delegate != delegate2);
		}

		[SpecialName]
		public void method_1(Delegate4 delegate4_1)
		{
			Delegate4 @delegate = delegate4_0;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value = (Delegate4)Delegate.Remove(delegate2, delegate4_1);
				@delegate = Interlocked.CompareExchange(ref delegate4_0, value, delegate2);
			}
			while ((object)@delegate != delegate2);
		}

		void NativeWindow.WndProc(ref Message m)
		{
			((NativeWindow)this).WndProc(ref m);
			if (((Message)(ref m)).get_Msg() != 537 || !(((Message)(ref m)).get_LParam() != IntPtr.Zero))
			{
				return;
			}
			Struct10 struct10_ = (Struct10)Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), typeof(Struct10));
			if (struct10_.int_1 == 2)
			{
				switch (((Message)(ref m)).get_WParam().ToInt32())
				{
				case 32768:
					method_2(Enum7.const_0, struct10_);
					break;
				case 32772:
					method_2(Enum7.const_2, struct10_);
					break;
				case 32769:
				case 32770:
				case 32771:
					break;
				}
			}
		}

		private void method_2(Enum7 enum7_0, Struct10 struct10_0)
		{
			string string_ = method_3(struct10_0.int_3);
			if (delegate4_0 != null)
			{
				Class38 class38_ = new Class38(string_);
				delegate4_0(new EventArgs0(enum7_0, class38_));
			}
		}

		private string method_3(int int_0)
		{
			int i;
			for (i = 0; i < 26; i++)
			{
				if (((uint)int_0 & (true ? 1u : 0u)) != 0)
				{
					break;
				}
				int_0 >>= 1;
			}
			if (i < 26)
			{
				return $"{Convert.ToChar(Convert.ToInt32('A') + i)}:";
			}
			return "?:";
		}
	}

	private delegate void Delegate5(Class38 disk);

	private Class42 class42_0;

	private Delegate4 delegate4_0;

	private bool bool_0;

	public Class41()
	{
		class42_0 = null;
		delegate4_0 = null;
		bool_0 = false;
	}

	void object.Finalize()
	{
		try
		{
			((IDisposable)this).Dispose();
		}
		finally
		{
			base.Finalize();
		}
	}

	void IDisposable.Dispose()
	{
		if (!bool_0)
		{
			if (class42_0 != null)
			{
				class42_0.method_1(method_2);
				class42_0.System_002EIDisposable_002EDispose();
				class42_0 = null;
			}
			bool_0 = true;
			GC.SuppressFinalize(this);
		}
	}

	[SpecialName]
	public void method_0(Delegate4 delegate4_1)
	{
		if (class42_0 == null)
		{
			class42_0 = new Class42();
			class42_0.method_0(method_2);
		}
		delegate4_0 = (Delegate4)Delegate.Combine(delegate4_0, delegate4_1);
	}

	public Class40 method_1()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		Class40 @class = new Class40();
		ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("select DeviceID, Model from Win32_DiskDrive where InterfaceType='USB'").Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val = (ManagementObject)enumerator.get_Current();
				ManagementObject val2 = Class39.smethod_0(new ManagementObjectSearcher(string.Format("associators of {{Win32_DiskDrive.DeviceID='{0}'}} where AssocClass = Win32_DiskDriveToDiskPartition", ((ManagementBaseObject)val).get_Item("DeviceID"))));
				if (val2 != null)
				{
					ManagementObject val3 = Class39.smethod_0(new ManagementObjectSearcher(string.Format("associators of {{Win32_DiskPartition.DeviceID='{0}'}} where AssocClass = Win32_LogicalDiskToPartition", ((ManagementBaseObject)val2).get_Item("DeviceID"))));
					if (val3 != null)
					{
						ManagementObject val4 = Class39.smethod_0(new ManagementObjectSearcher(string.Format("select FreeSpace, Size, VolumeName from Win32_LogicalDisk where Name='{0}'", ((ManagementBaseObject)val3).get_Item("Name"))));
						Class38 class2 = new Class38(((ManagementBaseObject)val3).get_Item("Name").ToString());
						class2.method_3(((ManagementBaseObject)val).get_Item("Model").ToString());
						class2.method_9(((ManagementBaseObject)val4).get_Item("VolumeName").ToString());
						class2.method_1((ulong)((ManagementBaseObject)val4).get_Item("FreeSpace"));
						class2.method_7((ulong)((ManagementBaseObject)val4).get_Item("Size"));
						@class.Add(class2);
					}
				}
			}
			return @class;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private void method_2(EventArgs0 eventArgs0_0)
	{
		if (delegate4_0 != null)
		{
			eventArgs0_0.method_0();
			if (eventArgs0_0.method_2() == Enum7.const_0 && eventArgs0_0.method_0().method_4()[0] != '?')
			{
				Delegate5 @delegate = method_3;
				IAsyncResult result = @delegate.BeginInvoke(eventArgs0_0.method_0(), null, null);
				@delegate.EndInvoke(result);
			}
			delegate4_0(eventArgs0_0);
		}
	}

	private void method_3(Class38 class38_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		ManagementObject val = Class39.smethod_0(new ManagementObjectSearcher($"associators of {{Win32_LogicalDisk.DeviceID='{class38_0.method_4()}'}} where AssocClass = Win32_LogicalDiskToPartition"));
		if (val == null)
		{
			return;
		}
		ManagementObject val2 = Class39.smethod_0(new ManagementObjectSearcher(string.Format("associators of {{Win32_DiskPartition.DeviceID='{0}'}}  where resultClass = Win32_DiskDrive", ((ManagementBaseObject)val).get_Item("DeviceID"))));
		if (val2 != null)
		{
			object obj = ((ManagementBaseObject)val2).get_Item("Model");
			if (obj != null)
			{
				class38_0.method_3(obj.ToString());
			}
		}
		ManagementObject val3 = Class39.smethod_0(new ManagementObjectSearcher($"select FreeSpace, Size, VolumeName from Win32_LogicalDisk where Name='{class38_0.method_4()}'"));
		if (val3 != null)
		{
			object obj2 = ((ManagementBaseObject)val3).get_Item("VolumeName");
			if (obj2 != null)
			{
				class38_0.method_9(obj2.ToString());
			}
			class38_0.method_1((ulong)((ManagementBaseObject)val3).get_Item("FreeSpace"));
			class38_0.method_7((ulong)((ManagementBaseObject)val3).get_Item("Size"));
		}
	}
}
