using SuchByte.MacroDeck.Plugins;
using System.Collections.Generic;

namespace MacroDeck.Pomodoro
{
    public class PomodoroPlugin : MacroDeckPlugin
    {
        public override void Enable()
        {
            this.Actions = new List<PluginAction>
            {
                new PomodoroAction()
            };
        }
    }
}