﻿using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace StedySoft.AnimationIssues {

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Templates : ResourceDictionary {

		public Templates() =>
			this.InitializeComponent();

		public static Templates SharedInstance { get; } = new Templates();

	}

}