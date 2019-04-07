using AutoMapper;
using TeduShop.Model.Model;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //Mapper.CreateMap<Post, PostViewModel>();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<PostTag, PostTagViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
            });
        }
    }
}