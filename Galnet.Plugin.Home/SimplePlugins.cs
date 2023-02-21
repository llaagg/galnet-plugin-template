using Galnet.Common;

namespace Galnet.Plugin.Home;

public class SimplePlugins : Plugin.Base.PluginRegistry
{
    public override void OnInit()
    {
        this.AddPlugin(this.Nop);
    }

    private void Nop(IContext context)
    {
        Console.WriteLine("nop");
    }
}
