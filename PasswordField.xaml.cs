﻿using System;
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

namespace AdvancedXAML
{
    /// <summary>
    /// Логика взаимодействия для PasswordField.xaml
    /// </summary>
    public partial class PasswordField : UserControl, INotifyPropertyChanged
    {
        public PasswordField()
        {
            InitializeComponent();

            Password = MainPasswordBox.Password;
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
                                                                                                        defaultValue: new CornerRadius(20),
                                                                                                        flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
                                                                                                        propertyChangedCallback: new PropertyChangedCallback(OnCornerRadiusChanged)));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        private static void OnCornerRadiusChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

        #region BorderThickness

        public static new readonly DependencyProperty BorderThicknessProperty = DependencyProperty.Register(nameof(BorderThickness),
                                                                                                            typeof(Thickness),
                                                                                                            typeof(PasswordField),
                                                                                                            new FrameworkPropertyMetadata(
                                                                                                               defaultValue: new Thickness(4),
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
                                                                                                      defaultValue: new SolidColorBrush(Color.FromArgb(255, 18, 18, 18)),
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private void PasswordChange(object sender, RoutedEventArgs e)
        {
            Password = ((PasswordBox)sender).Password;

            if (((PasswordBox)sender).IsFocused)
                PlaceHolderVisibility = Visibility.Collapsed;
            else
                PlaceHolderVisibility = Password == "" ? Visibility.Visible : Visibility.Collapsed;
        }

        private void PasswordBoxGotFocus(object sender, RoutedEventArgs e)
        {
            PlaceHolderVisibility = Visibility.Collapsed;
        }

        private void PasswordBoxLostFocus(object sender, RoutedEventArgs e)
        {
            PlaceHolderVisibility = Password == "" ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}