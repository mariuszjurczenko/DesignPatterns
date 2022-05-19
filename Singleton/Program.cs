using Singleton;

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Instancje są takie same.");
}

instance1.Log($"Wiadomość od {nameof(instance1)}");
instance1.Log($"Wiadomość od {nameof(instance2)}");
Logger.Instance.Log($"Wiadomość od {nameof(Logger.Instance)}");