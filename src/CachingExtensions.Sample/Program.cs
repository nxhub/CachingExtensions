using System;
using Microsoft.Extensions.Caching.Distributed;
using NXHub.Extensions.Caching;

namespace CachingExtensions.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IDistributedCache cache = null;

            if (!cache.TryGetObject("key", out Blog blog))
            {
                blog = new Blog
                {
                    Id = 1,
                    Title = "blog",
                    Content = "text",
                };

                cache.SetObject("key", blog, TimeSpan.FromMinutes(10));
            }
        }
    }
}
