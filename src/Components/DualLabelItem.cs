using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Graphics;

using StedySoft.Maui.Framework;

using Colors = Microsoft.Maui.Graphics.Colors;

namespace StedySoft.AnimationIssues.Components {

	#region Class DualLabelItem
	[Preserve(AllMembers = true)]
	public class DualLabelItem : ContentView {

		#region Constructor
		public DualLabelItem() {
			this.ControlTemplate =
				Application.Current.Resources.TryGetTemplate("DualLabelItemTemplate");
			this.BindingContext = this;
		}
		#endregion

		#region Bindable Properties

		#region Glyph
		public static readonly BindableProperty GlyphProperty =
			BindableProperty.Create(
				nameof(DualLabelItem.Glyph),
				typeof(string),
				typeof(DualLabelItem),
				string.Empty);

		public string? Glyph {
			get => (string?)this.GetValue(DualLabelItem.GlyphProperty);
			set => this.SetValue(DualLabelItem.GlyphProperty, value);
		}

		public static readonly BindableProperty GlyphColorProperty =
			BindableProperty.Create(
				nameof(DualLabelItem.GlyphColor),
				typeof(Color),
				typeof(DualLabelItem),
				Colors.Black);

		public Color GlyphColor {
			get => (Color)this.GetValue(DualLabelItem.GlyphColorProperty);
			set => this.SetValue(DualLabelItem.GlyphColorProperty, value);
		}

		public static readonly BindableProperty GlyphFontSizeProperty =
			BindableProperty.Create(
				nameof(DualLabelItem.GlyphFontSize),
				typeof(double),
				typeof(DualLabelItem),
				22d);

		public double GlyphFontSize {
			get => (double)this.GetValue(DualLabelItem.GlyphFontSizeProperty);
			set => this.SetValue(DualLabelItem.GlyphFontSizeProperty, value);
		}

		public static readonly BindableProperty GlyphFontFamilyProperty =
			BindableProperty.Create(
				nameof(DualLabelItem.GlyphFontFamily),
				typeof(string),
				typeof(DualLabelItem),
				null);

		public string GlyphFontFamily {
			get => (string)this.GetValue(DualLabelItem.GlyphFontFamilyProperty);
			set => this.SetValue(DualLabelItem.GlyphFontFamilyProperty, value);
		}

		public static readonly BindableProperty GlyphOpacityProperty =
			BindableProperty.Create(
				nameof(DualLabelItem.GlyphOpacity),
				typeof(double),
				typeof(DualLabelItem),
				1.0d);

		public double GlyphOpacity {
			get => (double)this.GetValue(DualLabelItem.GlyphOpacityProperty);
			set => this.SetValue(DualLabelItem.GlyphOpacityProperty, value);
		}
		#endregion

		#region Text
		public static readonly BindableProperty TextProperty =
			BindableProperty.Create(
				nameof(Text),
				typeof(string),
				typeof(DualLabelItem),
				string.Empty);

		public string? Text {
			get => (string?)this.GetValue(TextProperty);
			set => this.SetValue(TextProperty, value);
		}

		public static readonly BindableProperty FontSizeProperty =
			BindableProperty.Create(
				nameof(FontSize),
				typeof(double),
				typeof(DualLabelItem),
				15d);

		public double FontSize {
			get => (double)this.GetValue(FontSizeProperty);
			set => this.SetValue(FontSizeProperty, value);
		}

		public static readonly BindableProperty FontFamilyProperty =
			BindableProperty.Create(
				nameof(FontFamily),
				typeof(string),
				typeof(DualLabelItem),
				null);

		public string FontFamily {
			get => (string)this.GetValue(FontFamilyProperty);
			set => this.SetValue(FontFamilyProperty, value);
		}

		public static readonly BindableProperty TextColorProperty =
			BindableProperty.Create(
				nameof(TextColor),
				typeof(Color),
				typeof(DualLabelItem),
				Colors.Black);

		public Color TextColor {
			get => (Color)this.GetValue(TextColorProperty);
			set => this.SetValue(TextColorProperty, value);
		}
		#endregion

		#endregion

		#region Protected Overrides
		protected override void OnApplyTemplate() {
			base.OnApplyTemplate();
			this.GridLayout = this.GetTemplateChild("itemGrid").As<Grid>();
			this.GlyphElement ??= this.GridLayout?.FindByName<Label>("glyph");
			this.TextElement ??= this.GridLayout?.FindByName<Label>("text");
		}
		#endregion

		#region Public Properties
		public Grid GridLayout { get; private set; }

		public Label GlyphElement { get; private set; }

		public Label TextElement { get; private set; }
		#endregion

	}
	#endregion

}
