using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Test
{
    public sealed partial class GamePage : Page
    {
        readonly Game1 _game;

        public GamePage()
        {
            this.InitializeComponent();

            // Create the game.
            var launchArguments = string.Empty;
            _game = MonoGame.Framework.XamlGame<Game1>.Create(launchArguments, Window.Current.CoreWindow, swapChainPanel);
        }
    }
}
