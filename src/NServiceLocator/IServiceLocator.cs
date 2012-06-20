// Copyright 2011, Ben Aston (ben@bj.ma).
// 
// This file is part of NServiceLocator.
// 
// NServiceLocator is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// NServiceLocator is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with NServiceLocator.  If not, see <http://www.gnu.org/licenses/>.

namespace NServiceLocator
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// 	Responsible for defining the interface for types providing service-location functionality.
	/// </summary>
	/// <typeparam name="TActivationContext">The type of object used within the BindToMethod method argument. This is the type used  For Ninject this would be be Ninject.Activation.IContext.</typeparam>
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