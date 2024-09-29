
# Material Symbols Outlined for Web

**Material Symbols Outlined for Web** is a NuGet package that provides a simple way to add Google's Material Symbols icons to your C# web applications. It is designed primarily for Blazor applications, allowing you to easily manage and use icons via constants in the `AppIcons.cs` class.

---

## Features

- Provides a complete set of Material Symbols icons.
- Includes an `AppIcons.cs` class with predefined constants for every icon in the Material Symbols set.
- Uses a simple `<span>` or `<i>` tag with CSS `class` to integrate icons into your web pages.
- Seamless integration into `C# - Razor`  projects.

---

## Installation

1. Install the **Material Symbols Outlined for Web** NuGet package:

```coutlined
Install-Package MaterialSymbolsOutlined.Web
```

2. After adding the NuGet package to your project, include the CSS file in your project's `head` tag:
```html
<link href="_content/MaterialSymbolsOutlined.Web/icons.css" rel="stylesheet" />
```

---
Now you can start using icons in your application. Simply reference the icons using the AppIcons constants. For example:

```razor
 @using MaterialSymbolsOutlined.Web
```



```html

<span class="@AppIcons.HOME"></span>

<span class="@AppIcons.HOME"></span> 

<span class="@AppIcons.HOME_AND_GARDEN"></span> 

<span class="@AppIcons.SUPERVISED_USER_CIRCLE_OFF"></span> 
```

**Important:** All icon names are written in **UPPERCASE**. Please ensure that you use uppercase letters when referencing icons in your project.

## How to change Icon Appearance ?

```CSS
.ms-outlined {
	  font-variation-settings: 'FILL' 0, 'wght' 200, 'GRAD' 0, 'opsz' 30;

	  font-size: 100px;

	  color: red;
}
```


### Key points about the CSS:

- ``.ms-outlined`` is a class selector that targets elements with the class ms-outlined.
- ``font-variation-settings`` is used to customize various aspects of the icon's appearance:
- ``FILL`` controls the fill style (0 for outlined, 1 for filled).
- ``wght`` sets the weight (thickness) of the icon.
- ``GRAD`` determines the gradient style (0 for no gradient, 1 for rounded, 2 for outlined).
- ``opsz`` sets the optical size of the icon.

For more information please visit: [https://m3.material.io/](https://m3.material.io/styles/icons/overview)

`By applying this CSS to elements with the ms-outlined class, you can customize the appearance of Material Icons to your liking.`

## Contributions
Contributions and feedback are welcome. If you encounter any issues, feel free to open an issue on GitHub.







