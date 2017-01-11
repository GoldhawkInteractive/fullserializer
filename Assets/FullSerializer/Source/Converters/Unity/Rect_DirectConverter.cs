#if !NO_UNITY
using System;
using System.Collections.Generic;
using UnityEngine;

namespace FullSerializer {
    partial class fsConverterRegistrar {
        public static Internal.DirectConverters.Rect_DirectConverter Register_Rect_DirectConverter;
    }
}

namespace FullSerializer.Internal.DirectConverters {
    public class Rect_DirectConverter : fsDirectConverter<Rect> {
        protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized) {
            var result = fsResult.Success;

            result += SerializeMember(serialized, "xMin", model.xMin, null);
            result += SerializeMember(serialized, "yMin", model.yMin, null);
            result += SerializeMember(serialized, "xMax", model.xMax, null);
            result += SerializeMember(serialized, "yMax", model.yMax, null);

            return result;
        }

        protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model) {
            var result = fsResult.Success;

            var t0 = model.xMin;
            result += DeserializeMember(data, "xMin", out t0, null);
            model.xMin = t0;

            var t1 = model.yMin;
            result += DeserializeMember(data, "yMin", out t1, null);
            model.yMin = t1;

            var t2 = model.xMax;
            result += DeserializeMember(data, "xMax", out t2, null);
            model.xMax = t2;

            var t3 = model.yMax;
            result += DeserializeMember(data, "yMax", out t3, null);
            model.yMax = t3;

            return result;
        }

        public override object CreateInstance(fsData data, Type storageType) {
            return new Rect();
        }
    }
}
#endif