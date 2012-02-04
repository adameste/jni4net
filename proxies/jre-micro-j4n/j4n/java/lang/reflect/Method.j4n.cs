// This code was generated using jni4net. See http://jni4net.sourceforge.net/

#region Component Designer generated code
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantCast
// ReSharper disable RedundantCommaInArrayInitializer
// ReSharper disable RedundantExplicitArrayCreation
// ReSharper disable UnassignedField.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantExtendsListEntry
// ReSharper disable SuggestUseVarKeywordEvident
// ReSharper disable PossibleMultipleEnumeration
// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedMember.Global
#pragma warning disable 109
#pragma warning disable 649
#pragma warning disable 618

namespace java.lang.reflect
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.Method))]
    public sealed partial class Method : global::java.lang.reflect.AccessibleObject, global::java.lang.reflect.GenericDeclaration, global::java.lang.reflect.Member
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private Method(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.reflect.Method(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Method()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.reflect.AccessibleObject));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.reflect.GenericDeclaration_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.reflect.GenericDeclaration_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.reflect.Member_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.reflect.Member_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.Method));
        }
        
        /// <signature>#0 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        public global::java.lang.Class getDeclaringClass()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Method.j4n_Members[0]));
            }
        }
        
        /// <signature>#1 ()Ljava/lang/Object; ()Lsystem/Object;</signature>
        public object getDefaultValue()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Method.j4n_Members[1]));
            }
        }
        
        /// <signature>#2 ()[Ljava/lang/Class; ()[Ljava/lang/Class;</signature>
        public global::java.lang.Class[] getExceptionTypes()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Method.j4n_Members[2]));
            }
        }
        
        /// <signature>#3 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
        public global::java.lang.reflect.Type[] getGenericExceptionTypes()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.reflect.Type>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Method.j4n_Members[3]));
            }
        }
        
        /// <signature>#4 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
        public global::java.lang.reflect.Type[] getGenericParameterTypes()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.reflect.Type>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Method.j4n_Members[4]));
            }
        }
        
        /// <signature>#5 ()Ljava/lang/reflect/Type; ()Ljava/lang/reflect/Type;</signature>
        public global::java.lang.reflect.Type getGenericReturnType()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.reflect.Type>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Method.j4n_Members[5]));
            }
        }
        
        /// <signature>#6 ()I ()I</signature>
        public int getModifiers()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.lang.reflect.Method.j4n_Members[6]);
            }
        }
        
        /// <signature>#7 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getName()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.reflect.Method.j4n_Members[7]);
            }
        }
        
        /// <signature>#8 ()[[Ljava/lang/annotation/Annotation; ()[[Ljava/lang/annotation/Annotation;</signature>
        public global::java.lang.annotation.Annotation[][] getParameterAnnotations()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray11<global::java.lang.annotation.Annotation>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Method.j4n_Members[8]));
            }
        }
        
        /// <signature>#9 ()[Ljava/lang/Class; ()[Ljava/lang/Class;</signature>
        public global::java.lang.Class[] getParameterTypes()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Method.j4n_Members[9]));
            }
        }
        
        /// <signature>#10 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        public global::java.lang.Class getReturnType()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Method.j4n_Members[10]));
            }
        }
        
        /// <signature>#11 ()[Ljava/lang/reflect/TypeVariable; ()[Ljava/lang/reflect/TypeVariable;</signature>
        public global::java.lang.reflect.TypeVariable[] getTypeParameters()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.reflect.TypeVariable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Method.j4n_Members[11]));
            }
        }
        
        /// <signature>#12 (Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;[Lsystem/Object;)Lsystem/Object;</signature>
        public object invoke(object par0, object[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Method.j4n_Members[12], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object")));
            }
        }
        
        /// <signature>#13 ()Z ()Z</signature>
        public bool isBridge()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.reflect.Method.j4n_Members[13]);
            }
        }
        
        /// <signature>#14 ()Z ()Z</signature>
        public bool isSynthetic()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.reflect.Method.j4n_Members[14]);
            }
        }
        
        /// <signature>#15 ()Z ()Z</signature>
        public bool isVarArgs()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.reflect.Method.j4n_Members[15]);
            }
        }
        
        /// <signature>#16 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string toGenericString()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.reflect.Method.j4n_Members[16]);
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.reflect.Method))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.reflect.Method";
                    proxyInfo.JVMStaticApiName = "java_.lang.reflect.Method_";
                    proxyInfo.CLRApi = typeof(java.lang.reflect.Method);
                    proxyInfo.CLRStaticApi = typeof(java.lang.reflect.Method);
                    proxyInfo.CLRProxy = typeof(java.lang.reflect.Method);
                    proxyInfo.JVMProxyFactory = java.lang.reflect.Method.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("getDeclaringClass","()Ljava/lang/Class;", false, false), // #0 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getDefaultValue","()Ljava/lang/Object;", false, false), // #1 ()Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("getExceptionTypes","()[Ljava/lang/Class;", false, false), // #2 ()[Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getGenericExceptionTypes","()[Ljava/lang/reflect/Type;", false, false), // #3 ()[Ljava/lang/reflect/Type;
                        new global::net.sf.jni4net.core.MemberId("getGenericParameterTypes","()[Ljava/lang/reflect/Type;", false, false), // #4 ()[Ljava/lang/reflect/Type;
                        new global::net.sf.jni4net.core.MemberId("getGenericReturnType","()Ljava/lang/reflect/Type;", false, false), // #5 ()Ljava/lang/reflect/Type;
                        new global::net.sf.jni4net.core.MemberId("getModifiers","()I", false, false), // #6 ()I
                        new global::net.sf.jni4net.core.MemberId("getName","()Ljava/lang/String;", false, false), // #7 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getParameterAnnotations","()[[Ljava/lang/annotation/Annotation;", false, false), // #8 ()[[Ljava/lang/annotation/Annotation;
                        new global::net.sf.jni4net.core.MemberId("getParameterTypes","()[Ljava/lang/Class;", false, false), // #9 ()[Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getReturnType","()Ljava/lang/Class;", false, false), // #10 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getTypeParameters","()[Ljava/lang/reflect/TypeVariable;", false, false), // #11 ()[Ljava/lang/reflect/TypeVariable;
                        new global::net.sf.jni4net.core.MemberId("invoke","(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #12 (Lsystem/Object;[Lsystem/Object;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("isBridge","()Z", false, false), // #13 ()Z
                        new global::net.sf.jni4net.core.MemberId("isSynthetic","()Z", false, false), // #14 ()Z
                        new global::net.sf.jni4net.core.MemberId("isVarArgs","()Z", false, false), // #15 ()Z
                        new global::net.sf.jni4net.core.MemberId("toGenericString","()Ljava/lang/String;", false, false), // #16 ()Lsystem/String;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
