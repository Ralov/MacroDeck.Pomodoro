using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck.Plugins;
using System.Collections.Generic;

namespace Sebastian.Prueba1
{
    public class Main : MacroDeckPlugin
    {
        public override bool CanConfigure => false;

        public override void Enable()
        {
            this.Actions = new List<PluginAction>();
            MacroDeckLogger.Info(this, "Prueba1 cargado correctamente");
        }
    }
}