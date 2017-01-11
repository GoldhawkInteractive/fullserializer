#if !NO_UNITY
using System;
using System.Collections.Generic;
using UnityEngine;

namespace FullSerializer {
    partial class fsConverterRegistrar {
        public static Internal.DirectConverters.GUIStyle_DirectConverter Register_GUIStyle_DirectConverter;
    }
}

namespace FullSerializer.Internal.DirectConverters {
    public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle> {
        protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized) {
            var result = fsResult.Success;

            result += SerializeMember(serialized, "active", model.active, null);
            result += SerializeMember(serialized, "alignment", model.alignment, null);
            result += SerializeMember(serialized, "border", model.border, null);
            result += SerializeMember(serialized, "clipping", model.clipping, null);
            result += SerializeMember(serialized, "contentOffset", model.contentOffset, null);
            result += SerializeMember(serialized, "fixedHeight", model.fixedHeight, null);
            result += SerializeMember(serialized, "fixedWidth", model.fixedWidth, null);
            result += SerializeMember(serialized, "focused", model.focused, null);
            result += SerializeMember(serialized, "font", model.font, null);
            result += SerializeMember(serialized, "fontSize", model.fontSize, null);
            result += SerializeMember(serialized, "fontStyle", model.fontStyle, null);
            result += SerializeMember(serialized, "hover", model.hover, null);
            result += SerializeMember(serialized, "imagePosition", model.imagePosition, null);
            result += SerializeMember(serialized, "margin", model.margin, null);
            result += SerializeMember(serialized, "name", model.name, null);
            result += SerializeMember(serialized, "normal", model.normal, null);
            result += SerializeMember(serialized, "onActive", model.onActive, null);
            result += SerializeMember(serialized, "onFocused", model.onFocused, null);
            result += SerializeMember(serialized, "onHover", model.onHover, null);
            result += SerializeMember(serialized, "onNormal", model.onNormal, null);
            result += SerializeMember(serialized, "overflow", model.overflow, null);
            result += SerializeMember(serialized, "padding", model.padding, null);
            result += SerializeMember(serialized, "richText", model.richText, null);
            result += SerializeMember(serialized, "stretchHeight", model.stretchHeight, null);
            result += SerializeMember(serialized, "stretchWidth", model.stretchWidth, null);
            result += SerializeMember(serialized, "wordWrap", model.wordWrap, null);

            return result;
        }

        protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model) {
            var result = fsResult.Success;

            var t0 = model.active;
            result += DeserializeMember(data, "active", out t0, null);
            model.active = t0;

            var t2 = model.alignment;
            result += DeserializeMember(data, "alignment", out t2, null);
            model.alignment = t2;

            var t3 = model.border;
            result += DeserializeMember(data, "border", out t3, null);
            model.border = t3;

            var t4 = model.clipping;
            result += DeserializeMember(data, "clipping", out t4, null);
            model.clipping = t4;

            var t5 = model.contentOffset;
            result += DeserializeMember(data, "contentOffset", out t5, null);
            model.contentOffset = t5;

            var t6 = model.fixedHeight;
            result += DeserializeMember(data, "fixedHeight", out t6, null);
            model.fixedHeight = t6;

            var t7 = model.fixedWidth;
            result += DeserializeMember(data, "fixedWidth", out t7, null);
            model.fixedWidth = t7;

            var t8 = model.focused;
            result += DeserializeMember(data, "focused", out t8, null);
            model.focused = t8;

            var t9 = model.font;
            result += DeserializeMember(data, "font", out t9, null);
            model.font = t9;

            var t10 = model.fontSize;
            result += DeserializeMember(data, "fontSize", out t10, null);
            model.fontSize = t10;

            var t11 = model.fontStyle;
            result += DeserializeMember(data, "fontStyle", out t11, null);
            model.fontStyle = t11;

            var t12 = model.hover;
            result += DeserializeMember(data, "hover", out t12, null);
            model.hover = t12;

            var t13 = model.imagePosition;
            result += DeserializeMember(data, "imagePosition", out t13, null);
            model.imagePosition = t13;

            var t16 = model.margin;
            result += DeserializeMember(data, "margin", out t16, null);
            model.margin = t16;

            var t17 = model.name;
            result += DeserializeMember(data, "name", out t17, null);
            model.name = t17;

            var t18 = model.normal;
            result += DeserializeMember(data, "normal", out t18, null);
            model.normal = t18;

            var t19 = model.onActive;
            result += DeserializeMember(data, "onActive", out t19, null);
            model.onActive = t19;

            var t20 = model.onFocused;
            result += DeserializeMember(data, "onFocused", out t20, null);
            model.onFocused = t20;

            var t21 = model.onHover;
            result += DeserializeMember(data, "onHover", out t21, null);
            model.onHover = t21;

            var t22 = model.onNormal;
            result += DeserializeMember(data, "onNormal", out t22, null);
            model.onNormal = t22;

            var t23 = model.overflow;
            result += DeserializeMember(data, "overflow", out t23, null);
            model.overflow = t23;

            var t24 = model.padding;
            result += DeserializeMember(data, "padding", out t24, null);
            model.padding = t24;

            var t25 = model.richText;
            result += DeserializeMember(data, "richText", out t25, null);
            model.richText = t25;

            var t26 = model.stretchHeight;
            result += DeserializeMember(data, "stretchHeight", out t26, null);
            model.stretchHeight = t26;

            var t27 = model.stretchWidth;
            result += DeserializeMember(data, "stretchWidth", out t27, null);
            model.stretchWidth = t27;

            var t28 = model.wordWrap;
            result += DeserializeMember(data, "wordWrap", out t28, null);
            model.wordWrap = t28;

            return result;
        }

        public override object CreateInstance(fsData data, Type storageType) {
            return new GUIStyle();
        }
    }
}
#endif