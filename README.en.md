# Xaml.Advanced
Xaml.Advanced is not a large library of custom controls for XAML.

# Version 0.0.1

Contains two elements TextField, PasswordField.

## 1. TextField

For the most part, it does not differ from the standard xaml TextBox element, it also supports binding for most of its properties.
Its main difference is the presence of the properties cornerRadius, BorderBrushFocused and PlaceHolder.

- cornerRadius - property responsible for rounding corners.
- PlaceHolder - property responsible for what text will be displayed while the Text property is empty.
- BorderBrushFocused - property responsible for what color BorderBrush will be when the element has focus.

## 2. PasswordField

For the most part, it does not differ from the standard xaml of the PasswordBox element, it also supports binding for most of its properties (including the Password property).
Its main difference is the presence of the properties cornerRadius, PlaceHolder, BorderBrushFocused and IsButtonEnable, as well as the ability to change the password display mode when the property is enabled.

The first mode, standard for PasswordBox when all characters are replaced with "●". The second is when the password is fully visible.

- cornerRadius - property responsible for rounding corners.
- PlaceHolder - property responsible for what text will be displayed while the Text property is empty.
- BorderBrushFocused - property responsible for what color BorderBrush will be when the element has focus.
- IsButtonEnable - property responsible for whether the user will have access to the button to change the password display mode.

# Installation
After creating the project on the version .NET Framework 4.7.2 and higher. There are two installation options:

1. Use Visual Studio.
2. Manual installation.

## Use Visual Studio.

In the upper panel, select _'Project > Management of NuGet packages...'_, then select the page _'Overview'_ and in the field _'Search (Ctrl + L)'_ enter ***Xaml.Advanced***.
Click on '__Xaml.Advanced__ author:Marlo_9'. Next, install the selected NuGet.

## Manual installation.

After downloading the file __Xaml.Advanced.dll __. Open the project _'Solution Explorer > [Project Name]'_ click the PCM on _'Links'_ and select _'Add Link...'_.
Next, on the left, select the _'Overview'_ page, click the _' button from belowReview...'_ in the window that appears, select the previously installed file __Xaml.Advanced.dll __ and click _'Add'_ 

# Usage

After the installation is complete, in the window or element where you are going to use the elements of this library, you need to add the following.

#### Window
```xaml
<Window ...
        xmlns:xaml="clr-namespace:Xaml.Advanced;assembly=Xaml.Advanced">
    <Grid>
        <xaml:TextField/>
        <xaml:PasswordField/>
    </Grid>
</Window>
```
#### UserControl
```xaml
<UserControl ...
        xmlns:xaml="clr-namespace:Xaml.Advanced;assembly=Xaml.Advanced">
    <Grid>
        <xaml:TextField/>
        <xaml:PasswordField/>
    </Grid>
</UserControl>
```
> _'xaml'_ can be replaced with any other convenient word.
