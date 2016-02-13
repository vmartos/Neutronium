﻿using MVVM.HTML.Core.HTMLBinding;
using System;
using System.Threading.Tasks;
using MVVM.HTML.Core.JavascriptEngine.JavascriptObject;

namespace MVVM.HTML.Core.Binding.Mapping
{
    public interface IJavascriptSessionInjector : IDisposable
    {
        IJavascriptObject Inject(IJavascriptObject rawObject, IJavascriptObjectMapper ijvm, bool checknullvalue = true);
        Task RegisterMainViewModel(IJavascriptObject rawObject);
    }
}