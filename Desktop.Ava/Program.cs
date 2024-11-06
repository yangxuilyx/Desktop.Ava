﻿using Avalonia;
using System;
using System.Collections.Generic;
using Xilium.CefGlue;
using Xilium.CefGlue.Common;

namespace Desktop.Ava
{
    internal class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .WithInterFont()
                .AfterSetup(_ =>
                {
                    CefRuntimeLoader.Initialize(new CefSettings(), flags: [
                            new KeyValuePair<string, string>("enable-print-preview", "1"),
                            new KeyValuePair<string, string>("allow-running-insecure-content","1"),
                            new KeyValuePair<string, string>("disable-web-security","1"),
                            new KeyValuePair<string, string>("disable-gpu","1"),
                            new KeyValuePair<string, string>("disable-gpu-compositing","1"),
                        ]
                        );
                })
                .LogToTrace();
    }
}
