﻿using MVVM.HTML.Core.HTMLBinding;
using MVVM.HTML.Core.JavascriptEngine.JavascriptObject;

namespace MVVM.HTML.Core.Binding.Mapping
{
    internal class KnockoutSessionInjectorFactory : IJavascriptSessionInjectorFactory
    {
        public IJavascriptSessionInjector CreateInjector(IWebView iWebView, IJavascriptChangesListener iJavascriptListener)
        {
            return new KnockoutSessionInjector(iWebView, iJavascriptListener);
        }
    }
}