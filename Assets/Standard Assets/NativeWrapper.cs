<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;

namespace Helper
{
    public static class NativeWrapper
    {
        public static System.IntPtr GetNativePtr(Object obj)
        {
        	if(obj == null)
        	{
        		return System.IntPtr.Zero;
        	}

            var nativeWrapperIface = obj as INativeWrapper;
            if(nativeWrapperIface != null)
            {
                return nativeWrapperIface.nativePtr;
            }
            else
            {
                throw new ArgumentException("Object must wrap native type");
            }
        }
    }
=======
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;

namespace Helper
{
    public static class NativeWrapper
    {
        public static System.IntPtr GetNativePtr(Object obj)
        {
        	if(obj == null)
        	{
        		return System.IntPtr.Zero;
        	}

            var nativeWrapperIface = obj as INativeWrapper;
            if(nativeWrapperIface != null)
            {
                return nativeWrapperIface.nativePtr;
            }
            else
            {
                throw new ArgumentException("Object must wrap native type");
            }
        }
    }
>>>>>>> 5988ed10343d9064ee2c94a2c0ed2dec3b54cb96
}