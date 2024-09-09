using System;
using System.Collections.Generic;

public static class ServiceLocator {
    private static readonly Dictionary<Type, object> Services = new();
    
    public static void Register<T>(T service) {
        Services.Add(typeof(T), service);
    }

    public static void Unregister<T>() {
        Services.Remove(typeof(T));
    }

    public static T Get<T>() {
        return (T)Services.GetValueOrDefault(typeof(T));
    }
}