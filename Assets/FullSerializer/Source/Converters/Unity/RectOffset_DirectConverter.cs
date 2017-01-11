#if !NO_UNITY
using System;
using System.Collections.Generic;
using UnityEngine;

namespace FullSerializer {
    partial class fsConverterRegistrar {
        public static Internal.DirectConverters.RectOffset_DirectConverter Register_RectOffset_DirectConverter;
    }
}

namespace FullSerializer.Internal.DirectConverters {
    public class RectOffset_DirectConverter : fsDirectConverter<RectOffset> {
        protected override fsResult DoSerialize(RectOffset model, Dictionary<string, fsData> serialized) {
            var result = fsResult.Success;

            result += SerializeMember(serialized, "bottom", model.bottom, null);
            result += SerializeMember(serialized, "left", model.left, null);
            result += SerializeMember(serialized, "right", model.right, null);
            result += SerializeMember(serialized, "top", model.top, null);

            return result;
        }

        protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RectOffset model) {
            var result = fsResult.Success;

            var t0 = model.bottom;
            result += DeserializeMember(data, "bottom", out t0, null);
            model.bottom = t0;

            var t2 = model.left;
            result += DeserializeMember(data, "left", out t2, null);
            model.left = t2;

            var t3 = model.right;
            result += DeserializeMember(data, "right", out t3, null);
            model.right = t3;

            var t4 = model.top;
            result += DeserializeMember(data, "top", out t4, null);
            model.top = t4;

            return result;
        }

        public override object CreateInstance(fsData data, Type storageType) {
            return new RectOffset();
        }
    }
}
#endif