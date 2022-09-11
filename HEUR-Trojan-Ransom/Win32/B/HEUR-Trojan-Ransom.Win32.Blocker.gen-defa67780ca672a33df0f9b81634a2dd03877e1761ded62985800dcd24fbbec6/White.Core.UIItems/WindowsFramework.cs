namespace White.Core.UIItems;

public class WindowsFramework
{
	private readonly string frameworkId;

	public virtual bool IsManaged
	{
		get
		{
			if (!WinForm)
			{
				return WPF;
			}
			return true;
		}
	}

	public virtual bool WinForm => frameworkId.Equals("WinForm");

	public virtual bool WPF => frameworkId.Equals("WPF");

	public virtual bool Win32 => frameworkId.Equals("Win32");

	public virtual bool UIAutomationBug
	{
		get
		{
			if (!string.IsNullOrEmpty(frameworkId))
			{
				return frameworkId.Trim() == string.Empty;
			}
			return true;
		}
	}

	public virtual bool Silverlight => frameworkId.Equals("Silverlight");

	public WindowsFramework(string frameworkId)
	{
		this.frameworkId = frameworkId;
	}

	public override string ToString()
	{
		return frameworkId;
	}
}
