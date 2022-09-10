#define TRACE
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Text;
using Com.HP.App.HPToolkit;
using Com.HP.App.HPToolkit.HPDevice;
using Com.HP.App.HPTools;
using Com.HP.App.HPTools.HPDebug;
using Com.HP.HPXML;
using Com.HP.HPXML.DD.LEDMObjects;

namespace Com.HP.IPG.HPLJUTBES;

public class DataCollector
{
	private LedmXmlObjectManager _xmlObjects;

	private XmlDataModel _currentLedmObject;

	public bool CollectData(ClientDevice device, IHPLaserJetService serviceInstance)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		DebugOutput.WriteLine("Enter CollectData with device port = " + device.get_PortName(), 5);
		DebugOutput.WriteLine("                and ConnectionTypeNetworked = " + device.get_IsNetworked(), 5);
		if (device.get_PortName().Length > 0 && device.get_DriverName().Length > 0)
		{
			_xmlObjects = new LedmXmlObjectManager(device, device.get_DevGuid(), serviceInstance, device.get_IsConnected());
			if (_xmlObjects != null)
			{
				Trace.WriteLine("_xmlObjects is not null");
				try
				{
					ArrayList discoveredTreeTypeNames = _xmlObjects.get_DiscoveredTreeTypeNames();
					Trace.WriteLine("DiscoveredTreeTypeNames returned ok " + discoveredTreeTypeNames.Count);
					if (discoveredTreeTypeNames.Count > 0)
					{
						string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "HP\\HPLJUT");
						string text = Path.Combine(path, device.get_DriverName());
						if (!Directory.Exists(text))
						{
							Directory.CreateDirectory(text);
							OSUtils.AddDirectorySecurity(text.ToString(), FileSystemRights.FullControl, AccessControlType.Allow);
						}
						string path2 = device.get_PortName() + "_SureSupply.xml";
						string xmlFilePath = Path.Combine(text, path2);
						try
						{
							SaveTreeAsXML("ledm:hpLedmShopForSupplies", xmlFilePath, append: false);
						}
						catch (Exception ex)
						{
							Trace.WriteLine("Exception getting hpLedmShopForSupplies " + ex.Message);
						}
					}
				}
				catch (Exception ex2)
				{
					Trace.WriteLine("Device is not responding threw exception" + ex2.Message);
				}
			}
			return true;
		}
		DebugOutput.WriteLine("model or device port was not specified correctly", 5);
		return false;
	}

	private void SaveTreeAsXML(string treeName, string xmlFilePath, bool append)
	{
		if (append)
		{
			throw new NotImplementedException();
		}
		_currentLedmObject = ((XmlObjectManager)_xmlObjects).GetTreeObject(treeName);
		using FileStream fileStream = new FileStream(xmlFilePath, FileMode.Create, FileAccess.Write);
		string currentResponse = ((XmlObjectManager)_xmlObjects).get_CurrentResponse();
		string text = string.Empty;
		int num = currentResponse.IndexOf("<?xml version");
		if (num != -1)
		{
			text = currentResponse.Substring(num);
		}
		fileStream.Write(Encoding.UTF8.GetBytes(text), 0, text.Length);
		fileStream.Close();
	}
}
