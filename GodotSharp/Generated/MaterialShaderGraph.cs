using System;

namespace GodotEngine
{
    public class MaterialShaderGraph : ShaderGraph
    {
        private const string nativeName = "MaterialShaderGraph";

        public MaterialShaderGraph() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MaterialShaderGraph_Ctor(this);
        }

        internal MaterialShaderGraph(bool memoryOwn) : base(memoryOwn) {}

        ~MaterialShaderGraph()
        {
            Dispose();
        }

        public override void Dispose()
        {
            lock (this)
            {
                if (ptr != IntPtr.Zero)
                {
                    if (memoryOwn)
                    {
                        memoryOwn = false;
                    NativeCalls.godot_icall_MaterialShaderGraph_Dtor(ptr);
                        ptr = IntPtr.Zero;
                    }
                }

                GC.SuppressFinalize(this);
            }
        }
    }
}
