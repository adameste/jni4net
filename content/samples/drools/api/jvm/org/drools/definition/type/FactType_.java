// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.definition.type;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class FactType_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.definition.type.FactType_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.definition.type.FactType_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __FactType extends system.Object implements org.drools.definition.type.FactType {
    
    protected __FactType(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)V")
    public native void writeExternal(java.io.ObjectOutput par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)V")
    public native void readExternal(java.io.ObjectInput par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getName();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;")
    public native java.lang.Object get(java.lang.Object par0, java.lang.String par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)Lorg/drools/definition/type/FactField;")
    public native org.drools.definition.type.FactField getField(java.lang.String par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/List;")
    public native java.util.List getFields();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/Object;")
    public native java.lang.Object newInstance();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)V")
    public native void set(java.lang.Object par0, java.lang.String par1, java.lang.Object par2);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/Class;")
    public native java.lang.Class getFactClass();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Ljava/util/Map;")
    public native java.util.Map getAsMap(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;Ljava/util/Map;)V")
    public native void setFromMap(java.lang.Object par0, java.util.Map par1);
}
//</generated-proxy>