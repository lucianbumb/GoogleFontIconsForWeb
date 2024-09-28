
# Material Symbols Outlined for Web

**Material Symbols Outlined for Web** is a NuGet package that provides a simple way to add Google's Material Symbols icons to your C# web applications. It is designed primarily for Blazor applications, allowing you to easily manage and use icons via constants in the `AppIcons.cs` class.

## Features

- Provides a complete set of Material Symbols icons.
- Includes an `AppIcons.cs` class with predefined constants for every icon in the Material Symbols set.
- Uses a simple `<span>` tag with CSS to integrate icons into your web pages.
- Seamless integration into Blazor projects.

## Installation

1. Install the **Material Symbols Outlined for Web** NuGet package:

```charp
Install-Package MaterialSymbolsOutlined.Web
```



2. After adding the NuGet package to your project, include the CSS file in your project's `head` tag:
```html
<link href="_content/MaterialSymbolsOutlined.Web/icons.css" rel="stylesheet" />
```

Now you can start using icons in your application. Simply reference the icons using the AppIcons constants. For example:

```html
<span class="@AppIcons.Home"></span>
```


## Contributions
Contributions and feedback are welcome. If you encounter any issues, feel free to open an issue on GitHub.







