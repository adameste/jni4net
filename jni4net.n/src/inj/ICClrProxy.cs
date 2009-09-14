#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as 
published by the Free Software Foundation, either version 3 
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using java.lang;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.inj
{
    public partial interface ICClrProxy : ICJvmProxy
    {
        int getClrHandle();

        void initProxy(int par0);
    }

    internal partial class __ICClrProxy
    {
        private static int getClrHandle(JNIEnv env, IntPtr obj)
        {
            return env.CallIntMethod(obj, _getClrHandle0);
        }

        internal static object GetObject(JNIEnv env, IntPtr obj)
        {
            int handle = getClrHandle(env, obj);
            object real = IntHandle.ToObject(handle);
            return real;
        }

        internal static ICClrProxy CreateProxy(JNIEnv env, IntPtr obj, Class clazz)
        {
            ICClrProxy proxy = new __ICClrProxy(env);
            proxy.Init(env, obj, clazz);
            return proxy;
        }
    }
}