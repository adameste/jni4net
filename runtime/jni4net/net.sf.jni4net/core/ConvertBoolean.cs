﻿#region Copyright (C) 2012 by Pavel Savara

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

// ReSharper disable RedundantAssignment

using System;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    public class ConvertBoolean
    {
        #region To JVM

        public static JNIValueRef ToRefParam(JNIEnv env, bool value)
        {
            var _outObject = env.NewObject(Registry.refWrapper.JVMApi, Registry.refWrapperConstructor, ToWrappedValue(env, value));
            return new JNIValueRef(_outObject);
        }

        public static JNIValueRef ToRefParam(JNIEnv env, bool[] value)
        {
            var _outObject = env.NewObject(Registry.refWrapper.JVMApi, Registry.refWrapperConstructor, ToWrappedValue(env, value));
            return new JNIValueRef(_outObject);
        }

        public static JNIValueRef ToRefParam(JNIEnv env, bool[][] value)
        {
            var _outObject = env.NewObject(Registry.refWrapper.JVMApi, Registry.refWrapperConstructor, ToWrappedValue(env, value));
            return new JNIValueRef(_outObject);
        }

        public static JNIValue ToValue(bool value)
        {
            return new JNIValue {_bool = value ? (byte) 1 : (byte) 0};
        }

        public static JNIValue ToBoxedValue(JNIEnv env, bool[] value)
        {
            return new JNIValue { _object = ToBoxedPtr(env, value) };
        }

        public static JNIValue ToBoxedValue(JNIEnv env, bool value)
        {
            return new JNIValue {_object = ToBoxedPtr(env, value)};
        }

        public static JNIValue ToWrappedValue(JNIEnv env, bool[] value)
        {
            return new JNIValue { _object = ToWrappedPtr(env, value) };
        }

        public static JNIValue ToWrappedValue(JNIEnv env, bool[][] value)
        {
            return new JNIValue { _object = ToWrappedPtr(env, value) };
        }

        public static JNIValue ToWrappedValue(JNIEnv env, bool value)
        {
            return new JNIValue { _object = ToWrappedPtr(env, value) };
        }

        public static IntPtr ToBoxedPtr(JNIEnv env, bool value)
        {
            return env.NewObject(Registry.javaLangBoolean.JVMApi, Registry.javaLangBoolean.Members[1], ToValue(value));
        }

        public static IntPtr ToWrappedPtr(JNIEnv env, bool value)
        {
            return Registry.systemBool.CLRProxyFactory(env, value, typeof(bool));
        }

        public static JNIValue ToValue(JNIEnv env, bool[] value)
        {
            return new JNIValue { _object = ToPtr(env, value) };
        }

        public static JNIValue ToValue(JNIEnv env, bool[][] value)
        {
            return new JNIValue { _object = ToPtr(env, value) };
        }

        public static IntPtr ToPtr(JNIEnv env, bool[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            return env.NewBooleanArray(value);
        }

        public static IntPtr ToWrappedPtr(JNIEnv env, bool[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            IntPtr arr = env.NewObjectArray(Registry.systemBool.JVMApi, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    env.SetObjectArrayElement(arr, i, ToWrappedPtr(env, value[i]));
                }
                return arr;
            }
        }

        public static IntPtr ToBoxedPtr(JNIEnv env, bool[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            IntPtr arr = env.NewObjectArray(Registry.javaLangBoolean.JVMApi, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    env.SetObjectArrayElement(arr, i, ToBoxedPtr(env, value[i]));
                }
                return arr;
            }
        }

        public static IntPtr ToPtr(JNIEnv env, bool[][] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            IntPtr arr = env.NewObjectArray(Registry.javaLangBoolean.JVMApiArray, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    bool[] value2 = value[i];
                    if (value2 != null)
                    {
                        env.SetObjectArrayElement(arr, i, env.NewBooleanArray(value2));
                    }
                }
                return arr;
            }
        }

        public static IntPtr ToWrappedPtr(JNIEnv env, bool[][] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            IntPtr arr = env.NewObjectArray(Registry.systemBool.JVMApiArray, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    bool[] value2 = value[i];
                    if (value2 != null)
                    {
                        env.SetObjectArrayElement(arr, i, ToWrappedPtr(env,value2));
                    }
                }
                return arr;
            }
        }

        #endregion

        #region To CLR

        public static void FromOutParam(JNIEnv env, JNIValueOut param, out bool value)
        {
            var val = env.GetObjectField(param._outObject, Registry.outWrapperField);
            value = ConvertAbstract.ToCLR<bool>(env, val);
        }

        public static void FromOutParam(JNIEnv env, JNIValueOut param, out bool[] value)
        {
            var val = env.GetObjectField(param._outObject, Registry.outWrapperField);
            value = ConvertAbstract.ToCLRArray1<bool>(env, val);
        }

        public static void FromOutParam(JNIEnv env, JNIValueOut param, out bool[][] value)
        {
            var val = env.GetObjectField(param._outObject, Registry.outWrapperField);
            value = ConvertAbstract.ToCLRArray11<bool>(env, val);
        }

        public static void FromRefParam(JNIEnv env, JNIValueRef param, ref bool value)
        {
            var val = env.GetObjectField(param._refObject, Registry.refWrapperField);
            value = ConvertAbstract.ToCLR<bool>(env, val);
        }

        public static void FromRefParam(JNIEnv env, JNIValueRef param, ref bool[] value)
        {
            var val = env.GetObjectField(param._refObject, Registry.refWrapperField);
            value = ConvertAbstract.ToCLRArray1<bool>(env, val);
        }

        public static void FromRefParam(JNIEnv env, JNIValueRef param, ref bool[][] value)
        {
            var val = env.GetObjectField(param._refObject, Registry.refWrapperField);
            value = ConvertAbstract.ToCLRArray11<bool>(env, val);
        }

        public static bool[] ToCLRArray1(JNIEnv env, IntPtr array)
        {
            return env.GetBooleanArray(array);
        }

        public static bool[][] ToCLRArray11(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new bool[length][];
            for (int i = 0; i < length; i++)
            {
                res[i] = ToCLRArray1(env, env.GetObjectArrayElement(array, i));
            }
            return res;
        }

        #endregion
    }
}
