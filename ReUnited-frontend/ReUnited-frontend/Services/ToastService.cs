namespace Services
{
    public static class ToastService
    {
        public static event Action<string>? OnShow;
        public static void Show(string message)
        {
            OnShow?.Invoke(message);
        }
    }
}