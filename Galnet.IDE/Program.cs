using Galnet.Platform;
using Galnet.Plugin.Home;

var manager = new Manager();
manager.Register(new SimplePlugins());

manager.Context().Call(nameof(SimplePlugins.Nop));
