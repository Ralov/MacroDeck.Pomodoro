using SuchByte.MacroDeck.Plugins;
using System.Collections.Generic;

namespace MacroDeck.Pomodoro
{
    public class Main : MacroDeckPlugin
    {
        // Si NO vas a tener ventana de configuración, dejalo en false
        public override bool CanConfigure => false;

        public override void Enable()
        {
            this.Actions = new List<PluginAction>
            {
                new PomodoroAction()
            };
        }
    }
}