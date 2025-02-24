using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationApp.Models;

namespace NavigationApp.Pages;

public partial class NewsPage : ContentPage
{
    public NewsPage()
    {
        InitializeComponent();
        List<NewsItem> newsList = [
                new() {Title = "Pepe", Summary = "Pepe pecas", FullContent = "Pepe pecas pica papas"},
                new() {Title = "Tigres", Summary = "Tres tristes", FullContent = "Tres tristes tigres tragaban trigo en un trigal"},
            ];
        
        NewsListView.ItemsSource = newsList;
    }

    private async void OnNewsTabbed(object? sender, ItemTappedEventArgs e)
    {
        if (e.Item != null)
        {
            var selectedNewsItem = (NewsItem)e.Item;
            await Navigation.PushAsync(new NewsDetailPage
                {
                    BindingContext = selectedNewsItem
                }
            );
        }
    }
}