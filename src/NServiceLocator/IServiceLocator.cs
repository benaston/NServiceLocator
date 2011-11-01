namespace NServiceLocator
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///   Responsible for defining the interface for types 
    ///   providing service-location functionality.
    /// </summary>
    public interface IServiceLocator<out TActivationContext>
    {
        void BindToSelf(Type obj);

        void BindToSelf<T>();

        void BindToMethod<T>(Func<TActivationContext, T> func);

        void BindToInterface<TImplementation, TInterface>(TImplementation type, TInterface tInterface)
            where TImplementation : TInterface where TInterface : Type;

        void BindToInterface<TImplementation, TInterface>() where TImplementation : TInterface;

        void Release(object obj);

        object Locate(Type type);

        T Locate<T>();

        IEnumerable<T> LocateAllImplementorsOf<T>();

        IEnumerable<object> LocateAllImplementorsOf(Type type);
    }
}