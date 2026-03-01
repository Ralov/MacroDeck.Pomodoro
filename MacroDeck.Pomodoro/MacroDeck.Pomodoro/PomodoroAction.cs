using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.ActionButton;

namespace MacroDeck.Pomodoro
{
    public class PomodoroAction : PluginAction
    {
        public override string Name => "Toggle Pomodoro";

        public override string Description => "Inicia o pausa el temporizador Pomodoro";

        public override bool CanConfigure => false;


        public override void Trigger(string clientId, ActionButton actionButton)
        {
            if (!PomodoroTimer.IsRunning)
            {
                PomodoroTimer.Start();
            }
            else
            {
                PomodoroTimer.Pause();
            }
        }
    }
}