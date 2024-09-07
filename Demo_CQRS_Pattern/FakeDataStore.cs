namespace Demo_CQRS_Pattern
{
    public class FakeDataStore
    {
        private static List<Product> _products;

        public FakeDataStore()
        {
            _products = new List<Product>()
            {
                new() { Id = 1, Name = "Laptop" },
                new() { Id = 2, Name = "Smartphone" },
                new() { Id = 3, Name = "Tablet" },
                new() { Id = 4, Name = "Smartwatch" },
                new() { Id = 5, Name = "Headphones" },
                new() { Id = 6, Name = "Keyboard" },
                new() { Id = 7, Name = "Mouse" },
                new() { Id = 8, Name = "Monitor" },
                new() { Id = 9, Name = "Printer" },
                new() { Id = 10, Name = "Router" },
                new() { Id = 11, Name = "External Hard Drive" },
                new() { Id = 12, Name = "USB Flash Drive" },
                new() { Id = 13, Name = "Webcam" },
                new() { Id = 14, Name = "Microphone" },
                new() { Id = 15, Name = "Speakers" },
                new() { Id = 16, Name = "Projector" },
                new() { Id = 17, Name = "Scanner" },
                new() { Id = 18, Name = "Graphics Tablet" },
                new() { Id = 19, Name = "VR Headset" },
                new() { Id = 20, Name = "Drone" }
            };
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await Task.FromResult(_products);
        }

        public async Task AddProductAsync(Product model)
        {
            _products.Add(model);
            await Task.CompletedTask;
        }

        public async Task DeleteProductAsync(int id)
        {
            var model = _products.Find(x => x.Id == id);
            _products.Remove(model);
            await Task.CompletedTask;
        }

        public async Task UpdateProductAsync(int id, string newName)
        {
            var model = _products.Find(x => x.Id == id);
            if (model != null)
            {
                model.Name = newName;
            }
            await Task.CompletedTask;
        }
    }
}
