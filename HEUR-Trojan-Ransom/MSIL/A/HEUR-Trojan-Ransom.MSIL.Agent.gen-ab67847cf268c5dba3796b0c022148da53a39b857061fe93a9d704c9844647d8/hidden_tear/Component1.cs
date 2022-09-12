using System.ComponentModel;

namespace hidden_tear;

public class Component1 : Component
{
	private IContainer components;

	public Component1()
	{
		InitializeComponent();
	}

	public Component1(IContainer container)
	{
		container.Add(this);
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		components = new Container();
	}
}
