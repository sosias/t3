using T3.Core.DataTypes;
using T3.Core;
using T3.Core.Operator;
using T3.Core.Operator.Attributes;
using T3.Core.Operator.Slots;
using T3.Core.Resource;

namespace T3.Operators.Types.Id_b1ffe4dd_d734_4392_a644_7c587979066e
{
    public class DrawParticlesWithShadows : Instance<DrawParticlesWithShadows>
    {
        [Output(Guid = "09cbb463-d3bf-46d8-867f-3fe3dbc3a79b")]
        public readonly Slot<Command> Output = new Slot<Command>();

        [Input(Guid = "11e59dd7-1197-433c-a0aa-cf2acad6d33a")]
        public readonly InputSlot<T3.Core.DataTypes.ParticleSystem> ParticleSystem = new InputSlot<T3.Core.DataTypes.ParticleSystem>();

        [Input(Guid = "77f344db-32c0-4f86-b56e-7db51a68723b")]
        public readonly InputSlot<float> Size = new InputSlot<float>();

        [Input(Guid = "5a3a4e3f-28dd-41b3-bc92-8a60b22a4d1c")]
        public readonly InputSlot<System.Numerics.Vector4> Color = new InputSlot<System.Numerics.Vector4>();

        [Input(Guid = "6b704357-289a-4830-a1f9-e5d936aded62")]
        public readonly InputSlot<System.Numerics.Vector3> LightPosition = new InputSlot<System.Numerics.Vector3>();

        [Input(Guid = "f83171f4-8e18-4a83-9bd1-5829545ffaaa")]
        public readonly InputSlot<System.Numerics.Vector3> LightTarget = new InputSlot<System.Numerics.Vector3>();

        [Input(Guid = "9d76f7ed-ce58-4632-b499-2165dde90c86")]
        public readonly InputSlot<float> LightIntensity = new InputSlot<float>();

        [Input(Guid = "4eabf56b-52af-4728-b974-689278477a32")]
        public readonly InputSlot<float> LightDecay = new InputSlot<float>();

        [Input(Guid = "3f3dba11-7dc4-4af8-a9df-49b43e575b61")]
        public readonly InputSlot<float> RoundShading = new InputSlot<float>();

        [Input(Guid = "89ea0e79-ef39-4389-8b4b-757445746362")]
        public readonly InputSlot<float> NearPlane = new InputSlot<float>();

        [Input(Guid = "4932f88a-81b2-41a6-bd5d-64ca53115615")]
        public readonly InputSlot<T3.Core.DataTypes.Gradient> ColorOverLife = new InputSlot<T3.Core.DataTypes.Gradient>();

        [Input(Guid = "d167ff24-353b-4e45-adcc-c03f898018ac")]
        public readonly InputSlot<SharpDX.Direct3D11.Texture2D> ColorForDirection = new InputSlot<SharpDX.Direct3D11.Texture2D>();

        [Input(Guid = "3b14fc1e-3b56-4498-9da3-8b7cfba3a8ca")]
        public readonly InputSlot<System.Numerics.Vector3> LightPos = new InputSlot<System.Numerics.Vector3>();

    }
}

