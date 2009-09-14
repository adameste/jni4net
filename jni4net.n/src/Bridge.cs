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
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using java.lang;
using java_.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using selvin.exportdllattribute;
using Exception=System.Exception;
using Object=java.lang.Object;

namespace net.sf.jni4net
{
    public static partial class Bridge
    {
        private static readonly Dictionary<Assembly, object> knownAssemblies = new Dictionary<Assembly, object>();
        private static bool bindNative = true;
        public static bool Verbose { get; set; }
        public static bool Debug { get; set; }

        public static bool BindNative
        {
            get { return bindNative; }
            set { bindNative = value; }
        }

        public static void CreateJVM(params string[] options)
        {
            JavaVM jvm;
            JNIEnv env;
            JNI.CreateJavaVM(out jvm, out env, true, options);
        }

        public static void CreateJVM(out JavaVM jvm, out JNIEnv env, params string[] options)
        {
            JNI.CreateJavaVM(out jvm, out env, true, options);
        }

        public static void LoadAndRegisterAssembly(string assemblyPath)
        {
            Assembly assembly;
            if (File.Exists(assemblyPath))
            {
                assembly = Assembly.LoadFrom(assemblyPath);
            }
            else
            {
                assembly = Assembly.Load(assemblyPath);
            }
            RegisterAssembly(assembly);
        }

        public static void RegisterAssembly(Assembly assembly)
        {
            if (knownAssemblies.ContainsKey(assembly))
            {
                if (Verbose)
                {
                    Console.WriteLine("skipped " + assembly + " from " + assembly.Location);
                }
                return;
            }
            if (Verbose)
            {
                Console.WriteLine("loading " + assembly + " from " + assembly.Location);
            }
            knownAssemblies.Add(assembly, assembly);
            JNIEnv env = JNIEnv.ThreadEnv;
            //JavaProxiesMap.RegisterAssembly(env, assembly);
            //ClrProxiesMap.RegisterAssembly(env, assembly);
            Registry.RegisterAssembly(assembly, true);

            if (Verbose)
            {
                Console.WriteLine("loaded " + assembly + " from " + assembly.Location);
            }
        }

        public static void disposeClrHandle(int clrHandle)
        {
            IntHandle.Free(clrHandle);
        }

        #region Initialization

        [ExportDll("Java_net_sf_jni4net_Bridge_initDotNet", CallingConvention.StdCall)]
        internal static int initDotNet(IntPtr envi, IntPtr clazz)
        {
            JNIEnv env;
            try
            {
                env = JNIEnv.Wrap(envi);
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Can't bind env");
                return -1;
            }
            IntPtr br = env.FindClassPtr("net/sf/jni4net/Bridge");
            IntPtr vb = env.GetStaticFieldIDPtr(br, "verbose", "Z");
            Verbose = env.GetStaticBooleanField(br, vb);
            IntPtr db = env.GetStaticFieldIDPtr(br, "debug", "Z");
            Debug = env.GetStaticBooleanField(br, db);
            
            try
            {
                if (Verbose)
                {
                    Console.WriteLine("loading core from " + typeof(Bridge).Assembly.Location);
                }
                Init(env);
                if (Verbose)
                {
                    Console.WriteLine("core loaded from " + typeof (Bridge).Assembly.Location);
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Can't init bridge:" + ex.Message);
                Console.Error.WriteLine("Can't init bridge:" + ex);
                Class exClazz = env.FindClass("net/sf/jni4net/inj/INJException");
                env.ThrowNew(exClazz, ex.Message);
                return -1;
            }
            return 0;
        }

        internal static void Init(JNIEnv env)
        {
            if (BindNative)
            {
                IntPtr br = env.FindClassPtr("net/sf/jni4net/Bridge");
                IntPtr ir = env.GetStaticFieldIDPtr(br, "isRegistered", "Z");
                var isRegistered = env.GetStaticBooleanField(br, ir);
                if (isRegistered)
                {
                    // rather neat. When called like Clr->Java->Clr this dll gets loaded twice.
                    // which means two separate sets CLR of classes and static members
                    if (Verbose)
                    {
                        Console.WriteLine("Already initialized jni4net core before");
                    }
                    return;
                }
            }

            RegisterAssembly(typeof(Bridge).Assembly);
            MethodInfo initializer = Registry.GetWrapperInitializer(typeof (__Bridge), "__Init2");
            RegistryRecord record = Registry.GetCLRRecord(typeof (Bridge));
            Registry.RegisterNative(initializer, env, record.JVMProxy, record.JVMInterface);

            if (Verbose)
            {
                Console.WriteLine("Initialized jni4net core");
            }
            if (BindNative)
            {
                IntPtr br = env.FindClassPtr("net/sf/jni4net/Bridge");
                IntPtr ir = env.GetStaticFieldIDPtr(br, "isRegistered", "Z");
                env.SetStaticBooleanField(br, ir, true);
            }
        }

        #endregion
    }
}