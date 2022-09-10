using System;
using Com.HP.App.HPTools.HPDebug;

namespace Com.HP.IPG.HPLJUTBES;

internal class HPLJUTBackendServer
{
	[STAThread]
	private static void Main(string[] args)
	{
		string text = string.Empty;
		string portName = string.Empty;
		string empty = string.Empty;
		bool isNetworked = false;
		if (args.Length > 0)
		{
			DebugOutput.WriteLine("HPLJUTBackendServer: in Main()", 5);
			if (args.Length > 0)
			{
				int num = args.Length;
				int num2 = Array.IndexOf(args, "/Device");
				if (num > 0 && num2 >= 0 && num2 < num)
				{
					DebugOutput.Write("HPLJUTBackendServer: args Device = ", 5);
					if (num2 + 1 < num)
					{
						portName = (string)args.GetValue(num2 + 1);
					}
				}
				int num3 = Array.IndexOf(args, "/io");
				if (num > 0 && num3 >= 0 && num3 < num)
				{
					DebugOutput.Write("HPLJUTBackendServer: arg io = ", 5);
					if (num3 + 1 < num)
					{
						empty = (string)args.GetValue(num3 + 1);
						DebugOutput.WriteLine(empty, 5);
						if (empty == "USB")
						{
							isNetworked = false;
						}
						else if (empty == "NW")
						{
							isNetworked = true;
						}
					}
				}
				int num4 = Array.IndexOf(args, "/Model");
				if (num > 0 && num4 >= 0 && num4 < num)
				{
					DebugOutput.Write("HPLJUTBackendServer: arg Model (driver name for device enumeration) = ", 5);
					if (num4 + 1 < num)
					{
						text = (string)args.GetValue(num4 + 1);
						DebugOutput.WriteLine(text, 5);
					}
				}
			}
		}
		try
		{
			using DeviceEnumerator deviceEnumerator = new DeviceEnumerator();
			if (deviceEnumerator.GetDevice(text, portName))
			{
				DataCollector dataCollector = new DataCollector();
				if (dataCollector.CollectData(deviceEnumerator.Device, deviceEnumerator.HPLJServiceInstance))
				{
					DataUploader dataUploader = new DataUploader();
					dataUploader.UploadData(text, portName, isNetworked, addSegmentationData: true, useTestServer: true);
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
