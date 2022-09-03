using System.ComponentModel;
using System.Windows.Forms;
using Smart.Windows.Mvc;

namespace setup;

public class AppViewBase : ControlViewBase, IApplicationView
{
	private IContainer components;

	protected IFunctionControl FunctionCotrol { get; set; }

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ControlViewBase)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		components = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
	}

	public AppViewBase()
	{
		InitializeComponent();
	}

	public virtual void OnButtonExit()
	{
	}

	public void SetFunctionControl(IFunctionControl function)
	{
		FunctionCotrol = function;
	}

	public virtual void OnFunctionKey(Keys key)
	{
	}
}
