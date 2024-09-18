# How to trigger a hyperlink on the cell double clicked event of the .NET-MAUI-DataGrid.
In this article, we will show you how to trigger a hyperlink on the cell double clicked event of the [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## xaml
```
<ContentPage.BindingContext>
    <local:ControlInfoViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<ContentPage.Content>
    <syncfusion:SfDataGrid x:Name="dataGrid" CellDoubleTapped="dataGrid_CellDoubleTapped"
                            ItemsSource="{Binding ControlInfoCollection}" ColumnWidthMode="Auto">
        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridTextColumn MappingName="Control"/>
            <syncfusion:DataGridTextColumn MappingName="Platform"/>
            <syncfusion:DataGridTemplateColumn MappingName="UgLink">
                <syncfusion:DataGridTemplateColumn.CellTemplate>
                    <DataTemplate>
                        <local:HyperlinkLabel Text="User Guide documentation"
                            Url="{Binding UgLink}"
                            HorizontalOptions="Center"
                            LineBreakMode="NoWrap" />
                    </DataTemplate>
                </syncfusion:DataGridTemplateColumn.CellTemplate>
            </syncfusion:DataGridTemplateColumn>
                                            
        </syncfusion:SfDataGrid.Columns>
    </syncfusion:SfDataGrid>
</ContentPage.Content>
```

## C#
The below code illustrates how to trigger a hyperlink on the cell double clicked event of the DataGrid. The HyperlinkLabel class is a custom Label that defines a bindable property Url and visually styles the label as an underlined, blue hyperlink.
```
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
```

 ![hyperlink.gif](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI5NjAzIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.vIxhl6CaDirc2hgZcjSympye8X7Dz-V-5dapIeBszSI)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-trigger-a-hyperlink-on-the-cell-Double-clicked-event-of-.NET-MAUI-DataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to trigger a hyperlink on the cell double clicked event of the .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!