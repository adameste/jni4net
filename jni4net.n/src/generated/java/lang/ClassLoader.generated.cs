//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class ClassLoader : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _loadClass0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSystemClassLoader1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getResource2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getResourceAsStream3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSystemResource4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSystemResourceAsStream5;
        
        internal static global::net.sf.jni4net.jni.MethodId _clearAssertionStatus6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getParent7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getResources8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSystemResources9;
        
        internal static global::net.sf.jni4net.jni.MethodId _setClassAssertionStatus10;
        
        internal static global::net.sf.jni4net.jni.MethodId _setDefaultAssertionStatus11;
        
        internal static global::net.sf.jni4net.jni.MethodId _setPackageAssertionStatus12;
        
        protected ClassLoader(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.ClassLoader.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.ClassLoader.staticClass = @__class;
            global::java.lang.ClassLoader._loadClass0 = @__env.GetMethodID(global::java.lang.ClassLoader.staticClass, "loadClass", "(Ljava/lang/String;)Ljava/lang/Class;");
            global::java.lang.ClassLoader._getSystemClassLoader1 = @__env.GetStaticMethodID(global::java.lang.ClassLoader.staticClass, "getSystemClassLoader", "()Ljava/lang/ClassLoader;");
            global::java.lang.ClassLoader._getResource2 = @__env.GetMethodID(global::java.lang.ClassLoader.staticClass, "getResource", "(Ljava/lang/String;)Ljava/net/URL;");
            global::java.lang.ClassLoader._getResourceAsStream3 = @__env.GetMethodID(global::java.lang.ClassLoader.staticClass, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
            global::java.lang.ClassLoader._getSystemResource4 = @__env.GetStaticMethodID(global::java.lang.ClassLoader.staticClass, "getSystemResource", "(Ljava/lang/String;)Ljava/net/URL;");
            global::java.lang.ClassLoader._getSystemResourceAsStream5 = @__env.GetStaticMethodID(global::java.lang.ClassLoader.staticClass, "getSystemResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
            global::java.lang.ClassLoader._clearAssertionStatus6 = @__env.GetMethodID(global::java.lang.ClassLoader.staticClass, "clearAssertionStatus", "()V");
            global::java.lang.ClassLoader._getParent7 = @__env.GetMethodID(global::java.lang.ClassLoader.staticClass, "getParent", "()Ljava/lang/ClassLoader;");
            global::java.lang.ClassLoader._getResources8 = @__env.GetMethodID(global::java.lang.ClassLoader.staticClass, "getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
            global::java.lang.ClassLoader._getSystemResources9 = @__env.GetStaticMethodID(global::java.lang.ClassLoader.staticClass, "getSystemResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
            global::java.lang.ClassLoader._setClassAssertionStatus10 = @__env.GetMethodID(global::java.lang.ClassLoader.staticClass, "setClassAssertionStatus", "(Ljava/lang/String;Z)V");
            global::java.lang.ClassLoader._setDefaultAssertionStatus11 = @__env.GetMethodID(global::java.lang.ClassLoader.staticClass, "setDefaultAssertionStatus", "(Z)V");
            global::java.lang.ClassLoader._setPackageAssertionStatus12 = @__env.GetMethodID(global::java.lang.ClassLoader.staticClass, "setPackageAssertionStatus", "(Ljava/lang/String;Z)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Class;")]
        public virtual global::java.lang.Class loadClass(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.ClassLoader._loadClass0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/ClassLoader;")]
        public static global::java.lang.ClassLoader getSystemClassLoader() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.ClassLoader>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemClassLoader1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/net/URL;")]
        public virtual global::java.net.URL getResource(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.net.URL>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.ClassLoader._getResource2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/io/InputStream;")]
        public virtual global::java.io.InputStream getResourceAsStream(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.ClassLoader._getResourceAsStream3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/net/URL;")]
        public static global::java.net.URL getSystemResource(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.net.URL>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResource4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/io/InputStream;")]
        public static global::java.io.InputStream getSystemResourceAsStream(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.InputStream>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResourceAsStream5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void clearAssertionStatus() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.ClassLoader._clearAssertionStatus6);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/ClassLoader;")]
        public global::java.lang.ClassLoader getParent() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.ClassLoader>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.ClassLoader._getParent7));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/util/Enumeration;")]
        public virtual global::java.util.Enumeration getResources(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Enumeration>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.ClassLoader._getResources8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/util/Enumeration;")]
        public static global::java.util.Enumeration getSystemResources(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Enumeration>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResources9, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Z)V")]
        public virtual void setClassAssertionStatus(global::java.lang.String par0, bool par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.ClassLoader._setClassAssertionStatus10, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)V")]
        public virtual void setDefaultAssertionStatus(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.ClassLoader._setDefaultAssertionStatus11, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Z)V")]
        public virtual void setPackageAssertionStatus(global::java.lang.String par0, bool par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.ClassLoader._setPackageAssertionStatus12, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.ClassLoader(@__env);
            }
        }
    }
    #endregion
}
