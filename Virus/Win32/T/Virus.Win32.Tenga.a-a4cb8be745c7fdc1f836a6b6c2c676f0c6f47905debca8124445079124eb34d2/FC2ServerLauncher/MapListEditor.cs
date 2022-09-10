using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.Win32;

namespace FC2ServerLauncher;

internal class MapListEditor : UITypeEditor
{
	public class SettingsAttribute : Attribute
	{
		private bool m_multiSelect;

		private string m_formText;

		public bool MultiSelect
		{
			get
			{
				return m_multiSelect;
			}
			set
			{
				m_multiSelect = value;
			}
		}

		public string FormText
		{
			get
			{
				return m_formText;
			}
			set
			{
				m_formText = value;
			}
		}

		public SettingsAttribute(bool multiSelect, string formText)
		{
			m_multiSelect = multiSelect;
			m_formText = formText;
		}
	}

	private SettingsAttribute m_settings = new SettingsAttribute(multiSelect: true, "");

	public SettingsAttribute Settings
	{
		get
		{
			return m_settings;
		}
		set
		{
			m_settings = value;
		}
	}

	private RegistryKey GetRegistrySettings()
	{
		return Registry.CurrentUser.CreateSubKey("Software\\Ubisoft\\Far Cry 2\\ServerLauncher");
	}

	private int GetRegistryInt(RegistryKey key, string name, int defaultValue)
	{
		object value = key.GetValue(name);
		if (value is int)
		{
			return (int)value;
		}
		return defaultValue;
	}

	private void LoadSettings(FormMapCycle form)
	{
		RegistryKey registrySettings = GetRegistrySettings();
		Rectangle rectangle = default(Rectangle);
		rectangle.X = GetRegistryInt(registrySettings, "MapCycleFormX", ((Control)form).get_Bounds().X);
		rectangle.Y = GetRegistryInt(registrySettings, "MapCycleFormY", ((Control)form).get_Bounds().Y);
		rectangle.Width = GetRegistryInt(registrySettings, "MapCycleFormW", ((Control)form).get_Bounds().Width);
		rectangle.Height = GetRegistryInt(registrySettings, "MapCycleFormH", ((Control)form).get_Bounds().Height);
		Screen[] allScreens = Screen.get_AllScreens();
		foreach (Screen val in allScreens)
		{
			if (val.get_Bounds().IntersectsWith(rectangle))
			{
				((Control)form).set_Bounds(rectangle);
				((Form)form).set_StartPosition((FormStartPosition)0);
				break;
			}
		}
		registrySettings.Close();
	}

	private void SaveSettings(FormMapCycle form)
	{
		RegistryKey registrySettings = GetRegistrySettings();
		registrySettings.SetValue("MapCycleFormX", ((Control)form).get_Bounds().X);
		registrySettings.SetValue("MapCycleFormY", ((Control)form).get_Bounds().Y);
		registrySettings.SetValue("MapCycleFormW", ((Control)form).get_Bounds().Width);
		registrySettings.SetValue("MapCycleFormH", ((Control)form).get_Bounds().Height);
		registrySettings.Close();
	}

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider serviceprovider, object value)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		IWindowsFormsEditorService val = null;
		if (serviceprovider != null)
		{
			object? service = serviceprovider.GetService(typeof(IWindowsFormsEditorService));
			val = (IWindowsFormsEditorService)((service is IWindowsFormsEditorService) ? service : null);
		}
		if (val != null)
		{
			FormMapCycle formMapCycle = new FormMapCycle();
			((Control)formMapCycle).set_Text(m_settings.FormText);
			formMapCycle.MultiSelect = m_settings.MultiSelect;
			formMapCycle.Maps = (List<string>)value;
			LoadSettings(formMapCycle);
			((Form)formMapCycle).ShowDialog();
			if ((int)((Form)formMapCycle).get_DialogResult() == 1)
			{
				value = new List<string>(formMapCycle.Maps);
			}
			SaveSettings(formMapCycle);
			return value;
		}
		return null;
	}

	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (context != null && context.Instance != null)
		{
			SettingsAttribute settingsAttribute = (SettingsAttribute)context.PropertyDescriptor.Attributes[typeof(SettingsAttribute)];
			if (settingsAttribute != null)
			{
				m_settings = settingsAttribute;
			}
			return (UITypeEditorEditStyle)2;
		}
		return ((UITypeEditor)this).GetEditStyle(context);
	}
}
