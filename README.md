## 概述
分布式缓存接口 IDistributedCache(在包 [Microsoft.Extensions.Caching.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Caching.Abstractions) 中定义)的扩展包，提供方便的对象操作接口。

## 安装
```xml
<PackageReference Include="NXHub.Extensions.Caching" Version="0.0.2" />
```

## 使用
```cs
static void Test(IDistributedCache cache)
{
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
```
