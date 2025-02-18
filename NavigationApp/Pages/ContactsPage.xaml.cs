using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationApp.Pages;
using NavigationApp.Models;

public partial class ContactsPage : ContentPage
{
    private readonly List<Contact> _contacts = [
        new Contact(name:"Gabriel", phone:"5625304716"),
        new Contact(name:"Edgar", phone:"1234567890"),
        new Contact(name:"Bryan", phone:"09876-54321"),
    ];
    
    private List<Contact> _filteredContacts;
    
    public ContactsPage()
    {
        InitializeComponent();
        _filteredContacts = new(_contacts);
        
        contactList.ItemsSource = _filteredContacts;
    }

    private void OnAddContact(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void OnContactSelected(object? sender, SelectedItemChangedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void OnSearchTextChanged(object? sender, TextChangedEventArgs e)
    {
        throw new NotImplementedException();
    }
}