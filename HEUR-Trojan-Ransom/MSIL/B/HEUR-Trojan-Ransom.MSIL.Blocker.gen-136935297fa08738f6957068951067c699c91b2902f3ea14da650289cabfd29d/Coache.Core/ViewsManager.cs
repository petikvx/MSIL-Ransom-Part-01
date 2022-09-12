using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Coache.Common;
using Coache.Login;

namespace Coache.Core;

internal class ViewsManager
{
	private static Form _mainWindow;

	private static Dictionary<Type, Form> _Views = new Dictionary<Type, Form>();

	public static void SetMainWindow(Form mainWindow)
	{
		mainWindow.set_IsMdiContainer(true);
		_mainWindow = mainWindow;
	}

	public static void LoadView(Form form)
	{
		ClearViews();
		((Control)form).set_Text(string.Empty);
		form.set_ShowIcon(false);
		form.set_ControlBox(false);
		((Control)form).set_Dock((DockStyle)5);
		form.set_ShowInTaskbar(false);
		form.set_WindowState((FormWindowState)2);
		form.set_MdiParent(_mainWindow);
		form.set_TopMost(true);
		((Control)form).set_Top(1);
		((Control)form).Show();
	}

	public static void LoadModal(Form form)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		form.set_ShowIcon(false);
		form.set_MaximizeBox(false);
		form.set_MinimizeBox(false);
		form.set_FormBorderStyle((FormBorderStyle)3);
		form.set_ShowInTaskbar(false);
		form.set_TopMost(true);
		form.ShowDialog();
	}

	public static void LoadMenu()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		foreach (Type item in from x in typeof(MainView).Assembly.GetTypes()
			where x.IsSubclassOf(typeof(Form))
			select x)
		{
			if (IsAccesibleForm(item))
			{
				AddMenuItemForView(item);
			}
		}
		ToolStripMenuItem val = new ToolStripMenuItem("Salir", (Image)null, (EventHandler)Logoff);
		((ToolStrip)_mainWindow.get_MainMenuStrip()).get_Items().Add((ToolStripItem)(object)val);
	}

	public static void ClearViews()
	{
		Form[] mdiChildren = _mainWindow.get_MdiChildren();
		for (int i = 0; i < mdiChildren.Length; i++)
		{
			((Control)mdiChildren[i]).Hide();
		}
		if (_mainWindow.get_ActiveMdiChild() != null)
		{
			((Control)_mainWindow.get_ActiveMdiChild()).Hide();
		}
	}

	public static void Alert(string message)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(message);
	}

	public static void Reset()
	{
		((ToolStrip)_mainWindow.get_MainMenuStrip()).get_Items().Clear();
		_Views.Clear();
		LoadView((Form)(object)new LoginForm());
	}

	private static void AddMenuItemForView(Type formType)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		ToolStripMenuItem val = new ToolStripMenuItem(((Control)(Form)Activator.CreateInstance(formType)).get_Text(), (Image)null, (EventHandler)Navigate);
		((ToolStripItem)val).set_Tag((object)formType);
		ToolStripMenuItem val2 = val;
		((ToolStrip)_mainWindow.get_MainMenuStrip()).get_Items().Add((ToolStripItem)(object)val2);
	}

	private static void Navigate(object sender, EventArgs e)
	{
		Type type = ((ToolStripItem)((sender is ToolStripMenuItem) ? sender : null)).get_Tag() as Type;
		if (_Views.ContainsKey(type))
		{
			LoadView(_Views[type]);
			return;
		}
		object? obj = Activator.CreateInstance(type);
		Form val = (Form)((obj is Form) ? obj : null);
		_Views.Add(type, val);
		LoadView(val);
	}

	private static void Logoff(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("Confirma que desea salir del sistema?", "Salir", (MessageBoxButtons)1) == 1)
		{
			Session.Close();
		}
	}

	private static bool IsAccesibleForm(Type formType)
	{
		if ((NonNavigableAttribute)Attribute.GetCustomAttribute(formType, typeof(NonNavigableAttribute)) != null)
		{
			return false;
		}
		PermissionRequiredAttribute permissionRequiredAttribute = (PermissionRequiredAttribute)Attribute.GetCustomAttribute(formType, typeof(PermissionRequiredAttribute));
		if (permissionRequiredAttribute == null)
		{
			return true;
		}
		Functionalities[] permissions = permissionRequiredAttribute.Permissions;
		int num = 0;
		while (true)
		{
			if (num < permissions.Length)
			{
				Functionalities item = permissions[num];
				if (!Session.User.Permissions.Contains(item))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}
}
