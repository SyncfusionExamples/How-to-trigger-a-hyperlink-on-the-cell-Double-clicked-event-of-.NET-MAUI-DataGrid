using Microsoft.Maui.Controls;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.Themes;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void dataGrid_CellDoubleTapped(object sender, Syncfusion.Maui.DataGrid.DataGridCellDoubleTappedEventArgs e)
        {
            if (e.RowData is ControlInfo item && e.Column.MappingName == "UgLink")
            {
                // Get the URL from the tapped row's data
                var url = item.UgLink;

                // Ensure the URL is not null or empty before trying to open it
                if (!string.IsNullOrEmpty(url))
                {
                    // Open the URL using the Launcher
                    Launcher.OpenAsync(url);
                }
            }
        }
    }

    public class HyperlinkLabel : Label
    {
        public static readonly BindableProperty UrlProperty = BindableProperty.Create(nameof(Url), typeof(string), typeof(HyperlinkLabel), null);

        public string Url
        {
            get { return (string)GetValue(UrlProperty); }
            set { SetValue(UrlProperty, value); }
        }

        public HyperlinkLabel()
        {
            TextDecorations = TextDecorations.Underline;
            TextColor = Colors.Blue;
        }
    }
}
