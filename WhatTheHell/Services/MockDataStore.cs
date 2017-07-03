using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhatTheHell
{
    public class MockDataStore : IDataStore<Item>
    {
        bool isInitialized;
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var _items = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Title = "First item", Description="This is a nice description"},
                new Item { Id = Guid.NewGuid().ToString(), Title = "Second item", Description="This is a nice description"},
                new Item { Id = Guid.NewGuid().ToString(), Title = "Third item", Description="This is a nice description"},
                new Item { Id = Guid.NewGuid().ToString(), Title = "Fourth item", Description="This is a nice description"},
                new Item { Id = Guid.NewGuid().ToString(), Title = "Fifth item", Description="This is a nice description"},
                new Item { Id = Guid.NewGuid().ToString(), Title = "Sixth item", Description="This is a nice description"},
            };

            foreach (Item item in _items)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
