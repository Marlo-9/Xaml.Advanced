using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Xaml.Advanced
{
    /// <summary>
    /// Логика взаимодействия для PasswordField.xaml
    /// </summary>
    public partial class PasswordField : UserControl, INotifyPropertyChanged
    {
        public PasswordField()
        {
            InitializeComponent();

            //Password = MainPasswordBox.Password;
        }

        private Visibility _placeHolderVisibility;

        public Visibility PlaceHolderVisibility
        {
            get => _placeHolderVisibility;
            set
            {
                _placeHolderVisibility = value;
                OnPropertyChanged(nameof(PlaceHolderVisibility));
            }
        }

        private Visibility _focuseVisibility = Visibility.Collapsed;

        public Visibility FocuseVisibility
        {
            get => _focuseVisibility;
            set
            {
                _focuseVisibility = value;
                OnPropertyChanged(nameof(FocuseVisibility));
            }
        }

        private static CornerRadius _buttonCornerRadius;

        public CornerRadius ButtonCornerRadius
        {
            get => _buttonCornerRadius;
            set
            {
                _buttonCornerRadius = value;
                OnPropertyChanged(nameof(ButtonCornerRadius));
            }
        }

        private double _columnWidth;

        public double ColumnWidth
        {
            get => _columnWidth;
            set
            {
                _columnWidth = value;
                OnPropertyChanged(nameof(ColumnWidth));
            }
        }

        #region Password 

        public static readonly DependencyProperty PasswordProperty = DependencyProperty.Register(nameof(Password),
                                                                                                 typeof(string),
                                                                                                 typeof(PasswordField),
                                                                                                 new FrameworkPropertyMetadata(
                                                                                                    defaultValue: "",
                                                                                                    flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                    propertyChangedCallback: new PropertyChangedCallback(OnPasswordChanged)));

        public string Password
        {
            get => (string)GetValue(PasswordProperty);
            set => SetValue(PasswordProperty, value);
        }
        private static void OnPasswordChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

        #region PlaceHolder 

        public static readonly DependencyProperty PlaceHolderProperty = DependencyProperty.Register(nameof(PlaceHolder),
                                                                                                    typeof(string),
                                                                                                    typeof(PasswordField),
                                                                                                    new FrameworkPropertyMetadata(
                                                                                                       defaultValue: "",
                                                                                                       flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                       propertyChangedCallback: new PropertyChangedCallback(OnPlaceHolderChanged)));

        public string PlaceHolder
        {
            get => (string)GetValue(PlaceHolderProperty);
            set => SetValue(PlaceHolderProperty, value);
        }
        private static void OnPlaceHolderChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

        #region PlaceHolderOpacity

        public static readonly DependencyProperty PlaceHolderOpacityProperty = DependencyProperty.Register(nameof(PlaceHolderOpacity),
                                                                                                               typeof(double),
                                                                                                               typeof(PasswordField),
                                                                                                               new FrameworkPropertyMetadata(
                                                                                                                  defaultValue: 0.4,
                                                                                                                  flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                                  propertyChangedCallback: new PropertyChangedCallback(OnPlaceHolderOpacityChanged)));

        public int PlaceHolderOpacity
        {
            get => (int)GetValue(PlaceHolderOpacityProperty);
            set => SetValue(PlaceHolderOpacityProperty, value);
        }
        private static void OnPlaceHolderOpacityChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

        #region CornerRadius

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(nameof(CornerRadius),
                                                                                                     typeof(CornerRadius),
                                                                                                     typeof(PasswordField),
                                                                                                     new FrameworkPropertyMetadata(
                                                                                                        defaultValue: new CornerRadius(0),
                                                                                                        flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                        propertyChangedCallback: new PropertyChangedCallback(OnCornerRadiusChanged)));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        private static void OnCornerRadiusChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            PasswordField passwordField = (PasswordField)dependencyObject;

            passwordField.ButtonCornerRadius = new CornerRadius(0, passwordField.CornerRadius.TopRight - (passwordField.BorderThickness.Right / 1.8),
                                                  passwordField.CornerRadius.BottomRight - (passwordField.BorderThickness.Right / 1.8), 0);
        }

        #endregion

        #region BorderThickness

        public static new readonly DependencyProperty BorderThicknessProperty = DependencyProperty.Register(nameof(BorderThickness),
                                                                                                            typeof(Thickness),
                                                                                                            typeof(PasswordField),
                                                                                                            new FrameworkPropertyMetadata(
                                                                                                               defaultValue: new Thickness(3),
                                                                                                               flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                               propertyChangedCallback: new PropertyChangedCallback(OnBorderThicknessChanged)));

        public new Thickness BorderThickness
        {
            get => (Thickness)GetValue(BorderThicknessProperty);
            set => SetValue(BorderThicknessProperty, value);
        }
        private static void OnBorderThicknessChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

        #region Padding

        public static new readonly DependencyProperty PaddingProperty = DependencyProperty.Register(nameof(Padding),
                                                                                                    typeof(Thickness),
                                                                                                    typeof(PasswordField),
                                                                                                    new FrameworkPropertyMetadata(
                                                                                                       defaultValue: new Thickness(0),
                                                                                                       flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                       propertyChangedCallback: new PropertyChangedCallback(OnPaddingChanged)));

        public new Thickness Padding
        {
            get => (Thickness)GetValue(PaddingProperty);
            set => SetValue(PaddingProperty, value);
        }
        private static void OnPaddingChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

        #region Background

        public static new readonly DependencyProperty BackgroundProperty = DependencyProperty.Register(nameof(Background),
                                                                                                       typeof(SolidColorBrush),
                                                                                                       typeof(PasswordField),
                                                                                                       new FrameworkPropertyMetadata(
                                                                                                          defaultValue: new SolidColorBrush(Color.FromArgb(255, 18, 18, 18)),
                                                                                                          flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                          propertyChangedCallback: new PropertyChangedCallback(OnBackgroundChanged)));

        public new SolidColorBrush Background
        {
            get => (SolidColorBrush)GetValue(BackgroundProperty);
            set => SetValue(BackgroundProperty, value);
        }
        private static void OnBackgroundChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

        #region BorderBrush

        public static new readonly DependencyProperty BorderBrushProperty = DependencyProperty.Register(nameof(BorderBrush),
                                                                                                        typeof(SolidColorBrush),
                                                                                                        typeof(PasswordField),
                                                                                                        new FrameworkPropertyMetadata(
                                                                                                           defaultValue: new SolidColorBrush(Color.FromArgb(255, 18, 18, 18)),
                                                                                                           flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                           propertyChangedCallback: new PropertyChangedCallback(OnBorderBrushChanged)));

        public new SolidColorBrush BorderBrush
        {
            get => (SolidColorBrush)GetValue(BorderBrushProperty);
            set => SetValue(BorderBrushProperty, value);
        }
        private static void OnBorderBrushChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

        #region BorderBrushFocused

        public static readonly DependencyProperty BorderBrushFocusedProperty = DependencyProperty.Register(nameof(BorderBrushFocused),
                                                                                                           typeof(SolidColorBrush),
                                                                                                           typeof(PasswordField),
                                                                                                           new FrameworkPropertyMetadata(
                                                                                                              defaultValue: new SolidColorBrush(Color.FromArgb(255, 18, 18, 18)),
                                                                                                              flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                              propertyChangedCallback: new PropertyChangedCallback(OnBorderBrushFocusedChanged)));

        public SolidColorBrush BorderBrushFocused
        {
            get => (SolidColorBrush)GetValue(BorderBrushFocusedProperty);
            set => SetValue(BorderBrushFocusedProperty, value);
        }
        private static void OnBorderBrushFocusedChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

        #region Foreground

        public static new readonly DependencyProperty ForegroundProperty = DependencyProperty.Register(nameof(Foreground),
                                                                                                       typeof(SolidColorBrush),
                                                                                                       typeof(PasswordField),
                                                                                                       new FrameworkPropertyMetadata(
                                                                                                          defaultValue: new SolidColorBrush(Color.FromArgb(255, 235, 235, 235)),
                                                                                                          flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                          propertyChangedCallback: new PropertyChangedCallback(OnForegroundChanged)));

        public new SolidColorBrush Foreground
        {
            get => (SolidColorBrush)GetValue(ForegroundProperty);
            set => SetValue(ForegroundProperty, value);
        }
        private static void OnForegroundChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

        #region CaretBrush

        public static readonly DependencyProperty CaretBrushProperty = DependencyProperty.Register(nameof(CaretBrush),
                                                                                                   typeof(SolidColorBrush),
                                                                                                   typeof(PasswordField),
                                                                                                   new FrameworkPropertyMetadata(
                                                                                                      defaultValue: new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)),
                                                                                                      flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                      propertyChangedCallback: new PropertyChangedCallback(OnCaretBrushChanged)));

        public SolidColorBrush CaretBrush
        {
            get => (SolidColorBrush)GetValue(CaretBrushProperty);
            set => SetValue(CaretBrushProperty, value);
        }
        private static void OnCaretBrushChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

        #region SelectionBrush

        public static readonly DependencyProperty SelectionBrushProperty = DependencyProperty.Register(nameof(SelectionBrush),
                                                                                                       typeof(SolidColorBrush),
                                                                                                       typeof(PasswordField),
                                                                                                       new FrameworkPropertyMetadata(
                                                                                                          defaultValue: new SolidColorBrush(Color.FromArgb(255, 18, 18, 18)),
                                                                                                          flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                          propertyChangedCallback: new PropertyChangedCallback(OnSelectionBrushChanged)));

        public SolidColorBrush SelectionBrush
        {
            get => (SolidColorBrush)GetValue(SelectionBrushProperty);
            set => SetValue(SelectionBrushProperty, value);
        }
        private static void OnSelectionBrushChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

        #region IsButtonEnable

        public static readonly DependencyProperty IsButtonEnableProperty = DependencyProperty.Register(nameof(IsButtonEnable),
                                                                                                       typeof(bool),
                                                                                                       typeof(PasswordField),
                                                                                                       new FrameworkPropertyMetadata(
                                                                                                          defaultValue: false,
                                                                                                          flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                          propertyChangedCallback: new PropertyChangedCallback(OnIsButtonEnableChanged)));

        public bool IsButtonEnable
        {
            get => (bool)GetValue(IsButtonEnableProperty);
            set => SetValue(IsButtonEnableProperty, value);
        }
        private static void OnIsButtonEnableChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            PasswordField passwordField = (PasswordField)dependencyObject;

            passwordField.ColumnWidth = !(bool)e.NewValue ? 0 : passwordField.This.Height;
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private void PasswordChange(object sender, RoutedEventArgs e)
        {
            Password = ((PasswordBox)sender).Password;

            PlaceHolderVisibility = Password == "" ? Visibility.Visible : Visibility.Collapsed;
        }

        private void PasswordBoxGotFocus(object sender, RoutedEventArgs e)
        {
            FocuseVisibility = Visibility.Visible;
        }

        private void PasswordBoxLostFocus(object sender, RoutedEventArgs e)
        {
            FocuseVisibility = Visibility.Collapsed;

            PlaceHolderVisibility = Password == "" ? Visibility.Visible : Visibility.Collapsed;
        }

        private void TextBoxEnableChange(object sender, DependencyPropertyChangedEventArgs e)
        {
            MainPasswordBox.IsEnabled = !((TextBox)sender).IsEnabled;
            MainPasswordBox.Password = Password;
        }

        private void TextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            FocuseVisibility = Visibility.Visible;
        }

        private void TextBoxPasswordChange(object sender, TextChangedEventArgs e)
        {
            PlaceHolderVisibility = Password == "" ? Visibility.Visible : Visibility.Collapsed;
        }

        private void TextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            FocuseVisibility = Visibility.Collapsed;

            PlaceHolderVisibility = Password == "" ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
