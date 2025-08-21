using Blazored.LocalStorage;
using PhoneStore.Data.Models;

namespace PhoneStore.Data.Services
{
    public class CartService
    {
        private readonly ILocalStorageService _localStorage;
        private const string CartKey = "cartItems";
        public List<CartItem> Items { get; private set; } = new List<CartItem>();
        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();

        public CartService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task LoadCartAsync()
        {
            var storedItems = await _localStorage.GetItemAsync<List<CartItem>>(CartKey);
            if (storedItems != null) Items = storedItems;
            NotifyStateChanged();
        }

        public async Task AddItemAsync(CartItem item)
        {
            var existing = Items.FirstOrDefault(x => x.Id == item.Id);
            if (existing != null)
            {
                existing.Quantity += item.Quantity;
            }
            else
            {
                Items.Add(item);
            }

            await SaveCartAsync();
            NotifyStateChanged();
        }

        public async Task RemoveItemAsync(int id)
        {
            Items.RemoveAll(x => x.Id == id);
            await SaveCartAsync();
            NotifyStateChanged();
        }

        public async Task ClearCartAsync()
        {
            Items.Clear();
            await _localStorage.RemoveItemAsync(CartKey);
            NotifyStateChanged();
        }

        private async Task SaveCartAsync()
        {
            await _localStorage.SetItemAsync(CartKey, Items);
        }
    }

}
