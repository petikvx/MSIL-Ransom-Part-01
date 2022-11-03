using System;

namespace xClient.Core.MouseKeyHook;

public interface IKeyboardMouseEvents : IDisposable, IKeyboardEvents, IMouseEvents
{
}
