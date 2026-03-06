using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;

namespace prueba
{
    public class Main : MacroDeckPlugin
    {

        public override void Enable()
        {
            this.Actions = new List<PluginAction>();

            MacroDeckLogger.Info(this, typeof(Main), "Plugin prueba activado");
        }

  
    }
}