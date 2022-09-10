#define TRACE
using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Com.HP.App.HPToolkit;
using Com.HP.App.HPToolkit.HPDevice;
using Microsoft.Win32;
using ServiceCommunicationObjects;

namespace Com.HP.IPG.HPLJUTBES;

public class DeviceEnumerator : IDisposable
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class PRINTER_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string szPrinterName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string szDriverName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string szPortName;

		[MarshalAs(UnmanagedType.LPStr)]
		public string szHostName;

		[MarshalAs(UnmanagedType.LPStr)]
		public string szIPAddress;

		[MarshalAs(UnmanagedType.U4)]
		public uint dwPortNum;

		public uint Attributes;

		public string MacAddress;

		public string[] IPv6Addresses;

		public string[] AddressList;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class PRINTER_INFO_2W
	{
		[MarshalAs(UnmanagedType.LPTStr)]
		public string szServerName;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string szPrinterName;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string szShareName;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string szPortName;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string szDriverName;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string szComment;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string szLocation;

		public IntPtr devMode;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string szSepFile;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string szPrintProcessor;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string szDatatype;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string szParameters;

		public IntPtr securityDescriptor;

		[MarshalAs(UnmanagedType.U4)]
		public uint Attributes;

		[MarshalAs(UnmanagedType.U4)]
		public uint Priority;

		[MarshalAs(UnmanagedType.U4)]
		public uint DefaultPriority;

		[MarshalAs(UnmanagedType.U4)]
		public uint StartTime;

		[MarshalAs(UnmanagedType.U4)]
		public uint UntilTime;

		[MarshalAs(UnmanagedType.U4)]
		public uint Status;

		[MarshalAs(UnmanagedType.U4)]
		public uint cJobs;

		[MarshalAs(UnmanagedType.U4)]
		public uint AveragePPM;
	}

	private const int ERROR_INSUFFICIENT_BUFFER = 122;

	public const uint PRINTER_ENUM_CONNECTIONS = 4u;

	public const uint PRINTER_ENUM_LOCAL = 2u;

	private ClientDevice _currentDevice;

	private EnumerateClientDeviceList _ecd;

	private PRINTER_INFORMATION_TRANSPORT_STRUCT _currentPi;

	private PRINTER_INFO _currentPrn;

	public IHPLaserJetService HPLJServiceInstance { get; private set; }

	public ClientDevice Device => _currentDevice;

	public string DevicePort
	{
		get
		{
			if (_currentDevice == null)
			{
				return "";
			}
			return _currentDevice.get_PortName();
		}
	}

	public string DeviceGUID
	{
		get
		{
			if (_currentDevice == null)
			{
				return "";
			}
			return _currentDevice.get_DevGuid();
		}
	}

	public string DeviceIP
	{
		get
		{
			if (_currentDevice == null)
			{
				return string.Empty;
			}
			return _currentDevice.get_DefaultIpAddress();
		}
	}

	public bool IsNetworked
	{
		get
		{
			if (_currentDevice == null)
			{
				return false;
			}
			return _currentDevice.get_IsNetworked();
		}
	}

	public static PRINTER_INFO[] PrinterList
	{
		get
		{
			try
			{
				PRINTER_INFO[] array = null;
				uint flags = 6u;
				bool flag = EnumPrintersW(6u, null, 2u, IntPtr.Zero, 0u, out var bytesReceived, out var numPrinters);
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 122)
				{
					return null;
				}
				IntPtr intPtr = Marshal.AllocCoTaskMem((int)bytesReceived);
				flag = EnumPrintersW(flags, null, 2u, intPtr, bytesReceived, out bytesReceived, out numPrinters);
				lastWin32Error = Marshal.GetLastWin32Error();
				if (flag)
				{
					PRINTER_INFO_2W[] array2 = new PRINTER_INFO_2W[numPrinters];
					array = new PRINTER_INFO[numPrinters];
					IntPtr intPtr2 = intPtr;
					for (uint num = 0u; num < numPrinters; num++)
					{
						array2[num] = new PRINTER_INFO_2W();
						array[num] = new PRINTER_INFO();
						Marshal.PtrToStructure(intPtr2, (object)array2[num]);
						intPtr2 = (IntPtr)((int)intPtr2 + Marshal.SizeOf((object)array2[num]));
						AddPrinterInfo(array[num], array2[num]);
					}
				}
				Marshal.FreeCoTaskMem(intPtr);
				return array;
			}
			catch (Exception)
			{
			}
			return null;
		}
	}

	public bool GetDevice(string ProductName, string PortName)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		_ecd = new EnumerateClientDeviceList(ProductName);
		HPLJServiceInstance = _ecd.get_HPLJServiceInstance();
		Hashtable deviceList = _ecd.get_DeviceList();
		if (PortName != null && !PortName.Equals(string.Empty))
		{
			_currentDevice = (ClientDevice)deviceList[PortName];
		}
		if (_currentDevice == null)
		{
			foreach (ClientDevice value in deviceList.Values)
			{
				ClientDevice val = value;
				if (val.get_DriverName() != null && val.get_DriverName().Equals(ProductName))
				{
					_currentDevice = val;
					break;
				}
			}
		}
		if (_currentDevice != null)
		{
			return true;
		}
		return false;
	}

	public bool GetFakeDeviceNoLJService(string productName)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		Trace.WriteLine("In GetFakeDeviceNoLJService {" + productName + "}");
		PRINTER_INFO[] printerList = PrinterList;
		if (printerList != null)
		{
			foreach (PRINTER_INFO pRINTER_INFO in printerList)
			{
				Trace.WriteLine("GetFakeDeviceNoLJService:: pi.szPrinterName = " + pRINTER_INFO.szPrinterName + " pi.szDriverName = " + pRINTER_INFO.szDriverName + " pi.szPortName = " + pRINTER_INFO.szPortName);
				if (!(pRINTER_INFO.szDriverName == productName))
				{
					cleanCurrentPi();
					continue;
				}
				Trace.WriteLine("GetFakeDeviceNoLJService Product found");
				_currentPrn = pRINTER_INFO;
				cleanCurrentPi();
				_currentPi = new PRINTER_INFORMATION_TRANSPORT_STRUCT();
				_currentPi.szPortName = _currentPrn.szPortName;
				_currentPi.szPrinterName = _currentPrn.szPrinterName;
				_currentPi.IsNetworked = _currentPrn.AddressList.Length > 0;
				Trace.WriteLine("_currentPrn = pi");
				return true;
			}
		}
		Trace.WriteLine("GetFakeDeviceNoLJService returning false");
		return false;
	}

	private void cleanCurrentPi()
	{
		Trace.WriteLine("In cleanCurrentPi");
		if (_currentPi != null)
		{
			_currentPi.Address = "";
			_currentPi.Connected = false;
			_currentPi.dwPortNum = 8080u;
			_currentPi.GUID = "";
			_currentPi.IsNetworked = false;
			_currentPi.LedmPrinter = false;
			_currentPi.ModelName = "";
			_currentPi.SerialNumber = "";
			_currentPi.szDriverName = "";
			_currentPi.szPortName = "";
			_currentPi.szPrinterName = "";
		}
	}

	[DllImport("winspool.drv", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EnumPrintersW([MarshalAs(UnmanagedType.U4)] uint flags, [MarshalAs(UnmanagedType.LPTStr)] string printerName, [MarshalAs(UnmanagedType.U4)] uint level, IntPtr printerBuffer, [MarshalAs(UnmanagedType.U4)] uint sizeOfPrinterBuffer, [MarshalAs(UnmanagedType.U4)] out uint bytesReceived, [MarshalAs(UnmanagedType.U4)] out uint numPrinters);

	protected static void AddPrinterInfo(PRINTER_INFO returnPrinter, PRINTER_INFO_2W currentPrinter)
	{
		returnPrinter.szPrinterName = currentPrinter.szPrinterName;
		returnPrinter.szDriverName = currentPrinter.szDriverName;
		returnPrinter.szPortName = currentPrinter.szPortName;
		returnPrinter.Attributes = currentPrinter.Attributes;
		ResolvePort(currentPrinter.szDriverName, currentPrinter.szPortName, out var ipAddress, out var ipv6Addresses, out var hostName, out var portNumber, out var addresses, out var macAddress);
		returnPrinter.szIPAddress = ipAddress;
		returnPrinter.IPv6Addresses = ipv6Addresses;
		returnPrinter.szHostName = hostName;
		returnPrinter.dwPortNum = (uint)portNumber;
		returnPrinter.MacAddress = macAddress;
		if (addresses != null)
		{
			returnPrinter.AddressList = (string[])addresses.ToArray(typeof(string));
		}
	}

	protected static void ResolvePort(string printerName, string portName, out string ipAddress, out string[] ipv6Addresses, out string hostName, out int portNumber, out ArrayList addresses, out string macAddress)
	{
		ipAddress = null;
		addresses = new ArrayList();
		ipv6Addresses = null;
		hostName = null;
		portNumber = 0;
		macAddress = null;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Print\\Monitors\\HP Standard TCP/IP Port\\Ports\\" + portName);
		if (registryKey == null)
		{
			registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Print\\Monitors\\Advanced TCP/IP Port Monitor\\Ports\\" + portName);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Print\\Monitors\\Standard TCP/IP Port\\Ports\\" + portName);
			}
		}
		if (registryKey == null)
		{
			return;
		}
		hostName = (string)registryKey.GetValue("HostName");
		if (hostName != null && !hostName.Equals(string.Empty))
		{
			addresses.Add(hostName);
		}
		else
		{
			hostName = null;
		}
		ipAddress = (string)registryKey.GetValue("IPAddress");
		if (ipAddress != null && !ipAddress.Equals(string.Empty))
		{
			addresses.Add(ipAddress);
		}
		else
		{
			ipAddress = null;
		}
		ipv6Addresses = (string[])registryKey.GetValue("IPV6AddressEx");
		if (ipv6Addresses != null && ipv6Addresses.Length > 0)
		{
			string[] array = ipv6Addresses;
			foreach (string value in array)
			{
				addresses.Add(value);
			}
		}
		portNumber = (int)registryKey.GetValue("PortNumber");
		string text = (string)registryKey.GetValue("HWAddress");
		string text2 = (string)registryKey.GetValue("DeviceGUID");
		if (text != null && !text.Equals(string.Empty))
		{
			macAddress = text;
		}
		else
		{
			macAddress = text2;
		}
		registryKey.Close();
	}

	public void Dispose()
	{
		if (_ecd != null)
		{
			_ecd.Dispose();
		}
	}
}
