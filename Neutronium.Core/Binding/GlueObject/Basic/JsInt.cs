﻿using System.Globalization;
using Neutronium.Core.Binding.Builder;
using Neutronium.Core.WebBrowserEngine.JavascriptObject;

namespace Neutronium.Core.Binding.GlueObject.Basic
{
    internal sealed class JsInt : JsBasicTyped<int>, IBasicJsCsGlue
    {
        public JsInt(int value) : base(value) { }

        void IJsCsGlue.SetJsValue(IJavascriptObject value, IJavascriptSessionCache cache) => base.SetJsValue(value);

        public string GetCreationCode() => TypedValue.ToString(CultureInfo.InvariantCulture);

        public override string ToString() => TypedValue.ToString();

        public void RequestBuildInstruction(IJavascriptObjectBuilder builder)
            => builder.RequestIntCreation(TypedValue);
    }
}
