using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RawInput;

public sealed class InputDevice
{
	public delegate void DeviceEventHandler(object sender, KeyControlEventArgs e);

	public class KeyControlEventArgs : EventArgs
	{
		public DeviceInfo m_deviceInfo;

		public DeviceType m_device;

		public DeviceInfo Keyboard
		{
			get
			{
				return m_deviceInfo;
			}
			set
			{
				m_deviceInfo = value;
			}
		}

		public DeviceType Device
		{
			get
			{
				return m_device;
			}
			set
			{
				m_device = value;
			}
		}

		public KeyControlEventArgs(DeviceInfo dInfo, DeviceType device)
		{
			m_deviceInfo = dInfo;
			m_device = device;
		}

		public KeyControlEventArgs()
		{
		}
	}

	public class DeviceInfo
	{
		public string deviceName;

		public string deviceType;

		public IntPtr deviceHandle;

		public string Name;

		public string source;

		public ushort key;

		public string vKey;
	}

	public enum DeviceType
	{
		Key,
		Mouse,
		OEM
	}

	internal struct Struct0
	{
		[MarshalAs(UnmanagedType.U2)]
		public ushort ushort_0;

		[MarshalAs(UnmanagedType.U2)]
		public ushort ushort_1;

		[MarshalAs(UnmanagedType.U4)]
		public int int_0;

		public IntPtr intptr_0;
	}

	internal struct Struct1
	{
		public IntPtr intptr_0;

		[MarshalAs(UnmanagedType.U4)]
		public int int_0;
	}

	[StructLayout(LayoutKind.Explicit)]
	internal struct Struct2
	{
		[FieldOffset(0)]
		public Struct3 struct3_0;

		[FieldOffset(16)]
		public Struct4 struct4_0;

		[FieldOffset(16)]
		public Struct6 struct6_0;

		[FieldOffset(16)]
		public Struct7 struct7_0;
	}

	internal struct Struct3
	{
		[MarshalAs(UnmanagedType.U4)]
		public int int_0;

		[MarshalAs(UnmanagedType.U4)]
		public int int_1;

		public IntPtr intptr_0;

		[MarshalAs(UnmanagedType.U4)]
		public int int_2;
	}

	[StructLayout(LayoutKind.Explicit)]
	internal struct Struct4
	{
		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U2)]
		public ushort ushort_0;

		[FieldOffset(4)]
		[MarshalAs(UnmanagedType.U4)]
		public uint uint_0;

		[FieldOffset(4)]
		public Struct5 struct5_0;

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.U4)]
		public uint uint_1;

		[FieldOffset(12)]
		public int int_0;

		[FieldOffset(16)]
		public int int_1;

		[FieldOffset(20)]
		[MarshalAs(UnmanagedType.U4)]
		public uint uint_2;
	}

	internal struct Struct5
	{
		[MarshalAs(UnmanagedType.U2)]
		public ushort ushort_0;

		[MarshalAs(UnmanagedType.U2)]
		public ushort ushort_1;
	}

	internal struct Struct6
	{
		[MarshalAs(UnmanagedType.U2)]
		public ushort ushort_0;

		[MarshalAs(UnmanagedType.U2)]
		public ushort ushort_1;

		[MarshalAs(UnmanagedType.U2)]
		public ushort ushort_2;

		[MarshalAs(UnmanagedType.U2)]
		public ushort ushort_3;

		[MarshalAs(UnmanagedType.U4)]
		public uint uint_0;

		[MarshalAs(UnmanagedType.U4)]
		public uint uint_1;
	}

	internal struct Struct7
	{
		[MarshalAs(UnmanagedType.U4)]
		public int int_0;

		[MarshalAs(UnmanagedType.U4)]
		public int int_1;
	}

	public const int RIDEV_INPUTSINK = 256;

	public const int RID_INPUT = 268435459;

	public const int FAPPCOMMAND_MASK = 61440;

	public const int FAPPCOMMAND_MOUSE = 32768;

	public const int FAPPCOMMAND_OEM = 4096;

	public const int RIM_TYPEMOUSE = 0;

	public const int RIM_TYPEKEYBOARD = 1;

	public const int RIM_TYPEHID = 2;

	public const int RIDI_DEVICENAME = 536870919;

	public const int WM_KEYDOWN = 256;

	public const int WM_SYSKEYDOWN = 260;

	public const int WM_INPUT = 255;

	public const int VK_OEM_CLEAR = 254;

	public const int VK_LAST_KEY = 254;

	public Hashtable deviceList = new Hashtable();

	private DeviceEventHandler deviceEventHandler_0;

	public event DeviceEventHandler KeyPressed
	{
		add
		{
			DeviceEventHandler deviceEventHandler = deviceEventHandler_0;
			DeviceEventHandler deviceEventHandler2;
			do
			{
				deviceEventHandler2 = deviceEventHandler;
				DeviceEventHandler value2 = (DeviceEventHandler)Delegate.Combine(deviceEventHandler2, value);
				deviceEventHandler = Interlocked.CompareExchange(ref deviceEventHandler_0, value2, deviceEventHandler2);
			}
			while ((object)deviceEventHandler != deviceEventHandler2);
		}
		remove
		{
			DeviceEventHandler deviceEventHandler = deviceEventHandler_0;
			DeviceEventHandler deviceEventHandler2;
			do
			{
				deviceEventHandler2 = deviceEventHandler;
				DeviceEventHandler value2 = (DeviceEventHandler)Delegate.Remove(deviceEventHandler2, value);
				deviceEventHandler = Interlocked.CompareExchange(ref deviceEventHandler_0, value2, deviceEventHandler2);
			}
			while ((object)deviceEventHandler != deviceEventHandler2);
		}
	}

	[DllImport("User32.dll")]
	private static extern uint GetRawInputDeviceList(IntPtr pRawInputDeviceList, ref uint uiNumDevices, uint cbSize);

	[DllImport("User32.dll")]
	private static extern uint GetRawInputDeviceInfo(IntPtr hDevice, uint uiCommand, IntPtr pData, ref uint pcbSize);

	[DllImport("User32.dll")]
	private static extern bool RegisterRawInputDevices(Struct0[] pRawInputDevice, uint uiNumDevices, uint cbSize);

	[DllImport("User32.dll")]
	private static extern uint GetRawInputData(IntPtr hRawInput, uint uiCommand, IntPtr pData, ref uint pcbSize, uint cbSizeHeader);

	public InputDevice(IntPtr hwnd)
	{
		Struct0[] array = new Struct0[1];
		array[0].ushort_0 = 1;
		array[0].ushort_1 = 6;
		array[0].int_0 = 256;
		array[0].intptr_0 = hwnd;
		if (!RegisterRawInputDevices(array, (uint)array.Length, (uint)Marshal.SizeOf((object)array[0])))
		{
			throw new ApplicationException("Failed to register raw input device(s).");
		}
	}

	public string ReadReg(string item, ref bool isKeyboard)
	{
		item = item.Substring(4);
		string[] array = item.Split(new char[1] { '#' });
		string arg = array[0];
		string arg2 = array[1];
		string arg3 = array[2];
		RegistryKey localMachine = Registry.LocalMachine;
		string name = $"System\\CurrentControlSet\\Enum\\{arg}\\{arg2}\\{arg3}";
		localMachine = localMachine.OpenSubKey(name, writable: false);
		string result = (string)localMachine.GetValue("DeviceDesc");
		string text = (string)localMachine.GetValue("Class");
		if (text.ToUpper().Equals("KEYBOARD"))
		{
			isKeyboard = true;
		}
		else
		{
			isKeyboard = false;
		}
		return result;
	}

	public int EnumerateDevices()
	{
		int num = 0;
		uint uiNumDevices = 0u;
		int num2 = Marshal.SizeOf(typeof(Struct1));
		if (GetRawInputDeviceList(IntPtr.Zero, ref uiNumDevices, (uint)num2) == 0)
		{
			IntPtr intPtr = Marshal.AllocHGlobal((int)(num2 * uiNumDevices));
			GetRawInputDeviceList(intPtr, ref uiNumDevices, (uint)num2);
			for (int i = 0; i < uiNumDevices; i++)
			{
				uint pcbSize = 0u;
				Struct1 @struct = (Struct1)Marshal.PtrToStructure(new IntPtr(intPtr.ToInt32() + num2 * i), typeof(Struct1));
				GetRawInputDeviceInfo(@struct.intptr_0, 536870919u, IntPtr.Zero, ref pcbSize);
				if (pcbSize == 0)
				{
					continue;
				}
				IntPtr intPtr2 = Marshal.AllocHGlobal((int)pcbSize);
				GetRawInputDeviceInfo(@struct.intptr_0, 536870919u, intPtr2, ref pcbSize);
				string text = Marshal.PtrToStringAnsi(intPtr2);
				if (text.ToUpper().Contains("ROOT"))
				{
					continue;
				}
				if (@struct.int_0 == 1 || @struct.int_0 == 2)
				{
					DeviceInfo deviceInfo = new DeviceInfo();
					deviceInfo.deviceName = Marshal.PtrToStringAnsi(intPtr2);
					deviceInfo.deviceHandle = @struct.intptr_0;
					deviceInfo.deviceType = GetDeviceType(@struct.int_0);
					bool isKeyboard = false;
					string text2 = (deviceInfo.Name = ReadReg(text, ref isKeyboard));
					if (!deviceList.Contains(@struct.intptr_0) && isKeyboard)
					{
						num++;
						deviceList.Add(@struct.intptr_0, deviceInfo);
					}
				}
				Marshal.FreeHGlobal(intPtr2);
			}
			Marshal.FreeHGlobal(intPtr);
			return num;
		}
		throw new ApplicationException("An error occurred while retrieving the list of devices.");
	}

	public void ProcessInputCommand(Message message)
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		uint pcbSize = 0u;
		GetRawInputData(((Message)(ref message)).get_LParam(), 268435459u, IntPtr.Zero, ref pcbSize, (uint)Marshal.SizeOf(typeof(Struct3)));
		IntPtr intPtr = Marshal.AllocHGlobal((int)pcbSize);
		try
		{
			if (!(intPtr != IntPtr.Zero) || GetRawInputData(((Message)(ref message)).get_LParam(), 268435459u, intPtr, ref pcbSize, (uint)Marshal.SizeOf(typeof(Struct3))) != pcbSize)
			{
				return;
			}
			Struct2 @struct = (Struct2)Marshal.PtrToStructure(intPtr, typeof(Struct2));
			if (@struct.struct3_0.int_0 != 1 || (@struct.struct6_0.uint_0 != 256 && @struct.struct6_0.uint_0 != 260))
			{
				return;
			}
			ushort ushort_ = @struct.struct6_0.ushort_3;
			if (ushort_ <= 254)
			{
				DeviceInfo deviceInfo = null;
				if (!deviceList.Contains(@struct.struct3_0.intptr_0))
				{
					string message2 = $"Handle :{@struct.struct3_0.intptr_0} was not in hashtable. The device may support more than one handle or usage page, and is probably not a standard keyboard.";
					throw new ApplicationException(message2);
				}
				deviceInfo = (DeviceInfo)deviceList[@struct.struct3_0.intptr_0];
				Keys val = (Keys)Enum.Parse(typeof(Keys), Enum.GetName(typeof(Keys), ushort_));
				deviceInfo.vKey = ((object)val).ToString();
				deviceInfo.key = ushort_;
				if (deviceEventHandler_0 == null || deviceInfo == null)
				{
					string message3 = $"Received Unknown Key: {ushort_}. Possibly an unknown device";
					throw new ApplicationException(message3);
				}
				deviceEventHandler_0(this, new KeyControlEventArgs(deviceInfo, GetDevice(((Message)(ref message)).get_LParam().ToInt32())));
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public DeviceType GetDevice(int param)
	{
		return ((ushort)(param >> 16) & 0xF000) switch
		{
			4096 => DeviceType.OEM, 
			32768 => DeviceType.Mouse, 
			_ => DeviceType.Key, 
		};
	}

	public void ProcessMessage(Message message)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		int msg = ((Message)(ref message)).get_Msg();
		if (msg == 255)
		{
			ProcessInputCommand(message);
		}
	}

	public string GetDeviceType(int device)
	{
		return device switch
		{
			0 => "MOUSE", 
			1 => "KEYBOARD", 
			2 => "HID", 
			_ => "UNKNOWN", 
		};
	}
}
