﻿using System;

using Android.App;
using Android.Runtime;

using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace StedySoft.AnimationIssues {

	[Application]
	public class MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: MauiApplication(handle, ownership) {

		protected override MauiApp CreateMauiApp() =>
			MauiProgram.CreateMauiApp();

	}

}
