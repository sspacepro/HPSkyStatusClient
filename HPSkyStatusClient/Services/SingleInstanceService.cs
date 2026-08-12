using System.Threading;

namespace HPSkyStatusClient.Services;

public static class SingleInstanceService
{
    private const string MutexName =
        "HPSkyStatusClient-SingleInstance";

    private const string EventName =
        "HPSkyStatusClient-ShowMainForm";

    private static Mutex? _mutex;
    private static EventWaitHandle? _event;

    public static bool IsFirstInstance()
    {
        _mutex = new Mutex(
            true,
            MutexName,
            out bool createdNew);

        if (!createdNew)
        {
            SignalExistingInstance();
            return false;
        }

        _event = new EventWaitHandle(
            false,
            EventResetMode.AutoReset,
            EventName);

        return true;
    }

    public static void StartListener(Action showMainForm)
    {
        if (_event == null)
            return;

        Task.Run(() =>
        {
            while (true)
            {
                try
                {
                    _event.WaitOne();

                    showMainForm();
                }
                catch
                {
                    break;
                }
            }
        });
    }

    private static void SignalExistingInstance()
    {
        try
        {
            using var existingEvent =
                EventWaitHandle.OpenExisting(EventName);

            existingEvent.Set();
        }
        catch
        {
            // Existing instance may still be starting.
        }
    }

    public static void Dispose()
    {
        _event?.Dispose();
        _mutex?.ReleaseMutex();
        _mutex?.Dispose();
    }
}