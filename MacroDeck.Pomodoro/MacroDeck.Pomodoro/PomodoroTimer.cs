using System;
using System.Timers;

namespace MacroDeck.Pomodoro
{
    public static class PomodoroTimer
    {
        private static Timer? _timer;

        public static int RemainingSeconds { get; private set; }
        public static bool IsRunning { get; private set; }

        public static event Action? OnTick;
        public static event Action? OnFinished;

        public static void Start(int minutes = 25)
        {
            // Si ya está corriendo, no hagas nada
            if (IsRunning) return;

            // Si no hay tiempo cargado (nuevo o reseteado), carga el tiempo
            if (RemainingSeconds <= 0)
                RemainingSeconds = minutes * 60;

            _timer ??= new Timer(1000);
            _timer.AutoReset = true;
            _timer.Elapsed -= Tick;   // evita doble suscripción si Start se llama varias veces
            _timer.Elapsed += Tick;
            _timer.Start();

            IsRunning = true;
            OnTick?.Invoke();
        }

        public static void Pause()
        {
            _timer?.Stop();
            IsRunning = false;
            OnTick?.Invoke();
        }

        public static void Reset()
        {
            _timer?.Stop();
            RemainingSeconds = 0;
            IsRunning = false;
            OnTick?.Invoke();
        }

        private static void Tick(object? sender, ElapsedEventArgs e)
        {
            RemainingSeconds--;

            OnTick?.Invoke();

            if (RemainingSeconds <= 0)
            {
                _timer?.Stop();
                IsRunning = false;
                RemainingSeconds = 0;
                OnFinished?.Invoke();
                OnTick?.Invoke();
            }
        }
    }
}