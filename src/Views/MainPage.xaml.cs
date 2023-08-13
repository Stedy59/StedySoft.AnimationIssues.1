using System;

using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace StedySoft.AnimationIssues.Views {

	public partial class MainPage : ContentPage {

		public MainPage() =>
			this.InitializeComponent();

		private void OnSetOpacityTo0ButtonClicked(object sender, EventArgs e) =>
			new Animation()
				.WithConcurrent((f) => this.Label100.GlyphElement.Opacity = f, this.Label100.GlyphElement.Opacity, 0)
				.WithConcurrent((f) => this.Label75.GlyphElement.Opacity = f, Label75.GlyphElement.Opacity, 0)
				.WithConcurrent((f) => this.Label50.GlyphElement.Opacity = f, this.Label50.GlyphElement.Opacity, 0)
				.WithConcurrent((f) => this.Label25.GlyphElement.Opacity = f, this.Label25.GlyphElement.Opacity, 0)
				.WithConcurrent((f) => this.Label0.GlyphElement.Opacity = f, this.Label0.GlyphElement.Opacity, 0)
				.Commit(
					this,
					nameof(OnSetOpacityTo0ButtonClicked),
					length: 350,
					easing: Easing.SinOut);

		private void OnSetOpacityTo100ButtonClicked(object sender, EventArgs e) =>
			new Animation()
				.WithConcurrent((f) => this.Label100.GlyphElement.Opacity = f, this.Label100.GlyphElement.Opacity, 1.0)
				.WithConcurrent((f) => this.Label75.GlyphElement.Opacity = f, Label75.GlyphElement.Opacity, 1.0)
				.WithConcurrent((f) => this.Label50.GlyphElement.Opacity = f, this.Label50.GlyphElement.Opacity, 1.0)
				.WithConcurrent((f) => this.Label25.GlyphElement.Opacity = f, this.Label25.GlyphElement.Opacity, 1.0)
				.WithConcurrent((f) => this.Label0.GlyphElement.Opacity = f, this.Label0.GlyphElement.Opacity, 1.0)
				.Commit(
					this,
					nameof(OnSetOpacityTo100ButtonClicked),
					length: 350,
					easing: Easing.SinIn);

	}

}
