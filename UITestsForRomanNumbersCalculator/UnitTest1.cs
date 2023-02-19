using System.Xml.Linq;
using Avalonia.Controls;
using Avalonia.VisualTree;
using static System.Net.Mime.MediaTypeNames;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ExpectedText = "CDL";

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(Name => Name.Name == "textResult");
            var B_D = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonD");
            var B_L = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonL");
            var B_Sub = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonSub");
            var B_Res = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonResult");

            B_D.Command.Execute(B_D.CommandParameter);
            B_Sub.Command.Execute(B_Sub.CommandParameter);
            B_L.Command.Execute(B_L.CommandParameter);
            B_Res.Command.Execute(B_Res.CommandParameter);

            await Task.Delay(50);

            string ReceivedText = result.Text;
            Assert.True(ReceivedText.Equals(ExpectedText));
        }
      
        [Fact]
        public async void Test2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ExpectedText = "#ERROR";

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(Name => Name.Name == "textResult");
            var B_D = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonD");
            var B_Plus = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonPlus");

            B_D.Command.Execute(B_D.CommandParameter);
            B_D.Command.Execute(B_D.CommandParameter);
            B_Plus.Command.Execute(B_Plus.CommandParameter);

            await Task.Delay(50);

            string ReceivedText = result.Text;
            Assert.True(ReceivedText.Equals(ExpectedText));
        }
        [Fact]
        public async void Test3()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ExpectedText = "II";

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(Name => Name.Name == "textResult");
            var B_I = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonI");
            var B_Plus = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonPlus");
            var B_Res = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonResult");

            B_I.Command.Execute(B_I.CommandParameter);
            B_Plus.Command.Execute(B_Plus.CommandParameter);
            B_I.Command.Execute(B_I.CommandParameter);
            B_Res.Command.Execute(B_Res.CommandParameter);

            await Task.Delay(50);

            string ReceivedText = result.Text;
            Assert.True(ReceivedText.Equals(ExpectedText));
        }
        [Fact]
        public async void Test4()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ExpectedText = "M";

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(Name => Name.Name == "textResult");
            var B_C = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonC");
            var B_X = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonX");
            var B_Mul = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonMul");
            var B_Res = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonResult");

            B_C.Command.Execute(B_C.CommandParameter);
            B_Mul.Command.Execute(B_Mul.CommandParameter);
            B_X.Command.Execute(B_X.CommandParameter);
            B_Res.Command.Execute(B_Res.CommandParameter);

            await Task.Delay(50);

            string ReceivedText = result.Text;
            Assert.True(ReceivedText.Equals(ExpectedText));
        }

        [Fact]
        public async void Test5()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ExpectedText = "II";

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(Name => Name.Name == "textResult");
            var B_M = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonM");
            var B_D = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonD");
            var B_Div = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonDiv");
            var B_Res = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonResult");

            B_M.Command.Execute(B_M.CommandParameter);
            B_Div.Command.Execute(B_Div.CommandParameter);
            B_D.Command.Execute(B_D.CommandParameter);
            B_Res.Command.Execute(B_Res.CommandParameter);

            await Task.Delay(50);

            string ReceivedText = result.Text;
            Assert.True(ReceivedText.Equals(ExpectedText));
        }
        [Fact]
        public async void Test6()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ExpectedText = string.Empty;

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(Name => Name.Name == "textResult");
            var B_M = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonM");
            var B_CE = mainWindow.GetVisualDescendants().OfType<Button>().First(Name => Name.Name == "buttonCE");

            B_M.Command.Execute(B_M.CommandParameter);
            B_CE.Command.Execute(B_CE.CommandParameter);

            await Task.Delay(50);

            string ReceivedText = result.Text;
            Assert.True(ReceivedText.Equals(ExpectedText));
        }
    }
}