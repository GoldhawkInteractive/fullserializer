#if !NO_UNITY
using System;
using System.Collections.Generic;
using UnityEngine;

namespace FullSerializer {
    partial class fsConverterRegistrar {
        public static Internal.DirectConverters.Keyframe_DirectConverter Register_Keyframe_DirectConverter;
    }
}

namespace FullSerializer.Internal.DirectConverters {
    public class Keyframe_DirectConverter : fsDirectConverter<Keyframe> {
        protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized) {
            var result = fsResult.Success;

            result += SerializeMember(serialized, "time", model.time, null);
            result += SerializeMember(serialized, "value", model.value, null);
            result += SerializeMember(serialized, "tangentMode", model.tangentMode, null);
            result += SerializeMember(serialized, "inTangent", model.inTangent, null);
            result += SerializeMember(serialized, "outTangent", model.outTangent, null);

            return result;
        }

        protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model) {
            var result = fsResult.Success;

            var t0 = model.time;
            result += DeserializeMember(data, "time", out t0, null);
            model.time = t0;

            var t1 = model.value;
            result += DeserializeMember(data, "value", out t1, null);
            model.value = t1;

            var t2 = model.tangentMode;
            result += DeserializeMember(data, "tangentMode", out t2, null);
            model.tangentMode = t2;

            var t3 = model.inTangent;
            result += DeserializeMember(data, "inTangent", out t3, null);
            model.inTangent = t3;

            var t4 = model.outTangent;
            result += DeserializeMember(data, "outTangent", out t4, null);
            model.outTangent = t4;

            return result;
        }

        public override object CreateInstance(fsData data, Type storageType) {
            return new Keyframe();
        }
    }
}
#endif