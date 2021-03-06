using System.Windows.Input;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

// ReSharper disable CheckNamespace

namespace Highway.Insurance.UI.Windows.WPF.Extensions
// ReSharper restore CheckNamespace
{
    public static class WpfWindowExtensions
    {
        public static WpfWindow GetWindow(this WpfWindow parent, string windowTitle, bool exactMatch = false)
        {
            PropertyExpressionOperator expressionOperator = exactMatch
                                                                ? PropertyExpressionOperator.EqualTo
                                                                : PropertyExpressionOperator.Contains;
            var modalWindow = new WpfWindow
                {
                    SearchProperties =
                        {
                            {UITestControl.PropertyNames.Name, windowTitle, expressionOperator}
                        }
                };

            modalWindow.Find();
            return modalWindow;
        }

        public static WpfWindow AccessKeyPress(this WpfWindow currentScreen, string accessKey)
        {
            Keyboard.PressModifierKeys(ModifierKeys.Alt);
            Keyboard.SendKeys(accessKey);
            Keyboard.ReleaseModifierKeys(ModifierKeys.Alt);

            return currentScreen;
        }
    }
}