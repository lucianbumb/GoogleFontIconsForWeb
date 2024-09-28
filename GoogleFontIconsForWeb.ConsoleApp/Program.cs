
using System.Text;

var path = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf(AppDomain.CurrentDomain.FriendlyName));
var roundedProjectPath = Path.Combine(path, "MaterialSymbolsRounded.Web");
var outlinedProjectPath = Path.Combine(path, "MaterialSymbolsOutlined.Web");
var sharpProjectPath = Path.Combine(path, "MaterialSymbolsSharp.Web");
var files = Directory.GetFiles(Path.Combine(path,AppDomain.CurrentDomain.FriendlyName));

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(AppContext.BaseDirectory.Substring(0,AppContext.BaseDirectory.IndexOf(AppDomain.CurrentDomain.FriendlyName)));




var sb = new StringBuilder();



foreach (var file in files.Where(a=>a.Contains("codepoints")))
{
    if (file.Contains("Rounded"))
    {
        
        sb.AppendLine("""
                      @font-face {
                          font-family: 'Material Symbols Rounded';
                          src: url('MaterialSymbolsRounded[FILL,GRAD,opsz,wght].woff2') format('woff2');
                          font-weight: normal;
                          font-style: normal;
                          font-display: swap;
                      }

                      .ms-rounded {
                          font-family: 'Material Symbols Rounded';
                          font-variation-settings: 'FILL' 0, 'wght' 400, 'GRAD' 1, 'opsz' 48;
                          font-style: normal;
                          font-weight: normal;
                          font-variant: normal;
                          text-transform: none;
                          line-height: 1; 
                          -webkit-font-smoothing: antialiased; 
                          -moz-osx-font-smoothing: grayscale;
                          font-size: 24px;
                      }
                      """);
        sb.AppendLine();
        sb.AppendLine();
        
        var firstFile = File.ReadAllLines(file);
        var iconsClass = new StringBuilder();

        iconsClass.AppendLine("namespace MaterialSymbolsRounded.Web;");
        iconsClass.AppendLine("public class AppIcons");
        iconsClass.AppendLine("{");
        
        foreach (var line in firstFile)
        {
            var items = line.Split(" ");
            if(char.IsDigit(items[0].First())) continue;
            sb.AppendLine($".{items[0]}::before{{content: '\\{items[1]}';}}");

            iconsClass.AppendLine($"public const string {items[0].ToUpper()} = \"ms-rounded {items[0]}\";");
        }

        iconsClass.AppendLine("}");
        
        File.WriteAllText($"{roundedProjectPath}\\AppIcons.cs",iconsClass.ToString());
        File.WriteAllText($"{roundedProjectPath}\\wwwroot\\icons.css",sb.ToString());
    }
    
    if (file.Contains("Outlined"))
    {
        
        sb.AppendLine("""
                      @font-face {
                          font-family: 'Material Symbols Outlined';
                          src: url('MaterialSymbolsOutlined[FILL,GRAD,opsz,wght].woff2') format('woff2');
                          font-weight: normal;
                          font-style: normal;
                          font-display: swap;
                      }

                      .ms-outlined {
                          font-family: 'Material Symbols Outlined';
                          font-variation-settings: 'FILL' 0, 'wght' 400, 'GRAD' 0, 'opsz' 48;
                          font-style: normal;
                          font-weight: normal;
                          font-variant: normal;
                          text-transform: none;
                          line-height: 1; 
                          -webkit-font-smoothing: antialiased; 
                          -moz-osx-font-smoothing: grayscale;
                          font-size: 24px;
                      }
                      """);
        sb.AppendLine();
        sb.AppendLine();
        
        var firstFile = File.ReadAllLines(file);
        var iconsClass = new StringBuilder();

        iconsClass.AppendLine("namespace MaterialSymbolsOutlined.Web;");
        iconsClass.AppendLine("public class AppIcons");
        iconsClass.AppendLine("{");
        
        foreach (var line in firstFile)
        {
            var items = line.Split(" ");
            if(char.IsDigit(items[0].First())) continue;
            sb.AppendLine($".{items[0]}::before{{content: '\\{items[1]}';}}");

            iconsClass.AppendLine($"public const string {items[0].ToUpper()} = \"ms-outlined {items[0]}\";");
        }

        iconsClass.AppendLine("}");
        
        File.WriteAllText($"{outlinedProjectPath}\\AppIcons.cs",iconsClass.ToString());
        File.WriteAllText($"{outlinedProjectPath}\\wwwroot\\icons.css",sb.ToString());
    }

    if (file.Contains("Sharp"))
    {
        
        sb.AppendLine("""
                      @font-face {
                          font-family: 'Material Symbols Sharp';
                          src: url('MaterialSymbolsSharp[FILL,GRAD,opsz,wght].woff2') format('woff2');
                          font-weight: normal;
                          font-style: normal;
                          font-display: swap;
                      }

                      .ms-sharp {
                          font-family: 'Material Symbols Sharp';
                          font-variation-settings: 'FILL' 0, 'wght' 400, 'GRAD' 2, 'opsz' 48;
                          font-style: normal;
                          font-weight: normal;
                          font-variant: normal;
                          text-transform: none;
                          line-height: 1; 
                          -webkit-font-smoothing: antialiased; 
                          -moz-osx-font-smoothing: grayscale;
                          font-size: 24px;
                      }
                      """);
        sb.AppendLine();
        sb.AppendLine();
        
        var firstFile = File.ReadAllLines(file);
        var iconsClass = new StringBuilder();

        iconsClass.AppendLine("namespace MaterialSymbolsSharp.Web;");
        iconsClass.AppendLine("public class AppIcons");
        iconsClass.AppendLine("{");
        
        foreach (var line in firstFile)
        {
            var items = line.Split(" ");
            if(char.IsDigit(items[0].First())) continue;
            sb.AppendLine($".{items[0]}::before{{content: '\\{items[1]}';}}");

            iconsClass.AppendLine($"public const string {items[0].ToUpper()} = \"ms-sharp {items[0]}\";");
        }

        iconsClass.AppendLine("}");
        
        File.WriteAllText($"{sharpProjectPath}\\AppIcons.cs",iconsClass.ToString());
        File.WriteAllText($"{sharpProjectPath}\\wwwroot\\icons.css",sb.ToString());
    }

    sb.Clear();
}

